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
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DeptBL dept = new DeptBL();
                List<Dept> deptList = dept.GetAllDepartments();
                ViewState["deptlist"] = deptList;
                GridView1.DataSource = deptList;
                GridView1.DataBind();
               
                DropDownList1.DataSource = deptList;
                DropDownList1.DataBind();
                //DropDownList1.ClearSelection();
                DropDownList1.SelectedIndex = -1;

            }
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewState["deptlist"] != null)
            {
                List<Dept> deptList = (List<Dept>)ViewState["deptlist"];
                List<Dept> found = new List<Dept>();

                found.Add(deptList.Find(d => d.DName == DropDownList1.SelectedValue));
                GridView1.DataSource = found;
                GridView1.DataBind();
                    
            }

        }
    }
}