using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ado_net1
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
                Console.Write("Do you continue(y/n)");
                ans = Console.ReadLine();
            }
            while (ans == "y");
            //InsertQuery();
            //Console.WriteLine("press enter to exit");
            //Console.ReadLine();
        }
        public void InsertQuery()
        {
            try
            {
                SqlCommand getLastDeptNo = new SqlCommand();
                getLastDeptNo.CommandText = "Select max(deptno) from dept";
                getLastDeptNo.Connection = conn;
                conn.Open();
                object lastDeptnoObject = getLastDeptNo.ExecuteScalar();
                conn.Close();
                int lastDeptno = int.Parse(lastDeptnoObject.ToString());
                Console.WriteLine("Last Deptno: "+lastDeptno);

                SqlCommand insertcmd = new SqlCommand();
                Console.WriteLine("Insert data");

                int deptno = lastDeptno + 10;
                Console.WriteLine("enter department name");
                string dname = Console.ReadLine();
                Console.WriteLine("Enter city");
                string city = Console.ReadLine();
                
                insertcmd.CommandText = "insert into dept values(@deptno , @dname, @city )";
                //SqlParameter deptnoParam = new SqlParameter("@deptno",deptno);
                //SqlParameter dnameParam = new SqlParameter("@dname", dname);
                //SqlParameter cityParam = new SqlParameter("@city", city);
                //insertcmd.Parameters.Add(deptnoParam);
                //insertcmd.Parameters.Add(dnameParam);
                //insertcmd.Parameters.Add(cityParam);

                SqlParameter[] insertParam = new SqlParameter[3];
                insertParam[0] = new SqlParameter("@deptno", deptno);
                insertParam[1] = new SqlParameter("@dname", dname);

                insertParam[2] = new SqlParameter("@city", city);
                
                insertcmd.Parameters.AddRange(insertParam);
                insertcmd.Connection = conn;
                conn.Open();
                int result = insertcmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    Console.WriteLine("insert completed successfully");
                }
                else
                    Console.WriteLine("OOPS!!! Error in insert");
            }
            catch (SqlException sqe)
            {
                Console.WriteLine(sqe.Message);
            }
            finally { conn.Close(); }
        }
        public void UpdateData()
        {
            try
            {
                Console.WriteLine("Update data");
                Console.WriteLine("enter department number");
                string dno = Console.ReadLine();
                

                SqlCommand update = new SqlCommand();
                update.CommandText = "select  count(*) from dept where deptno=@dno";
                SqlParameter deptno = new SqlParameter("@dno", dno);
                update.Parameters.Add(deptno);
                    
                update.Connection = conn;
                conn.Open();
                object updatebool = update.ExecuteScalar();
                conn.Close();
                Console.WriteLine(int.Parse(updatebool.ToString()));
                int a = int.Parse(updatebool.ToString());
                if (a == 1)
                {
                    Console.WriteLine("enter department name");
                    string dname = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    string city = Console.ReadLine();

                    SqlCommand updatecmd = new SqlCommand();
                    updatecmd.CommandText = "update dept set dname=@dname , loc=@city where deptno=@dno";
                    SqlParameter[] updateParam = new SqlParameter[3];

                    updateParam[0] = new SqlParameter("@dname", dname);

                    updateParam[1] = new SqlParameter("@city", city);
                    updateParam[2] = new SqlParameter("@dno",dno);
                    updatecmd.Parameters.AddRange(updateParam);
                    updatecmd.Connection = conn;
                    conn.Open();
                    int result = updatecmd.ExecuteNonQuery();
                    if (result >= 0)
                    {
                        Console.WriteLine("update completed successfully");
                    }
                    else
                        Console.WriteLine("OOPS!!! Error in insert");
                }
                else
                    Console.WriteLine("deptno doesnot exist");


            }
            catch (SqlException sqe)
            {
                Console.WriteLine(sqe.Message);
            }
            finally { conn.Close(); }
        }
            

        
        public void DisplayData(string query)
        {
            try
            {
                
                conn.Open();
                Console.WriteLine("Connection Establish Successfully");
                SqlCommand comm = new SqlCommand(query, conn);
                SqlDataReader myreader = comm.ExecuteReader();
                //for (int i = 0; i < myreader.FieldCount; i++)
                //{
                //    Console.Write(myreader.GetName(i) + "\t");
                //}
                //Console.WriteLine();
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
