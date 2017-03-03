using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Osiris.DBUtility;

namespace Osiris.DAL
{
    public class PageHelper
    {

        public static DataSet GetDataList(string tableName,int size, int index, string where, out int OutTotalCount)
        {
            string spName = "PagerHelper"; 
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.VarChar,200),
                    new SqlParameter("@FieldList", SqlDbType.VarChar,2000),
                    new SqlParameter("@PrimaryKey", SqlDbType.VarChar,100),
                    new SqlParameter("@Where", SqlDbType.VarChar,2000),
                    new SqlParameter("@Order", SqlDbType.VarChar,1000),
                    new SqlParameter("@SortType", SqlDbType.Int),
                    new SqlParameter("@RecorderCount", SqlDbType.Int),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@TotalCount",SqlDbType.Int),
                    new SqlParameter("@TotalPageCount", SqlDbType.Int)
			};
            parameters[0].Value = tableName;
            parameters[1].Value = "*";
            parameters[2].Value = "Id";
            parameters[3].Value = where;
            parameters[4].Value = " id desc ";
            parameters[5].Value = "2";
            parameters[6].Value = "0";
            parameters[7].Value = size;
            parameters[8].Value = index;
            parameters[9].Value = ParameterDirection.Output;
            parameters[10].Value = ParameterDirection.Output;

            DataSet ds = DbHelperSQL.RunProcedure(spName, parameters, "tb");

            OutTotalCount = Convert.ToInt16(parameters[9].Value);
            return ds;

        }
    }
}
