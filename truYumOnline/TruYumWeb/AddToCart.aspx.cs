using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dao;

namespace TruYumWeb
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItemDaoCollection menuItem = new MenuItemDaoCollection();
            gridMenuItemListCustomer.DataSource = menuItem.GetMenuItemListCustomer();
            gridMenuItemListCustomer.DataBind();
            long userId = 1;
            long movieId = long.Parse(Request.Params["menuItemId"].ToString());
            CartDaoCollection fav;
            if (!IsPostBack)
            {
                fav = new CartDaoCollection();
                fav.AddCartItem(userId, movieId);
                Session["cart"] = fav;
            }
            else
            {
                fav = (CartDaoCollection)Session["cart"];
            }
            string status = "Item added to cart successfully";
            lblstatus.Text = status;
            lblstatus.Visible = true;
        }

        protected void gridMenuItemListCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                GridViewRow grv = gridMenuItemListCustomer.Rows[int.Parse(e.CommandArgument.ToString())];
                string movieId = grv.Cells[0].Text;
                Response.Redirect("AddToCart.aspx?menuItemId=" + movieId);
            }
        }
    }
}