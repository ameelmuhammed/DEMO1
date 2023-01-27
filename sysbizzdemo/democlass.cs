using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace sysbizzdemo.model
{
    public static class democlass
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=HP;Initial Catalog=sysbizzdemo;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;
        

        public static int InsertUpdate(string Command)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = Command;
            cmd.Parameters.Clear();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows;

        }
       public static void down(KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }
        public static DataTable display(string command)
        {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = command;
                cmd.Parameters.Clear();
                DataTable dt = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);
                conn.Close();
                return dt;
        }
        public static SqlDataReader GetDataReader(string Command)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = Command;
                cmd.Parameters.Clear();
                
                dr = cmd.ExecuteReader();
               // conn.Close();
                return dr;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error:Get DataReader- " + ex);
                //CloseConnection();
                return dr;
            }
        }
    }
}
    

