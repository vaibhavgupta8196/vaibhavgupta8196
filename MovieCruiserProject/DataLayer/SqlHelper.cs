using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    
    public class SqlHelper
    {
        static SqlConnection conn;
        public static void Insert(string commandText, CommandType commandType, SqlParameter[] param)
        {
            conn = new SqlConnection(@"Data Source=SHUBHAMSHARMA\MSSQLSERVER01;Initial Catalog=MovieCruiserProject;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = conn;
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }
            conn.Open();
            object rows = command.ExecuteNonQuery();
            conn.Close();
            
        }

        public static int Check(string commandText, CommandType commandType, SqlParameter[] param)
        {
            conn = new SqlConnection(@"Data Source=SHUBHAMSHARMA\MSSQLSERVER01;Initial Catalog=MovieCruiserProject;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = conn;
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }
            conn.Open();
            int rows = (int)command.ExecuteScalar();
            conn.Close();
            return rows;
        }

    }
}
