using Bookish.DataAccess;
using System;
using System.Collections.Generic;

namespace Bookish.ConsoleApp
{
    public class PrintData
    {
        public string ConnectionStr { get; private set; }

        public PrintData(string connectionStr)
        {
            ConnectionStr = connectionStr;
        }

        public void PrintAllTitles()
        {
            TitleQuery query = new TitleQuery(ConnectionStr);
            List<TitleInfo> results = query.SelectAllTitlesFromCatalogue();

            foreach (TitleInfo result in results)
            {
                Console.WriteLine("Title: {0}, ISBN: {1}, Entered by: {2}", result.Title_name, result.ISBN, result.Entered_by.First_name);
            }
        }
        public void PrintLoanHistoryForUser(int userId)
        {
            LoanHistoryQuery query = new LoanHistoryQuery(ConnectionStr);
            List<LoanHistoryToTitleInfo> results = query.SelectLoanHistoryByLibraryUserId(userId);

            foreach (LoanHistoryToTitleInfo result in results)
            {
                Console.WriteLine($"Title: {result.Title.Title_name}, Checked Out On: {result.LoanHistory.Onloan_date}, Due Back On: {result.LoanHistory.Dueback_date}");
            }
        }


    }
}
