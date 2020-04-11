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
    public partial class ShowCart : System.Web.UI.Page
    {
        CartDaoCollection fav;
        protected void Page_Load(object sender, EventArgs e)
        {
            long userId = 1;
            if (Session["cart"] != null)
            {
                fav = (CartDaoCollection)Session["cart"];
            }
            else
            {
                Response.Redirect("ShowCartEmpty.aspx");
            }

            try
            {
                if (Request.QueryString["removestatus"] != null)
                {
                    int rs = int.Parse(Request.Params["removeStatus"].ToString());


                    if (rs == 1)
                    {
                        string dele = "Item removed from Cart successfully";
                        lblDelete.Text = dele;
                        lblDelete.Visible = true;
                    }

                }

            }
            catch (CartEmptyException)
            {
                Response.Redirect("ShowCartEmpty.aspx");
            }

            gridcart.DataSource = fav.GetAllCartItems(userId).MenuItemList;
            gridcart.DataBind();
            //gridFavourites.FooterRow.Cells[1].Text = "Total";
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