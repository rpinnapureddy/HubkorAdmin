using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_csi_ido_prop_mst : tDALTable
    {
        public XVar clientid;
        public XVar app;
        public XVar ido_name;
        public XVar prop_name;
        public XVar table_name;
        public XVar column_name;
        public XVar data_type;
        public XVar length;
        public XVar dec_pos;
        public XVar def_value;
        public XVar required;
        public XVar map_field;
        public static void Init()
        {
            XVar dalTablecsi_ido_prop_mst = XVar.Array();
            dalTablecsi_ido_prop_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablecsi_ido_prop_mst["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTablecsi_ido_prop_mst["ido_name"] = new XVar("type", 202, "varname", "ido_name", "name", "ido_name", "autoInc", "0");
            dalTablecsi_ido_prop_mst["prop_name"] = new XVar("type", 202, "varname", "prop_name", "name", "prop_name", "autoInc", "0");
            dalTablecsi_ido_prop_mst["table_name"] = new XVar("type", 202, "varname", "table_name", "name", "table_name", "autoInc", "0");
            dalTablecsi_ido_prop_mst["column_name"] = new XVar("type", 202, "varname", "column_name", "name", "column_name", "autoInc", "0");
            dalTablecsi_ido_prop_mst["data_type"] = new XVar("type", 202, "varname", "data_type", "name", "data_type", "autoInc", "0");
            dalTablecsi_ido_prop_mst["length"] = new XVar("type", 3, "varname", "length", "name", "length", "autoInc", "0");
            dalTablecsi_ido_prop_mst["dec_pos"] = new XVar("type", 3, "varname", "dec_pos", "name", "dec_pos", "autoInc", "0");
            dalTablecsi_ido_prop_mst["def_value"] = new XVar("type", 202, "varname", "def_value", "name", "def_value", "autoInc", "0");
            dalTablecsi_ido_prop_mst["required"] = new XVar("type", 16, "varname", "required", "name", "required", "autoInc", "0");
            dalTablecsi_ido_prop_mst["map_field"] = new XVar("type", 202, "varname", "map_field", "name", "map_field", "autoInc", "0");
	        dalTablecsi_ido_prop_mst.InitAndSetArrayItem(true, "clientid", "key");
	        dalTablecsi_ido_prop_mst.InitAndSetArrayItem(true, "app", "key");
	        dalTablecsi_ido_prop_mst.InitAndSetArrayItem(true, "ido_name", "key");
	        dalTablecsi_ido_prop_mst.InitAndSetArrayItem(true, "prop_name", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_csi_ido_prop_mst"] = dalTablecsi_ido_prop_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_csi_ido_prop_mst()
        {
            			this.m_TableName = "dbo.csi_ido_prop_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_csi_ido_prop_mst";
        }
    }
}