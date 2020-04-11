using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    class MenuItemDaoCollectionTest
    {
        public static void Main(String[] args)
        {
            TestGetMenuItemListAdmin();
            Console.WriteLine("*************************************************");
            TestGetMenuItemListCustomer();
            Console.WriteLine("*************************************************");
            TestModifyMenuItem();
           // TestGetMenuItemListAdmin();
        }

        static void TestGetMenuItemListAdmin()
        {
            MenuItemDaoCollection menuItem = new MenuItemDaoCollection();
            List<MenuItem> mylist = menuItem.GetMenuItemListAdmin();
            foreach (MenuItem item in mylist)
            Console.WriteLine(item);
    
        }

        static void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection menuItem = new MenuItemDaoCollection();
            List<MenuItem> mylist = menuItem.GetMenuItemListCustomer();
            foreach (MenuItem item in mylist)
                Console.WriteLine(item);
        }
        static void TestModifyMenuItem()
        {
            MenuItem newMenu = new MenuItem(102, "Coke", 46.00f, true, Utility.ConvertToDate("12/06/2019"), "Drinks", false);
            MenuItemDaoCollection menuItem = new MenuItemDaoCollection();
            menuItem.ModifyMenuItem(newMenu);
            MenuItem modifiedMenuItem = menuItem.GetMenuItem(102);
            Console.WriteLine(modifiedMenuItem);
        }
    }
}
