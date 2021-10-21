using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.DAL
{
    class DAL_Group
    {
        private DAL_Group _instance;
        
        public DAL_Group instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DAL_Group();
                }
                return _instance;
            }
            private set
            {

            }           
        }
        public DAL_Group()
        {

        }

        // hàm lấy danh sách group
        public List<Group> DAL_getAllGroup()
        {
            List<Group> group = new List<Group>();
            foreach(DataRow d in DBHelper.Instance.executeNonQuery("select * from Group").Rows)
            {
                group.Add(new Group
                {
                    id_group = d["id_group"].ToString(),
                    name_group = d["name_group"].ToString(),
                    userId = d["userId"].ToString(),
                    date_create = d["date_create"].ToString(),
                    des = d["des"].ToString(),
                });
            }
            return group;
        }
        //public List<Group> DAL_getAllGroup()
        //{
        //    List<Group> group = new List<Group>();
        //    foreach (DataRow d in DBHelper.Instance.executeNonQuery("select * from Group").Rows)
        //    {
        //        group.Add(new Group
        //        {
        //            id_group = d["id_group"].ToString(),
        //            name_group = d["name_group"].ToString(),
        //            userId = d["userId"].ToString(),
        //            date_create = d["date_create"].ToString(),
        //            des = d["des"].ToString(),
        //        });
        //    }
        //    return group;
        //}
        // add group
        public void DAL_addGroup(string id_group, string name_group, string userId, string date_create, string des)
        {
            string query = "insert into Group values (N'"
                + id_group
                + "',N'"
                + name_group
                + "',N'"
                + userId
                + "',N'"
                + date_create
                + "',N'"
                + des
                + ")";
            DBHelper.Instance.executeQuery(query);
        }

        // add message_group
        public void DAL_addMessageGroup(string id_mesGroup, string id_sender, string id_group, string content_group, string date_sendGroup)
        {
            string query = "insert into Message_group values (N'"
                + id_mesGroup
                + "',N'"
                + id_sender
                + "',N'"
                + id_group
                + "',N'"
                + content_group
                + "',N'"
                + date_sendGroup
                + ")";
            DBHelper.Instance.executeQuery(query);
        }

        // add user_group
        public void DAL_addUserGroup(string id_userGroup, string id_member, string id_group, string date_join)
        {
            string query = "insert into User_group values (N'"
                + id_userGroup
                + "',N'"
                + id_member
                + "',N'"
                + id_group
                + "',N'"
                + date_join
                + ")";
            DBHelper.Instance.executeQuery(query);
        }

    }
}
