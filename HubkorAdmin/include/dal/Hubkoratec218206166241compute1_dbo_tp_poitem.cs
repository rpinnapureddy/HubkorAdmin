using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_poitem : tDALTable
    {
        public XVar clientid;
        public XVar po_num;
        public XVar po_line;
        public XVar po_release;
        public XVar site_ref;
        public XVar description;
        public XVar due_date;
        public XVar item;
        public XVar item_cost;
        public XVar item_cost_conv;
        public XVar non_inv_acct;
        public XVar non_inv_acct_unit1;
        public XVar non_inv_acct_unit2;
        public XVar non_inv_acct_unit3;
        public XVar non_inv_acct_unit4;
        public XVar plan_cost;
        public XVar plan_cost_conv;
        public XVar qty_ordered;
        public XVar qty_ordered_conv;
        public XVar qty_received;
        public XVar qty_voucher;
        public XVar rcvd_date;
        public XVar RecordDate;
        public XVar RowPointer;
        public XVar stat;
        public XVar u_m;
        public XVar unit_mat_cost;
        public XVar unit_mat_cost_conv;
        public XVar vend_item;
        public XVar voucher_cost;
        public XVar whse;
        public XVar DLDeleteIndicator;
        public XVar tp_id;
        public XVar tp_posted;
        public XVar CreateDate;
        public XVar tp_item_cost;
        public static void Init()
        {
            XVar dalTabletp_poitem = XVar.Array();
            dalTabletp_poitem["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_poitem["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTabletp_poitem["po_line"] = new XVar("type", 20, "varname", "po_line", "name", "po_line", "autoInc", "0");
            dalTabletp_poitem["po_release"] = new XVar("type", 20, "varname", "po_release", "name", "po_release", "autoInc", "0");
            dalTabletp_poitem["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_poitem["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTabletp_poitem["due_date"] = new XVar("type", 135, "varname", "due_date", "name", "due_date", "autoInc", "0");
            dalTabletp_poitem["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTabletp_poitem["item_cost"] = new XVar("type", 14, "varname", "item_cost", "name", "item_cost", "autoInc", "0");
            dalTabletp_poitem["item_cost_conv"] = new XVar("type", 14, "varname", "item_cost_conv", "name", "item_cost_conv", "autoInc", "0");
            dalTabletp_poitem["non_inv_acct"] = new XVar("type", 202, "varname", "non_inv_acct", "name", "non_inv_acct", "autoInc", "0");
            dalTabletp_poitem["non_inv_acct_unit1"] = new XVar("type", 202, "varname", "non_inv_acct_unit1", "name", "non_inv_acct_unit1", "autoInc", "0");
            dalTabletp_poitem["non_inv_acct_unit2"] = new XVar("type", 202, "varname", "non_inv_acct_unit2", "name", "non_inv_acct_unit2", "autoInc", "0");
            dalTabletp_poitem["non_inv_acct_unit3"] = new XVar("type", 202, "varname", "non_inv_acct_unit3", "name", "non_inv_acct_unit3", "autoInc", "0");
            dalTabletp_poitem["non_inv_acct_unit4"] = new XVar("type", 202, "varname", "non_inv_acct_unit4", "name", "non_inv_acct_unit4", "autoInc", "0");
            dalTabletp_poitem["plan_cost"] = new XVar("type", 14, "varname", "plan_cost", "name", "plan_cost", "autoInc", "0");
            dalTabletp_poitem["plan_cost_conv"] = new XVar("type", 14, "varname", "plan_cost_conv", "name", "plan_cost_conv", "autoInc", "0");
            dalTabletp_poitem["qty_ordered"] = new XVar("type", 14, "varname", "qty_ordered", "name", "qty_ordered", "autoInc", "0");
            dalTabletp_poitem["qty_ordered_conv"] = new XVar("type", 14, "varname", "qty_ordered_conv", "name", "qty_ordered_conv", "autoInc", "0");
            dalTabletp_poitem["qty_received"] = new XVar("type", 14, "varname", "qty_received", "name", "qty_received", "autoInc", "0");
            dalTabletp_poitem["qty_voucher"] = new XVar("type", 14, "varname", "qty_voucher", "name", "qty_voucher", "autoInc", "0");
            dalTabletp_poitem["rcvd_date"] = new XVar("type", 135, "varname", "rcvd_date", "name", "rcvd_date", "autoInc", "0");
            dalTabletp_poitem["RecordDate"] = new XVar("type", 135, "varname", "RecordDate", "name", "RecordDate", "autoInc", "0");
            dalTabletp_poitem["RowPointer"] = new XVar("type", 202, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTabletp_poitem["stat"] = new XVar("type", 202, "varname", "stat", "name", "stat", "autoInc", "0");
            dalTabletp_poitem["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTabletp_poitem["unit_mat_cost"] = new XVar("type", 14, "varname", "unit_mat_cost", "name", "unit_mat_cost", "autoInc", "0");
            dalTabletp_poitem["unit_mat_cost_conv"] = new XVar("type", 14, "varname", "unit_mat_cost_conv", "name", "unit_mat_cost_conv", "autoInc", "0");
            dalTabletp_poitem["vend_item"] = new XVar("type", 202, "varname", "vend_item", "name", "vend_item", "autoInc", "0");
            dalTabletp_poitem["voucher_cost"] = new XVar("type", 14, "varname", "voucher_cost", "name", "voucher_cost", "autoInc", "0");
            dalTabletp_poitem["whse"] = new XVar("type", 202, "varname", "whse", "name", "whse", "autoInc", "0");
            dalTabletp_poitem["DLDeleteIndicator"] = new XVar("type", 20, "varname", "DLDeleteIndicator", "name", "DLDeleteIndicator", "autoInc", "0");
            dalTabletp_poitem["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTabletp_poitem["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTabletp_poitem["CreateDate"] = new XVar("type", 135, "varname", "CreateDate", "name", "CreateDate", "autoInc", "0");
            dalTabletp_poitem["tp_item_cost"] = new XVar("type", 14, "varname", "tp_item_cost", "name", "tp_item_cost", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_poitem"] = dalTabletp_poitem;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_poitem()
        {
            			this.m_TableName = "dbo.tp_poitem";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_poitem";
        }
    }
}