using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    class CartDaoSqlTest
    {
        static void Main(string[] args)
        {
            //TestAddToCart();
            TestGetAllCartItem();
            //TestRemoveALLCart();
            Console.ReadLine();
        }
        static void TestAddToCart()
        {
            CartDaoSql test = new CartDaoSql();
            test.AddCartItem(1, 1);
            test.AddCartItem(1, 2);
            test.AddCartItem(1, 3);
            Console.WriteLine("successfully added");

        }
        static void TestGetAllCartItem()
        {
            CartDaoSql test = new CartDaoSql();
            
            var cart=test.GetAllCartItems(1);
            foreach (MenuItem item in cart.MenuItemList)
            {
                Console.WriteLine(item);
            }
        }
        static void TestRemoveALLCart()
        {
            CartDaoSql testDao = new CartDaoSql();
            testDao.RemoveCartItem(1, 3);
            Console.WriteLine("successfully deleted");
        }
    }
    
}
