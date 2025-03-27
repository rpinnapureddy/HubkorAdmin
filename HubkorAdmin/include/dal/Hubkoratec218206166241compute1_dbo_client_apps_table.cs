using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_client_apps_table : tDALTable
    {
        public XVar client;
        public XVar app;
        public XVar table_name;
        public XVar active;
        public static void Init()
        {
            XVar dalTableclient_apps_table = XVar.Array();
            dalTableclient_apps_table["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTableclient_apps_table["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTableclient_apps_table["table_name"] = new XVar("type", 202, "varname", "table_name", "name", "table_name", "autoInc", "0");
            dalTableclient_apps_table["active"] = new XVar("type", 11, "varname", "active", "name", "active", "autoInc", "0");
	        dalTableclient_apps_table.InitAndSetArrayItem(true, "client", "key");
	        dalTableclient_apps_table.InitAndSetArrayItem(true, "app", "key");
	        dalTableclient_apps_table.InitAndSetArrayItem(true, "table_name", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_client_apps_table"] = dalTableclient_apps_table;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_client_apps_table()
        {
            			this.m_TableName = "dbo.client_apps_table";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_client_apps_table";
        }
    }
}