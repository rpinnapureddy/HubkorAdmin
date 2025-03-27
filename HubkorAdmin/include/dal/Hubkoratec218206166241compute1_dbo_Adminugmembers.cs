using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_Adminugmembers : tDALTable
    {
        public XVar UserName;
        public XVar GroupID;
        public XVar Provider;
        public static void Init()
        {
            XVar dalTableAdminugmembers = XVar.Array();
            dalTableAdminugmembers["UserName"] = new XVar("type", 200, "varname", "UserName", "name", "UserName", "autoInc", "0");
            dalTableAdminugmembers["GroupID"] = new XVar("type", 3, "varname", "GroupID", "name", "GroupID", "autoInc", "0");
            dalTableAdminugmembers["Provider"] = new XVar("type", 200, "varname", "Provider", "name", "Provider", "autoInc", "0");
	        dalTableAdminugmembers.InitAndSetArrayItem(true, "UserName", "key");
	        dalTableAdminugmembers.InitAndSetArrayItem(true, "GroupID", "key");
	        dalTableAdminugmembers.InitAndSetArrayItem(true, "Provider", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_Adminugmembers"] = dalTableAdminugmembers;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_Adminugmembers()
        {
            			this.m_TableName = "dbo.Adminugmembers";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_Adminugmembers";
        }
    }
}