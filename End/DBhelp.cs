using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace End
{
    class DBhelp
    {
        private static String connStr = "server=localhost;database=c_sharp;uid=root;pwd=qwer1234;charset=utf8;sslmode=none";

        public static MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection(connStr);//
            if (conn.State == ConnectionState.Closed) conn.Open();//判断是否关闭 打开链接
            return conn;//返回链接
        }
        public static void CloseAll(MySqlConnection conn)
        {
            if (conn == null) return;
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Connecting)
                conn.Close();//关闭链接
        }
        public static int ExecuteNonQuery(string sql)
        {
            MySqlConnection conn = null;
            int result; //提前设置一个返回值
            try
            {
                conn = GetConn();//获取链接
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                result = cmd.ExecuteNonQuery();//执行sql 并返回受影响的行的个数
            }
            finally
            {
                CloseAll(conn);
            }
            return result;
        }
        public static MySqlDataReader executeQuery(string sql)
        {
            MySqlDataReader res = null;
            MySqlConnection conn = null;
            try
            {
                MySqlConnection conn1 = GetConn();
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                res = cmd.ExecuteReader();
            }
            finally
            {
                CloseAll(conn);
            }
            return res;
        }
    }
}
