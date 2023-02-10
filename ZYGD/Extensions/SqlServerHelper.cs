using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZYGD.Extensions
{
    internal class SqlServerHelper
    {
        static string connectionString = "Server=.;Integrated Security=true;DataBase=MyDataBase;";
        /// <summary>
        /// 执行增、删、改的方法
        /// </summary>
        /// <param name="sql">预计执行的非SELECT查询语句</param>
        /// <param name="param">SQL语句中的可变参数</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(param);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message); 
                    return -2;
                }
            }
        }


    }
}
