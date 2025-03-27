using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_po_rcpt_mst : tDALTable
    {
        public XVar clientid;
        public XVar seq;
        public XVar po_num;
        public XVar po_line;
        public XVar po_release;
        public XVar rcvd_date;
        public XVar date_seq;
        public XVar site_ref;
        public XVar qty_received;
        public XVar posted;
        public XVar createdate;
        public XVar recorddate;
        public XVar payload;
        public XVar receiptnumber;
        public XVar vend_num;
        public XVar item;
        public XVar u_m;
        public XVar response;
        public XVar payerentity;
        public static void Init()
        {
            XVar dalTabletp_po_rcpt_mst = XVar.Array();
            dalTabletp_po_rcpt_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_po_rcpt_mst["seq"] = new XVar("type", 20, "varname", "seq", "name", "seq", "autoInc", "1");
            dalTabletp_po_rcpt_mst["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTabletp_po_rcpt_mst["po_line"] = new XVar("type", 20, "varname", "po_line", "name", "po_line", "autoInc", "0");
            dalTabletp_po_rcpt_mst["po_release"] = new XVar("type", 20, "varname", "po_release", "name", "po_release", "autoInc", "0");
            dalTabletp_po_rcpt_mst["rcvd_date"] = new XVar("type", 135, "varname", "rcvd_date", "name", "rcvd_date", "autoInc", "0");
            dalTabletp_po_rcpt_mst["date_seq"] = new XVar("type", 20, "varname", "date_seq", "name", "date_seq", "autoInc", "0");
            dalTabletp_po_rcpt_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_po_rcpt_mst["qty_received"] = new XVar("type", 14, "varname", "qty_received", "name", "qty_received", "autoInc", "0");
            dalTabletp_po_rcpt_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTabletp_po_rcpt_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTabletp_po_rcpt_mst["recorddate"] = new XVar("type", 135, "varname", "recorddate", "name", "recorddate", "autoInc", "0");
            dalTabletp_po_rcpt_mst["payload"] = new XVar("type", 202, "varname", "payload", "name", "payload", "autoInc", "0");
            dalTabletp_po_rcpt_mst["receiptnumber"] = new XVar("type", 202, "varname", "receiptnumber", "name", "receiptnumber", "autoInc", "0");
            dalTabletp_po_rcpt_mst["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTabletp_po_rcpt_mst["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTabletp_po_rcpt_mst["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTabletp_po_rcpt_mst["response"] = new XVar("type", 202, "varname", "response", "name", "response", "autoInc", "0");
            dalTabletp_po_rcpt_mst["payerentity"] = new XVar("type", 202, "varname", "payerentity", "name", "payerentity", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_po_rcpt_mst"] = dalTabletp_po_rcpt_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_po_rcpt_mst()
        {
            			this.m_TableName = "dbo.tp_po_rcpt_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_po_rcpt_mst";
        }
    }
}