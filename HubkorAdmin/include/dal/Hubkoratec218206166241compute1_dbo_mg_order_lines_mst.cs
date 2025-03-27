using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_order_lines_mst : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar co_num;
        public XVar co_line;
        public XVar item;
        public XVar description;
        public XVar qty_ordered;
        public XVar u_m;
        public XVar discount;
        public XVar price;
        public XVar whse;
        public XVar increment_id;
        public XVar due_date;
        public XVar tax_code1;
        public XVar item_id;
        public XVar product_type;
        public static void Init()
        {
            XVar dalTablemg_order_lines_mst = XVar.Array();
            dalTablemg_order_lines_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablemg_order_lines_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablemg_order_lines_mst["co_num"] = new XVar("type", 202, "varname", "co_num", "name", "co_num", "autoInc", "0");
            dalTablemg_order_lines_mst["co_line"] = new XVar("type", 3, "varname", "co_line", "name", "co_line", "autoInc", "0");
            dalTablemg_order_lines_mst["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTablemg_order_lines_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablemg_order_lines_mst["qty_ordered"] = new XVar("type", 3, "varname", "qty_ordered", "name", "qty_ordered", "autoInc", "0");
            dalTablemg_order_lines_mst["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTablemg_order_lines_mst["discount"] = new XVar("type", 14, "varname", "discount", "name", "discount", "autoInc", "0");
            dalTablemg_order_lines_mst["price"] = new XVar("type", 14, "varname", "price", "name", "price", "autoInc", "0");
            dalTablemg_order_lines_mst["whse"] = new XVar("type", 202, "varname", "whse", "name", "whse", "autoInc", "0");
            dalTablemg_order_lines_mst["increment_id"] = new XVar("type", 202, "varname", "increment_id", "name", "increment_id", "autoInc", "0");
            dalTablemg_order_lines_mst["due_date"] = new XVar("type", 7, "varname", "due_date", "name", "due_date", "autoInc", "0");
            dalTablemg_order_lines_mst["tax_code1"] = new XVar("type", 202, "varname", "tax_code1", "name", "tax_code1", "autoInc", "0");
            dalTablemg_order_lines_mst["item_id"] = new XVar("type", 202, "varname", "item_id", "name", "item_id", "autoInc", "0");
            dalTablemg_order_lines_mst["product_type"] = new XVar("type", 202, "varname", "product_type", "name", "product_type", "autoInc", "0");
	        dalTablemg_order_lines_mst.InitAndSetArrayItem(true, "clientid", "key");
	        dalTablemg_order_lines_mst.InitAndSetArrayItem(true, "site_ref", "key");
	        dalTablemg_order_lines_mst.InitAndSetArrayItem(true, "co_num", "key");
	        dalTablemg_order_lines_mst.InitAndSetArrayItem(true, "co_line", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_order_lines_mst"] = dalTablemg_order_lines_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_order_lines_mst()
        {
            			this.m_TableName = "dbo.mg_order_lines_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_order_lines_mst";
        }
    }
}