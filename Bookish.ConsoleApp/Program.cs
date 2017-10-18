using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish.DataAccess;
using Bookish.DataAccess.Model;
using System.Configuration;

namespace Bookish.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleQuery tQuery = new TitleQuery(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            List<TitleInfo> titles = tQuery.GetAllTitlesFromCatalogue();

            foreach(TitleInfo title in titles)
            {
                Console.WriteLine("Title: {0}, ISBN: {1}", title.Title_name, title.ISBN);
            }

            Console.ReadLine();
        }
    }
}
