using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using DataLayer;

namespace BusinessLayerLogic
{
    public class EmpBL
    {
        List<Emp> emp;
        public List<Emp> GetAllEmployee()
        {
            
            EmpDL dl = new EmpDL();
            emp = dl.GetAllEmployee();
            return emp;
        }
    }
}
