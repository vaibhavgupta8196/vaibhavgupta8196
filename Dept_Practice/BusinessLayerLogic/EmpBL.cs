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
        public void InsertEmployee(List<Emp> emp)
        {
            EmpDL empdl = new EmpDL();
            empdl.InsertEmployee(emp);
        }
        public void DeleteEmployee(int empno)
        {
            EmpDL empdl = new EmpDL();
            empdl.DeleteEmployee(empno);
        }
        public void UpdateEmployee(int empno, string ename, string job, int mgr, DateTime hiredate, int sal, int comm, int deptno)
        {
            EmpDL empdl = new EmpDL();
            empdl.UpdateEmployee(empno,ename,job,mgr,hiredate,sal,comm,deptno);
        }
    }
}
