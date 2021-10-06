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

        // lấy tất cả userRelationship
        public List<UserRelationship> BLL_getUserRelationship()
        {
            return DAL_UserRelationship.instance.DAL_getUserRelationship();
        }
        // lấy message
        public List<Message> BLL_getMessage()
        {
            return DAL_UserRelationship.instance.DAL_getMessage();
        }

        // lấy id_rel lớn nhất 
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

        // lấy id_mes lớn nhất 
        public string BLL_getIdMesMax()
        {
            int max = 0;
            foreach(Message m in DAL_UserRelationship.instance.DAL_getMessage())
            {
                if (Convert.ToInt32(m.id_mes) > max)
                {
                    max = Convert.ToInt32(m.id_mes);
                }
            }
            return max.ToString();
        }

        // add userRelation
        public void BLL_addUserRelationship(string id_rel, string userId, string userId_receive, string relation)
        {
            DAL_UserRelationship.instance.DAL_addUserRelationship(id_rel, userId, userId_receive, relation);
        }
        // add message
        public void BLL_addMessage(string id_mes, string id_rel, string content_mes, string date_send)
        {
            DAL_UserRelationship.instance.DAL_addMessage(id_mes, id_rel, content_mes, date_send);
        }

        // hàm kiểm tra cuộc nhắn tin đã tồn tại hay chưa 
        public string BLL_exits(string userId, string userId_receive)
        {
            string id_rel = "";
            int exits = 0;
            foreach (UserRelationship ur in DAL_UserRelationship.instance.DAL_getUserRelationship())
            {
                if (ur.userId == userId && ur.userId_receive == userId_receive)
                {
                    exits += 1;
                    id_rel = ur.id_rel;
                }
            }
            return id_rel; 
        }
        // hàm add userRelation hoặc message nếu userRelation đã tồn tại
        public void BLL_addUserOrMes(string id_rel, string id_mes, string userId, string userId_receive, string relation, string content_mes, string date_send)
        {  
            if(BLL_exits(userId, userId_receive) != "")
            {
                BLL_addMessage(id_mes, BLL_exits(userId, userId_receive), content_mes, date_send);
            }   
            else
            {
                BLL_addUserRelationship(id_rel, userId, userId_receive, relation);
                BLL_addMessage(id_mes,id_rel,content_mes, date_send);
            }                
        }

        // hàm load message for khung chat
        public List<Message> BLL_loadMessageForChat(string userId, string userId_receive)
        {
            List<Message> listMes = new List<Message>();
            foreach(UserRelationship ur in BLL_getUserRelationship())
            {
                if((ur.userId == userId && ur.userId_receive == userId_receive) || (ur.userId == userId_receive && ur.userId_receive == userId))
                {
                    foreach(Message m in BLL_getMessage())
                    {
                        if(ur.id_rel == m.id_rel)
                        {
                            listMes.Add(m);
                        }    
                    }    
                }    
            }    
            return listMes;
        }

    }
}
