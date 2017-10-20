using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookish.DataAccess;
using System.Configuration;

namespace Bookish.Web.Helpers
{
    public class BookishDbQuery
    {
        //todo: learn how to set conn strings to easily swap between dev, uat & live instances
        public string ConnectionStr = ConfigurationManager.ConnectionStrings["BookishDbConnection"].ConnectionString;

    }
}