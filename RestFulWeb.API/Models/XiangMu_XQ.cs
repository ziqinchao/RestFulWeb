using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestFulWeb.API.Models
{
    public class XiangMu_XQ
    {
        public class ParaGetXMDetail
        {
            public string XMNumber;
        }
        public class ResultXMDetail
        {
            public string RowGuid;
            public string XMNumber;
            public string Sbdw;
        }
    }
}