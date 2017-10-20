using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Web.Models
{
    public class LoanStatus
    {
        public enum StatusType
        {
            OnLoan,
            Missing,
            Reserved,
            Recalled,
            Returned
        }

        public string Type { get; set; }
        public DateTime Date { get; set; }
    }
}