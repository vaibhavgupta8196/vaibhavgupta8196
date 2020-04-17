using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestBusinessLayer
{
    public class Login
    {
        public bool validate(string username, string password)
        {
            if (username == "raj" && password == "raj#123")
                return true;
            return false;
        }
    }
}
