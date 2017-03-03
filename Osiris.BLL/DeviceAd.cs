using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Osiris.BLL
{
    public class DeviceAd
    {
        private readonly Osiris.DAL.DeviceAd dal = new Osiris.DAL.DeviceAd();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Osiris.Model.DeviceAd model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Osiris.Model.DeviceAd model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {
           return dal.Delete(Id);
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.DeviceAd GetModel(int Id)
        {
            return dal.GetModel(Id);
        }


        /// <summary>
        /// 获取当前用户所有的广告
        /// </summary>
        public DataSet UserAllAd(string userName, string DeviceId, out string returnValue)
        {
            return dal.UserAllAd(userName, DeviceId, out returnValue);
        }

        /// <summary>
        /// 获取最后一条广告
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="DeviceId"></param>
        /// <param name="returnValue"></param>
        /// <returns></returns>
        public DataSet UserAllLast(string userName, string DeviceId, out string returnValue)
        {
            return dal.UserAllLast(userName, DeviceId, out returnValue);
        }

        /// <summary>
        /// 获取当前时段用户广告 (根据时间判断)
        /// </summary>
        /// <param name="DeviceId">设备id</param>
        /// <param name="returnValue">返回值</param>
        /// <returns></returns>
        public DataSet UserCurrentAd(string DeviceId, out string returnValue)
        {
            return dal.UserCurrentAd(DeviceId,out returnValue);
        }

        /// <summary>
        /// 获取当前时段用户广告 (根据时间判断)
        /// </summary>
        /// <param name="DeviceId">设备id</param>
        /// <param name="returnValue">返回值</param>
        /// <returns></returns>
        public DataSet GetAdByEareTime(string DeviceId, string eare, out string returnValue)
        {
            return dal.GetAdByEareTime(DeviceId, eare, out returnValue);
        }

        /// <summary>
        /// 获取广告集合
        /// </summary>
        /// <param name="size"></param>
        /// <param name="index"></param>
        /// <param name="where"></param>
        /// <param name="OutTotalCount"></param>
        /// <returns></returns>
        public List<Osiris.Model.DeviceAd> GetDeviceAdList(int size, int index, string where, out int OutTotalCount)
        {
            return dal.GetDeviceAdList(size, index, where, out OutTotalCount);
        }
        /// <summary>
        /// 获得分页总数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetDeviceAdCount(string strWhere)
        {
            return dal.GetDeviceAdCount(strWhere);
        }
    }
}
