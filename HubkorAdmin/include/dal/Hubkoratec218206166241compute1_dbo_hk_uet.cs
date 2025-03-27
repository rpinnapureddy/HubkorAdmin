using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_uet : tDALTable
    {
        public XVar clientid;
        public XVar table;
        public XVar field_to;
        public XVar field;
        public XVar fldint;
        public XVar rowpointer;
        public static void Init()
        {
            XVar dalTablehk_uet = XVar.Array();
            dalTablehk_uet["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablehk_uet["table"] = new XVar("type", 202, "varname", "table", "name", "table", "autoInc", "0");
            dalTablehk_uet["field_to"] = new XVar("type", 202, "varname", "field_to", "name", "field_to", "autoInc", "0");
            dalTablehk_uet["field"] = new XVar("type", 202, "varname", "field", "name", "field", "autoInc", "0");
            dalTablehk_uet["int"] = new XVar("type", 3, "varname", "fldint", "name", "int", "autoInc", "0");
            dalTablehk_uet["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_uet"] = dalTablehk_uet;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_uet()
        {
            			this.m_TableName = "dbo.hk_uet";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_uet";
        }
    }
}