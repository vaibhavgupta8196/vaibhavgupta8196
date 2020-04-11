using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dao;
using Model;

namespace TruYumWeb
{
    public partial class ShowMenuItemListCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItemDaoCollection menuItem;
            
            if (Session["menu"] != null)
            {
                menuItem = (MenuItemDaoCollection)Session["menu"];

            }
            else
            {
                menuItem = new MenuItemDaoCollection();

                Session["menu"] = (MenuItemDaoCollection)menuItem;
            }
            grid1.DataSource = menuItem.GetMenuItemListCustomer();
            grid1.DataBind();
        }

        protected void gridMenuItemListCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
        }

        protected void grid1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void grid1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                GridViewRow grv = grid1.Rows[int.Parse(e.CommandArgument.ToString())];
                string movieId = grv.Cells[0].Text;
                Response.Redirect("AddToCart.aspx?menuItemId=" + movieId);
            }

        }
    }
}