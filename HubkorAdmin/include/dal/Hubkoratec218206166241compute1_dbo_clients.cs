using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_clients : tDALTable
    {
        public XVar id;
        public XVar name;
        public XVar shortcode;
        public XVar date_created;
        public XVar provision_date;
        public XVar termination_date;
        public XVar active;
        public XVar onprem;
        public XVar sf_auto_create_accounts;
        public XVar sf_bill_to_only_sync;
        public XVar sl_master_site;
        public XVar num_days_incoming;
        public XVar num_days_outgoing;
        public XVar uet_auto_map;
        public XVar tp_inv_acct;
        public XVar tp_vend_stat;
        public XVar account_manager;
        public XVar service_manager;
        public XVar project_manager;
        public XVar primary_contact;
        public XVar primary_email;
        public XVar primary_phone;
        public XVar invoice_cycle;
        public XVar effective_invoice;
        public XVar next_invoice;
        public XVar last_invoice;
        public XVar termination_invoice;
        public XVar terms_days;
        public XVar sc_expense_process;
        public XVar email_flash;
        public XVar tp_distribution_date;
        public XVar tp_post_unreceived_po;
        public XVar tp_posttype;
        public XVar NotConsiderItem;
        public XVar tp_multisite;
        public XVar tp_consider_inv_acct;
        public XVar Shipment_Type;
        public XVar tp_consider_external_email;
        public XVar tp_consider_decimals;
        public XVar ship_flag;
        public static void Init()
        {
            XVar dalTableclients = XVar.Array();
            dalTableclients["id"] = new XVar("type", 3, "varname", "id", "name", "id", "autoInc", "1");
            dalTableclients["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTableclients["shortcode"] = new XVar("type", 202, "varname", "shortcode", "name", "shortcode", "autoInc", "0");
            dalTableclients["date_created"] = new XVar("type", 7, "varname", "date_created", "name", "date_created", "autoInc", "0");
            dalTableclients["provision_date"] = new XVar("type", 7, "varname", "provision_date", "name", "provision_date", "autoInc", "0");
            dalTableclients["termination_date"] = new XVar("type", 7, "varname", "termination_date", "name", "termination_date", "autoInc", "0");
            dalTableclients["active"] = new XVar("type", 11, "varname", "active", "name", "active", "autoInc", "0");
            dalTableclients["onprem"] = new XVar("type", 16, "varname", "onprem", "name", "onprem", "autoInc", "0");
            dalTableclients["sf_auto_create_accounts"] = new XVar("type", 16, "varname", "sf_auto_create_accounts", "name", "sf_auto_create_accounts", "autoInc", "0");
            dalTableclients["sf_bill_to_only_sync"] = new XVar("type", 16, "varname", "sf_bill_to_only_sync", "name", "sf_bill_to_only_sync", "autoInc", "0");
            dalTableclients["sl_master_site"] = new XVar("type", 202, "varname", "sl_master_site", "name", "sl_master_site", "autoInc", "0");
            dalTableclients["num_days_incoming"] = new XVar("type", 3, "varname", "num_days_incoming", "name", "num_days_incoming", "autoInc", "0");
            dalTableclients["num_days_outgoing"] = new XVar("type", 3, "varname", "num_days_outgoing", "name", "num_days_outgoing", "autoInc", "0");
            dalTableclients["uet_auto_map"] = new XVar("type", 16, "varname", "uet_auto_map", "name", "uet_auto_map", "autoInc", "0");
            dalTableclients["tp_inv_acct"] = new XVar("type", 202, "varname", "tp_inv_acct", "name", "tp_inv_acct", "autoInc", "0");
            dalTableclients["tp_vend_stat"] = new XVar("type", 202, "varname", "tp_vend_stat", "name", "tp_vend_stat", "autoInc", "0");
            dalTableclients["account_manager"] = new XVar("type", 202, "varname", "account_manager", "name", "account_manager", "autoInc", "0");
            dalTableclients["service_manager"] = new XVar("type", 202, "varname", "service_manager", "name", "service_manager", "autoInc", "0");
            dalTableclients["project_manager"] = new XVar("type", 202, "varname", "project_manager", "name", "project_manager", "autoInc", "0");
            dalTableclients["primary_contact"] = new XVar("type", 202, "varname", "primary_contact", "name", "primary_contact", "autoInc", "0");
            dalTableclients["primary_email"] = new XVar("type", 202, "varname", "primary_email", "name", "primary_email", "autoInc", "0");
            dalTableclients["primary_phone"] = new XVar("type", 202, "varname", "primary_phone", "name", "primary_phone", "autoInc", "0");
            dalTableclients["invoice_cycle"] = new XVar("type", 202, "varname", "invoice_cycle", "name", "invoice_cycle", "autoInc", "0");
            dalTableclients["effective_invoice"] = new XVar("type", 7, "varname", "effective_invoice", "name", "effective_invoice", "autoInc", "0");
            dalTableclients["next_invoice"] = new XVar("type", 7, "varname", "next_invoice", "name", "next_invoice", "autoInc", "0");
            dalTableclients["last_invoice"] = new XVar("type", 7, "varname", "last_invoice", "name", "last_invoice", "autoInc", "0");
            dalTableclients["termination_invoice"] = new XVar("type", 7, "varname", "termination_invoice", "name", "termination_invoice", "autoInc", "0");
            dalTableclients["terms_days"] = new XVar("type", 3, "varname", "terms_days", "name", "terms_days", "autoInc", "0");
            dalTableclients["sc_expense_process"] = new XVar("type", 202, "varname", "sc_expense_process", "name", "sc_expense_process", "autoInc", "0");
            dalTableclients["email_flash"] = new XVar("type", 202, "varname", "email_flash", "name", "email_flash", "autoInc", "0");
            dalTableclients["tp_distribution_date"] = new XVar("type", 202, "varname", "tp_distribution_date", "name", "tp_distribution_date", "autoInc", "0");
            dalTableclients["tp_post_unreceived_po"] = new XVar("type", 16, "varname", "tp_post_unreceived_po", "name", "tp_post_unreceived_po", "autoInc", "0");
            dalTableclients["tp_posttype"] = new XVar("type", 202, "varname", "tp_posttype", "name", "tp_posttype", "autoInc", "0");
            dalTableclients["NotConsiderItem"] = new XVar("type", 16, "varname", "NotConsiderItem", "name", "NotConsiderItem", "autoInc", "0");
            dalTableclients["tp_multisite"] = new XVar("type", 16, "varname", "tp_multisite", "name", "tp_multisite", "autoInc", "0");
            dalTableclients["tp_consider_inv_acct"] = new XVar("type", 16, "varname", "tp_consider_inv_acct", "name", "tp_consider_inv_acct", "autoInc", "0");
            dalTableclients["Shipment_Type"] = new XVar("type", 202, "varname", "Shipment_Type", "name", "Shipment_Type", "autoInc", "0");
            dalTableclients["tp_consider_external_email"] = new XVar("type", 16, "varname", "tp_consider_external_email", "name", "tp_consider_external_email", "autoInc", "0");
            dalTableclients["tp_consider_decimals"] = new XVar("type", 16, "varname", "tp_consider_decimals", "name", "tp_consider_decimals", "autoInc", "0");
            dalTableclients["ship_flag"] = new XVar("type", 3, "varname", "ship_flag", "name", "ship_flag", "autoInc", "0");
	        dalTableclients.InitAndSetArrayItem(true, "shortcode", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_clients"] = dalTableclients;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_clients()
        {
            			this.m_TableName = "dbo.clients";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_clients";
        }
    }
}