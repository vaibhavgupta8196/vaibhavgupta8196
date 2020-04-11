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
    public partial class ShowMenuItemListAdmin : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItemDaoCollection menuItem;
            //if (Session["menuItem"] != null)
            //    menuItem = (MenuItemDaoCollection).Session[""];
            
            if (Session["menu"] != null)
            {
                menuItem = (MenuItemDaoCollection)Session["menu"];

            }
            else
            {
                menuItem = new MenuItemDaoCollection();

                Session["menu"] = (MenuItemDaoCollection)menuItem;
            }
            gridMenuItemList.DataSource = menuItem.GetMenuItemListAdmin();
            gridMenuItemList.DataBind();
            
            

        }

        protected void gridMenuItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridMenuItemList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gridMenuItemList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //GridViewRow gr = gridMenuItemList.Rows[e.NewEditIndex];
            //String menuItemId = gr.Cells[0].Text;
            //Response.Redirect("ShowEditMenuItem.aspx?MenuItemId=" + menuItemId);
            MenuItemDaoCollection menuItem;
            if (Session["menu"] != null)
            {
                menuItem = (MenuItemDaoCollection)Session["menu"];
                String menuItemId = menuItem.GetMenuItemListAdmin()[e.NewEditIndex].Id.ToString();
                Response.Redirect("ShowEditMenuItem.aspx?menuItemId=" + menuItemId);

            }
        }
    }
}