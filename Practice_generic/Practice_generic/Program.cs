using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Practice_generic
{
    class Program
    {
        SqlConnection conn;
        static void Main(string[] args)
        {
        }
        public Program()
        {
            conn = new SqlConnection(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; initial Catalog=Scott;Integrated security=true");
            //string ans = "y";
            //  do
            //{
            //    Console.Write("Enter Your Query:");
            //    string query = Console.ReadLine();
            //    DisplayData(query);
            //    Console.Write("do u wanna continue(y/n)");
            //    ans = Console.ReadLine();

            //} while (ans == "y");
            GetEmployee();
            Console.WriteLine("press enter to quit");
            Console.ReadLine();
        }
        public void GetEmployee()
        {
            DisplayData("select hiredate from emp");
            foreach (var d in hiredate)
            {
                Console.WriteLine(d);
            }
            DateTime minhiredate = hiredate.Min();
            DateTime maxhiredate = hiredate.Max();
            Console.WriteLine("Display Max employment");
            DisplayEmp(minhiredate);
            Console.WriteLine("Display Min employment");
            DisplayEmp(maxhiredate);

        }
        public void DisplayEmp(DateTime date)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select * from emp where hiredate=@date";
            comm.Connection = conn;
            SqlParameter param = new SqlParameter("@date", date);
            comm.Parameters.Add(param);
            //conn.Close();
            conn.Open();
            SqlDataReader sdr = comm.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                    Console.Write(sdr[i] + "\t");
                Console.WriteLine();
            }
            conn.Close();
        }
        public List<DateTime> hiredate = new List<DateTime>();
        public void InsertQuery()
        {
            try
            {
                SqlCommand getLastDeptNoCommand = new SqlCommand();
                getLastDeptNoCommand.CommandText = "select max(deptno) from dept";
                getLastDeptNoCommand.Connection = conn;
                conn.Open();
                object lastDeptnoObj = getLastDeptNoCommand.ExecuteScalar();
                conn.Close();
                int lastDepno = int.Parse(lastDeptnoObj.ToString());
                Console.WriteLine("Last Dept No:" + lastDepno);
                SqlCommand insertCommand = new SqlCommand();
                int deptno = lastDepno + 10;
                Console.Write("Enter Dept Name:");
                string deptname = Console.ReadLine();
                Console.Write("Enter Dept Loc:");
                string deptloc = Console.ReadLine();
                insertCommand.CommandText = "insert into dept values(@deptno,@deptname,@deptloc)";
                SqlParameter[] insertParam = new SqlParameter[3];
                insertParam[0] = new SqlParameter("@deptno", deptno);
                insertParam[1] = new SqlParameter("@deptname", deptname);
                insertParam[2] = new SqlParameter("@deptloc", deptloc);
                insertCommand.Parameters.AddRange(insertParam);
                insertCommand.Connection = conn;
                conn.Open();
                int result = insertCommand.ExecuteNonQuery();
                if (result >= 0)
                    Console.WriteLine("Insert completed successfully");
                else
                    Console.WriteLine("OOPS!!!!Error in Insert ");
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
        public void DisplayData(string query)
        {
            try
            {

                conn.Open();
                Console.WriteLine("Connection Established Successfully");
                SqlCommand comm = new SqlCommand(query, conn);
                SqlDataReader myReader = comm.ExecuteReader();
                for (int i = 0; i < myReader.FieldCount; i++)
                {
                    Console.Write(myReader.GetName(i) + "\t");
                }
                Console.WriteLine();
                //while (myReader.Read())
                //{
                //    for (int i = 0; i < myReader.FieldCount; i++)
                //        Console.Write(myReader[i].ToString() + "\t");
                //    Console.WriteLine();
                //}
                while (myReader.Read())
                {
                    for (int i = 0; i < myReader.FieldCount; i++)
                    {
                        hiredate.Add(DateTime.Parse((myReader[i]).ToString()));

                    }
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
