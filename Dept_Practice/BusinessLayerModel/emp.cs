using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerModel
{
    public class Emp
    {
        private int empNo;
        private string eName;
        private string job;
        private int mgr;
        private DateTime hireDate;
        private int sal;
        private int comm;
        private int deptNo;

        public int EmpNo { get => empNo; set => empNo = value; }
        public string EName { get => eName; set => eName = value; }
        public string Job { get => job; set => job = value; }
        public int Mgr { get => mgr; set => mgr = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public int Sal { get => sal; set => sal = value; }
        public int Comm { get => comm; set => comm = value; }
        public int DeptNo { get => deptNo; set => deptNo = value; }

        public Emp()
        { }
        public Emp(int empNo, string eName, string job, int mgr, DateTime hireDate, int sal, int comm, int deptNo)
        {
            this.EmpNo = empNo;
            this.EName = eName;
            this.Job = job;
            this.Mgr = mgr;
            this.HireDate = hireDate;
            this.Sal = sal;
            this.Comm = comm;
            this.DeptNo = deptNo;
        }
    }
}
