using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWeb.MODELS
{
    public class CommonResult<T>
    {
        public CommonResultCodeDesc ReturnInfo = new CommonResultCodeDesc();
        public CommonResultCodeDesc BusinessInfo = new CommonResultCodeDesc();
        public T UserArea
        {
            get;
            set;
        }
    }
}
