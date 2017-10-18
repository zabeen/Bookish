using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess.Model
{
    public class CopyInfo
    {
        // from dbo.title_copy
        public int TitleCopyId { get; set; }
        public TitleInfo Title { get; set; }
        public DateTime AddedToLibraryOn { get; set; }
        public UserInfo AddedToLibraryBy { get; set; }
        public DateTime RemovedFromLibraryOn { get; set; }
        public UserInfo RemovedFromLibraryBy { get; set; }
        public bool IsAvailableForLoan { get; set; }

    }
}
