using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_auditlog_mst : tDALTable
    {
        public XVar clientid;
        public XVar seq;
        public XVar payload;
        public XVar create_date;
        public XVar posted;
        public XVar ref_num;
        public XVar process;
        public XVar rowpointer;
        public XVar logId;
        public XVar response;
        public XVar refrowpointer;
        public XVar status;
        public XVar statusmessage;
        public XVar app;
        public static void Init()
        {
            XVar dalTableauditlog_mst = XVar.Array();
            dalTableauditlog_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTableauditlog_mst["seq"] = new XVar("type", 20, "varname", "seq", "name", "seq", "autoInc", "1");
            dalTableauditlog_mst["payload"] = new XVar("type", 202, "varname", "payload", "name", "payload", "autoInc", "0");
            dalTableauditlog_mst["create_date"] = new XVar("type", 135, "varname", "create_date", "name", "create_date", "autoInc", "0");
            dalTableauditlog_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTableauditlog_mst["ref_num"] = new XVar("type", 202, "varname", "ref_num", "name", "ref_num", "autoInc", "0");
            dalTableauditlog_mst["process"] = new XVar("type", 202, "varname", "process", "name", "process", "autoInc", "0");
            dalTableauditlog_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTableauditlog_mst["logId"] = new XVar("type", 202, "varname", "logId", "name", "logId", "autoInc", "0");
            dalTableauditlog_mst["response"] = new XVar("type", 202, "varname", "response", "name", "response", "autoInc", "0");
            dalTableauditlog_mst["refrowpointer"] = new XVar("type", 72, "varname", "refrowpointer", "name", "refrowpointer", "autoInc", "0");
            dalTableauditlog_mst["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            dalTableauditlog_mst["statusmessage"] = new XVar("type", 202, "varname", "statusmessage", "name", "statusmessage", "autoInc", "0");
            dalTableauditlog_mst["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
	        dalTableauditlog_mst.InitAndSetArrayItem(true, "seq", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_auditlog_mst"] = dalTableauditlog_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_auditlog_mst()
        {
            			this.m_TableName = "dbo.auditlog_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_auditlog_mst";
        }
    }
}