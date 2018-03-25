using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CoordinateTransformation
{
   public class AccessHelper
    {
        //读取配置文件连接字符串
        public static readonly string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\CoordinateSystem.mdb";
        public static int ExecuteNonQuery(string cmdText, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandTimeout = 3000;
                    //cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string cmdText, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandTimeout = 3000;
                    //cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string cmdText, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandTimeout = 3000;
                    //cmd.Parameters.AddRange(parameters);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static DataSet ExecuteDataSet(string cmdText, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandTimeout = 3000;
                    cmd.Parameters.AddRange(parameters);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataSet dt = new DataSet();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static OleDbDataReader ExecuteDataReader(string cmdText, params OleDbParameter[] parameters)
        {
            OleDbConnection conn = new OleDbConnection(connstr);
            conn.Open();
            using (OleDbCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.CommandTimeout = 3000;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    }
}
       

