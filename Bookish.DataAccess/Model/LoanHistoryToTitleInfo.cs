﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.DataAccess
{
    public class LoanHistoryToTitleInfo
    {
        public LoanHistoryInfo LoanHistory { get; set; }
        public TitleInfo Title { get; set; }
    }
}
