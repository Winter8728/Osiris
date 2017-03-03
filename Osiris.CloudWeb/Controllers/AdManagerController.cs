using Osiris.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Osiris.Model;
using System.IO;
using System.Drawing;

namespace Osiris.CloudWeb.Controllers
{
    public class AdManagerController : Controller
    {

        Osiris.BLL.DeviceAd bll = new BLL.DeviceAd();
        [Osiris.CloudWeb.App_Start.CheckLogin]
        public ActionResult Index()
        {
            ViewData["pageCount"] = bll.GetDeviceAdCount("");
            return View();
        }


        [HttpPost]
        public string AllDeviceAdList(string index, string pageSize)
        {
            string str = string.Empty;

            //具体的页面数
            int pageIndex = 0;
            int.TryParse(index, out  pageIndex);

            //页面显示条数
            int size = Convert.ToInt32(pageSize);

            if (pageIndex == 0)
            {
                pageIndex = 1;
            }

            int count;
            List<Osiris.Model.DeviceAd> list = bll.GetDeviceAdList(size, pageIndex, "", out count);

            StringBuilder sb = new StringBuilder();
            foreach (Osiris.Model.DeviceAd p in list)
            {
                sb.Append("<tr><td>");
                sb.Append(p.Id);
                sb.Append("</td><td>");
                sb.Append(string.IsNullOrEmpty(p.ThumbPath) ? "<img src='/content/images/icon_txt.png' class='listimg'/>" : "<img src='" + p.ThumbPath + "' class='listimg'/>");
                sb.Append("</td><td>");
                sb.Append(p.AdType==0?"文本":p.AdType==1?"图片":"视频");
                sb.Append("</td><td>");
                sb.Append(string.IsNullOrEmpty(p.AdText) ? "" : StringHelper.ClipString(p.AdText, 10));
                sb.Append("</td><td>");
                sb.Append(string.IsNullOrEmpty(p.AdPath) ? "" : StringHelper.ClipString(p.AdPath, 25));
                sb.Append("</td><td>");
                sb.Append(p.RepeatNum);
                sb.Append("</td><td>");
                sb.Append(p.Eare);
                sb.Append("</td><td>");
                sb.Append(p.BeginTime);
                sb.Append("</td><td>");
                sb.Append(p.CreateTime.ToString());
                sb.Append("</td><td>");
                sb.Append(p.Creator);
                sb.Append("</td><td>");
                sb.Append("<div class=\"table-fun table-option\"><a href='/AdManager/Edit/" + p.Id + "'>修改</a><a href='/AdManager/Delete/" + p.Id + "'>删除</a></div>");
                sb.Append("</td></tr>");
            }
            str = sb.ToString();
            return str;
        }

        public ActionResult Edit(int id = 0)
        {
            DeviceAd dev = new DeviceAd();
            dev.Id = id;
            ViewData["eare"] = "上海市";
            if (id != 0)
            {
                dev = bll.GetModel(id);
                ViewData["eare"] = dev.Eare;
            }
            return View(dev);
        }

        [HttpPost]
        public ActionResult Edit(DeviceAd d)
        {

            if (Session["UserName"] != null)
                d.Creator = Session["UserName"].ToString();

            //新增
            if (d.Id == 0)
            {
                bll.Add(d);
            }
            else
            {
                bll.Update(d);
            }
            return Redirect("/AdManager/Index");
        }


        public ActionResult Delete(int id)
        {
            bool flag = bll.Delete(id);
            return Redirect("/AdManager/Index");
        }

        [HttpPost]
        public JsonResult Upload()
        {
            HttpPostedFileBase file = Request.Files[0];
            if (file == null)
            {
                return Json(new { code = 1, msg = "没有文件" });
            }
            var ext = Path.GetExtension(file.FileName);
            int type = GetFileType(ext);
            string path = string.Empty;
            if (type.Equals(1))
            {
                path = "/FileStore/AdFiles/Photos";
            }
            else if (type.Equals(2))
            {
                path = "/FileStore/AdFiles/Videos";
            }
            else
                path = "/FileStore/AdFiles";

            var fileName = Path.Combine(Request.MapPath(path), Path.GetFileName(file.FileName));
            try
            {

                file.SaveAs(fileName);

                string str = path + "/" + Path.GetFileName(file.FileName);

                string thumbPath = string.Empty;
                thumbPath = path + "/thumb/" + Path.ChangeExtension(file.FileName, ".jpg");
                if (type.Equals(1))
                {
                    GetSmallImage(str, thumbPath);
                }
                else if (type.Equals(2))
                {
                    CatchImg(str, thumbPath);
                }


                return Json(new { code = 0, msg = "上传成功", url = path + "/" + file.FileName, thumbPath = thumbPath });
            }
            catch
            {
                return Json(new { code = 1, msg = "上传失败" });
            }
        }

        private void GetSmallImage(string fileName, string newFileName)
        {
            //版权信息
            string strAdd = ""; // "www.yesartech.com";
            int width = 200;
            int height = 200;
            System.Drawing.Image image, newImage;
            //载入原图像
            image = System.Drawing.Image.FromFile(Server.MapPath(fileName));
            //回调
            System.Drawing.Image.GetThumbnailImageAbort callb = new System.Drawing.Image.GetThumbnailImageAbort(callBack);
            //生成缩略图
            newImage = image.GetThumbnailImage(width, height, callb, new System.IntPtr());

            AddInfo(newImage, strAdd, newFileName, 16);

        }
        private bool callBack()
        {
            return true;
        }
        /// <summary>
        /// 添加版权信息
        /// </summary>
        /// <param name="image"></param>
        /// <param name="strAdd"></param>
        /// <param name="newFileName"></param>
        /// <param name="fontSize"></param>
        private void AddInfo(System.Drawing.Image image, string strAdd, string newFileName, int fontSize)
        {
            Response.Clear();
            Bitmap b = new Bitmap(image);
            Graphics g = Graphics.FromImage(b);
            g.DrawString(strAdd, new Font("宋体", fontSize), new SolidBrush(Color.Red), image.Width / 2 - 80, image.Height - 30);
            b.Save(Server.MapPath(newFileName), System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private int GetFileType(string ext)
        {
            string[] image = { ".jpg", ".png", ".bmp", ".gif" };
            string[] video = { ".avi", ".mp4", ".flv" };
            ext = ext.ToLower();
            if (Array.IndexOf(image, ext) > -1)
                return 1;
            if (Array.IndexOf(video, ext) > -1)
                return 2;

            return 0;
        }
        /// <summary>
        /// 上传视频生成缩略图
        /// </summary>
        /// <param name="vFileName"></param>
        /// <param name="SmallPic"></param>
        /// <returns></returns>
        public string CatchImg(string vFileName, string thumbPath)
        {
            try
            {
                string ffmpeg = "/ffmpeg.exe";
                ffmpeg = Server.MapPath(ffmpeg);
                if ((!System.IO.File.Exists(ffmpeg)) || (!System.IO.File.Exists(Server.MapPath(vFileName))))
                {
                    return "";
                }

                string flv_img_p = Server.MapPath(thumbPath);
                string FlvImgSize = "200x200";
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(ffmpeg);
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                startInfo.Arguments = " -i " + Server.MapPath(vFileName) + " -y -f image2 -t 0.1 -s " + FlvImgSize + " " + flv_img_p;
                try
                {
                    System.Diagnostics.Process.Start(startInfo);
                }
                catch
                {
                    return "";
                }
                System.Threading.Thread.Sleep(4000);
                if (System.IO.File.Exists(flv_img_p))
                {
                    return flv_img_p.Replace(Server.MapPath("~/"), ""); ;
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

    }
}
