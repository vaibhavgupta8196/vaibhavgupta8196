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
            if (!IsPostBack)
            {
                EmpBL empBL = new EmpBL();
                List<Emp> empList = empBL.GetAllEmployee();
                ViewState["data"] = empList;
               // FormView1.AllowPaging = true;
                FormView1.DataSource = empList;
                FormView1.DataBind();
            }
            
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            if (ViewState["data"] != null)
            {
                EmpBL empBL = new EmpBL();
                List<Emp> emplist = (List<Emp>)ViewState["data"];
                //List<Emp> empList = empBL.GetAllEmployee();
                //FormView1.PageIndex = e.NewPageIndex;
                //FormView1.AllowPaging = true;
                FormView1.DataSource = emplist;
                FormView1.DataBind();
            }
        }

        protected void Insert1_Click(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Insert);
           
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int empno = int.Parse(((TextBox)FormView1.FindControl("eempno")).Text);
            string ename = ((TextBox)FormView1.FindControl("eename")).Text;
            string job = ((TextBox)(FormView1.FindControl("ejob"))).Text;
            int mgr = int.Parse(((TextBox)(FormView1.FindControl("emgr"))).Text);
            DateTime hiredate = DateTime.Parse(((TextBox)(FormView1.FindControl("ehiredate"))).Text);
            int sal = int.Parse(((TextBox)(FormView1.FindControl("esal"))).Text);
            int comm = int.Parse(((TextBox)FormView1.FindControl("ecomm")).Text);

            int deptno = int.Parse(((TextBox)(FormView1.FindControl("edeptno"))).Text);
            EmpBL empbl = new EmpBL();
            empbl.UpdateEmployee(empno,ename,job,mgr,hiredate,sal,comm,deptno);
            
            FormView1.ChangeMode(FormViewMode.ReadOnly);
            List<Emp> emplist = empbl.GetAllEmployee();
            ViewState["data"] = emplist;
            FormView1.DataSource = emplist;
            FormView1.DataBind();
            
        }

        protected void empno_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void insert2_Click(object sender, EventArgs e)
        {
            List<Emp> dp = new List<Emp>();

            
           int empno = int.Parse(((TextBox)FormView1.FindControl("iempno")).Text);
            string ename = ((TextBox)FormView1.FindControl("iename")).Text;
            string job = ((TextBox)(FormView1.FindControl("ijob"))).Text;
            int mgr = int.Parse(((TextBox)(FormView1.FindControl("imgr"))).Text);
            DateTime hiredate = DateTime.Parse(((TextBox)(FormView1.FindControl("ihiredate"))).Text);
            int sal = int.Parse(((TextBox)(FormView1.FindControl("isal"))).Text);
            int comm = int.Parse(((TextBox)(FormView1.FindControl("icomm"))).Text);

            int deptno = int.Parse(((TextBox)(FormView1.FindControl("ideptno"))).Text);

            Emp emp = new Emp(empno, ename, job, mgr, hiredate, sal, comm, deptno);
            dp.Add(emp);
            EmpBL empbl = new EmpBL();
            empbl.InsertEmployee(dp);
            FormView1.ChangeMode(FormViewMode.ReadOnly);
            List<Emp> emplist = empbl.GetAllEmployee();
            ViewState["data"] = emplist;
            FormView1.DataSource = emplist;
            FormView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(((TextBox)FormView1.FindControl("empno")).Text);
            EmpBL empbl = new EmpBL();
            empbl.DeleteEmployee(empno);
            FormView1.ChangeMode(FormViewMode.ReadOnly);
            List<Emp> emplist = empbl.GetAllEmployee();
            ViewState["data"] = emplist;
            FormView1.DataSource = emplist;
            FormView1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Edit);
            List<Emp> emplist = (List<Emp>)ViewState["data"];
            FormView1.DataSource = emplist;
            FormView1.DataBind();
            
        }

        protected void FormView1_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            
                FormView1.ChangeMode(e.NewMode);
               
        }

        protected void empno_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}