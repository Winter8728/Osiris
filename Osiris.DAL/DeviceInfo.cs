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
	/// 数据访问类:DeviceInfo
	/// </summary>
	public partial class DeviceInfo
	{ 
		public DeviceInfo()
		{}
		#region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string DeviceId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DeviceInfo");
            strSql.Append(" where DeviceId=@DeviceId");
            SqlParameter[] parameters = {
					new SqlParameter("@DeviceId", SqlDbType.VarChar,20)
			};
            parameters[0].Value = DeviceId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Osiris.Model.DeviceInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DeviceInfo(");
			strSql.Append("DeviceId,Brightness,Temperature,Powerwaste,ViewModel,Switch,Lon,Lat,Creator,Remark)");
			strSql.Append(" values (");
			strSql.Append("@DeviceId,@Brightness,@Temperature,@Powerwaste,@ViewModel,@Switch,@Lon,@Lat,@Creator,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DeviceId", SqlDbType.VarChar,20),
					new SqlParameter("@Brightness", SqlDbType.VarChar,10),
					new SqlParameter("@Temperature", SqlDbType.VarChar,10),
					new SqlParameter("@Powerwaste", SqlDbType.VarChar,10),
					new SqlParameter("@ViewModel", SqlDbType.VarChar,10),
					new SqlParameter("@Switch", SqlDbType.VarChar,10),
					new SqlParameter("@Lon", SqlDbType.VarChar,20),
                    new SqlParameter("@Lat", SqlDbType.VarChar,20),
					new SqlParameter("@Creator", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.DeviceId;
			parameters[1].Value = model.Brightness;
			parameters[2].Value = model.Temperature;
			parameters[3].Value = model.Powerwaste;
			parameters[4].Value = model.ViewModel;
			parameters[5].Value = model.Switch;
			parameters[6].Value = model.Lon;
            parameters[7].Value = model.Lat;
			parameters[8].Value = model.Creator;
			parameters[9].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Osiris.Model.DeviceInfo model)
		{
            Osiris.Model.DeviceInfo m = GetModel(model.Id);
            if (m == null)
                return false;

			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DeviceInfo set "); 
			strSql.Append("Brightness=@Brightness,");
			strSql.Append("Temperature=@Temperature,");
			strSql.Append("Powerwaste=@Powerwaste,");
			strSql.Append("ViewModel=@ViewModel,");
			strSql.Append("Switch=@Switch,");
			strSql.Append("IsLock=@IsLock,");
			strSql.Append("Lon=@Lon,");
            strSql.Append("Lat=@Lat,"); 
			strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Gyroscope=@Gyroscope");
            strSql.Append(" where DeviceId=@DeviceId");
			SqlParameter[] parameters = {
					new SqlParameter("@DeviceId", SqlDbType.VarChar,20),
					new SqlParameter("@Brightness", SqlDbType.VarChar,10),
					new SqlParameter("@Temperature", SqlDbType.VarChar,10),
					new SqlParameter("@Powerwaste", SqlDbType.VarChar,10),
					new SqlParameter("@ViewModel", SqlDbType.VarChar,10),
					new SqlParameter("@Switch", SqlDbType.VarChar,10),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@Lon", SqlDbType.VarChar,20), 
                    new SqlParameter("@Lat", SqlDbType.VarChar,20), 
					new SqlParameter("@UpdateTime", SqlDbType.DateTime), 
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@Gyroscope", SqlDbType.VarChar,20)};

            parameters[0].Value = model.DeviceId == null ? m.DeviceId : model.DeviceId;
            parameters[1].Value = model.Brightness == null ? m.Brightness : model.Brightness;
            parameters[2].Value = model.Temperature == null ? m.Temperature : model.Temperature;
            parameters[3].Value = model.Powerwaste == null ? m.Powerwaste : model.Powerwaste;
            parameters[4].Value = model.ViewModel == null ? m.ViewModel : model.ViewModel;
			parameters[5].Value = model.Switch==null?m.Switch:model.Switch;
            parameters[6].Value = model.IsLock == false ? m.IsLock : model.IsLock;
            parameters[7].Value = model.Lon == null ? m.Lon : model.Lon;
            parameters[8].Value = model.Lat == null ? m.Lat : model.Lat;
            parameters[9].Value = DateTime.Now;
			parameters[10].Value = model.Remark==null?(m.Remark==null?"":m.Remark):model.Remark;
            parameters[11].Value = model.Gyroscope == null ? m.Gyroscope : model.Gyroscope;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeviceInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeviceInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Osiris.Model.DeviceInfo GetModel(string deviceId)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 Id,DeviceId,Brightness,Temperature,Powerwaste,ViewModel,Switch,IsLock,Lon,Lat,CreateTime,UpdateTime,Creator,Remark,Gyroscope from DeviceInfo ");
            strSql.Append(" where deviceId=@deviceId");
			SqlParameter[] parameters = {
					new SqlParameter("@deviceId", SqlDbType.VarChar,20)
			};
            parameters[0].Value = deviceId;

			Osiris.Model.DeviceInfo model=new Osiris.Model.DeviceInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

        public Osiris.Model.DeviceInfo GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,DeviceId,Brightness,Temperature,Powerwaste,ViewModel,Switch,IsLock,Lon,Lat,CreateTime,UpdateTime,Creator,Remark,Gyroscope from DeviceInfo ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int)
			};
            parameters[0].Value = id;

            Osiris.Model.DeviceInfo model = new Osiris.Model.DeviceInfo();
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
		public Osiris.Model.DeviceInfo DataRowToModel(DataRow row)
		{
			Osiris.Model.DeviceInfo model=new Osiris.Model.DeviceInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DeviceId"]!=null)
				{
					model.DeviceId=row["DeviceId"].ToString();
				}
				if(row["Brightness"]!=null)
				{
					model.Brightness=row["Brightness"].ToString();
				}
				if(row["Temperature"]!=null)
				{
					model.Temperature=row["Temperature"].ToString();
				}
				if(row["Powerwaste"]!=null)
				{
					model.Powerwaste=row["Powerwaste"].ToString();
				}
				if(row["ViewModel"]!=null)
				{
					model.ViewModel=row["ViewModel"].ToString();
				}
				if(row["Switch"]!=null)
				{
					model.Switch=row["Switch"].ToString();
				}
				if(row["IsLock"]!=null && row["IsLock"].ToString()!="")
				{
					if((row["IsLock"].ToString()=="1")||(row["IsLock"].ToString().ToLower()=="true"))
					{
						model.IsLock=true;
					}
					else
					{
						model.IsLock=false;
					}
				}
				if(row["Lon"]!=null)
				{
                    model.Lon = row["Lon"].ToString();
				}
                if (row["Lat"] != null)
                {
                    model.Lat = row["Lat"].ToString();
                }
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["Creator"]!=null)
				{
					model.Creator=row["Creator"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
                if (row["Gyroscope"] != null)
                {
                    model.Remark = row["Gyroscope"].ToString();
                }
			}
			return model;
		}

        /// <summary>
        /// 获取所有设备
        /// </summary>
        /// <returns></returns>
        public List<Osiris.Model.DeviceInfo> GetDeviceInfoAllList()
        {
            List<Osiris.Model.DeviceInfo> list = new List<Model.DeviceInfo>();
            DataSet ds = GetList("");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }
            return list;
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
            List<Osiris.Model.DeviceInfo> list = new List<Model.DeviceInfo>();
            DataSet ds = PageHelper.GetDataList("DeviceInfo", size, index, where, out OutTotalCount);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }

            return list; 
        }
         
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM DeviceInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,DeviceId,Brightness,Temperature,Powerwaste,ViewModel,Switch,IsLock,Lon,Lat,CreateTime,UpdateTime,Creator,Remark ");
			strSql.Append(" FROM DeviceInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
        /// 获得分页总数
		/// </summary>
		/// <param name="strWhere"></param>
		/// <returns></returns>
        public int GetDeviceCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DeviceInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from DeviceInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DeviceInfo";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

