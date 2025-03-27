using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_po_rcpt : tDALTable
    {
        public XVar clientid;
        public XVar po_num;
        public XVar po_line;
        public XVar po_release;
        public XVar rcvd_date;
        public XVar date_seq;
        public XVar site_ref;
        public XVar exch_rate;
        public XVar item_cost;
        public XVar pack_num;
        public XVar qty_received;
        public XVar qty_returned;
        public XVar qty_vouchered;
        public XVar tp_posted;
        public static void Init()
        {
            XVar dalTabletp_po_rcpt = XVar.Array();
            dalTabletp_po_rcpt["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_po_rcpt["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTabletp_po_rcpt["po_line"] = new XVar("type", 20, "varname", "po_line", "name", "po_line", "autoInc", "0");
            dalTabletp_po_rcpt["po_release"] = new XVar("type", 20, "varname", "po_release", "name", "po_release", "autoInc", "0");
            dalTabletp_po_rcpt["rcvd_date"] = new XVar("type", 135, "varname", "rcvd_date", "name", "rcvd_date", "autoInc", "0");
            dalTabletp_po_rcpt["date_seq"] = new XVar("type", 20, "varname", "date_seq", "name", "date_seq", "autoInc", "0");
            dalTabletp_po_rcpt["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_po_rcpt["exch_rate"] = new XVar("type", 14, "varname", "exch_rate", "name", "exch_rate", "autoInc", "0");
            dalTabletp_po_rcpt["item_cost"] = new XVar("type", 14, "varname", "item_cost", "name", "item_cost", "autoInc", "0");
            dalTabletp_po_rcpt["pack_num"] = new XVar("type", 202, "varname", "pack_num", "name", "pack_num", "autoInc", "0");
            dalTabletp_po_rcpt["qty_received"] = new XVar("type", 14, "varname", "qty_received", "name", "qty_received", "autoInc", "0");
            dalTabletp_po_rcpt["qty_returned"] = new XVar("type", 14, "varname", "qty_returned", "name", "qty_returned", "autoInc", "0");
            dalTabletp_po_rcpt["qty_vouchered"] = new XVar("type", 14, "varname", "qty_vouchered", "name", "qty_vouchered", "autoInc", "0");
            dalTabletp_po_rcpt["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_po_rcpt"] = dalTabletp_po_rcpt;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_po_rcpt()
        {
            			this.m_TableName = "dbo.tp_po_rcpt";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_po_rcpt";
        }
    }
}