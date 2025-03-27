using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sf_customer_master : tDALTable
    {
        public XVar clientid;
        public XVar sf_posted;
        public XVar mg_posted;
        public XVar cust_num;
        public XVar cust_seq;
        public XVar name;
        public XVar city;
        public XVar state;
        public XVar zip;
        public XVar country;
        public XVar county;
        public XVar address;
        public XVar contact1;
        public XVar phone1;
        public XVar contact2;
        public XVar phone2;
        public XVar contact3;
        public XVar phone3;
        public XVar credit_limit;
        public XVar terms_code;
        public XVar curr_code;
        public XVar ship_to_email;
        public XVar bill_to_email;
        public XVar internet_url;
        public XVar internal_email_addr;
        public XVar external_email_addr;
        public XVar RowPointer;
        public XVar sf_id;
        public XVar accountnumber;
        public XVar parentaccount;
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
        public XVar site_ref;
        public XVar SalesForceID_Uf;
        public XVar err_message;
        public XVar order_bal;
        public XVar sales_ytd;
        public XVar sales_lst_yr;
        public XVar posted_bal;
        public XVar parent_account;
        public XVar slsman;
        public XVar cust_type;
        public XVar pricecode;
        public XVar DLDeleteIndicator;
        public XVar VariationNumber;
        public static void Init()
        {
            XVar dalTablesf_customer_master = XVar.Array();
            dalTablesf_customer_master["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesf_customer_master["sf_posted"] = new XVar("type", 3, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablesf_customer_master["mg_posted"] = new XVar("type", 3, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablesf_customer_master["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTablesf_customer_master["cust_seq"] = new XVar("type", 20, "varname", "cust_seq", "name", "cust_seq", "autoInc", "0");
            dalTablesf_customer_master["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTablesf_customer_master["city"] = new XVar("type", 202, "varname", "city", "name", "city", "autoInc", "0");
            dalTablesf_customer_master["state"] = new XVar("type", 202, "varname", "state", "name", "state", "autoInc", "0");
            dalTablesf_customer_master["zip"] = new XVar("type", 202, "varname", "zip", "name", "zip", "autoInc", "0");
            dalTablesf_customer_master["country"] = new XVar("type", 202, "varname", "country", "name", "country", "autoInc", "0");
            dalTablesf_customer_master["county"] = new XVar("type", 202, "varname", "county", "name", "county", "autoInc", "0");
            dalTablesf_customer_master["address"] = new XVar("type", 202, "varname", "address", "name", "address", "autoInc", "0");
            dalTablesf_customer_master["contact1"] = new XVar("type", 202, "varname", "contact1", "name", "contact1", "autoInc", "0");
            dalTablesf_customer_master["phone1"] = new XVar("type", 202, "varname", "phone1", "name", "phone1", "autoInc", "0");
            dalTablesf_customer_master["contact2"] = new XVar("type", 202, "varname", "contact2", "name", "contact2", "autoInc", "0");
            dalTablesf_customer_master["phone2"] = new XVar("type", 202, "varname", "phone2", "name", "phone2", "autoInc", "0");
            dalTablesf_customer_master["contact3"] = new XVar("type", 202, "varname", "contact3", "name", "contact3", "autoInc", "0");
            dalTablesf_customer_master["phone3"] = new XVar("type", 202, "varname", "phone3", "name", "phone3", "autoInc", "0");
            dalTablesf_customer_master["credit_limit"] = new XVar("type", 14, "varname", "credit_limit", "name", "credit_limit", "autoInc", "0");
            dalTablesf_customer_master["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablesf_customer_master["curr_code"] = new XVar("type", 202, "varname", "curr_code", "name", "curr_code", "autoInc", "0");
            dalTablesf_customer_master["ship_to_email"] = new XVar("type", 202, "varname", "ship_to_email", "name", "ship_to_email", "autoInc", "0");
            dalTablesf_customer_master["bill_to_email"] = new XVar("type", 202, "varname", "bill_to_email", "name", "bill_to_email", "autoInc", "0");
            dalTablesf_customer_master["internet_url"] = new XVar("type", 202, "varname", "internet_url", "name", "internet_url", "autoInc", "0");
            dalTablesf_customer_master["internal_email_addr"] = new XVar("type", 202, "varname", "internal_email_addr", "name", "internal_email_addr", "autoInc", "0");
            dalTablesf_customer_master["external_email_addr"] = new XVar("type", 202, "varname", "external_email_addr", "name", "external_email_addr", "autoInc", "0");
            dalTablesf_customer_master["RowPointer"] = new XVar("type", 72, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTablesf_customer_master["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablesf_customer_master["accountnumber"] = new XVar("type", 202, "varname", "accountnumber", "name", "accountnumber", "autoInc", "0");
            dalTablesf_customer_master["parentaccount"] = new XVar("type", 202, "varname", "parentaccount", "name", "parentaccount", "autoInc", "0");
            dalTablesf_customer_master["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablesf_customer_master["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablesf_customer_master["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablesf_customer_master["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablesf_customer_master["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablesf_customer_master["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablesf_customer_master["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablesf_customer_master["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablesf_customer_master["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablesf_customer_master["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            dalTablesf_customer_master["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesf_customer_master["SalesForceID_Uf"] = new XVar("type", 202, "varname", "SalesForceID_Uf", "name", "SalesForceID_Uf", "autoInc", "0");
            dalTablesf_customer_master["err_message"] = new XVar("type", 202, "varname", "err_message", "name", "err_message", "autoInc", "0");
            dalTablesf_customer_master["order_bal"] = new XVar("type", 14, "varname", "order_bal", "name", "order_bal", "autoInc", "0");
            dalTablesf_customer_master["sales_ytd"] = new XVar("type", 14, "varname", "sales_ytd", "name", "sales_ytd", "autoInc", "0");
            dalTablesf_customer_master["sales_lst_yr"] = new XVar("type", 14, "varname", "sales_lst_yr", "name", "sales_lst_yr", "autoInc", "0");
            dalTablesf_customer_master["posted_bal"] = new XVar("type", 14, "varname", "posted_bal", "name", "posted_bal", "autoInc", "0");
            dalTablesf_customer_master["parent_account"] = new XVar("type", 202, "varname", "parent_account", "name", "parent_account", "autoInc", "0");
            dalTablesf_customer_master["slsman"] = new XVar("type", 202, "varname", "slsman", "name", "slsman", "autoInc", "0");
            dalTablesf_customer_master["cust_type"] = new XVar("type", 202, "varname", "cust_type", "name", "cust_type", "autoInc", "0");
            dalTablesf_customer_master["pricecode"] = new XVar("type", 202, "varname", "pricecode", "name", "pricecode", "autoInc", "0");
            dalTablesf_customer_master["DLDeleteIndicator"] = new XVar("type", 20, "varname", "DLDeleteIndicator", "name", "DLDeleteIndicator", "autoInc", "0");
            dalTablesf_customer_master["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sf_customer_master"] = dalTablesf_customer_master;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sf_customer_master()
        {
            			this.m_TableName = "dbo.sf_customer_master";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sf_customer_master";
        }
    }
}