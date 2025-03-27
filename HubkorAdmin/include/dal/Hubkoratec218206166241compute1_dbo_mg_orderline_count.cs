using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_orderline_count : tDALTable
    {
        public XVar clientid;
        public XVar co_num;
        public XVar yy;
        public XVar mm;
        public XVar extprice;
        public static void Init()
        {
            XVar dalTablemg_orderline_count = XVar.Array();
            dalTablemg_orderline_count["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablemg_orderline_count["co_num"] = new XVar("type", 202, "varname", "co_num", "name", "co_num", "autoInc", "0");
            dalTablemg_orderline_count["yy"] = new XVar("type", 3, "varname", "yy", "name", "yy", "autoInc", "0");
            dalTablemg_orderline_count["mm"] = new XVar("type", 3, "varname", "mm", "name", "mm", "autoInc", "0");
            dalTablemg_orderline_count["extprice"] = new XVar("type", 14, "varname", "extprice", "name", "extprice", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_orderline_count"] = dalTablemg_orderline_count;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_orderline_count()
        {
            			this.m_TableName = "dbo.mg_orderline_count";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_orderline_count";
        }
    }
}