using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_schema_field : tDALTable
    {
        public XVar app;
        public XVar name;
        public XVar TABLE_NAME;
        public XVar COLUMN_NAME;
        public XVar DATA_TYPE;
        public XVar CHARACTER_MAXIMUM_LENGTH;
        public XVar NUMERIC_PRECISION;
        public XVar NUMERIC_SCALE;
        public static void Init()
        {
            XVar dalTablehk_schema_field = XVar.Array();
            dalTablehk_schema_field["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTablehk_schema_field["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTablehk_schema_field["TABLE_NAME"] = new XVar("type", 202, "varname", "TABLE_NAME", "name", "TABLE_NAME", "autoInc", "0");
            dalTablehk_schema_field["COLUMN_NAME"] = new XVar("type", 202, "varname", "COLUMN_NAME", "name", "COLUMN_NAME", "autoInc", "0");
            dalTablehk_schema_field["DATA_TYPE"] = new XVar("type", 202, "varname", "DATA_TYPE", "name", "DATA_TYPE", "autoInc", "0");
            dalTablehk_schema_field["CHARACTER_MAXIMUM_LENGTH"] = new XVar("type", 3, "varname", "CHARACTER_MAXIMUM_LENGTH", "name", "CHARACTER_MAXIMUM_LENGTH", "autoInc", "0");
            dalTablehk_schema_field["NUMERIC_PRECISION"] = new XVar("type", 16, "varname", "NUMERIC_PRECISION", "name", "NUMERIC_PRECISION", "autoInc", "0");
            dalTablehk_schema_field["NUMERIC_SCALE"] = new XVar("type", 3, "varname", "NUMERIC_SCALE", "name", "NUMERIC_SCALE", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_schema_field"] = dalTablehk_schema_field;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_schema_field()
        {
            			this.m_TableName = "dbo.hk_schema_field";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_schema_field";
        }
    }
}