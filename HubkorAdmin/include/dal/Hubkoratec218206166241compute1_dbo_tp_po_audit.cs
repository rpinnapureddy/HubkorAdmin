using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_po_audit : tDALTable
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
            XVar dalTabletp_po_audit = XVar.Array();
            dalTabletp_po_audit["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_po_audit["seq"] = new XVar("type", 20, "varname", "seq", "name", "seq", "autoInc", "1");
            dalTabletp_po_audit["payload"] = new XVar("type", 202, "varname", "payload", "name", "payload", "autoInc", "0");
            dalTabletp_po_audit["create_date"] = new XVar("type", 135, "varname", "create_date", "name", "create_date", "autoInc", "0");
            dalTabletp_po_audit["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTabletp_po_audit["ref_num"] = new XVar("type", 202, "varname", "ref_num", "name", "ref_num", "autoInc", "0");
            dalTabletp_po_audit["process"] = new XVar("type", 202, "varname", "process", "name", "process", "autoInc", "0");
            dalTabletp_po_audit["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTabletp_po_audit["logId"] = new XVar("type", 202, "varname", "logId", "name", "logId", "autoInc", "0");
            dalTabletp_po_audit["response"] = new XVar("type", 202, "varname", "response", "name", "response", "autoInc", "0");
            dalTabletp_po_audit["refrowpointer"] = new XVar("type", 72, "varname", "refrowpointer", "name", "refrowpointer", "autoInc", "0");
            dalTabletp_po_audit["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            dalTabletp_po_audit["statusmessage"] = new XVar("type", 202, "varname", "statusmessage", "name", "statusmessage", "autoInc", "0");
            dalTabletp_po_audit["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_po_audit"] = dalTabletp_po_audit;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_po_audit()
        {
            			this.m_TableName = "dbo.tp_po_audit";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_po_audit";
        }
    }
}