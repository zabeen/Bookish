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
        public int AuthorId { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string Surname { get; set; }
        public string Suffix { get; set; }
        public string Alias { get; set; }
    }
}
