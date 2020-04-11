using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cart
    {
        #region Instance Variable
        private List<MenuItem> menuItemList;
        private double total;
        #endregion



        #region Constructor
        public Cart()
        { }

        public Cart(List<MenuItem> menuItem, double total)
        {
            this.MenuItemList = menuItem;
            this.Total = total;
        }
        #endregion

        #region properties

        public List<MenuItem> MenuItemList
        { get => menuItemList; set => menuItemList = value; }
        public double Total
        { get => total; set => total = value; }

        public override string ToString()
        {
            string itemNames = string.Empty;
            foreach (MenuItem item in MenuItemList)
            {
                itemNames += item.Name + ",";
            }
            return "Cart [ MenuList= " + itemNames + ", total= " + total + " ]";
           
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (this == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Cart other = (Cart)obj;
            if (MenuItemList == null)
            {
                if (other.MenuItemList != null)
                    return false;
            }
            else if (!MenuItemList.Equals(other.MenuItemList))
                return false;
            if (total != other.total)
                return false;
            return true;
              
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
