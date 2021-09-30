using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
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
            foreach(User u in DBHelper.Instance.executeNonQuery("select * from User").Rows)
            {
                user.Add(new User { 
                    userId = u.userId,
                    firstName = u.firstName,
                    lastName = u.lastName,
                    userName = u.userName,
                    passWord = u.passWord,
                    email = u.email,
                    phone = u.phone
                });
            }    
            return user;
        }

        public void DAL_addUser(string userId, string firstName, string lastName, string userName, string passWord, string email, string phone)
        {
            string query = "Insert into User values("
                + userId + ","
                + firstName + ","
                + lastName + ","
                + userName + ","
                + passWord + ","
                + email + ","
                + phone + ")";
            DBHelper.Instance.executeQuery(query);
        }
    }
}
