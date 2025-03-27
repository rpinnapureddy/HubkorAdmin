using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sh_stores_mst : tDALTable
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
        public XVar locale;
        public XVar shop_currency_code;
        public XVar tax_code1;
        public XVar frt_tax_code1;
        public XVar msc_tax_code1;
        public XVar default_display_currency_code;
        public XVar base_currency_code;
        public XVar id;
        public XVar line_tax_code1;
        public XVar version_sh;
        public XVar shop_name;
        public XVar store_name;
        public XVar shipment_type;
        public XVar check_only_item_and_whse;
        public XVar use_itemloc_mst;
        public static void Init()
        {
            XVar dalTablesh_stores_mst = XVar.Array();
            dalTablesh_stores_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesh_stores_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesh_stores_mst["whse"] = new XVar("type", 202, "varname", "whse", "name", "whse", "autoInc", "0");
            dalTablesh_stores_mst["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTablesh_stores_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablesh_stores_mst["ship_code"] = new XVar("type", 202, "varname", "ship_code", "name", "ship_code", "autoInc", "0");
            dalTablesh_stores_mst["co_prefix"] = new XVar("type", 202, "varname", "co_prefix", "name", "co_prefix", "autoInc", "0");
            dalTablesh_stores_mst["bank_code"] = new XVar("type", 202, "varname", "bank_code", "name", "bank_code", "autoInc", "0");
            dalTablesh_stores_mst["invcategory"] = new XVar("type", 202, "varname", "invcategory", "name", "invcategory", "autoInc", "0");
            dalTablesh_stores_mst["end_type"] = new XVar("type", 202, "varname", "end_type", "name", "end_type", "autoInc", "0");
            dalTablesh_stores_mst["prepaid"] = new XVar("type", 16, "varname", "prepaid", "name", "prepaid", "autoInc", "0");
            dalTablesh_stores_mst["locale"] = new XVar("type", 202, "varname", "locale", "name", "locale", "autoInc", "0");
            dalTablesh_stores_mst["shop_currency_code"] = new XVar("type", 202, "varname", "shop_currency_code", "name", "shop_currency_code", "autoInc", "0");
            dalTablesh_stores_mst["tax_code1"] = new XVar("type", 202, "varname", "tax_code1", "name", "tax_code1", "autoInc", "0");
            dalTablesh_stores_mst["frt_tax_code1"] = new XVar("type", 202, "varname", "frt_tax_code1", "name", "frt_tax_code1", "autoInc", "0");
            dalTablesh_stores_mst["msc_tax_code1"] = new XVar("type", 202, "varname", "msc_tax_code1", "name", "msc_tax_code1", "autoInc", "0");
            dalTablesh_stores_mst["default_display_currency_code"] = new XVar("type", 202, "varname", "default_display_currency_code", "name", "default_display_currency_code", "autoInc", "0");
            dalTablesh_stores_mst["base_currency_code"] = new XVar("type", 202, "varname", "base_currency_code", "name", "base_currency_code", "autoInc", "0");
            dalTablesh_stores_mst["id"] = new XVar("type", 202, "varname", "id", "name", "id", "autoInc", "0");
            dalTablesh_stores_mst["line_tax_code1"] = new XVar("type", 202, "varname", "line_tax_code1", "name", "line_tax_code1", "autoInc", "0");
            dalTablesh_stores_mst["version_sh"] = new XVar("type", 200, "varname", "version_sh", "name", "version_sh", "autoInc", "0");
            dalTablesh_stores_mst["shop_name"] = new XVar("type", 202, "varname", "shop_name", "name", "shop_name", "autoInc", "0");
            dalTablesh_stores_mst["store_name"] = new XVar("type", 202, "varname", "store_name", "name", "store_name", "autoInc", "0");
            dalTablesh_stores_mst["shipment_type"] = new XVar("type", 202, "varname", "shipment_type", "name", "shipment_type", "autoInc", "0");
            dalTablesh_stores_mst["check_only_item_and_whse"] = new XVar("type", 11, "varname", "check_only_item_and_whse", "name", "check_only_item_and_whse", "autoInc", "0");
            dalTablesh_stores_mst["use_itemloc_mst"] = new XVar("type", 11, "varname", "use_itemloc_mst", "name", "use_itemloc_mst", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sh_stores_mst"] = dalTablesh_stores_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sh_stores_mst()
        {
            			this.m_TableName = "dbo.sh_stores_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sh_stores_mst";
        }
    }
}