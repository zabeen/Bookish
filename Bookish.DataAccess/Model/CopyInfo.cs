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
        public int Title_copy_id { get; set; }
        public TitleInfo Title { get; set; }
        public DateTime Entered_date { get; set; }
        public UserInfo Entered_by { get; set; }
        public DateTime Disposed_date { get; set; }
        public UserInfo Disposed_by { get; set; }
        public bool Is_available { get; set; }
 
    }
}
