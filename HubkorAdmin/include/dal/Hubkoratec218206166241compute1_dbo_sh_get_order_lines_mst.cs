using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sh_get_order_lines_mst : tDALTable
    {
        public XVar in_dex;
        public XVar clientid;
        public XVar VariationNumber;
        public XVar Name;
        public XVar Quantity;
        public XVar Sku;
        public XVar site_ref;
        public XVar co_num;
        public XVar co_line;
        public XVar Vendor;
        public XVar VariantTitle;
        public XVar Amount;
        public XVar tp_id;
        public XVar tp_posted;
        public XVar sc_id;
        public XVar sc_posted;
        public XVar sf_id;
        public XVar sf_posted;
        public XVar mg_id;
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
        public XVar L_id;
        public XVar mg_posted;
        public XVar item_id;
        public XVar OriginalTotal;
        public XVar TotalDiscount;
        public XVar CurrencyCode;
        public XVar tax_code1;
        public XVar fulfill_id;
        public XVar Fulfill_status;
        public XVar fulfill_line_id;
        public XVar Total_Quantity;
        public XVar sh_posted;
        public XVar u_m;
        public static void Init()
        {
            XVar dalTablesh_get_order_lines_mst = XVar.Array();
            dalTablesh_get_order_lines_mst["in_dex"] = new XVar("type", 3, "varname", "in_dex", "name", "in_dex", "autoInc", "1");
            dalTablesh_get_order_lines_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesh_get_order_lines_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Name"] = new XVar("type", 202, "varname", "Name", "name", "Name", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Quantity"] = new XVar("type", 3, "varname", "Quantity", "name", "Quantity", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Sku"] = new XVar("type", 202, "varname", "Sku", "name", "Sku", "autoInc", "0");
            dalTablesh_get_order_lines_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesh_get_order_lines_mst["co_num"] = new XVar("type", 202, "varname", "co_num", "name", "co_num", "autoInc", "0");
            dalTablesh_get_order_lines_mst["co_line"] = new XVar("type", 3, "varname", "co_line", "name", "co_line", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Vendor"] = new XVar("type", 202, "varname", "Vendor", "name", "Vendor", "autoInc", "0");
            dalTablesh_get_order_lines_mst["VariantTitle"] = new XVar("type", 202, "varname", "VariantTitle", "name", "VariantTitle", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Amount"] = new XVar("type", 202, "varname", "Amount", "name", "Amount", "autoInc", "0");
            dalTablesh_get_order_lines_mst["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTablesh_get_order_lines_mst["sc_id"] = new XVar("type", 202, "varname", "sc_id", "name", "sc_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["sc_posted"] = new XVar("type", 16, "varname", "sc_posted", "name", "sc_posted", "autoInc", "0");
            dalTablesh_get_order_lines_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["sf_posted"] = new XVar("type", 16, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablesh_get_order_lines_mst["mg_id"] = new XVar("type", 202, "varname", "mg_id", "name", "mg_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablesh_get_order_lines_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            dalTablesh_get_order_lines_mst["L_id"] = new XVar("type", 202, "varname", "L_id", "name", "L_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["mg_posted"] = new XVar("type", 16, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablesh_get_order_lines_mst["item_id"] = new XVar("type", 202, "varname", "item_id", "name", "item_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["OriginalTotal"] = new XVar("type", 14, "varname", "OriginalTotal", "name", "OriginalTotal", "autoInc", "0");
            dalTablesh_get_order_lines_mst["TotalDiscount"] = new XVar("type", 14, "varname", "TotalDiscount", "name", "TotalDiscount", "autoInc", "0");
            dalTablesh_get_order_lines_mst["CurrencyCode"] = new XVar("type", 202, "varname", "CurrencyCode", "name", "CurrencyCode", "autoInc", "0");
            dalTablesh_get_order_lines_mst["tax_code1"] = new XVar("type", 202, "varname", "tax_code1", "name", "tax_code1", "autoInc", "0");
            dalTablesh_get_order_lines_mst["fulfill_id"] = new XVar("type", 202, "varname", "fulfill_id", "name", "fulfill_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Fulfill_status"] = new XVar("type", 202, "varname", "Fulfill_status", "name", "Fulfill_status", "autoInc", "0");
            dalTablesh_get_order_lines_mst["fulfill_line_id"] = new XVar("type", 202, "varname", "fulfill_line_id", "name", "fulfill_line_id", "autoInc", "0");
            dalTablesh_get_order_lines_mst["Total_Quantity"] = new XVar("type", 3, "varname", "Total_Quantity", "name", "Total_Quantity", "autoInc", "0");
            dalTablesh_get_order_lines_mst["sh_posted"] = new XVar("type", 16, "varname", "sh_posted", "name", "sh_posted", "autoInc", "0");
            dalTablesh_get_order_lines_mst["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
	        dalTablesh_get_order_lines_mst.InitAndSetArrayItem(true, "clientid", "key");
	        dalTablesh_get_order_lines_mst.InitAndSetArrayItem(true, "site_ref", "key");
	        dalTablesh_get_order_lines_mst.InitAndSetArrayItem(true, "co_num", "key");
	        dalTablesh_get_order_lines_mst.InitAndSetArrayItem(true, "in_dex", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sh_get_order_lines_mst"] = dalTablesh_get_order_lines_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sh_get_order_lines_mst()
        {
            			this.m_TableName = "dbo.sh_get_order_lines_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sh_get_order_lines_mst";
        }
    }
}