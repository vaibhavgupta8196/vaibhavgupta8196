using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace disconnected_architecture
{
    class Program
    {
        DataSet mydataset;
        SqlDataAdapter empadapter;
        SqlDataAdapter dptadapter;
        SqlDataAdapter salgradeadapter;
        SqlConnection conn;
        SqlCommandBuilder dptCmdBld;
        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            mydataset=new DataSet();

            conn = new SqlConnection();
            string myconnectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();

               
                conn.ConnectionString=(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; database=Scott;Integrated security=true");
           
            empadapter = new SqlDataAdapter("select * from emp",conn);
            dptadapter = new SqlDataAdapter("select * from dept", conn);
            salgradeadapter = new SqlDataAdapter("select * from salgrade", conn);

            empadapter.Fill(mydataset,"emp");
            dptadapter.Fill(mydataset,"dept");
            salgradeadapter.Fill(mydataset, "salgrade");

            DataColumn[] primarykeyColOfDept = new DataColumn[]
            {mydataset.Tables[1].Columns[0] };
            mydataset.Tables[1].PrimaryKey = primarykeyColOfDept;

            dptCmdBld = new SqlCommandBuilder(dptadapter);

            //DisplayDataSet();
            //insertIntoDataset("dept");
            //DeleteDataSet("dept");
            //Console.WriteLine("after insert");

            DisplayDataSet();
            LinqDemo();
            Console.ReadLine();

        }
        public void DeleteDataSet(string tablename)
        {
            if (tablename == "dept")
            {
                Console.WriteLine("Enter Department No: ");
                int deptno = int.Parse(Console.ReadLine());
                DataRow de = mydataset.Tables[1].Rows.Find(deptno);
                de.Delete();


                dptadapter.Update(mydataset, "dept");
            }
        }
        public void LinqDemo()
        {
            var result = from emp in mydataset.Tables[0].AsEnumerable()
                         join dept in mydataset.Tables[1].AsEnumerable()
                         on emp.Field<int>("deptno") equals dept.Field<int>("deptno")
                         where emp.Field<String>("job") == "CLERK" && emp.Field<int>("deptno")==20
                         select new
                         {
                             EmployeeName = emp.Field<String>("ename")
                         };
            foreach (var r in result)
            {
                Console.WriteLine(r.EmployeeName);
            }
        }
        public void UpdateDataSet(string tableName)
        {
            if (tableName == "dept")
            {
                Console.WriteLine("Enter Department No: ");
                int deptno = int.Parse(Console.ReadLine());
                DataRow de=mydataset.Tables[1].Rows.Find(deptno);
                if (de != null)
                {
                    de[1] = "NewDeptName";
                    de[2] = "NewDeptLoc";
                }
                dptadapter.Update(mydataset, "dept");
            }
        }
        public void insertIntoDataset(string tableName)
        {
            if (tableName == "dept")
            {
                DataTable table = mydataset.Tables[1];
               
                DataRow newRow = table.NewRow();
                
                newRow[0] = 70;
                newRow[1] = "Dept1";
                newRow[2] = "Loc1";
                table.Rows.Add(newRow);

                //newRow = table.NewRow();
                //newRow[0] = 80;
                //newRow[1] = "Dept2";
                //newRow[2] = "Loc1";
                //table.Rows.Add(newRow);
            }

            dptadapter.Update(mydataset, "dept");
            Console.WriteLine("success");
        }
        public void DisplayDataSet()
        {
            foreach (DataTable dt in mydataset.Tables)
            {
                Console.WriteLine(dt.TableName);
                Console.WriteLine("********************");
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc]+"\t");
                    }
                    Console.WriteLine();
                }

                

            }




        }
    }
}
