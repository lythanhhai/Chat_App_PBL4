using PBL4_Chat.DAL;
using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.BLL
{
    class BLL_User
    {
        private static BLL_User _instance;

        public static BLL_User instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_User();
                }
                return _instance;
            }
            private set
            {

            }
        }

        public BLL_User()
        {

        }

        public List<User> BLL_getUser()
        {
            return DAL_User.instance.DAL_getUser();
        }

        public void BLL_addUser(string userId, string firstName, string lastName, string userName, string passWord, string email, string phone)
        {
            DAL_User.instance.DAL_addUser(userId,firstName,lastName,userName,passWord,email,phone);
        }

        public string getUserIdMax_BLL()
        {
            int Max = 0;
            List<User> list = new List<User>();
            list = DAL_User.instance.DAL_getUser();
            foreach(User u in list)
            {
                if(Convert.ToInt32(u.userId) > Max)
                {
                    Max = Convert.ToInt32(u.userId);
                }    
            }    
            return Max.ToString();
        }
    }
}
