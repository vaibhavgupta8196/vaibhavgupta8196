using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace TruYumComsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAdminFunctions();
            TestCustomerFunctions();

        }

        private static void TestAdminFunctions()
        {
            Console.WriteLine("Menu list Admin");
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            List<MenuItem> items = menuItemDaoCollection.GetMenuItemListAdmin();
            Console.WriteLine("MenuItem list Admin - details");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Modify the first itemin the Admin list &get the data");
            items = menuItemDaoCollection.GetMenuItemListAdmin();
            MenuItem itemToModify = new MenuItem();
            itemToModify = items[0];
            itemToModify.Price = 100;
            menuItemDaoCollection.ModifyMenuItem(itemToModify);
            itemToModify = menuItemDaoCollection.GetMenuItem(items[0].Id);
            Console.WriteLine(itemToModify);
            Console.ReadKey();
        }
        private static void TestCustomerFunctions()
        {
            MenuItemDaoCollection productDaoCollection = new MenuItemDaoCollection();
            CartDaoCollection cartDaoCollection = new CartDaoCollection();
            Cart usercart;
            List<MenuItem> items;
            Console.WriteLine("Menuitem list Customer - item names");
            items = productDaoCollection.GetMenuItemListCustomer();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);

            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Get all cart item - Check for empty exception");
            try
            {
                usercart = cartDaoCollection.GetAllCartItems(1);
            }
            catch (CartEmptyException cartEmptyException)
            {
                Console.WriteLine(cartEmptyException.Message);
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Add item to cart & get all cart item");
            try
            {
                cartDaoCollection.AddCartItem(1, 102);
                usercart = cartDaoCollection.GetAllCartItems(1);
                items = usercart.MenuItemList;
                Console.WriteLine("\r\n");
                Console.WriteLine("Item(s) in user cart");
                for (int i = 0; i < items.Count; i++)
                {

                    Console.WriteLine(items[i]);
                }
            }
            catch (CartEmptyException cartEmptyException)
            {
                Console.WriteLine(cartEmptyException.Message);
            
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Remove item from cart &Get all cart item");

            try
            {
                cartDaoCollection.RemoveCartItem(1, 102);
                usercart = cartDaoCollection.GetAllCartItems(1);

            }
            catch (CartEmptyException cartEmptyException)
            {
                Console.WriteLine(cartEmptyException.Message);
            }
            Console.ReadKey();
        }
    }
}
