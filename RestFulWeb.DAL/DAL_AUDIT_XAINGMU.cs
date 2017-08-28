using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epoint.MisBizLogic2;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;
using System.Data.Common;

namespace RestFulWeb.DAL
{
    public class DAL_AUDIT_XAINGMU
    {
        public DataView SelectFieldsByXMNUMBER(string XMNUMBER)
        {
            Database db = null;
            db = DatabaseFactory.CreateDatabase("Frame_ConnectionString");
            string strSql = DatabaseSettings.CmdSwitch("select RowGuid,BiGuid,XMNAME,XMNUMBER,XMTYPE,SBDW from AUDIT_XIANGMU where XMNUMBER='"+XMNUMBER+"'", "select RowGuid,BiGuid,XMNAME,XMNUMBER,XMTYPE,SBDW from AUDIT_XIANGMU");
            DbCommand cmd = db.GetSqlStringCommand(strSql);
            db.AddInParameter(cmd, "XMNUMBER", DbType.String, XMNUMBER);
            return db.ExecuteDataView(cmd);
            
        }
    }
}
