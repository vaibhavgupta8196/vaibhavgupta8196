using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using System.Data;
using System.Data.SqlClient;

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
                int mgr = dr[3]==DBNull.Value? 0 : int.Parse(dr[3].ToString());
                DateTime hireDate= DateTime.Parse(dr[4].ToString());
                int sal = int.Parse(dr[5].ToString());
                int comm = dr[6] == DBNull.Value ? 0 : int.Parse(dr[6].ToString());
                
                int deptNo = int.Parse(dr[7].ToString());

                Emp dpt = new Emp(empno,name,job,mgr,hireDate,sal,comm,deptNo);
                dp.Add(dpt);
            }
            return dp;
        }
        public void InsertEmployee(List<Emp> emp)
        {
            Emp y=null;

            foreach (var i in emp)
            {
                y = i;
            }
            int empno = y.EmpNo;    //int.Parse(emp[0].ToString());
            string ename = y.EName;  //emp[1].ToString();
            string job = y.Job;      //emp[2].ToString();
            int mgr = y.Mgr;     //int.Parse(emp[3].ToString());
            DateTime hiredate = y.HireDate;// DateTime.Parse(emp[4].ToString());
            int sal = y.Sal;  // int.Parse(emp[5].ToString());
            int comm = y.Comm; // int.Parse(emp[6].ToString());
            int deptno = y.DeptNo; // int.Parse(emp[7].ToString());

            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@EMPNO", empno);
            Param[1] = new SqlParameter("@ENAME", ename);
            Param[2] = new SqlParameter("@JOB", job );
            Param[3] = new SqlParameter("@MGR", mgr );
            Param[4] = new SqlParameter("@HIREDATE", hiredate );
            Param[5] = new SqlParameter("@SAL", sal);
            Param[6] = new SqlParameter("@COMM",comm );
            Param[7] = new SqlParameter("@DEPTNO", deptno);
            SqlHelper.InsertUpdateDelete("insert into emp values (@EMPNO, @ENAME, @JOB, @MGR, @HIREDATE, @SAL, @COMM, @DEPTNO )", CommandType.Text, Param);

        }

        public void DeleteEmployee(int empno)
        {
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@EMPNO", empno);
            SqlHelper.InsertUpdateDelete(" delete from emp where EMPNO=@empno ", CommandType.Text, Param);
            
        }
        public void UpdateEmployee(int empno, string ename, string job, int mgr, DateTime hiredate, int sal, int comm, int deptno)
        {
            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@EMPNO", empno);
            Param[1] = new SqlParameter("@ENAME", ename);
            Param[2] = new SqlParameter("@JOB", job);
            Param[3] = new SqlParameter("@MGR", mgr);
            Param[4] = new SqlParameter("@HIREDATE", hiredate);
            Param[5] = new SqlParameter("@SAL", sal);
            Param[6] = new SqlParameter("@COMM", comm);
            Param[7] = new SqlParameter("@DEPTNO", deptno);
            SqlHelper.InsertUpdateDelete("modify emp  set  ENAME=@ENAME, JOB=@JOB, MGR=@MGR, HIREDATE@HIREDATE, SAL=@SAL, COMM=@COMM, DEPTNO=@DEPTNO where EMPNO=@EMPNO ", CommandType.Text, Param);

        }
    }
}
