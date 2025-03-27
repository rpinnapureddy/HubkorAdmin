using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_csi_lc_rcpt_mst : tDALTable
    {
        public XVar clientid;
        public XVar VariationNumber;
        public XVar ref_type;
        public XVar ref_num;
        public XVar ref_line_suf;
        public XVar ref_release;
        public XVar lc_type;
        public XVar rcvd_date;
        public XVar date_seq;
        public XVar site_ref;
        public XVar CreateDate;
        public XVar CreatedBy;
        public XVar exch_rate;
        public XVar grn_num;
        public XVar InWorkflow;
        public XVar NoteExistsFlag;
        public XVar qty_ordered;
        public XVar qty_received;
        public XVar rcvd_amt;
        public XVar RecordDate;
        public XVar RowPointer;
        public XVar unit_cost;
        public XVar UpdatedBy;
        public XVar vch_amt;
        public XVar vend_num;
        public XVar voucher;
        public XVar vouchered;
        public XVar DLDeleteIndicator;
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
        public XVar tp_id;
        public XVar tp_posted;
        public XVar sc_id;
        public XVar sf_id;
        public XVar mg_id;
        public XVar mg_posted;
        public XVar sf_posted;
        public XVar sc_posted;
        public static void Init()
        {
            XVar dalTablecsi_lc_rcpt_mst = XVar.Array();
            dalTablecsi_lc_rcpt_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["ref_type"] = new XVar("type", 202, "varname", "ref_type", "name", "ref_type", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["ref_num"] = new XVar("type", 202, "varname", "ref_num", "name", "ref_num", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["ref_line_suf"] = new XVar("type", 20, "varname", "ref_line_suf", "name", "ref_line_suf", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["ref_release"] = new XVar("type", 20, "varname", "ref_release", "name", "ref_release", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["lc_type"] = new XVar("type", 202, "varname", "lc_type", "name", "lc_type", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["rcvd_date"] = new XVar("type", 135, "varname", "rcvd_date", "name", "rcvd_date", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["date_seq"] = new XVar("type", 20, "varname", "date_seq", "name", "date_seq", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["CreateDate"] = new XVar("type", 135, "varname", "CreateDate", "name", "CreateDate", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["CreatedBy"] = new XVar("type", 202, "varname", "CreatedBy", "name", "CreatedBy", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["exch_rate"] = new XVar("type", 14, "varname", "exch_rate", "name", "exch_rate", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["grn_num"] = new XVar("type", 202, "varname", "grn_num", "name", "grn_num", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["InWorkflow"] = new XVar("type", 20, "varname", "InWorkflow", "name", "InWorkflow", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["NoteExistsFlag"] = new XVar("type", 20, "varname", "NoteExistsFlag", "name", "NoteExistsFlag", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["qty_ordered"] = new XVar("type", 14, "varname", "qty_ordered", "name", "qty_ordered", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["qty_received"] = new XVar("type", 14, "varname", "qty_received", "name", "qty_received", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["rcvd_amt"] = new XVar("type", 14, "varname", "rcvd_amt", "name", "rcvd_amt", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["RecordDate"] = new XVar("type", 135, "varname", "RecordDate", "name", "RecordDate", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["RowPointer"] = new XVar("type", 202, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["unit_cost"] = new XVar("type", 14, "varname", "unit_cost", "name", "unit_cost", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["UpdatedBy"] = new XVar("type", 202, "varname", "UpdatedBy", "name", "UpdatedBy", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["vch_amt"] = new XVar("type", 14, "varname", "vch_amt", "name", "vch_amt", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["voucher"] = new XVar("type", 20, "varname", "voucher", "name", "voucher", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["vouchered"] = new XVar("type", 20, "varname", "vouchered", "name", "vouchered", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["DLDeleteIndicator"] = new XVar("type", 20, "varname", "DLDeleteIndicator", "name", "DLDeleteIndicator", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["sc_id"] = new XVar("type", 202, "varname", "sc_id", "name", "sc_id", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["mg_id"] = new XVar("type", 202, "varname", "mg_id", "name", "mg_id", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["mg_posted"] = new XVar("type", 16, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["sf_posted"] = new XVar("type", 16, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablecsi_lc_rcpt_mst["sc_posted"] = new XVar("type", 16, "varname", "sc_posted", "name", "sc_posted", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_csi_lc_rcpt_mst"] = dalTablecsi_lc_rcpt_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_csi_lc_rcpt_mst()
        {
            			this.m_TableName = "dbo.csi_lc_rcpt_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_csi_lc_rcpt_mst";
        }
    }
}