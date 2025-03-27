using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_documents : tDALTable
    {
        public XVar id;
        public XVar clientid;
        public XVar apps;
        public XVar description;
        public XVar file_name;
        public static void Init()
        {
            XVar dalTabledocuments = XVar.Array();
            dalTabledocuments["id"] = new XVar("type", 3, "varname", "id", "name", "id", "autoInc", "1");
            dalTabledocuments["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabledocuments["apps"] = new XVar("type", 202, "varname", "apps", "name", "apps", "autoInc", "0");
            dalTabledocuments["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTabledocuments["file_name"] = new XVar("type", 202, "varname", "file_name", "name", "file_name", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_documents"] = dalTabledocuments;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_documents()
        {
            			this.m_TableName = "dbo.documents";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_documents";
        }
    }
}