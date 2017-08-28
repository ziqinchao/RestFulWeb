using RestFulWeb.API.Models;
using RestFulWeb.BLL;
using RestFulWeb.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RestFulWeb.API.Controllers
{
    public class XiangMu_XQController : Controller
    {
        // GET: XiangMu_XQ
        BLL_AUDIT_XIANGMU bLL = new BLL_AUDIT_XIANGMU();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetXMDetail()
        {
            //1.验证功能
            string jsonData = GetParas();
            CommonResult result = new CommonResult();
            CommonParameters<XiangMu_XQ.ParaGetXMDetail> P_XMDetial = RestFulWeb.API.Models.Common.DeserializeParam<XiangMu_XQ.ParaGetXMDetail>(jsonData);
            try
            {
                if (!Common.CheckValidate(P_XMDetial.ValidateData))
                {
                    result.SetBusinessFail("您没有调用的权限");
                    return Content(Common.SerializeResult<XiangMu_XQ.ParaGetXMDetail>(null, result), "application/json");
                }
                //2.请求数据源，拼接数据
                XiangMu_XQ.ResultXMDetail UserArea = new XiangMu_XQ.ResultXMDetail();
                DataView dv = new DataView();
                string XMNumber = Convert.ToString(P_XMDetial.Paras.XMNumber);
                dv = bLL.GetXMDetial(XMNumber);
                foreach (DataRow dr in dv.ToTable().Rows)
                {
                    UserArea.RowGuid = Convert.ToString(dr["RowGuid"]);
                    UserArea.XMNumber= Convert.ToString(dr["XMNumber"]);
                    UserArea.Sbdw= Convert.ToString(dr["Sbdw"]);
                }
                return Content(Common.SerializeResult<XiangMu_XQ.ResultXMDetail>(UserArea, result), "application/json");
            }
            catch (Exception ex)
            {
                result.SetBusinessFail("代码错误");
                return Content(Common.SerializeResult<XiangMu_XQ.ResultXMDetail>(null, result), "application/json");

            }

            //return View();
        }

        public string GetParas()
        {
            StreamReader sr = new StreamReader(System.Web.HttpContext.Current.Request.InputStream, Encoding.UTF8);
            return sr.ReadToEnd();
        }
    }
}