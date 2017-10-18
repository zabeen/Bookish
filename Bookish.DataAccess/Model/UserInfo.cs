using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class UserInfo
    {
        // Info on individual library user, from dbo.library_user
        public int LibraryUserId { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
