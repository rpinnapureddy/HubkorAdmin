using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sh_products_mst : tDALTable
    {
        public XVar clientid;
        public XVar id;
        public XVar price;
        public XVar quantity;
        public XVar item;
        public XVar title;
        public XVar posted;
        public XVar location_name;
        public XVar rowpointer;
        public XVar create_date;
        public XVar trans_num;
        public XVar jresult;
        public XVar site_ref;
        public static void Init()
        {
            XVar dalTablesh_products_mst = XVar.Array();
            dalTablesh_products_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesh_products_mst["id"] = new XVar("type", 202, "varname", "id", "name", "id", "autoInc", "0");
            dalTablesh_products_mst["price"] = new XVar("type", 14, "varname", "price", "name", "price", "autoInc", "0");
            dalTablesh_products_mst["quantity"] = new XVar("type", 3, "varname", "quantity", "name", "quantity", "autoInc", "0");
            dalTablesh_products_mst["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTablesh_products_mst["title"] = new XVar("type", 202, "varname", "title", "name", "title", "autoInc", "0");
            dalTablesh_products_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablesh_products_mst["location_name"] = new XVar("type", 202, "varname", "location_name", "name", "location_name", "autoInc", "0");
            dalTablesh_products_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTablesh_products_mst["create_date"] = new XVar("type", 135, "varname", "create_date", "name", "create_date", "autoInc", "0");
            dalTablesh_products_mst["trans_num"] = new XVar("type", 3, "varname", "trans_num", "name", "trans_num", "autoInc", "1");
            dalTablesh_products_mst["jresult"] = new XVar("type", 202, "varname", "jresult", "name", "jresult", "autoInc", "0");
            dalTablesh_products_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sh_products_mst"] = dalTablesh_products_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sh_products_mst()
        {
            			this.m_TableName = "dbo.sh_products_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sh_products_mst";
        }
    }
}