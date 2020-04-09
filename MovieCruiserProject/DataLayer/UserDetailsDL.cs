using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerModel;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class UserDetailsDL
    {
        public void InsertEmployee(List<UserDetails> emp)
        {
            UserDetails y = null;

            foreach (var i in emp)
            {
                y = i;
            }
            int userId = y.UserId;    //int.Parse(emp[0].ToString());
            string firstName = y.FirstName;  //emp[1].ToString();
            string lastName = y.LastName;      //emp[2].ToString();
            string userName = y.UserName;     //int.Parse(emp[3].ToString());
            string password = y.Password;// DateTime.Parse(emp[4].ToString());
            int mobileNumber = y.MobileNumber;  // int.Parse(emp[5].ToString());
            string emailId = y.EmailId; // int.Parse(emp[6].ToString());
            string jobType = y.JobType; // int.Parse(emp[7].ToString());

            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@userId", userId);
            Param[1] = new SqlParameter("@firstName", @firstName);
            Param[2] = new SqlParameter("@lastName",lastName);
            Param[3] = new SqlParameter("@userName",userName);
            Param[4] = new SqlParameter("@password",password);
            Param[5] = new SqlParameter("@mobileNumber",mobileNumber);
            Param[6] = new SqlParameter("@emailId",emailId);
            Param[7] = new SqlParameter("@jobType",jobType);
            SqlHelper.Insert("insert into UserDetails values (@userId, @firstName, @lastName, @userName, @password, @mobileNumber, @emailId, @jobType ", CommandType.Text, Param);

        }
        public int CheckUserName(string userName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@userName",userName);
            int i=SqlHelper.Check("select * from UserDetails where userName=@userName",CommandType.Text,param);
            return i;
        }
        public int CheckCredentials(string userName, string password)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userName", userName);
            param[1] = new SqlParameter("@password", password);
            int i = SqlHelper.Check("select * from UserDetails where userName=@userName and password=@password", CommandType.Text, param);
            return i;
        }
    }
}
