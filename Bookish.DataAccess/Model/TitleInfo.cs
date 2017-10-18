using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class TitleInfo
    {
        // Info on an individual title within the library catalogue, from dbo.catalogue
        public int CatalogueId { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string ISBN { get; set; }
        public int LoanPeriodInDays { get; set; }
        public DateTime AddedToLibraryOn { get; set; }
        public UserInfo AddedToLibraryBy { get; set; }
    }
}
