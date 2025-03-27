using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_order_count : tDALTable
    {
        public XVar yy;
        public XVar mm;
        public XVar tot;
        public XVar clientid;
        public static void Init()
        {
            XVar dalTablemg_order_count = XVar.Array();
            dalTablemg_order_count["yy"] = new XVar("type", 3, "varname", "yy", "name", "yy", "autoInc", "0");
            dalTablemg_order_count["mm"] = new XVar("type", 3, "varname", "mm", "name", "mm", "autoInc", "0");
            dalTablemg_order_count["tot"] = new XVar("type", 14, "varname", "tot", "name", "tot", "autoInc", "0");
            dalTablemg_order_count["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_order_count"] = dalTablemg_order_count;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_order_count()
        {
            			this.m_TableName = "dbo.mg_order_count";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_order_count";
        }
    }
}