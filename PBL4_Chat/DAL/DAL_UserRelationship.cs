using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.DAL
{
    class DAL_UserRelationship
    {
        private static DAL_UserRelationship _instance;

        public static DAL_UserRelationship instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAL_UserRelationship();
                }
                return _instance;
            }
            private set
            {

            }
        }

        public DAL_UserRelationship()
        {

        }

        public List<UserRelationship> DAL_getUserRelationship()
        {
            List<UserRelationship> list = new List<UserRelationship>();
            foreach(DataRow u in DBHelper.Instance.executeNonQuery("select * from [User_relationship]").Rows)
            {
                list.Add(new UserRelationship
                {
                    id_rel = u["id_rel"].ToString(),
                    id_mes = u["id_mes"].ToString(),
                    userId = u["userId"].ToString(),
                    userId_receive = u["userId_receive"].ToString(),
                    relation = u["relation"].ToString(),
                });
            }
            return list;
        }

        public void DAL_addUserRelationship(string id_rel, string id_mes, string userId, string userId_receive, string relation)
        {
            string query = "insert into [User_relationship] values (N'"
                + id_rel
                + "',N'"
                + id_mes
                + "',N'"
                + userId
                + "',N'"
                + userId_receive
                + "',N'"
                + relation
                + "')";
            DBHelper.Instance.executeQuery(query);
        }


        public void DAL_addMessage(string id_mes, string id_rel, string content_mes, string date_send)
        {
            string query = "insert into [User_relationship] values (N'"
                + id_mes
                + "',N'"
                + id_rel
                + "',N'"
                + content_mes
                + "',N'"
                + date_send
                + "')";
            DBHelper.Instance.executeQuery(query);
        }
    }
}
