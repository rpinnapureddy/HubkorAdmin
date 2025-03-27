using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_recordcounts : tDALTable
    {
        public XVar clientid;
        public XVar table_name;
        public XVar count;
        public XVar site_ref;
        public XVar siteCnt;
        public static void Init()
        {
            XVar dalTablerecordcounts = XVar.Array();
            dalTablerecordcounts["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablerecordcounts["table_name"] = new XVar("type", 202, "varname", "table_name", "name", "table_name", "autoInc", "0");
            dalTablerecordcounts["count"] = new XVar("type", 3, "varname", "count", "name", "count", "autoInc", "0");
            dalTablerecordcounts["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablerecordcounts["siteCnt"] = new XVar("type", 3, "varname", "siteCnt", "name", "siteCnt", "autoInc", "0");
	        dalTablerecordcounts.InitAndSetArrayItem(true, "clientid", "key");
	        dalTablerecordcounts.InitAndSetArrayItem(true, "table_name", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_recordcounts"] = dalTablerecordcounts;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_recordcounts()
        {
            			this.m_TableName = "dbo.recordcounts";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_recordcounts";
        }
    }
}