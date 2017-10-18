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
        public int UserLoanHistoryId { get; set; }
        public UserInfo User { get; set; }
        public CopyInfo Copy { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime StatusChangedDate { get; set; }
    }
}
