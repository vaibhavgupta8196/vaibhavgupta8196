using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    class MenuItemDaoSqlTest
    {
        static void Main(String[] args)
        {
            Console.WriteLine("**************************");
            TestGetMenuItemListAdmin();
            Console.WriteLine("**************************");
            
            TestGetMenuItemListCustomer();
            Console.WriteLine("**************************");
            TestModifyMenuItemList();
            Console.ReadLine();
        }
        static void TestModifyMenuItemList()
        {
            MenuItem newMenu = new MenuItem(4, "Sandwich", 1234, false, Utility.ConvertToDate("12/12/2020"), "Drinks", true);
            MenuItemDaoSql menuItem = new MenuItemDaoSql();
            menuItem.ModifyMenuItem(newMenu);
            Console.WriteLine("success modify");
            MenuItem modifiedMenuItem = menuItem.GetMenuItem(4);
            Console.WriteLine(modifiedMenuItem);

            
        }
        static void TestGetMenuItemListAdmin()
        {
            MenuItemDaoSql menuItem = new MenuItemDaoSql();
            List<MenuItem> mylist = menuItem.GetMenuItemListAdmin();
            foreach (MenuItem item in mylist)
            {
                Console.WriteLine(item);
            }

        }
        static void TestGetMenuItemListCustomer()
        {
            MenuItemDaoSql menuItem = new MenuItemDaoSql();
            List<MenuItem> mylist = menuItem.GetMenuItemListCustomer();
            foreach (MenuItem item in mylist)
            {
                Console.WriteLine(item);
            }
        }

    }
}
