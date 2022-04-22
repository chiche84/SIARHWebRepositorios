using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Common.Application
{
    public class Paged
    {
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public Paged()
        {
            PageNumber = 1;
            PageSize = 10;
        }

    }
}
