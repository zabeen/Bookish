using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookish.DataAccess;
using Bookish.Web.Models;

namespace Bookish.Web.ViewModels
{
    public class LoansViewModel
    {
        public string TitleName { get; set; }
        public string TitleVersion { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public DateTime DueBackDate { get; set; }
        public LoanStatus CurrentStatus { get; set; }
    }
}