using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using System.Data;




namespace DataLayer
{
    public class DeptDL
    {
       
        public List<Dept> GetAllDepartments()
        {
            DataTable dt = SqlHelper.GetDataTable("select * from dept", CommandType.Text, null);
            List<Dept> dp = new List<Dept>();
            foreach (DataRow dr in dt.Rows)
            {
                Dept dpt = new Dept(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString());
                dp.Add(dpt);
            }
            return dp;
        }
        public List<string> GetAllDepartmentName()
        {
            List<string> a = new List<string>();
            DataTable dt = SqlHelper.GetDataTable("select dname from dept", CommandType.Text, null);
            
            
            foreach (DataRow dr in dt.Rows)
            {
                
                a.Add( dr[0].ToString());
                
            }
            return a;

        }
    }
}
