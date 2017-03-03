using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Osiris.BLL
{
    public class Coordinate
    {
        Osiris.DAL.Coordinate dal = new DAL.Coordinate();

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Eare)
        {
            return dal.Exists(Eare);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Osiris.Model.Coordinate model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Osiris.Model.Coordinate model)
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
        public Osiris.Model.Coordinate GetModel(int Id)
        {
            return dal.GetModel(Id);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.Coordinate DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 获取广告集合
        /// </summary>
        /// <param name="size"></param>
        /// <param name="index"></param>
        /// <param name="where"></param>
        /// <param name="OutTotalCount"></param>
        /// <returns></returns>
        public List<Osiris.Model.Coordinate> GetCoordinateList(int size, int index, string where, out int OutTotalCount)
        {
            return dal.GetCoordinateList(size, index, where, out OutTotalCount);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 根据地区获取坐标
        /// </summary>
        /// <param name="eare"></param>
        /// <returns></returns>
        public string GetCoordinateByeare(string eare)
        {
            return dal.GetCoordinateByeare(eare);
        }
    }
}
