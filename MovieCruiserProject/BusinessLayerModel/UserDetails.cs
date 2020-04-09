using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerModel
{
    [Serializable]
    public class UserDetails
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private int mobileNumber;
        private string emailId;
        private string jobType;

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public string JobType { get => jobType; set => jobType = value; }

        public UserDetails()
        { 
        }

        public UserDetails(int userId, string firstName, string lastName, string userName, string password, int mobileNumber, string emailId, string jobType)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Password = password;
            this.MobileNumber = mobileNumber;
            this.EmailId = emailId;
            this.JobType = jobType;
        }
    }
}
