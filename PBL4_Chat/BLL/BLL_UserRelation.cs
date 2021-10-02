using PBL4_Chat.DAL;
using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.BLL
{
    class BLL_UserRelation
    {
        private static BLL_UserRelation _instance;

        public static BLL_UserRelation instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_UserRelation();
                }
                return _instance;
            }
            private set
            {

            }
        }

        public BLL_UserRelation()
        {

        }

        public List<UserRelationship> BLL_getUserRelationship()
        {
            return DAL_UserRelationship.instance.DAL_getUserRelationship();
        }

        public string BLL_getIdRelMax()
        {
            int max = 0;
            foreach(UserRelationship u in DAL_UserRelationship.instance.DAL_getUserRelationship())
            {
                if(Convert.ToInt32(u.id_rel) > max)
                {
                    max = Convert.ToInt32(u.id_rel);
                }    
            }    
            return max.ToString();
        }

        public void BLL_addUserRelationship(string id_rel, string id_mes, string userId, string userId_receive, string relation)
        {
            DAL_UserRelationship.instance.DAL_addUserRelationship(id_rel, id_mes, userId, userId_receive, relation);
        }

        public void BLL_addMessage(string id_mes, string id_rel, string content_mes, string date_send)
        {
            DAL_UserRelationship.instance.DAL_addMessage(id_mes, id_rel, content_mes, date_send);
        }
    }
}
