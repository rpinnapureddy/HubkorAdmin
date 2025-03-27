using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_stores_mst : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar whse;
        public XVar cust_num;
        public XVar terms_code;
        public XVar ship_code;
        public XVar co_prefix;
        public XVar bank_code;
        public XVar invcategory;
        public XVar end_type;
        public XVar prepaid;
        public XVar id;
        public XVar code;
        public XVar tax_code1;
        public XVar frt_tax_code1;
        public XVar msc_tax_code1;
        public XVar line_tax_code1;
        public XVar website_id;
        public XVar locale;
        public XVar base_currency_code;
        public XVar default_display_currency_code;
        public XVar timezone;
        public XVar weight_unit;
        public XVar base_url;
        public XVar base_link_url;
        public XVar base_static_url;
        public XVar base_media_url;
        public XVar secure_base_url;
        public XVar secure_base_link_url;
        public XVar secure_base_static_url;
        public XVar secure_base_media_url;
        public XVar phone_number;
        public static void Init()
        {
            XVar dalTablemg_stores_mst = XVar.Array();
            dalTablemg_stores_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablemg_stores_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablemg_stores_mst["whse"] = new XVar("type", 202, "varname", "whse", "name", "whse", "autoInc", "0");
            dalTablemg_stores_mst["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTablemg_stores_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablemg_stores_mst["ship_code"] = new XVar("type", 202, "varname", "ship_code", "name", "ship_code", "autoInc", "0");
            dalTablemg_stores_mst["co_prefix"] = new XVar("type", 202, "varname", "co_prefix", "name", "co_prefix", "autoInc", "0");
            dalTablemg_stores_mst["bank_code"] = new XVar("type", 202, "varname", "bank_code", "name", "bank_code", "autoInc", "0");
            dalTablemg_stores_mst["invcategory"] = new XVar("type", 202, "varname", "invcategory", "name", "invcategory", "autoInc", "0");
            dalTablemg_stores_mst["end_type"] = new XVar("type", 202, "varname", "end_type", "name", "end_type", "autoInc", "0");
            dalTablemg_stores_mst["prepaid"] = new XVar("type", 16, "varname", "prepaid", "name", "prepaid", "autoInc", "0");
            dalTablemg_stores_mst["id"] = new XVar("type", 202, "varname", "id", "name", "id", "autoInc", "0");
            dalTablemg_stores_mst["code"] = new XVar("type", 202, "varname", "code", "name", "code", "autoInc", "0");
            dalTablemg_stores_mst["tax_code1"] = new XVar("type", 202, "varname", "tax_code1", "name", "tax_code1", "autoInc", "0");
            dalTablemg_stores_mst["frt_tax_code1"] = new XVar("type", 202, "varname", "frt_tax_code1", "name", "frt_tax_code1", "autoInc", "0");
            dalTablemg_stores_mst["msc_tax_code1"] = new XVar("type", 202, "varname", "msc_tax_code1", "name", "msc_tax_code1", "autoInc", "0");
            dalTablemg_stores_mst["line_tax_code1"] = new XVar("type", 202, "varname", "line_tax_code1", "name", "line_tax_code1", "autoInc", "0");
            dalTablemg_stores_mst["website_id"] = new XVar("type", 202, "varname", "website_id", "name", "website_id", "autoInc", "0");
            dalTablemg_stores_mst["locale"] = new XVar("type", 202, "varname", "locale", "name", "locale", "autoInc", "0");
            dalTablemg_stores_mst["base_currency_code"] = new XVar("type", 202, "varname", "base_currency_code", "name", "base_currency_code", "autoInc", "0");
            dalTablemg_stores_mst["default_display_currency_code"] = new XVar("type", 202, "varname", "default_display_currency_code", "name", "default_display_currency_code", "autoInc", "0");
            dalTablemg_stores_mst["timezone"] = new XVar("type", 202, "varname", "timezone", "name", "timezone", "autoInc", "0");
            dalTablemg_stores_mst["weight_unit"] = new XVar("type", 202, "varname", "weight_unit", "name", "weight_unit", "autoInc", "0");
            dalTablemg_stores_mst["base_url"] = new XVar("type", 202, "varname", "base_url", "name", "base_url", "autoInc", "0");
            dalTablemg_stores_mst["base_link_url"] = new XVar("type", 202, "varname", "base_link_url", "name", "base_link_url", "autoInc", "0");
            dalTablemg_stores_mst["base_static_url"] = new XVar("type", 202, "varname", "base_static_url", "name", "base_static_url", "autoInc", "0");
            dalTablemg_stores_mst["base_media_url"] = new XVar("type", 202, "varname", "base_media_url", "name", "base_media_url", "autoInc", "0");
            dalTablemg_stores_mst["secure_base_url"] = new XVar("type", 202, "varname", "secure_base_url", "name", "secure_base_url", "autoInc", "0");
            dalTablemg_stores_mst["secure_base_link_url"] = new XVar("type", 202, "varname", "secure_base_link_url", "name", "secure_base_link_url", "autoInc", "0");
            dalTablemg_stores_mst["secure_base_static_url"] = new XVar("type", 202, "varname", "secure_base_static_url", "name", "secure_base_static_url", "autoInc", "0");
            dalTablemg_stores_mst["secure_base_media_url"] = new XVar("type", 202, "varname", "secure_base_media_url", "name", "secure_base_media_url", "autoInc", "0");
            dalTablemg_stores_mst["phone_number"] = new XVar("type", 202, "varname", "phone_number", "name", "phone_number", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_stores_mst"] = dalTablemg_stores_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_stores_mst()
        {
            			this.m_TableName = "dbo.mg_stores_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_stores_mst";
        }
    }
}