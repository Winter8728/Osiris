using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Osiris.DBUtility;
using System.Data.Common;
using System.Collections.Generic;
namespace Osiris.DAL
{
    /// <summary>
    /// 数据访问类:UserInfo
    /// </summary>
    public partial class UserInfo
    {
        
        public UserInfo()
        {
        }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserInfo");
            strSql.Append(" where UserName=@UserName");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20)
			};
            parameters[0].Value = UserName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 用户登录操作
        /// </summary>
        public string CheckUserInfo(string userName, string password)
        {
            string returnValue;
            string spName = "CheckUserInfo"; 

            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20),
                    new SqlParameter("@password", SqlDbType.VarChar,32)
			};
            parameters[0].Value = userName;
            parameters[1].Value = password;

            int v =  DbHelperSQL.RunProcedureByReturnValue(spName, parameters) ;
            switch (v)
            {
                case 0: returnValue = "success"; break;
                case 1: returnValue = "用户名不存在"; break;
                case 2: returnValue = "密码错误"; break;
                case 3: returnValue = "用户被锁定"; break;
                default: returnValue = "未知错误"; break;
            }
            return returnValue;
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddUserInfo(Osiris.Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserInfo(");
            strSql.Append("UserName,Password,HeadImage,IsAdmin,Creator,Remark)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@Password,@HeadImage,@IsAdmin,@Creator,@Remark)");
            strSql.Append(";select @@IDENTITY");

            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20),
                    new SqlParameter("@Password", SqlDbType.VarChar,32),
                    new SqlParameter("@HeadImage", SqlDbType.VarChar,100),
                    new SqlParameter("@IsAdmin", SqlDbType.Bit),
                    new SqlParameter("@Creator", SqlDbType.VarChar,20),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,50),
			};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.HeadImage;
            parameters[3].Value = model.IsAdmin;
            parameters[4].Value = model.Creator;
            parameters[5].Value = model.Remark;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateUserInfo(Osiris.Model.UserInfo model)
        {
            Osiris.Model.UserInfo u = GetModel(model.Id);

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserInfo set "); 
            strSql.Append("Password=@Password,");
            strSql.Append("HeadImage=@HeadImage,");
            strSql.Append("IsLock=@IsLock,");
            strSql.Append("IsAdmin=@IsAdmin,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("Creator=@Creator,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where Id=@Id");

            SqlParameter[] parameters = { 
                    new SqlParameter("@Password", SqlDbType.VarChar,32),
                    new SqlParameter("@HeadImage", SqlDbType.VarChar,100),
                    new SqlParameter("@IsLock", SqlDbType.Int),
                    new SqlParameter("@IsAdmin", SqlDbType.Bit),
                    new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                    new SqlParameter("@Creator", SqlDbType.VarChar,20),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@Id", SqlDbType.Int)
			};
            parameters[0].Value = model.Password == null ? u.Password : model.Password ;
            parameters[1].Value = model.HeadImage == null ? u.HeadImage : model.HeadImage;
            parameters[2].Value = model.IsLock == 0 ? u.Password : model.Password;
            parameters[3].Value = model.IsAdmin == false ? u.IsAdmin : model.IsAdmin;
            parameters[4].Value = DateTime.Now;
            parameters[5].Value = model.Creator == null ? u.Creator : model.Creator;
            parameters[6].Value = model.Remark == null ? u.Remark : model.Remark;
            parameters[7].Value = model.Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteUserInfo(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfo ");
            strSql.Append(" where Id=@Id");

            SqlParameter[] parameters = {  
                    new SqlParameter("@Id", SqlDbType.Int)
			}; 
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.UserInfo GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from UserInfo ");
            strSql.Append(" where id=@id");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int)
			};
            parameters[0].Value = id; 
             
            Osiris.Model.UserInfo model = new Osiris.Model.UserInfo();
            DataTable dt = DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return DataRowToModel(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.UserInfo DataRowToModel(DataRow row)
        {
            Osiris.Model.UserInfo model = new Osiris.Model.UserInfo();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["Password"] != null)
                {
                    model.Password = row["Password"].ToString();
                }
                if (row["HeadImage"] != null)
                {
                    model.HeadImage = row["HeadImage"].ToString();
                }
                if (row["IsLock"] != null && row["IsLock"].ToString() != "")
                {
                    model.IsLock = int.Parse(row["IsLock"].ToString());
                }
                if (row["IsAdmin"] != null && row["IsAdmin"].ToString() != "")
                {
                    if ((row["IsAdmin"].ToString() == "1") || (row["IsAdmin"].ToString().ToLower() == "true"))
                    {
                        model.IsAdmin = true;
                    }
                    else
                    {
                        model.IsAdmin = false;
                    }
                }
                if (row["CreateTime"] != null && row["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(row["CreateTime"].ToString());
                }
                if (row["UpdateTime"] != null && row["UpdateTime"].ToString() != "")
                {
                    model.UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
                }
                if (row["Creator"] != null)
                {
                    model.Creator = row["Creator"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
            }
            return model;
        }

        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataTable GetList(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select Id,UserName,Password,IsLock,IsAdmin,CreateTime,UpdateTime,Creator,Remark ");
        //    strSql.Append(" FROM UserInfo ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    return DbHelperSQL.ExecuteDataTable(strSql.ToString(),null);
        //} 

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
            
            List<Osiris.Model.UserInfo> list = new List<Model.UserInfo>();
            DataSet ds = PageHelper.GetDataList("UserInfo", size, index, where, out OutTotalCount);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }
             
            return list;
             
        }
        /// <summary>
        /// 获得分页总数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetUserCount(string where) {
            string strSql = " select count(*) from userInfo "; 
            if(where.Length>0)
                strSql += " where  "+where;
            int count = Convert.ToInt32(DbHelperSQL.GetSingle(strSql));
            return count;
        }
        #endregion  BasicMethod 
    }
}

