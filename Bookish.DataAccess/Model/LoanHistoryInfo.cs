using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class LoanHistoryInfo
    {
        // Info on the loan history of an individual title copy
        public int User_loan_history_id { get; set; }
        public UserInfo User { get; set; }
        public CopyInfo Copy { get; set; }
        public string Current_status { get; set; }
        public DateTime Status_changed_date { get; set; }
    }
}
