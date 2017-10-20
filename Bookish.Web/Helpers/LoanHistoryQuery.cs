using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookish.DataAccess;

namespace Bookish.Web.Helpers
{
    public class LoansQuery : BookishDbQuery
    {
        public List<LoanHistoryToTitleInfo> GetLoanHistoryForUser(int userId)
        {
            List<LoanHistoryToTitleInfo> results = new List<LoanHistoryToTitleInfo>();
            try
            {
                LoanHistoryQuery query = new LoanHistoryQuery(ConnectionStr);
                results = query.SelectLoanHistoryByLibraryUserId(userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return results;
        }

    }
}