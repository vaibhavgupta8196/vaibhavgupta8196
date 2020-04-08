using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using System.Data;

namespace DataLayer
{
    public class EmpDL
    {
        public List<Emp> GetAllEmployee()
        {
            DataTable dt = SqlHelper.GetDataTable("select * from emp", CommandType.Text, null);
            List<Emp> dp = new List<Emp>();
            foreach (DataRow dr in dt.Rows)
            {
                int empno = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                string job = dr[2].ToString();
                int mgr = int.Parse(dr[3].ToString());
                DateTime hireDate= DateTime.Parse(dr[4].ToString());
                int sal = int.Parse(dr[5].ToString());
                int comm = int.Parse(dr[6].ToString());
                int deptNo = int.Parse(dr[7].ToString());

                Emp dpt = new Emp(empno,name,job,mgr,hireDate,sal,comm,deptNo);
                dp.Add(dpt);
            }
            return dp;
        }
        public void InsertEmployee(List<Emp> emp)
        {
            
        }
    }
}
