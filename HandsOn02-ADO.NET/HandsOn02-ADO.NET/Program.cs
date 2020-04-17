using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;


namespace HandsOn02_ADO.NET
{
    class Program
    {
        SqlConnection conn = new SqlConnection(@"data source =SHUBHAMSHARMA\MSSQLSERVER01;initial catalog=Scott;Integrated Security=true");
        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();

        }

        public Program()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    Console.WriteLine("Enter Emplyeee Name");
                    string empName = Console.ReadLine();
                    Console.WriteLine("Enter New Department");
                    string deptName = Console.ReadLine();



                    SqlCommand update = new SqlCommand();
                    update.CommandText = "select  deptno from dept where dname=@dname";
                    SqlParameter deptno = new SqlParameter("@dname", deptName);
                    update.Parameters.Add(deptno);

                    update.Connection = conn;
                    conn.Open();
                    object updatebool = update.ExecuteScalar();
                    conn.Close();
                    Console.WriteLine(int.Parse(updatebool.ToString()));
                    int a = int.Parse(updatebool.ToString());
                    if (a == 1)
                    {
                        SqlCommand updateCommand = new SqlCommand();
                        updateCommand.CommandText = "update emp set deptno=(select deptno from dept where dname=@deptname) from emp e join dept d on e.deptno = d.deptno where e.ename = @empName";
                        updateCommand.Connection = conn;

                        SqlParameter[] param = new SqlParameter[2];
                        param[0] = new SqlParameter("@deptname", deptName);
                        param[1] = new SqlParameter("@empName", empName);
                        updateCommand.Parameters.AddRange(param);

                        conn.Open();
                        int result = updateCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Updation Successfull");
                            ts.Complete();
                        }
                        else
                            throw new Exception(" Update Failed");
                        
                    }
                    else
                    {
                        Console.WriteLine("department doesnot exist");
                        throw new Exception("Update Failed");
                    }
                    ts.Complete();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ts.Dispose();
                }

                finally
                {
                    conn.Close();
                    ts.Dispose();
                }
                Console.ReadLine();
                
            }
        }

       
       
            



        
    }
}
