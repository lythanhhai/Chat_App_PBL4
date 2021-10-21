using PBL4_Chat.DAL;
using PBL4_Chat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.BLL
{
    class BLL_Group
    {
        private static BLL_Group _instance;

        public static BLL_Group instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_Group();
                }
                return _instance;
            }
            private set
            {

            }
        }
        public BLL_Group()
        {

        }

        // hàm lấy danh sách group
        public List<Group> BLL_getAllGroup()
        {
            return DAL_Group.instance.DAL_getAllGroup();
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
        public void BLL_addGroup(string id_group, string name_group, string userId, string date_create, string des)
        {
            DAL_Group.instance.DAL_addGroup(id_group, name_group, userId, date_create, des);
        }

        // add message_group
        public void BLL_addMessageGroup(string id_mesGroup, string id_sender, string id_group, string content_group, string date_sendGroup)
        {
            DAL_Group.instance.DAL_addMessageGroup(id_mesGroup, id_sender, id_group, content_group, date_sendGroup);
        }

        // add user_group
        public void BLL_addUserGroup(string id_userGroup, string id_member, string id_group, string date_join)
        {
            DAL_Group.instance.DAL_addUserGroup(id_userGroup, id_member, id_group, date_join);
        }

        public string BLL_getMaxIdGroup()
        {
            int max = 1;
            foreach(Group g in BLL_getAllGroup())
            {
                if(Convert.ToInt32(g.id_group) > max)
                {
                    max = Convert.ToInt32(g.id_group);
                }    
            }
            return Convert.ToString(max);
        }
    }
}
