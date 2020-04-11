using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    class CartDaoSql : ICartDao
    {
        public void AddCartItem(long userId, long menuItemId)
        {
            
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand insertcart = new SqlCommand();
            insertcart.CommandText = ("insert into cart values(@userid,@me_id)");
            insertcart.Connection = sqlConnection;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userid", userId);
            param[1] = new SqlParameter("@me_id",menuItemId);
            insertcart.Parameters.AddRange(param);
            sqlConnection.Open();
            insertcart.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public Cart GetAllCartItems(long userId)
        {
            
            Cart cart = new Cart();
            List<MenuItem> menuList = new List<MenuItem>();
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand insertcart = new SqlCommand();
            insertcart.CommandText = "select me_id,me_name,me_price,me_active,me_date_of_launch,me_category,me_free_delivery from menu_item m, cart c where c.ct_us_id=@userid and c.ct_pr_id=m.me_id ";
            
            SqlParameter param = new SqlParameter("@userid",userId);
            

            insertcart.Parameters.Add(param);
            insertcart.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = insertcart.ExecuteReader();
            
            while (reader.Read())
            {
                menuList.Add(new MenuItem(long.Parse(reader["me_id"].ToString()),
                    reader["me_name"].ToString(),
                    float.Parse(reader["me_price"].ToString()),
                    reader["me_active"].ToString() == "yes",
                    DateTime.Parse(reader["me_date_of_launch"].ToString()),
                    reader["me_category"].ToString(),
                    reader["me_free_delivery"].ToString() == "yes"));

            }
            cart.MenuItemList = menuList;
            return cart;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            List<MenuItem> menuList = new List<MenuItem>();
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand menuListCommand = new SqlCommand();
            menuListCommand.CommandText = "delete from cart where ct_us_id=@userId and ct_pr_id=@me_id";
            SqlParameter idparam = new SqlParameter("@userId", userId);
            menuListCommand.Parameters.Add(idparam);
            SqlParameter menuparam = new SqlParameter("@me_id", menuItemId);
            menuListCommand.Parameters.Add(menuparam);
            menuListCommand.Connection = sqlConnection;
            sqlConnection.Open();
            menuListCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
