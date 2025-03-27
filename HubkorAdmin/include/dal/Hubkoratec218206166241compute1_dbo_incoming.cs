using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_incoming : tDALTable
    {
        public XVar post_id;
        public XVar client;
        public XVar payload;
        public XVar topic;
        public XVar createdate;
        public XVar posted;
        public XVar ref_num;
        public XVar rowpointer;
        public XVar process;
        public XVar recordname;
        public XVar app;
        public XVar site;
        public static void Init()
        {
            XVar dalTableincoming = XVar.Array();
            dalTableincoming["post_id"] = new XVar("type", 20, "varname", "post_id", "name", "post_id", "autoInc", "1");
            dalTableincoming["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTableincoming["payload"] = new XVar("type", 202, "varname", "payload", "name", "payload", "autoInc", "0");
            dalTableincoming["topic"] = new XVar("type", 202, "varname", "topic", "name", "topic", "autoInc", "0");
            dalTableincoming["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTableincoming["posted"] = new XVar("type", 200, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTableincoming["ref_num"] = new XVar("type", 202, "varname", "ref_num", "name", "ref_num", "autoInc", "0");
            dalTableincoming["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTableincoming["process"] = new XVar("type", 202, "varname", "process", "name", "process", "autoInc", "0");
            dalTableincoming["recordname"] = new XVar("type", 202, "varname", "recordname", "name", "recordname", "autoInc", "0");
            dalTableincoming["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTableincoming["site"] = new XVar("type", 202, "varname", "site", "name", "site", "autoInc", "0");
	        dalTableincoming.InitAndSetArrayItem(true, "post_id", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_incoming"] = dalTableincoming;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_incoming()
        {
            			this.m_TableName = "dbo.incoming";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_incoming";
        }
    }
}