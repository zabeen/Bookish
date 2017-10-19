using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Bookish.DataAccess
{
    public class LoanHistoryQuery : DbQuery
    {
        public LoanHistoryQuery(string connectionStr) : base(connectionStr) { }

        public List<LoanHistoryToTitleInfo> SelectLoanHistoryByLibraryUserId(int libraryUserId)
        {
            List<LoanHistoryToTitleInfo> resultsList = new List<LoanHistoryToTitleInfo>();

            using (IDbConnection db = CreateNewDbConnection())
            {
                string sql = $"EXEC SelectUserLoanHistoryByLibraryUserId {libraryUserId}";
                var data = db.Query<LoanHistoryInfo, TitleInfo, LoanHistoryToTitleInfo>(
                    sql, 
                    (loanHistory, title) => { return new LoanHistoryToTitleInfo() { LoanHistory = loanHistory, Title = title }; }, 
                    splitOn: "catalogue_id");
                resultsList = data.ToList();
            }

            return resultsList;
        }

    }
}
