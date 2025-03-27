using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_order_line_mst : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar increment_id;
        public XVar store_id;
        public XVar item_id;
        public XVar sku;
        public XVar qty_ordered;
        public XVar row_total;
        public XVar discount_amount;
        public XVar price;
        public XVar original_price;
        public XVar qty_shipped;
        public XVar qty_canceled;
        public XVar product_option;
        public XVar name;
        public XVar product_type;
        public static void Init()
        {
            XVar dalTablemg_order_line_mst = XVar.Array();
            dalTablemg_order_line_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablemg_order_line_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablemg_order_line_mst["increment_id"] = new XVar("type", 202, "varname", "increment_id", "name", "increment_id", "autoInc", "0");
            dalTablemg_order_line_mst["store_id"] = new XVar("type", 202, "varname", "store_id", "name", "store_id", "autoInc", "0");
            dalTablemg_order_line_mst["item_id"] = new XVar("type", 202, "varname", "item_id", "name", "item_id", "autoInc", "0");
            dalTablemg_order_line_mst["sku"] = new XVar("type", 202, "varname", "sku", "name", "sku", "autoInc", "0");
            dalTablemg_order_line_mst["qty_ordered"] = new XVar("type", 3, "varname", "qty_ordered", "name", "qty_ordered", "autoInc", "0");
            dalTablemg_order_line_mst["row_total"] = new XVar("type", 14, "varname", "row_total", "name", "row_total", "autoInc", "0");
            dalTablemg_order_line_mst["discount_amount"] = new XVar("type", 14, "varname", "discount_amount", "name", "discount_amount", "autoInc", "0");
            dalTablemg_order_line_mst["price"] = new XVar("type", 14, "varname", "price", "name", "price", "autoInc", "0");
            dalTablemg_order_line_mst["original_price"] = new XVar("type", 14, "varname", "original_price", "name", "original_price", "autoInc", "0");
            dalTablemg_order_line_mst["qty_shipped"] = new XVar("type", 3, "varname", "qty_shipped", "name", "qty_shipped", "autoInc", "0");
            dalTablemg_order_line_mst["qty_canceled"] = new XVar("type", 3, "varname", "qty_canceled", "name", "qty_canceled", "autoInc", "0");
            dalTablemg_order_line_mst["product_option"] = new XVar("type", 202, "varname", "product_option", "name", "product_option", "autoInc", "0");
            dalTablemg_order_line_mst["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTablemg_order_line_mst["product_type"] = new XVar("type", 202, "varname", "product_type", "name", "product_type", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_order_line_mst"] = dalTablemg_order_line_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_order_line_mst()
        {
            			this.m_TableName = "dbo.mg_order_line_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_order_line_mst";
        }
    }
}