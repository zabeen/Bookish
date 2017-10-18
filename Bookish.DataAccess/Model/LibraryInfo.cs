using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class LibraryInfo
    {
        // info on library catalogue
        public int TitlesTotalCount { get; set; }
        public int TitlesOnLoanCount { get; set; }
        public int AuthorsCount { get; set; }

        // info on library users
        public int UsersCount { get; set; }
    }
}
