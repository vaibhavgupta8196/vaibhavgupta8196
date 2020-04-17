using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HandsOn_01
{
    class Program
    {
        SqlConnection conn;
        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            conn = new SqlConnection(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; initial Catalog=Scott;Integrated security=true");

            string ans = "y";
            do
            {
                Console.Write("Enter the query : ");
                string query = Console.ReadLine();
                DisplayData(query);
                Console.Write("Do you want to continue(y/n)");
                ans = Console.ReadLine();
            } while (ans == "y");
        }
        public void DisplayData(string query)
        {
            try
            {

                conn.Open();

                SqlCommand comm = new SqlCommand(query, conn);
                SqlDataReader myreader = comm.ExecuteReader();
                
                Console.WriteLine("The Jobs of The Employees are");
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                        Console.Write(myreader[i].ToString() + "\t");
                    Console.WriteLine();
                }


            }
            catch (SqlException sqe)
            {
                Console.WriteLine(sqe.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
