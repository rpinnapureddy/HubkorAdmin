using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_Adminugrights : tDALTable
    {
        public XVar fldTableName;
        public XVar GroupID;
        public XVar AccessMask;
        public XVar Page;
        public static void Init()
        {
            XVar dalTableAdminugrights = XVar.Array();
            dalTableAdminugrights["TableName"] = new XVar("type", 200, "varname", "fldTableName", "name", "TableName", "autoInc", "0");
            dalTableAdminugrights["GroupID"] = new XVar("type", 3, "varname", "GroupID", "name", "GroupID", "autoInc", "0");
            dalTableAdminugrights["AccessMask"] = new XVar("type", 200, "varname", "AccessMask", "name", "AccessMask", "autoInc", "0");
            dalTableAdminugrights["Page"] = new XVar("type", 201, "varname", "Page", "name", "Page", "autoInc", "0");
	        dalTableAdminugrights.InitAndSetArrayItem(true, "TableName", "key");
	        dalTableAdminugrights.InitAndSetArrayItem(true, "GroupID", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_Adminugrights"] = dalTableAdminugrights;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_Adminugrights()
        {
            			this.m_TableName = "dbo.Adminugrights";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_Adminugrights";
        }
    }
}