using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess
{
    public class UserInfo
    {
        // Info on individual library user, from dbo.library_user
        public int Library_user_id { get; set; }
        public string User_role { get; set; }
        public string Username { get; set; }
        public string First_name { get; set; }
        public string Surname { get; set; }
    }
}
