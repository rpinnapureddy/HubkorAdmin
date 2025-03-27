using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_client_app_connector : tDALTable
    {
        public XVar client;
        public XVar app;
        public XVar connector;
        public static void Init()
        {
            XVar dalTablehk_client_app_connector = XVar.Array();
            dalTablehk_client_app_connector["client"] = new XVar("type", 202, "varname", "client", "name", "client", "autoInc", "0");
            dalTablehk_client_app_connector["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTablehk_client_app_connector["connector"] = new XVar("type", 202, "varname", "connector", "name", "connector", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_client_app_connector"] = dalTablehk_client_app_connector;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_client_app_connector()
        {
            			this.m_TableName = "dbo.hk_client_app_connector";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_client_app_connector";
        }
    }
}