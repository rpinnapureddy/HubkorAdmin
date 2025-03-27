using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_connector : tDALTable
    {
        public XVar connector;
        public XVar app;
        public XVar description;
        public XVar active;
        public static void Init()
        {
            XVar dalTableconnector = XVar.Array();
            dalTableconnector["connector"] = new XVar("type", 202, "varname", "connector", "name", "connector", "autoInc", "0");
            dalTableconnector["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTableconnector["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTableconnector["active"] = new XVar("type", 16, "varname", "active", "name", "active", "autoInc", "0");
	        dalTableconnector.InitAndSetArrayItem(true, "connector", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_connector"] = dalTableconnector;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_connector()
        {
            			this.m_TableName = "dbo.connector";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_connector";
        }
    }
}