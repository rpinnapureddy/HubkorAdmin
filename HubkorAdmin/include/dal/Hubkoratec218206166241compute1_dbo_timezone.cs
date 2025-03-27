using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_timezone : tDALTable
    {
        public XVar timezone;
        public XVar offset;
        public static void Init()
        {
            XVar dalTabletimezone = XVar.Array();
            dalTabletimezone["timezone"] = new XVar("type", 202, "varname", "timezone", "name", "timezone", "autoInc", "0");
            dalTabletimezone["offset"] = new XVar("type", 3, "varname", "offset", "name", "offset", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_timezone"] = dalTabletimezone;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_timezone()
        {
            			this.m_TableName = "dbo.timezone";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_timezone";
        }
    }
}