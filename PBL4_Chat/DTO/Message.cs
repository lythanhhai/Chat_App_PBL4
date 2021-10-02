using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.DTO
{
    class Message
    {
        public string id_mes { get; set; }
        public string id_rel { get; set; }
        public string contentMes { get; set; }
        public string date_send { get; set; }
    }
}
