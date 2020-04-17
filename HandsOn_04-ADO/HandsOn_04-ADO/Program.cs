using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HandsOn_04_ADO
{
    class Program
    {
        DataSet mydataset;
        SqlDataAdapter empadapter;
        
        SqlConnection conn;
        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            conn = new SqlConnection(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; initial Catalog=Scott;Integrated security=true");
            mydataset = new DataSet();
            empadapter = new SqlDataAdapter("select ename, year(hiredate), dname from emp  join dept  on emp.deptno=dept.deptno",conn);
            empadapter.Fill(mydataset,"data");

            foreach (DataTable dt in mydataset.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i=i+3)
                    {
                        Console.WriteLine(dr[i]+" - "+dr[i+1]+ " of "+dr[i+2]);
                    }
                }

            }
            Console.ReadLine();





        }
    }
}
