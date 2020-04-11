using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dao;

namespace TruYumWeb
{
    public partial class ShowCartNotification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long userId = 1;
            long movieId = long.Parse(Request.Params["menuItemId"].ToString());
            CartDaoCollection fav = (CartDaoCollection)Session["cart"];
            fav.RemoveCartItem(userId, movieId);
            try
            {
                fav.GetAllCartItems(userId);
                int removestatus = 1;
                Response.Redirect("ShowCart.aspx?removeStatus=" + removestatus.ToString());

            }
            catch (CartEmptyException)
            {
                Response.Redirect("ShowCartEmpty.aspx");
            }
            Total.Text = fav.GetAllCartItems(userId).Total.ToString();
        }

        protected void gridcart_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = gridcart.Rows[int.Parse(e.CommandArgument.ToString())];
            string movieId = row.Cells[0].Text;
            Response.Redirect("ShowCartNotification.aspx?menuItemId=" + movieId);
        }
    }
}