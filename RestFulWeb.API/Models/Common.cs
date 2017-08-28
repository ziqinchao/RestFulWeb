using Newtonsoft.Json;
using RestFulWeb.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestFulWeb.API.Models
{
    public class Common
    {
        public static CommonParameters<T> DeserializeParam<T>(string inputStr)
        {
            var value = Newtonsoft.Json.JsonConvert.DeserializeObject<CommonParameters<T>>(inputStr);
            return value;
        }

        public static string SerializeResult<T>(T UserArea, CommonResult result)
        {
            CommonResult<T> common = new CommonResult<T>();
            common.BusinessInfo.Code = result.BusinessInfo.Code;
            common.ReturnInfo.Code = result.ReturnInfo.Code;
            common.BusinessInfo.Description = result.BusinessInfo.Description;
            common.ReturnInfo.Description = result.ReturnInfo.Description;
            if (common.BusinessInfo.Code == "1" && common.ReturnInfo.Code == "1")
            {
                common.UserArea = UserArea;
            }
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Include,
                DateTimeZoneHandling = DateTimeZoneHandling.Local,
                ContractResolver = new RestFulWeb.BLL.Substitute()
            };
            return Newtonsoft.Json.JsonConvert.SerializeObject(common, Formatting.Indented,jsonSerializerSettings);
        }
        public static bool CheckValidate(string str)
        {
            return true;
        }
        
    }
}