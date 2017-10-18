using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class AuthorInfo
    {
        // from dbo.author
        public int Author_id { get; set; }
        public string Prefix { get; set; }
        public string First_name { get; set; }
        public string Middle_names { get; set; }
        public string Surname { get; set; }
        public string Suffix { get; set; }
        public string Alias { get; set; }
    }
}
