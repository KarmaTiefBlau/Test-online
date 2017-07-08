using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado
{
    public class SqlHelper
    {
        static string connstr = "server = (local); database = ExamSystem; uid = sa; pwd = 111";

        /// <summary>
        /// 查询数据库，并返回一张表（dataTable）
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <param name="parameters">查询需要的参数</param>
        /// <returns>查询结果集</returns>
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connstr);
            adapter.SelectCommand.Parameters.AddRange(parameters);
            try
            {
                adapter.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <param name="parameters">查询需要的参数</param>
        /// <returns>影响行数</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddRange(parameters);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        return -1;
                        
                    }
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }




    }
}
