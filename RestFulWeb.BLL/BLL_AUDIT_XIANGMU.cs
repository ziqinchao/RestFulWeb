using RestFulWeb.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWeb.BLL
{
    public class BLL_AUDIT_XIANGMU
    {
        public DataView GetXMDetial(string XMNUMBER)
        {
            DAL_AUDIT_XAINGMU dAL_AUDIT_XAINGMU = new DAL_AUDIT_XAINGMU();
            DataView dataView = dAL_AUDIT_XAINGMU.SelectFieldsByXMNUMBER(XMNUMBER);
            return dataView;
        }
    }
}
