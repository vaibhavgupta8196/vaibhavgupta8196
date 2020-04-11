using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dao
{
    public class CartDaoCollection : ICartDao
    {
        private static Dictionary<long, Cart> userCart;
        public CartDaoCollection()
        {
            if (userCart == null)
            {
                userCart = new Dictionary<long, Cart>();
            }
        }
        public void AddCartItem(long userId, long menuItemId)
        {

            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            MenuItem item = menuItemDao.GetMenuItem(menuItemId);
            if (userCart.ContainsKey(userId))
                userCart[userId].MenuItemList.Add(item);
            else
            {
                Cart cart = new Cart();
                List<MenuItem> menuItemList = new List<MenuItem>();
                menuItemList.Add(item);
                cart.MenuItemList = menuItemList;
                userCart.Add(userId, cart);
            }
               


    }

        public Cart GetAllCartItems(long userId)
        {
            Cart cart ;
            bool success = userCart.TryGetValue(userId, out cart);
            if (cart == null || cart.MenuItemList.Count == 0)
            {
                throw new CartEmptyException();
            }
            if (success)
            {
                List<MenuItem> menuList = cart.MenuItemList;
                float totalPrice = 0;
                foreach (MenuItem item in menuList)
                {
                    totalPrice += item.Price;
                }
                cart.Total = totalPrice;
            }
            return cart;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            Cart cart;
            bool success = userCart.TryGetValue(userId, out cart);
            if (cart == null || cart.MenuItemList.Count == 0)
            {
                throw new CartEmptyException();
            }
            if (success)
            {
                List<MenuItem> menuList = userCart[userId].MenuItemList;
                for (int i = 0; i < menuList.Count; i++)
                {
                    if (menuList[i].Id == menuItemId)
                    {
                        menuList.RemoveAll(list => list.Id == menuItemId);
                    }

                }
            }


        }
            
    }
}
