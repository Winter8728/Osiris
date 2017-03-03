using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Osiris.DBUtility;
using System.Data.Common;
using System.Collections.Generic;//Please add references
namespace Osiris.DAL
{
	/// <summary>
	/// 数据访问类:DeviceAd
	/// </summary>
	public partial class DeviceAd
	{ 
        
		public DeviceAd()
		{}
		#region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Osiris.Model.DeviceAd model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DeviceAd(");
            strSql.Append("AdType,AdText,AdPath,ThumbPath,RepeatNum,Eare,BeginTime,EndTime,Creator,Remark)");
            strSql.Append(" values (");
            strSql.Append("@AdType,@AdText,@AdPath,@ThumbPath,@RepeatNum,@Eare,@BeginTime,@EndTime,@Creator,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@AdType", SqlDbType.Int,4),
                    new SqlParameter("@AdText", SqlDbType.VarChar,500),
                    new SqlParameter("@AdPath", SqlDbType.VarChar,100),
                    new SqlParameter("@ThumbPath", SqlDbType.VarChar,100),
                    new SqlParameter("@RepeatNum", SqlDbType.Int,4),
                    new SqlParameter("@Eare", SqlDbType.NVarChar,10),
                    new SqlParameter("@BeginTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime), 
                    new SqlParameter("@Creator", SqlDbType.VarChar,20),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.AdType;
            parameters[1].Value = model.AdText;
            parameters[2].Value = model.AdPath;
            parameters[3].Value = model.ThumbPath;
            parameters[4].Value = model.RepeatNum;
            parameters[5].Value = model.Eare;
            parameters[6].Value = model.BeginTime;
            parameters[7].Value = model.EndTime; 
            parameters[8].Value = model.Creator;
            parameters[9].Value = model.Remark;

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
        public bool Update(Osiris.Model.DeviceAd model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DeviceAd set ");
            strSql.Append("AdType=@AdType,");
            strSql.Append("AdPath=@AdPath,");
            strSql.Append("RepeatNum=@RepeatNum,");
            strSql.Append("Eare=@Eare,");
            strSql.Append("BeginTime=@BeginTime,");
            strSql.Append("EndTime=@EndTime,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("Creator=@Creator,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@AdType", SqlDbType.Int,4),
                    new SqlParameter("@AdPath", SqlDbType.VarChar,100),
                    new SqlParameter("@RepeatNum", SqlDbType.Int,4),
                    new SqlParameter("@Eare", SqlDbType.NVarChar,10),
                    new SqlParameter("@BeginTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime),
                    new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                    new SqlParameter("@Creator", SqlDbType.VarChar,20),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.AdType;
            parameters[1].Value = model.AdPath;
            parameters[2].Value = model.RepeatNum;
            parameters[3].Value = model.Eare;
            parameters[4].Value = model.BeginTime;
            parameters[5].Value = model.EndTime;
            parameters[6].Value = DateTime.Now;
            parameters[7].Value = model.Creator;
            parameters[8].Value = model.Remark;
            parameters[9].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceAd ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DeviceAd ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Osiris.Model.DeviceAd GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from DeviceAd ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

            Osiris.Model.DeviceAd model = new Osiris.Model.DeviceAd();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Osiris.Model.DeviceAd DataRowToModel(DataRow row)
        {
            Osiris.Model.DeviceAd model = new Osiris.Model.DeviceAd();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["AdType"] != null && row["AdType"].ToString() != "")
                {
                    model.AdType = int.Parse(row["AdType"].ToString());
                }
                if (row["AdText"] != null && row["AdText"].ToString() != "")
                {
                    model.AdText = row["AdText"].ToString() ;
                }
                if (row["AdPath"] != null)
                {
                    model.AdPath = row["AdPath"].ToString();
                }
                if (row["ThumbPath"] != null)
                {
                    model.ThumbPath = row["ThumbPath"].ToString();
                }
                if (row["RepeatNum"] != null && row["RepeatNum"].ToString() != "")
                {
                    model.RepeatNum = int.Parse(row["RepeatNum"].ToString());
                }
                if (row["Eare"] != null)
                {
                    model.Eare = row["Eare"].ToString();
                }
                if (row["BeginTime"] != null && row["BeginTime"].ToString() != "")
                {
                    model.BeginTime = DateTime.Parse(row["BeginTime"].ToString());
                }
                if (row["EndTime"] != null && row["EndTime"].ToString() != "")
                {
                    model.EndTime = DateTime.Parse(row["EndTime"].ToString());
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

		/// <summary>
		/// 获取当前用户所有的广告
		/// </summary>
        public DataSet UserAllAd(string userName, string DeviceId,out string returnValue)
		{ 
            string spName = "UserAdAll";

            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20),
                    new SqlParameter("@DeviceId", SqlDbType.VarChar,30)
			};
            parameters[0].Value = userName;
            parameters[1].Value = DeviceId;


            return DbHelperSQL.RunProcedure(spName, parameters, "DeviceAd", out returnValue);
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
            string spName = "UserAdLast";

            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20),
                    new SqlParameter("@DeviceId", SqlDbType.VarChar,30)
			};
            parameters[0].Value = userName;
            parameters[1].Value = DeviceId;


            return DbHelperSQL.RunProcedure(spName, parameters, "DeviceAd", out returnValue);
        }
        /// <summary>
        /// 获取当前时段用户广告 (根据时间判断)
        /// </summary>
        /// <param name="DeviceId">设备id</param>
        /// <param name="returnValue">返回值</param>
        /// <returns></returns>
        public DataSet UserCurrentAd(string DeviceId, out string returnValue)
        {
            string spName = "GetCurrentAd";

            SqlParameter[] parameters = { 
                    new SqlParameter("@DeviceId", SqlDbType.VarChar,30)
			}; 
            parameters[0].Value = DeviceId;
             
            return DbHelperSQL.RunProcedure(spName, parameters, "DeviceAd", out returnValue);
        }

        /// <summary>
        /// 获取当前时段用户广告 (根据时间判断)
        /// </summary>
        /// <param name="DeviceId">设备id</param>
        /// <param name="returnValue">返回值</param>
        /// <returns></returns>
        public DataSet GetAdByEareTime(string DeviceId,string eare, out string returnValue)
        {
            string spName = "GetAdByEareTime";

            SqlParameter[] parameters = { 
                    new SqlParameter("@DeviceId", SqlDbType.VarChar,30),
                    new SqlParameter("@Eare", SqlDbType.VarChar,20)
			};
            parameters[0].Value = DeviceId;
            parameters[1].Value = eare;

            return DbHelperSQL.RunProcedure(spName, parameters, "DeviceAd", out returnValue);
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
            List<Osiris.Model.DeviceAd> list = new List<Model.DeviceAd>();
            DataSet ds = PageHelper.GetDataList("DeviceAd", size, index, where, out OutTotalCount);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }

            return list;
        }
        /// <summary>
        /// 获得分页总数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetDeviceAdCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM DeviceAd ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        ///// <summary>
        ///// 获得前几行数据
        ///// </summary>
        //public DataSet GetList(int Top,string strWhere,string filedOrder)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select ");
        //    if(Top>0)
        //    {
        //        strSql.Append(" top "+Top.ToString());
        //    }
        //    strSql.Append(" Id,AdType,AdPath,RepeatNum,Eare,BeginTime,EndTime,CreateTime,UpdateTime,Creator,Remark ");
        //    strSql.Append(" FROM DeviceAd ");
        //    if(strWhere.Trim()!="")
        //    {
        //        strSql.Append(" where "+strWhere);
        //    }
        //    strSql.Append(" order by " + filedOrder);
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
         

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

