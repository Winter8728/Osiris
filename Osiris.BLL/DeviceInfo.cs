using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Osiris.BLL
{
    public class DeviceInfo
    {
        private readonly Osiris.DAL.DeviceInfo dal = new Osiris.DAL.DeviceInfo();

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string DeviceId)
        {
            return dal.Exists(DeviceId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Osiris.Model.DeviceInfo model)
        {
            return dal.Add(model);
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



        public bool Update(Osiris.Model.DeviceInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.DeviceInfo GetModel(string deviceId)
        {
            return dal.GetModel(deviceId);
        }
        public Osiris.Model.DeviceInfo GetModel(int id)
        {
            return dal.GetModel(id);
        }
        /// <summary>
        /// 获取所有设备
        /// </summary>
        /// <returns></returns>
        public List<Osiris.Model.DeviceInfo> GetDeviceInfoAllList()
        {
            return dal.GetDeviceInfoAllList();
        }

        /// <summary>
        /// 获取终端集合
        /// </summary>
        /// <param name="size"></param>
        /// <param name="index"></param>
        /// <param name="where"></param>
        /// <param name="OutTotalCount"></param>
        /// <returns></returns>
        public List<Osiris.Model.DeviceInfo> GetDeviceInfoList(int size, int index, string where, out int OutTotalCount)
        {
            return dal.GetDeviceInfoList(size, index, where, out OutTotalCount);
        }

        /// <summary>
        /// 获得分页总数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetDeviceCount(string where)
        {
            return dal.GetDeviceCount(where);
        }
    }
}
