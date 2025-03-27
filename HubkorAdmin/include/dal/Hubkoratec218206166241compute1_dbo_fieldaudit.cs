using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_fieldaudit : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar table_value;
        public XVar ref_num;
        public XVar ref_line;
        public XVar new_value;
        public XVar old_value;
        public XVar create_date;
        public XVar seq;
        public XVar field_value;
        public static void Init()
        {
            XVar dalTablefieldaudit = XVar.Array();
            dalTablefieldaudit["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablefieldaudit["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablefieldaudit["table_value"] = new XVar("type", 202, "varname", "table_value", "name", "table_value", "autoInc", "0");
            dalTablefieldaudit["ref_num"] = new XVar("type", 202, "varname", "ref_num", "name", "ref_num", "autoInc", "0");
            dalTablefieldaudit["ref_line"] = new XVar("type", 3, "varname", "ref_line", "name", "ref_line", "autoInc", "0");
            dalTablefieldaudit["new_value"] = new XVar("type", 202, "varname", "new_value", "name", "new_value", "autoInc", "0");
            dalTablefieldaudit["old_value"] = new XVar("type", 202, "varname", "old_value", "name", "old_value", "autoInc", "0");
            dalTablefieldaudit["create_date"] = new XVar("type", 135, "varname", "create_date", "name", "create_date", "autoInc", "0");
            dalTablefieldaudit["seq"] = new XVar("type", 3, "varname", "seq", "name", "seq", "autoInc", "1");
            dalTablefieldaudit["field_value"] = new XVar("type", 202, "varname", "field_value", "name", "field_value", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_fieldaudit"] = dalTablefieldaudit;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_fieldaudit()
        {
            			this.m_TableName = "dbo.fieldaudit";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_fieldaudit";
        }
    }
}