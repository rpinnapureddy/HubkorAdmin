using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_client_apps : tDALTable
    {
        public XVar client;
        public XVar app;
        public XVar active;
        public XVar profile_id;
        public XVar effective_date;
        public XVar termination_date;
        public XVar email_flash;
        public XVar status;
        public static void Init()
        {
            XVar dalTableclient_apps = XVar.Array();
            dalTableclient_apps["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTableclient_apps["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTableclient_apps["active"] = new XVar("type", 11, "varname", "active", "name", "active", "autoInc", "0");
            dalTableclient_apps["profile_id"] = new XVar("type", 202, "varname", "profile_id", "name", "profile_id", "autoInc", "0");
            dalTableclient_apps["effective_date"] = new XVar("type", 7, "varname", "effective_date", "name", "effective_date", "autoInc", "0");
            dalTableclient_apps["termination_date"] = new XVar("type", 7, "varname", "termination_date", "name", "termination_date", "autoInc", "0");
            dalTableclient_apps["email_flash"] = new XVar("type", 202, "varname", "email_flash", "name", "email_flash", "autoInc", "0");
            dalTableclient_apps["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
	        dalTableclient_apps.InitAndSetArrayItem(true, "client", "key");
	        dalTableclient_apps.InitAndSetArrayItem(true, "app", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_client_apps"] = dalTableclient_apps;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_client_apps()
        {
            			this.m_TableName = "dbo.client_apps";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_client_apps";
        }
    }
}