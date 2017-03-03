using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Osiris.DBUtility;
using System.Collections.Generic;//Please add references
namespace Osiris.DAL
{
	/// <summary>
	/// 数据访问类:Coordinate
	/// </summary>
	public partial class Coordinate
	{
		public Coordinate()
		{}
		#region  BasicMethod
         
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(string Eare)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Coordinate");
            strSql.Append(" where Eare=@Eare");
			SqlParameter[] parameters = {
					new SqlParameter("@Eare", SqlDbType.NVarChar,10)
			};
            parameters[0].Value = Eare;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
         

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Osiris.Model.Coordinate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Coordinate(");
			strSql.Append("Eare,Lon,Lat,LogoName,Creator,Remark)");
			strSql.Append(" values (");
            strSql.Append("@Eare,@Lon,@lat,@LogoName,@Creator,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Eare", SqlDbType.NVarChar,5),
					new SqlParameter("@Lon", SqlDbType.VarChar,20),
                    new SqlParameter("@Lat", SqlDbType.VarChar,20),
					new SqlParameter("@LogoName", SqlDbType.NVarChar,30), 
					new SqlParameter("@Creator", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Eare;
			parameters[1].Value = model.Lon;
            parameters[2].Value = model.Lat;
			parameters[3].Value = model.LogoName; 
			parameters[4].Value = model.Creator;
			parameters[5].Value = model.Remark;

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
		public bool Update(Osiris.Model.Coordinate model)
		{
            Osiris.Model.Coordinate m = GetModel(model.Id);
            if (m == null)
                return false;

			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Coordinate set ");
			strSql.Append("Eare=@Eare,");
			strSql.Append("Lon=@Lon,");
            strSql.Append("Lat=@Lat,");
			strSql.Append("LogoName=@LogoName,"); 
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("Creator=@Creator,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Eare", SqlDbType.NVarChar,5),
					new SqlParameter("@Lon", SqlDbType.VarChar,20),
                    new SqlParameter("@Lat", SqlDbType.VarChar,20),
					new SqlParameter("@LogoName", SqlDbType.NVarChar,30), 
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@Creator", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.Eare == null ? m.Eare : model.Eare;
            parameters[1].Value = model.Lon == null ? m.Lon : model.Lon;
            parameters[2].Value = model.Lat == null ? m.Lat : model.Lat;
            parameters[3].Value = model.LogoName == null ? m.LogoName : model.LogoName;
			parameters[4].Value = DateTime.Now;
            parameters[5].Value = model.Creator == null ? m.Creator : model.Creator;
            parameters[6].Value = model.Remark == null ? m.Remark : model.Remark;
			parameters[7].Value = model.Id;

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
			strSql.Append("delete from Coordinate ");
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
			strSql.Append("delete from Coordinate ");
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
		public Osiris.Model.Coordinate GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Eare,Lon,Lat,LogoName,CreateTime,UpdateTime,Creator,Remark from Coordinate ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Osiris.Model.Coordinate model=new Osiris.Model.Coordinate();
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


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Osiris.Model.Coordinate DataRowToModel(DataRow row)
		{
			Osiris.Model.Coordinate model=new Osiris.Model.Coordinate();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Eare"]!=null)
				{
					model.Eare=row["Eare"].ToString();
				}
				if(row["Lon"]!=null)
				{
                    model.Lon = row["Lon"].ToString();
				}
                if (row["Lat"] != null)
                {
                    model.Lat = row["Lat"].ToString();
                }
				if(row["LogoName"]!=null)
				{
					model.LogoName=row["LogoName"].ToString();
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
			}
			return model;
		}
        /// <summary>
        /// 根据地区获取坐标
        /// </summary>
        /// <param name="eare"></param>
        /// <returns></returns>
        public string GetCoordinateByeare(string eare)
        {
           DataRow dr = GetList(" eare='" + eare + "'").Tables[0].Rows[0];
           string coo = dr["lon"].ToString() + "," + dr["lat"].ToString();

           return coo;
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Eare,Lon,Lat,LogoName,CreateTime,UpdateTime,Creator,Remark ");
			strSql.Append(" FROM Coordinate ");
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
			strSql.Append(" Id,Eare,Lon,Lat,LogoName,CreateTime,UpdateTime,Creator,Remark ");
			strSql.Append(" FROM Coordinate ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
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
            List<Osiris.Model.Coordinate> list = new List<Model.Coordinate>();
            DataSet ds = PageHelper.GetDataList("Coordinate", size, index, where, out OutTotalCount);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(DataRowToModel(dr));
            }

            return list;
        }

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Coordinate ");
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
			strSql.Append(")AS Row, T.*  from Coordinate T ");
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
			parameters[0].Value = "Coordinate";
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

