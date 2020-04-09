using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using DataLayer;

namespace BusinessLayerLogic
{
    
    public class UserDetailsBL
    {
        UserDetailsDL userdl;
        public void InsertEmployee(List<UserDetails> user)
        {
            userdl = new UserDetailsDL();
            userdl.InsertEmployee(user);
        }
        public int CheckUserName(string userName)
        {
            userdl = new UserDetailsDL();

            int i = userdl.CheckUserName(userName);
            return i;
        }
        public int CheckCredentials(string userName, string password)
        {
            userdl = new UserDetailsDL();
            int i = userdl.CheckCredentials(userName, password);
            return i;
        }
    }
}
