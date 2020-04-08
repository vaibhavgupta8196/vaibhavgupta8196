using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
                List <Emp> empList = empBL.GetAllEmployee();
                GridView1.DataSource = empList;
                GridView1.DataBind();
            }
        }
    }
}