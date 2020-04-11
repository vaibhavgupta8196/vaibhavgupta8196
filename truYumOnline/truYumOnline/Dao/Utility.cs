using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Dao
{
    public static class Utility
    {
        public static DateTime ConvertToDate(string dateInput)
        {
            DateTime dateOfLaunch = default(DateTime);
            try
            {
                dateOfLaunch = DateTime.ParseExact(DateTime.Parse(dateInput).
                    ToString("MM/dd/yyyy"),"MM/dd/yyyy", null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dateOfLaunch;
        }
        public static string GetconnectionString(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
