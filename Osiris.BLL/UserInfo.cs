using System;
using System.Data;
using System.Collections.Generic;
using Osiris.Model;
namespace Osiris.BLL
{
	/// <summary>
	/// UserInfo
	/// </summary>
	public partial class UserInfo
	{
        private readonly Osiris.DAL.UserInfo dal = new Osiris.DAL.UserInfo();
		public UserInfo()
		{}
		#region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string UserName)
        {
            return dal.Exists(UserName);
        }

        /// <summary>
        /// 用户登录操作
        /// </summary>
        public string CheckUserInfo(string userName, string password)
        {
            return dal.CheckUserInfo(userName, password);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddUserInfo(Osiris.Model.UserInfo model)
        {
            return dal.AddUserInfo(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateUserInfo(Osiris.Model.UserInfo model)
        {
            return dal.UpdateUserInfo(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteUserInfo(int Id)
        { 
            return dal.DeleteUserInfo(Id);
        } 

        /// <summary>
        /// 获取用户集合
        /// </summary>
        /// <param name="size"></param>
        /// <param name="index"></param>
        /// <param name="where"></param>
        /// <param name="OutTotalCount"></param>
        /// <returns></returns>
        public List<Osiris.Model.UserInfo> GetUserInfoList(int size, int index, string where, out int OutTotalCount)
        {
            return dal.GetUserInfoList(size, index, where, out OutTotalCount);

        }

        /// <summary>
        /// 获得分页总数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetUserCount(string where)
        {
            return dal.GetUserCount(where);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.UserInfo GetModel(int id)
        {
            return dal.GetModel(id);
        }
         
        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataTable GetList(string strWhere)
        //{
        //   return  dal.GetList(strWhere);
        //} 

		#endregion  BasicMethod 
	}
}

