using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using DataLayer;



namespace BusinessLayerLogic
{
    public class DeptBL
    {
        List<Dept> dept;
        public List<Dept> GetAllDepartments()
        {
            DeptDL dl = new DeptDL();
            dept = dl.GetAllDepartments();
            return dept;
        }
        public List<string> GetAllDepartmentsName()
        {
            DeptDL dl = new DeptDL();
            List<string> a;
            a= dl.GetAllDepartmentName();
            return a ;
        }
    }
}
