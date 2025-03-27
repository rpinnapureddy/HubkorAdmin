using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_po : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar po_num;
        public XVar stat;
        public XVar vend_num;
        public XVar name;
        public XVar order_date;
        public XVar vend_order;
        public XVar whse;
        public XVar po_cost;
        public XVar tp_posted;
        public XVar inv_num;
        public XVar inv_date;
        public XVar curr_code;
        public XVar dist_date;
        public XVar exch_rate;
        public XVar received;
        public XVar PendInv;
        public XVar CreateDate;
        public XVar RecordDate;
        public XVar tp_posted_date;
        public XVar tp_rev;
        public XVar firstrcvd;
        public XVar lastrcvd;
        public XVar tp_closed;
        public static void Init()
        {
            XVar dalTabletp_po = XVar.Array();
            dalTabletp_po["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_po["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_po["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTabletp_po["stat"] = new XVar("type", 202, "varname", "stat", "name", "stat", "autoInc", "0");
            dalTabletp_po["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTabletp_po["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTabletp_po["order_date"] = new XVar("type", 135, "varname", "order_date", "name", "order_date", "autoInc", "0");
            dalTabletp_po["vend_order"] = new XVar("type", 202, "varname", "vend_order", "name", "vend_order", "autoInc", "0");
            dalTabletp_po["whse"] = new XVar("type", 202, "varname", "whse", "name", "whse", "autoInc", "0");
            dalTabletp_po["po_cost"] = new XVar("type", 14, "varname", "po_cost", "name", "po_cost", "autoInc", "0");
            dalTabletp_po["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTabletp_po["inv_num"] = new XVar("type", 202, "varname", "inv_num", "name", "inv_num", "autoInc", "0");
            dalTabletp_po["inv_date"] = new XVar("type", 135, "varname", "inv_date", "name", "inv_date", "autoInc", "0");
            dalTabletp_po["curr_code"] = new XVar("type", 202, "varname", "curr_code", "name", "curr_code", "autoInc", "0");
            dalTabletp_po["dist_date"] = new XVar("type", 135, "varname", "dist_date", "name", "dist_date", "autoInc", "0");
            dalTabletp_po["exch_rate"] = new XVar("type", 14, "varname", "exch_rate", "name", "exch_rate", "autoInc", "0");
            dalTabletp_po["received"] = new XVar("type", 20, "varname", "received", "name", "received", "autoInc", "0");
            dalTabletp_po["PendInv"] = new XVar("type", 3, "varname", "PendInv", "name", "PendInv", "autoInc", "0");
            dalTabletp_po["CreateDate"] = new XVar("type", 135, "varname", "CreateDate", "name", "CreateDate", "autoInc", "0");
            dalTabletp_po["RecordDate"] = new XVar("type", 135, "varname", "RecordDate", "name", "RecordDate", "autoInc", "0");
            dalTabletp_po["tp_posted_date"] = new XVar("type", 135, "varname", "tp_posted_date", "name", "tp_posted_date", "autoInc", "0");
            dalTabletp_po["tp_rev"] = new XVar("type", 3, "varname", "tp_rev", "name", "tp_rev", "autoInc", "0");
            dalTabletp_po["firstrcvd"] = new XVar("type", 135, "varname", "firstrcvd", "name", "firstrcvd", "autoInc", "0");
            dalTabletp_po["lastrcvd"] = new XVar("type", 135, "varname", "lastrcvd", "name", "lastrcvd", "autoInc", "0");
            dalTabletp_po["tp_closed"] = new XVar("type", 16, "varname", "tp_closed", "name", "tp_closed", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_po"] = dalTabletp_po;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_po()
        {
            			this.m_TableName = "dbo.tp_po";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_po";
        }
    }
}