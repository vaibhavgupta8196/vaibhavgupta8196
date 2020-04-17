using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;

namespace HandsOn_05_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        DataSet mydataset;
        SqlDataAdapter empadapter;
        
        
        SqlConnection conn;
        
        public Program()
        {
            mydataset = new DataSet();

            conn = new SqlConnection(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; initial Catalog=Scott;Integrated security=true");

            empadapter = new SqlDataAdapter("select * from emp", conn);
           

            empadapter.Fill(mydataset, "emp");
            
            LinqDemo();
            Console.ReadLine();
        }
        public void LinqDemo()
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            var result = from emp in mydataset.Tables[0].AsEnumerable()
                         where emp.Field<DateTime>("hiredate").Year==year
                         
                         select new
                         {
                             EmployeeName = emp.Field<String>("ename"),
                             
                         };

            foreach (var r in result)
            {
                Console.WriteLine(r.EmployeeName);
                
                
            }
        }
    }
}
