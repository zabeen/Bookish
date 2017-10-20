using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess
{
    public class LoanHistoryInfo
    {
        // Info on the loan history of an individual title copy
        public int User_loan_history_id { get; set; }
        public UserInfo User { get; set; }
        public CopyInfo Copy { get; set; }
        public DateTime Onloan_date { get; set; }
        public DateTime Dueback_date { get; set; }
        public DateTime Missing_date { get; set; }
        public DateTime Reserved_date { get; set; }
        public DateTime Recalled_date { get; set; }
        public DateTime Returned_date { get; set; }
    }
}
