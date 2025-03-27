using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sc_invoice_line_mst : tDALTable
    {
        public XVar seq_num;
        public XVar invoice_id;
        public XVar item;
        public XVar description;
        public XVar po_num;
        public XVar po_line;
        public XVar po_release;
        public XVar unit_price;
        public XVar qty;
        public XVar amt;
        public XVar tax_amt;
        public XVar acct;
        public XVar unit1;
        public XVar unit2;
        public XVar unit3;
        public XVar unit4;
        public XVar grn_num;
        public XVar grn_line;
        public XVar rowpointer;
        public XVar createdate;
        public XVar err_msg;
        public XVar terms_code;
        public XVar u_m;
        public XVar qtu_qty_received;
        public XVar qtu_qty_voucher;
        public XVar cpr_item_cost_conv;
        public XVar cpr_plan_cost_conv;
        public XVar site_ref;
        public XVar clientid;
        public XVar currency;
        public XVar taxcode_Externalid;
        public XVar GL_acc_name;
        public XVar GL_acc_num;
        public XVar trans_num;
        public XVar lineitemid;
        public XVar unit;
        public XVar Billable;
        public XVar sro_num;
        public XVar line;
        public XVar posted;
        public XVar line_percentage;
        public static void Init()
        {
            XVar dalTablesc_invoice_line_mst = XVar.Array();
            dalTablesc_invoice_line_mst["seq_num"] = new XVar("type", 3, "varname", "seq_num", "name", "seq_num", "autoInc", "0");
            dalTablesc_invoice_line_mst["invoice_id"] = new XVar("type", 202, "varname", "invoice_id", "name", "invoice_id", "autoInc", "0");
            dalTablesc_invoice_line_mst["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTablesc_invoice_line_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablesc_invoice_line_mst["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTablesc_invoice_line_mst["po_line"] = new XVar("type", 3, "varname", "po_line", "name", "po_line", "autoInc", "0");
            dalTablesc_invoice_line_mst["po_release"] = new XVar("type", 3, "varname", "po_release", "name", "po_release", "autoInc", "0");
            dalTablesc_invoice_line_mst["unit_price"] = new XVar("type", 14, "varname", "unit_price", "name", "unit_price", "autoInc", "0");
            dalTablesc_invoice_line_mst["qty"] = new XVar("type", 14, "varname", "qty", "name", "qty", "autoInc", "0");
            dalTablesc_invoice_line_mst["amt"] = new XVar("type", 14, "varname", "amt", "name", "amt", "autoInc", "0");
            dalTablesc_invoice_line_mst["tax_amt"] = new XVar("type", 14, "varname", "tax_amt", "name", "tax_amt", "autoInc", "0");
            dalTablesc_invoice_line_mst["acct"] = new XVar("type", 202, "varname", "acct", "name", "acct", "autoInc", "0");
            dalTablesc_invoice_line_mst["unit1"] = new XVar("type", 202, "varname", "unit1", "name", "unit1", "autoInc", "0");
            dalTablesc_invoice_line_mst["unit2"] = new XVar("type", 202, "varname", "unit2", "name", "unit2", "autoInc", "0");
            dalTablesc_invoice_line_mst["unit3"] = new XVar("type", 202, "varname", "unit3", "name", "unit3", "autoInc", "0");
            dalTablesc_invoice_line_mst["unit4"] = new XVar("type", 202, "varname", "unit4", "name", "unit4", "autoInc", "0");
            dalTablesc_invoice_line_mst["grn_num"] = new XVar("type", 202, "varname", "grn_num", "name", "grn_num", "autoInc", "0");
            dalTablesc_invoice_line_mst["grn_line"] = new XVar("type", 3, "varname", "grn_line", "name", "grn_line", "autoInc", "0");
            dalTablesc_invoice_line_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTablesc_invoice_line_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTablesc_invoice_line_mst["err_msg"] = new XVar("type", 202, "varname", "err_msg", "name", "err_msg", "autoInc", "0");
            dalTablesc_invoice_line_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablesc_invoice_line_mst["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTablesc_invoice_line_mst["qtu_qty_received"] = new XVar("type", 14, "varname", "qtu_qty_received", "name", "qtu_qty_received", "autoInc", "0");
            dalTablesc_invoice_line_mst["qtu_qty_voucher"] = new XVar("type", 14, "varname", "qtu_qty_voucher", "name", "qtu_qty_voucher", "autoInc", "0");
            dalTablesc_invoice_line_mst["cpr_item_cost_conv"] = new XVar("type", 14, "varname", "cpr_item_cost_conv", "name", "cpr_item_cost_conv", "autoInc", "0");
            dalTablesc_invoice_line_mst["cpr_plan_cost_conv"] = new XVar("type", 14, "varname", "cpr_plan_cost_conv", "name", "cpr_plan_cost_conv", "autoInc", "0");
            dalTablesc_invoice_line_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesc_invoice_line_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesc_invoice_line_mst["currency"] = new XVar("type", 202, "varname", "currency", "name", "currency", "autoInc", "0");
            dalTablesc_invoice_line_mst["taxcode_Externalid"] = new XVar("type", 202, "varname", "taxcode_Externalid", "name", "taxcode_Externalid", "autoInc", "0");
            dalTablesc_invoice_line_mst["GL_acc_name"] = new XVar("type", 202, "varname", "GL_acc_name", "name", "GL_acc_name", "autoInc", "0");
            dalTablesc_invoice_line_mst["GL_acc_num"] = new XVar("type", 202, "varname", "GL_acc_num", "name", "GL_acc_num", "autoInc", "0");
            dalTablesc_invoice_line_mst["trans_num"] = new XVar("type", 3, "varname", "trans_num", "name", "trans_num", "autoInc", "0");
            dalTablesc_invoice_line_mst["lineitemid"] = new XVar("type", 202, "varname", "lineitemid", "name", "lineitemid", "autoInc", "0");
            dalTablesc_invoice_line_mst["unit"] = new XVar("type", 202, "varname", "unit", "name", "unit", "autoInc", "0");
            dalTablesc_invoice_line_mst["Billable"] = new XVar("type", 202, "varname", "Billable", "name", "Billable", "autoInc", "0");
            dalTablesc_invoice_line_mst["sro_num"] = new XVar("type", 202, "varname", "sro_num", "name", "sro_num", "autoInc", "0");
            dalTablesc_invoice_line_mst["line"] = new XVar("type", 202, "varname", "line", "name", "line", "autoInc", "0");
            dalTablesc_invoice_line_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablesc_invoice_line_mst["line_percentage"] = new XVar("type", 14, "varname", "line_percentage", "name", "line_percentage", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sc_invoice_line_mst"] = dalTablesc_invoice_line_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sc_invoice_line_mst()
        {
            			this.m_TableName = "dbo.sc_invoice_line_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sc_invoice_line_mst";
        }
    }
}