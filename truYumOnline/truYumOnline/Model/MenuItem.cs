using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class MenuItem
    {
        #region Instance Variable
        private long id;
        private string name;
        private float price;
        private Boolean active;
        private DateTime dateOfLaunch;
        private string category;
        private Boolean freeDelivery;
        #endregion

        #region Constructor
        public MenuItem()
        { }
        public MenuItem(long id, string name, float price, bool active, DateTime dateOfLaunch, string category, Boolean freeDelivery)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Active = active;
            this.DateOfLaunch = dateOfLaunch;
            this.Category = category;
            this.FreeDelivery = freeDelivery;
        }

        #endregion

        #region properties
        public long Id 
        { get => id; set => id = value; }
        public string Name 
        { get => name; set => name = value; }
        public float Price 
        { get => price; set => price = value; }
        public bool Active 
        { get => active; set => active = value; }
        public DateTime DateOfLaunch 
        { get => dateOfLaunch; set => dateOfLaunch = value; }
        public string Category 
        { get => category; set => category = value; }
        public bool FreeDelivery
        { get => freeDelivery; set => freeDelivery = value; }

        
        public override string ToString()
        {
            return "MenuItem [id= "+id+", name= "+name+ ", Price= "+price+", active= "+active+", date of launch= "+dateOfLaunch+", category= "+category+", free delivery= "+freeDelivery+" ]"; 
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (this == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            MenuItem other = (MenuItem)obj;
            if (id != other.id)
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
