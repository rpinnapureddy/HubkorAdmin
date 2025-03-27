using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_aptran_clear_mst : tDALTable
    {
        public XVar trans_num;
        public XVar trans_date;
        public XVar clientid;
        public XVar site_ref;
        public XVar invoice_id;
        public XVar notes;
        public static void Init()
        {
            XVar dalTabletp_aptran_clear_mst = XVar.Array();
            dalTabletp_aptran_clear_mst["trans_num"] = new XVar("type", 3, "varname", "trans_num", "name", "trans_num", "autoInc", "0");
            dalTabletp_aptran_clear_mst["trans_date"] = new XVar("type", 135, "varname", "trans_date", "name", "trans_date", "autoInc", "0");
            dalTabletp_aptran_clear_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_aptran_clear_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_aptran_clear_mst["invoice_id"] = new XVar("type", 202, "varname", "invoice_id", "name", "invoice_id", "autoInc", "0");
            dalTabletp_aptran_clear_mst["notes"] = new XVar("type", 202, "varname", "notes", "name", "notes", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_aptran_clear_mst"] = dalTabletp_aptran_clear_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_aptran_clear_mst()
        {
            			this.m_TableName = "dbo.tp_aptran_clear_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_aptran_clear_mst";
        }
    }
}