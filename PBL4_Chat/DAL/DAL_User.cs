using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.DAL
{
    class DAL_User
    {
        private static DAL_User _instance;
        
        public static DAL_User instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAL_User();
                }
                return _instance;
            }
            private set
            {

            }
        }

        public DAL_User()
        {

        }

        public List<User> DAL_getUser()
        {
            List<User> user = new List<User>();
            foreach(DataRow u in DBHelper.Instance.executeNonQuery("select * from [User]").Rows)
            {
                user.Add(new User { 
                    userId = u["userId"].ToString(),
                    firstName = u["firstName"].ToString(),
                    lastName = u["lastName"].ToString(),
                    userName = u["userName"].ToString(),
                    passWord = u["passWord"].ToString(),
                    email = u["email"].ToString(),
                    phone = u["phone"].ToString()
                });
            }    
            return user;
        }

        public void DAL_addUser(string userId, string firstName, string lastName, string userName, string passWord, string email, string phone)
        {
            string query = "insert into [User] values (N'"
                + userId
                + "',N'"
                + firstName
                + "',N'"
                + lastName
                + "',N'"
                + userName
                + "',N'"
                + passWord
                + "',N'"
                + email
                + "',N'"
                + phone
                + "')";
            DBHelper.Instance.executeQuery(query);
        }
    }
}
