using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_schema_table : tDALTable
    {
        public XVar app;
        public XVar name;
        public XVar TABLE_NAME;
        public static void Init()
        {
            XVar dalTablehk_schema_table = XVar.Array();
            dalTablehk_schema_table["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTablehk_schema_table["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTablehk_schema_table["TABLE_NAME"] = new XVar("type", 202, "varname", "TABLE_NAME", "name", "TABLE_NAME", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_schema_table"] = dalTablehk_schema_table;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_schema_table()
        {
            			this.m_TableName = "dbo.hk_schema_table";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_schema_table";
        }
    }
}