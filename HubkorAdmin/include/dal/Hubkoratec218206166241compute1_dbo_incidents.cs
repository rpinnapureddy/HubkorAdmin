using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_incidents : tDALTable
    {
        public XVar id;
        public XVar category;
        public XVar summary;
        public XVar description;
        public XVar clientid;
        public XVar apps;
        public XVar createdate;
        public XVar completed;
        public XVar status;
        public XVar duedate;
        public XVar severity;
        public XVar createdby;
        public XVar phone;
        public XVar contact;
        public XVar contact_pref;
        public XVar documents;
        public XVar est_hrs;
        public XVar act_hrs;
        public XVar assignedto;
        public XVar tech_notes;
        public static void Init()
        {
            XVar dalTableincidents = XVar.Array();
            dalTableincidents["id"] = new XVar("type", 3, "varname", "id", "name", "id", "autoInc", "1");
            dalTableincidents["category"] = new XVar("type", 202, "varname", "category", "name", "category", "autoInc", "0");
            dalTableincidents["summary"] = new XVar("type", 202, "varname", "summary", "name", "summary", "autoInc", "0");
            dalTableincidents["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTableincidents["clientid"] = new XVar("type", 130, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTableincidents["apps"] = new XVar("type", 130, "varname", "apps", "name", "apps", "autoInc", "0");
            dalTableincidents["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTableincidents["completed"] = new XVar("type", 135, "varname", "completed", "name", "completed", "autoInc", "0");
            dalTableincidents["status"] = new XVar("type", 130, "varname", "status", "name", "status", "autoInc", "0");
            dalTableincidents["duedate"] = new XVar("type", 7, "varname", "duedate", "name", "duedate", "autoInc", "0");
            dalTableincidents["severity"] = new XVar("type", 202, "varname", "severity", "name", "severity", "autoInc", "0");
            dalTableincidents["createdby"] = new XVar("type", 202, "varname", "createdby", "name", "createdby", "autoInc", "0");
            dalTableincidents["phone"] = new XVar("type", 202, "varname", "phone", "name", "phone", "autoInc", "0");
            dalTableincidents["contact"] = new XVar("type", 202, "varname", "contact", "name", "contact", "autoInc", "0");
            dalTableincidents["contact_pref"] = new XVar("type", 202, "varname", "contact_pref", "name", "contact_pref", "autoInc", "0");
            dalTableincidents["documents"] = new XVar("type", 202, "varname", "documents", "name", "documents", "autoInc", "0");
            dalTableincidents["est_hrs"] = new XVar("type", 14, "varname", "est_hrs", "name", "est_hrs", "autoInc", "0");
            dalTableincidents["act_hrs"] = new XVar("type", 14, "varname", "act_hrs", "name", "act_hrs", "autoInc", "0");
            dalTableincidents["assignedto"] = new XVar("type", 202, "varname", "assignedto", "name", "assignedto", "autoInc", "0");
            dalTableincidents["tech_notes"] = new XVar("type", 202, "varname", "tech_notes", "name", "tech_notes", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_incidents"] = dalTableincidents;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_incidents()
        {
            			this.m_TableName = "dbo.incidents";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_incidents";
        }
    }
}