using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_SourceManagement : tDALTable
    {
        public XVar Application;
        public XVar CreatedDate;
        public XVar User;
        public XVar Description;
        public XVar ChangeSet;
        public XVar Id;
        public static void Init()
        {
            XVar dalTableSourceManagement = XVar.Array();
            dalTableSourceManagement["Application"] = new XVar("type", 200, "varname", "Application", "name", "Application", "autoInc", "0");
            dalTableSourceManagement["CreatedDate"] = new XVar("type", 135, "varname", "CreatedDate", "name", "CreatedDate", "autoInc", "0");
            dalTableSourceManagement["User"] = new XVar("type", 200, "varname", "User", "name", "User", "autoInc", "0");
            dalTableSourceManagement["Description"] = new XVar("type", 202, "varname", "Description", "name", "Description", "autoInc", "0");
            dalTableSourceManagement["ChangeSet"] = new XVar("type", 202, "varname", "ChangeSet", "name", "ChangeSet", "autoInc", "0");
            dalTableSourceManagement["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_SourceManagement"] = dalTableSourceManagement;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_SourceManagement()
        {
            			this.m_TableName = "dbo.SourceManagement";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_SourceManagement";
        }
    }
}