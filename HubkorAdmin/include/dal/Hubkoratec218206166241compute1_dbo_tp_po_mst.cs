using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_po_mst : tDALTable
    {
        public XVar clientid;
        public XVar seq;
        public XVar vend_num;
        public XVar po_num;
        public XVar status;
        public XVar orderdate;
        public XVar currency;
        public XVar payerentity;
        public XVar createdate;
        public XVar recorddate;
        public XVar posted;
        public XVar payload;
        public XVar response;
        public static void Init()
        {
            XVar dalTabletp_po_mst = XVar.Array();
            dalTabletp_po_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_po_mst["seq"] = new XVar("type", 20, "varname", "seq", "name", "seq", "autoInc", "1");
            dalTabletp_po_mst["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTabletp_po_mst["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTabletp_po_mst["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            dalTabletp_po_mst["orderdate"] = new XVar("type", 202, "varname", "orderdate", "name", "orderdate", "autoInc", "0");
            dalTabletp_po_mst["currency"] = new XVar("type", 202, "varname", "currency", "name", "currency", "autoInc", "0");
            dalTabletp_po_mst["payerentity"] = new XVar("type", 202, "varname", "payerentity", "name", "payerentity", "autoInc", "0");
            dalTabletp_po_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTabletp_po_mst["recorddate"] = new XVar("type", 135, "varname", "recorddate", "name", "recorddate", "autoInc", "0");
            dalTabletp_po_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTabletp_po_mst["payload"] = new XVar("type", 202, "varname", "payload", "name", "payload", "autoInc", "0");
            dalTabletp_po_mst["response"] = new XVar("type", 202, "varname", "response", "name", "response", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_po_mst"] = dalTabletp_po_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_po_mst()
        {
            			this.m_TableName = "dbo.tp_po_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_po_mst";
        }
    }
}