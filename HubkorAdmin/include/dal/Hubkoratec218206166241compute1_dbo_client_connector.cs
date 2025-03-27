using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_client_connector : tDALTable
    {
        public XVar client;
        public XVar connector;
        public XVar app;
        public XVar active;
        public static void Init()
        {
            XVar dalTableclient_connector = XVar.Array();
            dalTableclient_connector["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTableclient_connector["connector"] = new XVar("type", 202, "varname", "connector", "name", "connector", "autoInc", "0");
            dalTableclient_connector["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTableclient_connector["active"] = new XVar("type", 11, "varname", "active", "name", "active", "autoInc", "0");
	        dalTableclient_connector.InitAndSetArrayItem(true, "client", "key");
	        dalTableclient_connector.InitAndSetArrayItem(true, "connector", "key");
	        dalTableclient_connector.InitAndSetArrayItem(true, "app", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_client_connector"] = dalTableclient_connector;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_client_connector()
        {
            			this.m_TableName = "dbo.client_connector";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_client_connector";
        }
    }
}