using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish.DataAccess;
using System.Configuration;

namespace Bookish.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintData data = new PrintData(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            data.PrintLoanHistoryForUser(3);
            Console.ReadLine();
        }

    }
}
