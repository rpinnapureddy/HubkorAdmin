using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_audit : tDALTable
    {
        public XVar id;
        public XVar datetime;
        public XVar ip;
        public XVar user;
        public XVar table;
        public XVar action;
        public XVar description;
        public static void Init()
        {
            XVar dalTablehk_audit = XVar.Array();
            dalTablehk_audit["id"] = new XVar("type", 3, "varname", "id", "name", "id", "autoInc", "1");
            dalTablehk_audit["datetime"] = new XVar("type", 135, "varname", "datetime", "name", "datetime", "autoInc", "0");
            dalTablehk_audit["ip"] = new XVar("type", 200, "varname", "ip", "name", "ip", "autoInc", "0");
            dalTablehk_audit["user"] = new XVar("type", 200, "varname", "user", "name", "user", "autoInc", "0");
            dalTablehk_audit["table"] = new XVar("type", 200, "varname", "table", "name", "table", "autoInc", "0");
            dalTablehk_audit["action"] = new XVar("type", 200, "varname", "action", "name", "action", "autoInc", "0");
            dalTablehk_audit["description"] = new XVar("type", 201, "varname", "description", "name", "description", "autoInc", "0");
	        dalTablehk_audit.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_audit"] = dalTablehk_audit;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_audit()
        {
            			this.m_TableName = "dbo.hk_audit";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_audit";
        }
    }
}