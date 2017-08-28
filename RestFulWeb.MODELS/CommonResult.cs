using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWeb.MODELS
{
    public class CommonResult
    {
        public CommonResultCodeDesc ReturnInfo = new CommonResultCodeDesc();
        public CommonResultCodeDesc BusinessInfo = new CommonResultCodeDesc();
        public CommonResult()
        {
            this.SetBusinessSuccess("");
            this.SetResultSuccess("");
        }

        public void SetResultSuccess(string desc)
        {
            this.ReturnInfo.Code = "1";
            this.ReturnInfo.Description = desc;
        }
        public void SetResultFail(string desc)
        {
            this.ReturnInfo.Code = "0";
            this.ReturnInfo.Description = desc;
        }

        public void SetBusinessSuccess(string desc)
        {
            this.BusinessInfo.Code = "1";
            this.BusinessInfo.Description = desc;
        }
        public void SetBusinessFail(string desc)
        {
            this.BusinessInfo.Code = "0";
            this.BusinessInfo.Description = desc;
        }
    }
}
