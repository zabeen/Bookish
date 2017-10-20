using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;
using Bookish.Web.Models;
using Bookish.Web.Helpers;
using Bookish.Web.ViewModels;

namespace Bookish.Web.Controllers
{
    [Authorize]
    public class LoansController : Controller
    {
        // GET: Loans
        public ActionResult Index(LoansSelection selection)
        {
            //todo: want grab user ID based on who is logged in, not via get

            var info = new List<LoansViewModel>();
            ViewBag.Message = "Here is your loan history: the titles you have checked out, and when they are due back.";

            // if no user ID provided then return view immediately
            if (selection.UserId == null)
                return View(info);

            // retrieve loan history from db
            LoansQuery query = new LoansQuery();
            List<LoanHistoryToTitleInfo> results = new List<LoanHistoryToTitleInfo>();
            try
            {
                results = query.GetLoanHistoryForUser(int.Parse(selection.UserId));
            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "Oops!!";
                //todo: test error handling & improve error message generation
            }
         
            // iterate over results in descending order of due date, and prepare data for view
            foreach (LoanHistoryToTitleInfo result in results.OrderByDescending(r => r.LoanHistory.Dueback_date).ToList())
            {
                LoansViewModel row = new LoansViewModel()
                {
                    TitleName = result.Title.Title_name,
                    TitleVersion = result.Title.Title_version,
                    CheckedOutDate = result.LoanHistory.Onloan_date,
                    DueBackDate = result.LoanHistory.Dueback_date
                };

                // collate loan status dates
                List<LoanStatus> statuses = new List<LoanStatus>()
                {
                    new LoanStatus() {Type = LoanStatus.StatusType.OnLoan.ToString(), Date = result.LoanHistory.Onloan_date },
                    new LoanStatus() {Type = LoanStatus.StatusType.Missing.ToString(), Date = result.LoanHistory.Missing_date },
                    new LoanStatus() {Type = LoanStatus.StatusType.Reserved.ToString(), Date = result.LoanHistory.Reserved_date },
                    new LoanStatus() {Type = LoanStatus.StatusType.Recalled.ToString(), Date = result.LoanHistory.Recalled_date },
                    new LoanStatus() {Type = LoanStatus.StatusType.Returned.ToString(), Date = result.LoanHistory.Returned_date }
                };

                // Set current status to that with highest date
                row.CurrentStatus = statuses.OrderByDescending(s => s.Date).First();

                info.Add(row);
            }            

            return View(info);
        }
    }
}