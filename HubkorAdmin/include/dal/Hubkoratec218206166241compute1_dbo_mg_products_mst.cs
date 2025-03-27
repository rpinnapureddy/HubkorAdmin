using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_products_mst : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar id;
        public XVar sku;
        public XVar attribute_set_id;
        public XVar price;
        public XVar status;
        public XVar visibility;
        public XVar type_id;
        public XVar created_at;
        public XVar updated_at;
        public XVar weight;
        public XVar custom_attributes;
        public static void Init()
        {
            XVar dalTablemg_products_mst = XVar.Array();
            dalTablemg_products_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablemg_products_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablemg_products_mst["id"] = new XVar("type", 202, "varname", "id", "name", "id", "autoInc", "0");
            dalTablemg_products_mst["sku"] = new XVar("type", 202, "varname", "sku", "name", "sku", "autoInc", "0");
            dalTablemg_products_mst["attribute_set_id"] = new XVar("type", 202, "varname", "attribute_set_id", "name", "attribute_set_id", "autoInc", "0");
            dalTablemg_products_mst["price"] = new XVar("type", 14, "varname", "price", "name", "price", "autoInc", "0");
            dalTablemg_products_mst["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            dalTablemg_products_mst["visibility"] = new XVar("type", 202, "varname", "visibility", "name", "visibility", "autoInc", "0");
            dalTablemg_products_mst["type_id"] = new XVar("type", 202, "varname", "type_id", "name", "type_id", "autoInc", "0");
            dalTablemg_products_mst["created_at"] = new XVar("type", 202, "varname", "created_at", "name", "created_at", "autoInc", "0");
            dalTablemg_products_mst["updated_at"] = new XVar("type", 202, "varname", "updated_at", "name", "updated_at", "autoInc", "0");
            dalTablemg_products_mst["weight"] = new XVar("type", 202, "varname", "weight", "name", "weight", "autoInc", "0");
            dalTablemg_products_mst["custom_attributes"] = new XVar("type", 202, "varname", "custom_attributes", "name", "custom_attributes", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_products_mst"] = dalTablemg_products_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_products_mst()
        {
            			this.m_TableName = "dbo.mg_products_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_products_mst";
        }
    }
}