using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_client_connections : tDALTable
    {
        public XVar profileid;
        public XVar client;
        public XVar baseurl;
        public XVar config;
        public XVar site;
        public XVar rest_usr;
        public XVar rest_pwd;
        public XVar oauth_usr;
        public XVar oauth_pwd;
        public XVar oauth_clientid;
        public XVar oauth_secret;
        public XVar tokenurl;
        public XVar app;
        public XVar token;
        public XVar lst_token_validate;
        public static void Init()
        {
            XVar dalTableclient_connections = XVar.Array();
            dalTableclient_connections["profileid"] = new XVar("type", 202, "varname", "profileid", "name", "profileid", "autoInc", "0");
            dalTableclient_connections["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTableclient_connections["baseurl"] = new XVar("type", 202, "varname", "baseurl", "name", "baseurl", "autoInc", "0");
            dalTableclient_connections["config"] = new XVar("type", 202, "varname", "config", "name", "config", "autoInc", "0");
            dalTableclient_connections["site"] = new XVar("type", 202, "varname", "site", "name", "site", "autoInc", "0");
            dalTableclient_connections["rest_usr"] = new XVar("type", 202, "varname", "rest_usr", "name", "rest_usr", "autoInc", "0");
            dalTableclient_connections["rest_pwd"] = new XVar("type", 202, "varname", "rest_pwd", "name", "rest_pwd", "autoInc", "0");
            dalTableclient_connections["oauth_usr"] = new XVar("type", 202, "varname", "oauth_usr", "name", "oauth_usr", "autoInc", "0");
            dalTableclient_connections["oauth_pwd"] = new XVar("type", 202, "varname", "oauth_pwd", "name", "oauth_pwd", "autoInc", "0");
            dalTableclient_connections["oauth_clientid"] = new XVar("type", 202, "varname", "oauth_clientid", "name", "oauth_clientid", "autoInc", "0");
            dalTableclient_connections["oauth_secret"] = new XVar("type", 202, "varname", "oauth_secret", "name", "oauth_secret", "autoInc", "0");
            dalTableclient_connections["tokenurl"] = new XVar("type", 202, "varname", "tokenurl", "name", "tokenurl", "autoInc", "0");
            dalTableclient_connections["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTableclient_connections["token"] = new XVar("type", 202, "varname", "token", "name", "token", "autoInc", "0");
            dalTableclient_connections["lst_token_validate"] = new XVar("type", 135, "varname", "lst_token_validate", "name", "lst_token_validate", "autoInc", "0");
	        dalTableclient_connections.InitAndSetArrayItem(true, "profileid", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_client_connections"] = dalTableclient_connections;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_client_connections()
        {
            			this.m_TableName = "dbo.client_connections";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_client_connections";
        }
    }
}