using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_client_inv_items : tDALTable
    {
        public XVar clientid;
        public XVar app;
        public XVar item;
        public XVar description;
        public XVar u_m;
        public XVar rate;
        public XVar qty;
        public XVar discount;
        public XVar eff_date;
        public XVar term_date;
        public XVar bill_type;
        public static void Init()
        {
            XVar dalTablehk_client_inv_items = XVar.Array();
            dalTablehk_client_inv_items["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablehk_client_inv_items["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTablehk_client_inv_items["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTablehk_client_inv_items["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablehk_client_inv_items["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTablehk_client_inv_items["rate"] = new XVar("type", 14, "varname", "rate", "name", "rate", "autoInc", "0");
            dalTablehk_client_inv_items["qty"] = new XVar("type", 14, "varname", "qty", "name", "qty", "autoInc", "0");
            dalTablehk_client_inv_items["discount"] = new XVar("type", 14, "varname", "discount", "name", "discount", "autoInc", "0");
            dalTablehk_client_inv_items["eff_date"] = new XVar("type", 7, "varname", "eff_date", "name", "eff_date", "autoInc", "0");
            dalTablehk_client_inv_items["term_date"] = new XVar("type", 7, "varname", "term_date", "name", "term_date", "autoInc", "0");
            dalTablehk_client_inv_items["bill_type"] = new XVar("type", 202, "varname", "bill_type", "name", "bill_type", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_client_inv_items"] = dalTablehk_client_inv_items;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_client_inv_items()
        {
            			this.m_TableName = "dbo.hk_client_inv_items";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_client_inv_items";
        }
    }
}