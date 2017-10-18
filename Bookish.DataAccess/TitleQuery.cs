using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish.DataAccess.Model;
using System.Data;
using Dapper;

namespace Bookish.DataAccess
{
    public class TitleQuery : DbQuery
    {
        public TitleQuery(string connectionStr) : base(connectionStr) { }

        public List<TitleInfo> GetAllTitlesFromCatalogue()
        {
            List<TitleInfo> titleList = new List<TitleInfo>();

            using (IDbConnection db = CreateNewDbConnection())
            {
                string sql = "EXEC SelectAllTitlesFromCatalogue";
                var allTitles = db.Query<TitleInfo, UserInfo, TitleInfo>(sql, (title, user) => { title.Entered_by = user; return title; }, splitOn: "library_user_id");
                titleList = allTitles.ToList();
            }

            return titleList;
        }
    }
}
