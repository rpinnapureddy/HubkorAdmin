using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_csi_terms_mst : tDALTable
    {
        public XVar clientid;
        public XVar terms_code;
        public XVar site_ref;
        public XVar advanced;
        public XVar cash_only;
        public XVar CreateDate;
        public XVar CreatedBy;
        public XVar cutoff_day;
        public XVar description;
        public XVar disc_days;
        public XVar disc_pct;
        public XVar due_days;
        public XVar holiday_offset_method;
        public XVar InWorkflow;
        public XVar NoteExistsFlag;
        public XVar prox_code;
        public XVar prox_day;
        public XVar prox_disc_day;
        public XVar prox_disc_month_to_forward;
        public XVar prox_month_to_forward;
        public XVar RecordDate;
        public XVar RowPointer;
        public XVar tax_disc;
        public XVar UpdatedBy;
        public XVar use_multi_due_dates;
        public XVar DLDeleteIndicator;
        public XVar VariationNumber;
        public XVar salesforceid;
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
        public static void Init()
        {
            XVar dalTablecsi_terms_mst = XVar.Array();
            dalTablecsi_terms_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablecsi_terms_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablecsi_terms_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablecsi_terms_mst["advanced"] = new XVar("type", 20, "varname", "advanced", "name", "advanced", "autoInc", "0");
            dalTablecsi_terms_mst["cash_only"] = new XVar("type", 20, "varname", "cash_only", "name", "cash_only", "autoInc", "0");
            dalTablecsi_terms_mst["CreateDate"] = new XVar("type", 135, "varname", "CreateDate", "name", "CreateDate", "autoInc", "0");
            dalTablecsi_terms_mst["CreatedBy"] = new XVar("type", 202, "varname", "CreatedBy", "name", "CreatedBy", "autoInc", "0");
            dalTablecsi_terms_mst["cutoff_day"] = new XVar("type", 20, "varname", "cutoff_day", "name", "cutoff_day", "autoInc", "0");
            dalTablecsi_terms_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablecsi_terms_mst["disc_days"] = new XVar("type", 20, "varname", "disc_days", "name", "disc_days", "autoInc", "0");
            dalTablecsi_terms_mst["disc_pct"] = new XVar("type", 14, "varname", "disc_pct", "name", "disc_pct", "autoInc", "0");
            dalTablecsi_terms_mst["due_days"] = new XVar("type", 20, "varname", "due_days", "name", "due_days", "autoInc", "0");
            dalTablecsi_terms_mst["holiday_offset_method"] = new XVar("type", 202, "varname", "holiday_offset_method", "name", "holiday_offset_method", "autoInc", "0");
            dalTablecsi_terms_mst["InWorkflow"] = new XVar("type", 20, "varname", "InWorkflow", "name", "InWorkflow", "autoInc", "0");
            dalTablecsi_terms_mst["NoteExistsFlag"] = new XVar("type", 20, "varname", "NoteExistsFlag", "name", "NoteExistsFlag", "autoInc", "0");
            dalTablecsi_terms_mst["prox_code"] = new XVar("type", 20, "varname", "prox_code", "name", "prox_code", "autoInc", "0");
            dalTablecsi_terms_mst["prox_day"] = new XVar("type", 20, "varname", "prox_day", "name", "prox_day", "autoInc", "0");
            dalTablecsi_terms_mst["prox_disc_day"] = new XVar("type", 20, "varname", "prox_disc_day", "name", "prox_disc_day", "autoInc", "0");
            dalTablecsi_terms_mst["prox_disc_month_to_forward"] = new XVar("type", 20, "varname", "prox_disc_month_to_forward", "name", "prox_disc_month_to_forward", "autoInc", "0");
            dalTablecsi_terms_mst["prox_month_to_forward"] = new XVar("type", 20, "varname", "prox_month_to_forward", "name", "prox_month_to_forward", "autoInc", "0");
            dalTablecsi_terms_mst["RecordDate"] = new XVar("type", 135, "varname", "RecordDate", "name", "RecordDate", "autoInc", "0");
            dalTablecsi_terms_mst["RowPointer"] = new XVar("type", 202, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTablecsi_terms_mst["tax_disc"] = new XVar("type", 14, "varname", "tax_disc", "name", "tax_disc", "autoInc", "0");
            dalTablecsi_terms_mst["UpdatedBy"] = new XVar("type", 202, "varname", "UpdatedBy", "name", "UpdatedBy", "autoInc", "0");
            dalTablecsi_terms_mst["use_multi_due_dates"] = new XVar("type", 20, "varname", "use_multi_due_dates", "name", "use_multi_due_dates", "autoInc", "0");
            dalTablecsi_terms_mst["DLDeleteIndicator"] = new XVar("type", 20, "varname", "DLDeleteIndicator", "name", "DLDeleteIndicator", "autoInc", "0");
            dalTablecsi_terms_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablecsi_terms_mst["salesforceid"] = new XVar("type", 202, "varname", "salesforceid", "name", "salesforceid", "autoInc", "0");
            dalTablecsi_terms_mst["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTablecsi_terms_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTablecsi_terms_mst["sc_id"] = new XVar("type", 202, "varname", "sc_id", "name", "sc_id", "autoInc", "0");
            dalTablecsi_terms_mst["sc_posted"] = new XVar("type", 16, "varname", "sc_posted", "name", "sc_posted", "autoInc", "0");
            dalTablecsi_terms_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablecsi_terms_mst["sf_posted"] = new XVar("type", 16, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablecsi_terms_mst["mg_id"] = new XVar("type", 202, "varname", "mg_id", "name", "mg_id", "autoInc", "0");
            dalTablecsi_terms_mst["mg_posted"] = new XVar("type", 16, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablecsi_terms_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_csi_terms_mst"] = dalTablecsi_terms_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_csi_terms_mst()
        {
            			this.m_TableName = "dbo.csi_terms_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_csi_terms_mst";
        }
    }
}