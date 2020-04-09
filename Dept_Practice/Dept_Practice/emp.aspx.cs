using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using BusinessLayerLogic;
using BusinessLayerModel;

namespace Dept_Practice
{
    public partial class emp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                EmpBL empBL = new EmpBL();
                List <Emp> empList = empBL.GetAllEmployee();
                FormView1.DataSource = empList;
                FormView1.DataBind();
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<Emp> dp = new List<Emp>();

            int empno= int.Parse(((TextBox)FormView1.FindControl("empno")).Text);
            string ename =( (TextBox)FormView1.FindControl("ename")).Text;
            string job = ((TextBox)(FormView1.FindControl("job"))).Text;
            int mgr = int.Parse(((TextBox)(FormView1.FindControl("mgr"))).Text);
            DateTime hiredate = DateTime.Parse(((TextBox)(FormView1.FindControl("hiredate"))).Text);
            int sal = int.Parse(((TextBox)(FormView1.FindControl("sal"))).Text);  
            int comm = int.Parse(((TextBox)(FormView1.FindControl("comm"))).Text);
            
            int deptno = int.Parse(((TextBox)(FormView1.FindControl("deptno"))).Text);

            Emp emp = new Emp(empno,ename,job,mgr,hiredate,sal,comm,deptno);
            dp.Add(emp);
            EmpBL empbl = new EmpBL();
            empbl.InsertEmployee(dp);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(((TextBox)FormView1.FindControl("empno")).Text);
            EmpBL empbl = new EmpBL();
            empbl.DeleteEmployee(empno);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(((TextBox)FormView1.FindControl("empno")).Text);
            string ename = ((TextBox)FormView1.FindControl("ename")).Text;
            string job = ((TextBox)(FormView1.FindControl("job"))).Text;
            int mgr = int.Parse(((TextBox)(FormView1.FindControl("mgr"))).Text);
            DateTime hiredate = DateTime.Parse(((TextBox)(FormView1.FindControl("hiredate"))).Text);
            int sal = int.Parse(((TextBox)(FormView1.FindControl("sal"))).Text);
            int comm = int.Parse(((TextBox)(FormView1.FindControl("comm"))).Text);

            int deptno = int.Parse(((TextBox)(FormView1.FindControl("deptno"))).Text);
            EmpBL empbl = new EmpBL();
            empbl.UpdateEmployee(empno,ename,job,mgr,hiredate,sal,comm,deptno);
        }
    }
}