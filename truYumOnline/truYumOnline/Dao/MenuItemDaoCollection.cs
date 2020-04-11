using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class MenuItemDaoCollection : IMenuItemDao
    {

        private List<MenuItem> menuItemList;
        public MenuItemDaoCollection()
        {
            if (menuItemList == null)
            {
                menuItemList = new List<MenuItem>();
                menuItemList.Add(new MenuItem(101, "Sandwich", 99.00f, true, Utility.ConvertToDate("15/03/2017"), "Main Course", true));
                menuItemList.Add(new MenuItem(102, "Burger", 129.00f, true, Utility.ConvertToDate("23/12/2017"), "Main Course", false));
                menuItemList.Add(new MenuItem(103, "Pizza", 149.00f, true, Utility.ConvertToDate("21/08/2018"), "Main Course", false));
                menuItemList.Add(new MenuItem(104, "French Fries", 57.00f, false, Utility.ConvertToDate("02/07/2017"), "Starters", true));
                menuItemList.Add(new MenuItem(105, "Choclate Brownie", 32.00f, true, Utility.ConvertToDate("20/11/2022"), "Dessert", true));
            }
        }
        public MenuItem GetMenuItem(long menuItemId)
        {
            foreach(MenuItem item in menuItemList)
            {
                if(item.Id==menuItemId)
                {
                    return item;
                }
              
            }
              return null;
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> customerlist = new List<MenuItem>();
            foreach (MenuItem item in menuItemList)
            {
                if (item.DateOfLaunch < DateTime.Now && item.Active)
                    customerlist.Add(item);
            }
            return customerlist;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            for (int i = 0; i < menuItemList.Count; i++)
            {
                if (menuItemList[i].Id == menuItem.Id)
                    menuItemList[i] = menuItem;
            }
        }
    }
}
