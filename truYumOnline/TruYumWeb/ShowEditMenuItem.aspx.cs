using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Dao;

namespace TruYumWeb
{
    public partial class ShowEditMenuItem : System.Web.UI.Page
    {
        MenuItemDaoCollection menuItem;
        Model.MenuItem item;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["menu"] != null)
            {
                string menuItemId = Request.Params["menuItemId"].ToString();
                menuItem = (MenuItemDaoCollection)Session["menu"];
                item = menuItem.GetMenuItem(long.Parse(menuItemId));
                Session["item"] = item;
                ShowMenuItem(item);
            }
            
        }
        private void ShowMenuItem(Model.MenuItem menuItem)
        {
            text.Text=menuItem.Name;
            price.Text = menuItem.Price.ToString();
            dateOfLaunch.Text = menuItem.DateOfLaunch.ToString("yyyy-MM-dd");
            if (menuItem.Active)
                yes.Checked = true;
            else
                no.Checked = true;
            if (menuItem.FreeDelivery)
                freeDelivery.Checked = true;
            else
                freeDelivery.Checked = false;
            category.SelectedValue = menuItem.Category;

        }
        private void ModifyMenuItem()
        {
            
        }
       

        protected void save_Click(object sender, EventArgs e)
        {
            menuItem = (MenuItemDaoCollection)Session["menu"];
            item = (Model.MenuItem)Session["item"];
            item.Name = text.Text;
            item.Price = int.Parse(price.Text);
            item.DateOfLaunch = DateTime.Parse(dateOfLaunch.Text.ToString());
            if (yes.Checked)
                item.Active = true;
            else
                item.Active = false;
            item.Category = category.Text.ToString();
            if (freeDelivery.Checked)
                item.FreeDelivery = true;
            else
                item.FreeDelivery = false;

            menuItem.ModifyMenuItem(item);
            Response.Redirect("ShowEditMenuItemStatus.aspx");

        }

      
        
    }
}