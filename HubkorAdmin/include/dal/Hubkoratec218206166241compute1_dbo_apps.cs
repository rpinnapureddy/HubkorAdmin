using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_apps : tDALTable
    {
        public XVar code;
        public XVar name;
        public XVar auth_type;
        public XVar host_url;
        public XVar Last_Executed_Time;
        public XVar Next_Execution_Time;
        public static void Init()
        {
            XVar dalTableapps = XVar.Array();
            dalTableapps["code"] = new XVar("type", 202, "varname", "code", "name", "code", "autoInc", "0");
            dalTableapps["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTableapps["auth_type"] = new XVar("type", 202, "varname", "auth_type", "name", "auth_type", "autoInc", "0");
            dalTableapps["host_url"] = new XVar("type", 202, "varname", "host_url", "name", "host_url", "autoInc", "0");
            dalTableapps["Last_Executed_Time"] = new XVar("type", 135, "varname", "Last_Executed_Time", "name", "Last_Executed_Time", "autoInc", "0");
            dalTableapps["Next_Execution_Time"] = new XVar("type", 135, "varname", "Next_Execution_Time", "name", "Next_Execution_Time", "autoInc", "0");
	        dalTableapps.InitAndSetArrayItem(true, "code", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_apps"] = dalTableapps;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_apps()
        {
            			this.m_TableName = "dbo.apps";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_apps";
        }
    }
}