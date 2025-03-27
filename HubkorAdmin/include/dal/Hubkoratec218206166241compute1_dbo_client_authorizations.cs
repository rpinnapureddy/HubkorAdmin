using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_client_authorizations : tDALTable
    {
        public XVar client;
        public XVar api_key;
        public XVar date_created;
        public XVar date_expired;
        public XVar role;
        public static void Init()
        {
            XVar dalTableclient_authorizations = XVar.Array();
            dalTableclient_authorizations["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTableclient_authorizations["api_key"] = new XVar("type", 202, "varname", "api_key", "name", "api_key", "autoInc", "0");
            dalTableclient_authorizations["date_created"] = new XVar("type", 135, "varname", "date_created", "name", "date_created", "autoInc", "0");
            dalTableclient_authorizations["date_expired"] = new XVar("type", 135, "varname", "date_expired", "name", "date_expired", "autoInc", "0");
            dalTableclient_authorizations["role"] = new XVar("type", 202, "varname", "role", "name", "role", "autoInc", "0");
	        dalTableclient_authorizations.InitAndSetArrayItem(true, "client", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_client_authorizations"] = dalTableclient_authorizations;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_client_authorizations()
        {
            			this.m_TableName = "dbo.client_authorizations";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_client_authorizations";
        }
    }
}