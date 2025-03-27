using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_csi_chart_mst : tDALTable
    {
        public XVar clientid;
        public XVar acct;
        public XVar site_ref;
        public XVar access_unit1;
        public XVar access_unit2;
        public XVar access_unit3;
        public XVar access_unit4;
        public XVar acct_class;
        public XVar CreateDate;
        public XVar CreatedBy;
        public XVar description;
        public XVar eff_date;
        public XVar InWorkflow;
        public XVar is_control;
        public XVar ledger_dim_name;
        public XVar MX_applies_to_ietu;
        public XVar MX_diot_trans_type;
        public XVar MX_ietu_class;
        public XVar MX_ietu_deduction_pct;
        public XVar NoteExistsFlag;
        public XVar obs_date;
        public XVar RecordDate;
        public XVar reports_to_acct;
        public XVar RowPointer;
        public XVar trans_method;
        public XVar type;
        public XVar UpdatedBy;
        public XVar use_buy_rate;
        public XVar DLDeleteIndicator;
        public XVar VariationNumber;
        public XVar tp_id;
        public XVar tp_posted;
        public XVar sc_id;
        public XVar sc_posted;
        public XVar sf_id;
        public XVar sf_posted;
        public XVar mg_id;
        public XVar mg_posted;
        public XVar uf_uet1;
        public XVar uf_uet2;
        public XVar uf_uet3;
        public XVar uf_uet4;
        public XVar uf_uet5;
        public XVar uf_uet6;
        public XVar uf_uet7;
        public XVar uf_uet8;
        public XVar uf_uet9;
        public XVar uf_uet10;
        public XVar tp_status;
        public static void Init()
        {
            XVar dalTablecsi_chart_mst = XVar.Array();
            dalTablecsi_chart_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablecsi_chart_mst["acct"] = new XVar("type", 202, "varname", "acct", "name", "acct", "autoInc", "0");
            dalTablecsi_chart_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablecsi_chart_mst["access_unit1"] = new XVar("type", 202, "varname", "access_unit1", "name", "access_unit1", "autoInc", "0");
            dalTablecsi_chart_mst["access_unit2"] = new XVar("type", 202, "varname", "access_unit2", "name", "access_unit2", "autoInc", "0");
            dalTablecsi_chart_mst["access_unit3"] = new XVar("type", 202, "varname", "access_unit3", "name", "access_unit3", "autoInc", "0");
            dalTablecsi_chart_mst["access_unit4"] = new XVar("type", 202, "varname", "access_unit4", "name", "access_unit4", "autoInc", "0");
            dalTablecsi_chart_mst["acct_class"] = new XVar("type", 202, "varname", "acct_class", "name", "acct_class", "autoInc", "0");
            dalTablecsi_chart_mst["CreateDate"] = new XVar("type", 135, "varname", "CreateDate", "name", "CreateDate", "autoInc", "0");
            dalTablecsi_chart_mst["CreatedBy"] = new XVar("type", 202, "varname", "CreatedBy", "name", "CreatedBy", "autoInc", "0");
            dalTablecsi_chart_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablecsi_chart_mst["eff_date"] = new XVar("type", 135, "varname", "eff_date", "name", "eff_date", "autoInc", "0");
            dalTablecsi_chart_mst["InWorkflow"] = new XVar("type", 20, "varname", "InWorkflow", "name", "InWorkflow", "autoInc", "0");
            dalTablecsi_chart_mst["is_control"] = new XVar("type", 20, "varname", "is_control", "name", "is_control", "autoInc", "0");
            dalTablecsi_chart_mst["ledger_dim_name"] = new XVar("type", 202, "varname", "ledger_dim_name", "name", "ledger_dim_name", "autoInc", "0");
            dalTablecsi_chart_mst["MX_applies_to_ietu"] = new XVar("type", 20, "varname", "MX_applies_to_ietu", "name", "MX_applies_to_ietu", "autoInc", "0");
            dalTablecsi_chart_mst["MX_diot_trans_type"] = new XVar("type", 202, "varname", "MX_diot_trans_type", "name", "MX_diot_trans_type", "autoInc", "0");
            dalTablecsi_chart_mst["MX_ietu_class"] = new XVar("type", 202, "varname", "MX_ietu_class", "name", "MX_ietu_class", "autoInc", "0");
            dalTablecsi_chart_mst["MX_ietu_deduction_pct"] = new XVar("type", 14, "varname", "MX_ietu_deduction_pct", "name", "MX_ietu_deduction_pct", "autoInc", "0");
            dalTablecsi_chart_mst["NoteExistsFlag"] = new XVar("type", 20, "varname", "NoteExistsFlag", "name", "NoteExistsFlag", "autoInc", "0");
            dalTablecsi_chart_mst["obs_date"] = new XVar("type", 135, "varname", "obs_date", "name", "obs_date", "autoInc", "0");
            dalTablecsi_chart_mst["RecordDate"] = new XVar("type", 135, "varname", "RecordDate", "name", "RecordDate", "autoInc", "0");
            dalTablecsi_chart_mst["reports_to_acct"] = new XVar("type", 202, "varname", "reports_to_acct", "name", "reports_to_acct", "autoInc", "0");
            dalTablecsi_chart_mst["RowPointer"] = new XVar("type", 202, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTablecsi_chart_mst["trans_method"] = new XVar("type", 202, "varname", "trans_method", "name", "trans_method", "autoInc", "0");
            dalTablecsi_chart_mst["type"] = new XVar("type", 202, "varname", "type", "name", "type", "autoInc", "0");
            dalTablecsi_chart_mst["UpdatedBy"] = new XVar("type", 202, "varname", "UpdatedBy", "name", "UpdatedBy", "autoInc", "0");
            dalTablecsi_chart_mst["use_buy_rate"] = new XVar("type", 20, "varname", "use_buy_rate", "name", "use_buy_rate", "autoInc", "0");
            dalTablecsi_chart_mst["DLDeleteIndicator"] = new XVar("type", 20, "varname", "DLDeleteIndicator", "name", "DLDeleteIndicator", "autoInc", "0");
            dalTablecsi_chart_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablecsi_chart_mst["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTablecsi_chart_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTablecsi_chart_mst["sc_id"] = new XVar("type", 202, "varname", "sc_id", "name", "sc_id", "autoInc", "0");
            dalTablecsi_chart_mst["sc_posted"] = new XVar("type", 16, "varname", "sc_posted", "name", "sc_posted", "autoInc", "0");
            dalTablecsi_chart_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablecsi_chart_mst["sf_posted"] = new XVar("type", 16, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablecsi_chart_mst["mg_id"] = new XVar("type", 202, "varname", "mg_id", "name", "mg_id", "autoInc", "0");
            dalTablecsi_chart_mst["mg_posted"] = new XVar("type", 16, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablecsi_chart_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            dalTablecsi_chart_mst["tp_status"] = new XVar("type", 202, "varname", "tp_status", "name", "tp_status", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_csi_chart_mst"] = dalTablecsi_chart_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_csi_chart_mst()
        {
            			this.m_TableName = "dbo.csi_chart_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_csi_chart_mst";
        }
    }
}