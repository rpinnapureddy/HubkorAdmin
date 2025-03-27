using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sh_fulfillment_orders_mst : tDALTable
    {
        public XVar in_dex;
        public XVar clientid;
        public XVar order_id;
        public XVar site_ref;
        public XVar co_num;
        public XVar fulfill_id;
        public XVar fulfillment_status;
        public XVar fulfill_line_id;
        public XVar Quantity;
        public XVar tags;
        public XVar co_line;
        public XVar deliveryMethod;
        public static void Init()
        {
            XVar dalTablesh_fulfillment_orders_mst = XVar.Array();
            dalTablesh_fulfillment_orders_mst["in_dex"] = new XVar("type", 3, "varname", "in_dex", "name", "in_dex", "autoInc", "1");
            dalTablesh_fulfillment_orders_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["order_id"] = new XVar("type", 202, "varname", "order_id", "name", "order_id", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["co_num"] = new XVar("type", 202, "varname", "co_num", "name", "co_num", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["fulfill_id"] = new XVar("type", 202, "varname", "fulfill_id", "name", "fulfill_id", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["fulfillment_status"] = new XVar("type", 202, "varname", "fulfillment_status", "name", "fulfillment_status", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["fulfill_line_id"] = new XVar("type", 202, "varname", "fulfill_line_id", "name", "fulfill_line_id", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["Quantity"] = new XVar("type", 3, "varname", "Quantity", "name", "Quantity", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["tags"] = new XVar("type", 202, "varname", "tags", "name", "tags", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["co_line"] = new XVar("type", 3, "varname", "co_line", "name", "co_line", "autoInc", "0");
            dalTablesh_fulfillment_orders_mst["deliveryMethod"] = new XVar("type", 202, "varname", "deliveryMethod", "name", "deliveryMethod", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sh_fulfillment_orders_mst"] = dalTablesh_fulfillment_orders_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sh_fulfillment_orders_mst()
        {
            			this.m_TableName = "dbo.sh_fulfillment_orders_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sh_fulfillment_orders_mst";
        }
    }
}