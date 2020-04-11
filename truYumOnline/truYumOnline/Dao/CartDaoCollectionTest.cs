using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class CartDaoCollectionTest
    {
        public static void Main(string[] args)
        {
            TestAddCartItem();
            Console.WriteLine("__________________________________________________");
            TestRemoveCartItem();

        }
        static void TestAddCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1, 102);
            cartDao.AddCartItem(1, 101);
            try
            {
                Cart myCart = cartDao.GetAllCartItems(1);
                Console.WriteLine(myCart);
            }
            catch(CartEmptyException ce)
            {
                Console.WriteLine(ce.Message);
            }

        }

        static void TestRemoveCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            try
            {
                Console.WriteLine("Removing items from cart");
                cartDao.RemoveCartItem(1, 102);
                Cart mycart = cartDao.GetAllCartItems(1);
                Console.WriteLine("Aftre removing 1st item from cart");
                Console.WriteLine(mycart);
                Console.WriteLine("After removing 2nd item from cart");
                cartDao.RemoveCartItem(1, 101);
                
                mycart = cartDao.GetAllCartItems(1);
                Console.WriteLine(mycart);
            }
            catch (CartEmptyException ce)
            {
                Console.WriteLine(ce.Message);
            }
        }
    }
}
