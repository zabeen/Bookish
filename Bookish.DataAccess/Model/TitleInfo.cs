using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class TitleInfo
    {
        // Info on an individual title within the library catalogue, from dbo.catalogue
        public int Catalogue_id { get; set; }
        public string Title_name { get; set; }
        public string Title_version { get; set; }
        public string ISBN { get; set; }
        public int Loan_period_in_days { get; set; }
        public DateTime Entered_date { get; set; }
        public UserInfo Entered_by { get; set; }
    }
}
