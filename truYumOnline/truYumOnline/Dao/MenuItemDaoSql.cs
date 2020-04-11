using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.CodeDom;

namespace Dao
{
    class MenuItemDaoSql : IMenuItemDao
    {
        public MenuItem GetMenuItem(long menuItemId)
        {
            List<MenuItem> menuList = new List<MenuItem>();
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand menuListCommand = new SqlCommand();
            menuListCommand.CommandText = "select me_id,me_name,me_price,me_active,me_date_of_launch,me_category,me_free_delivery from menu_item where me_id=@menuItemid";
            SqlParameter idparam = new SqlParameter("@menuItemid", menuItemId);
            menuListCommand.Parameters.Add(idparam);
            menuListCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader menuListReader = menuListCommand.ExecuteReader();
            while (menuListReader.Read())
            {

                menuList.Add(new MenuItem(

                    long.Parse(menuListReader["me_id"].ToString()),
                    menuListReader["me_name"].ToString(),
                    float.Parse(menuListReader["me_price"].ToString()),
                    menuListReader["me_active"].ToString() == "yes",
                    DateTime.Parse(menuListReader["me_date_of_launch"].ToString()),
                    menuListReader["me_category"].ToString(),
                    menuListReader["me_free_delivery"].ToString() == "yes")
                    );
            }
            return menuList.First();
            //throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            List<MenuItem> menuList = new List<MenuItem>();
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand menuListCommand = new SqlCommand();
            menuListCommand.CommandText = "select me_id,me_name,me_price,me_active,me_date_of_launch,me_category,me_free_delivery from menu_item";
            menuListCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader menuListReader = menuListCommand.ExecuteReader();
            while (menuListReader.Read())
            {
                menuList.Add(new MenuItem(long.Parse(menuListReader["me_id"].ToString()),
                    menuListReader["me_name"].ToString(),
                    float.Parse(menuListReader["me_price"].ToString()),
                    bool.Parse(menuListReader["me_active"].ToString() == "yes" ? "true" : "false"),
                    DateTime.Parse(menuListReader["me_date_of_launch"].ToString()),
                    menuListReader["me_category"].ToString(),
                    bool.Parse(menuListReader["me_free_delivery"].ToString() == "yes" ? "true" : "false")));

            }
            return menuList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> menuList = new List<MenuItem>();
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand menuListCommand = new SqlCommand();
            menuListCommand.CommandText = "select me_id,me_name,me_price,me_active,me_date_of_launch,me_category,me_free_delivery from menu_item where me_date_of_launch < getdate() and me_active='yes'";
            menuListCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader menuListReader = menuListCommand.ExecuteReader();
            while (menuListReader.Read())
            {
                menuList.Add(new MenuItem(long.Parse(menuListReader["me_id"].ToString()),
                    menuListReader["me_name"].ToString(),
                    float.Parse(menuListReader["me_price"].ToString()),
                    bool.Parse(menuListReader["me_active"].ToString() == "yes" ? "true" : "false"),
                    DateTime.Parse(menuListReader["me_date_of_launch"].ToString()),
                    menuListReader["me_category"].ToString(),
                    bool.Parse(menuListReader["me_free_delivery"].ToString() == "yes" ? "true" : "false")));

            }
            return menuList;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            List<MenuItem> menuList = new List<MenuItem>();
            SqlConnection sqlConnection = new SqlConnection(Utility.GetconnectionString("truYum"));
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "update menu_item set me_name=@me_name,me_price=@me_price,me_active=@me_active,me_date_of_launch =@me_date_of_launch,me_category =@me_category,me_free_delivery =@me_free_delivery where me_id = @me_id";
            updateCommand.Connection = sqlConnection;
            SqlParameter[] updateParam = new SqlParameter[7];
            updateParam[0] = new SqlParameter("@me_name", menuItem.Name);
            updateParam[1] = new SqlParameter("@me_price", menuItem.Price);
            updateParam[2] = new SqlParameter("@me_active", menuItem.Active==true? "yes" : "no");
            updateParam[3] = new SqlParameter("@me_date_of_launch", menuItem.DateOfLaunch);
            updateParam[4] = new SqlParameter("@me_category", menuItem.Category);
            updateParam[5] = new SqlParameter("@me_Free_delivery", menuItem.FreeDelivery==true? "yes":"no");
            updateParam[6] = new SqlParameter("@me_id", menuItem.Id);
            updateCommand.Parameters.AddRange(updateParam);
            sqlConnection.Open();
            updateCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
