using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据库
{
    class server
    {
        private static string constring = @"server =LAPTOP-PRPGFGCD\MSSQLSERVER2;database=student1;uid=sa;pwd=123456;";
        public static DataTable GetDataTable(string sql)
        {
            //连接数据库
            SqlConnection con = new SqlConnection(constring);
            //执行SQL语句
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, con);
            //创建数据集 用于接收返回数据
            DataSet myds = new DataSet();
            //向数据中心填充数据
            sqlda.Fill(myds);
            con.Close();
            //返回表，由于里面有很多表，选择第一个表
            return myds.Tables[0];
            

        }



    }
}
