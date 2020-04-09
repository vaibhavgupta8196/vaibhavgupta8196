using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayer
{
    public class SqlHelper
    {
        static SqlConnection conn;
        public static DataTable GetDataTable(string commandText, CommandType commandType, SqlParameter[] param)
        {
            conn = new SqlConnection(@"Data Source=SHUBHAMSHARMA\MSSQLSERVER01;Initial Catalog=SCOTT;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection=conn;
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            return ds;
        }
        public static void InsertUpdateDelete(string commandText, CommandType commandType, SqlParameter[] param)
        {
            conn = new SqlConnection(@"Data Source=SHUBHAMSHARMA\MSSQLSERVER01;Initial Catalog=SCOTT;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = conn;
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }
            conn.Open();
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();


        }
    }
}
