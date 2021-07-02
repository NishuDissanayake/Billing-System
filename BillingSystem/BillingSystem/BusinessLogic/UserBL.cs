using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.BusinessLogic
{
    class UserBL
    {
        public int id { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string contact { get; set; }

        public string address { get; set; }

        public string gender { get; set; }

        public string usertype { get; set; }

        public DateTime addeddate { get; set; }

        public int addedby { get; set; }
    }
}
