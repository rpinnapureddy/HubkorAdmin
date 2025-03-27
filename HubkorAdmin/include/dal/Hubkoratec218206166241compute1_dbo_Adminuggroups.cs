using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_Adminuggroups : tDALTable
    {
        public XVar GroupID;
        public XVar Label;
        public XVar Provider;
        public XVar Comment;
        public static void Init()
        {
            XVar dalTableAdminuggroups = XVar.Array();
            dalTableAdminuggroups["GroupID"] = new XVar("type", 3, "varname", "GroupID", "name", "GroupID", "autoInc", "1");
            dalTableAdminuggroups["Label"] = new XVar("type", 200, "varname", "Label", "name", "Label", "autoInc", "0");
            dalTableAdminuggroups["Provider"] = new XVar("type", 200, "varname", "Provider", "name", "Provider", "autoInc", "0");
            dalTableAdminuggroups["Comment"] = new XVar("type", 201, "varname", "Comment", "name", "Comment", "autoInc", "0");
	        dalTableAdminuggroups.InitAndSetArrayItem(true, "GroupID", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_Adminuggroups"] = dalTableAdminuggroups;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_Adminuggroups()
        {
            			this.m_TableName = "dbo.Adminuggroups";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_Adminuggroups";
        }
    }
}