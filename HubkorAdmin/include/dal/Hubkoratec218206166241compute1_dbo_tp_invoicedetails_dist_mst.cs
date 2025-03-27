using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails_dist_mst : tDALTable
    {
        public XVar clientid;
        public XVar invoiceid;
        public XVar po;
        public XVar createdate;
        public XVar recorddate;
        public static void Init()
        {
            XVar dalTabletp_invoicedetails_dist_mst = XVar.Array();
            dalTabletp_invoicedetails_dist_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_invoicedetails_dist_mst["invoiceid"] = new XVar("type", 202, "varname", "invoiceid", "name", "invoiceid", "autoInc", "0");
            dalTabletp_invoicedetails_dist_mst["po"] = new XVar("type", 202, "varname", "po", "name", "po", "autoInc", "0");
            dalTabletp_invoicedetails_dist_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTabletp_invoicedetails_dist_mst["recorddate"] = new XVar("type", 135, "varname", "recorddate", "name", "recorddate", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_invoicedetails_dist_mst"] = dalTabletp_invoicedetails_dist_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails_dist_mst()
        {
            			this.m_TableName = "dbo.tp_invoicedetails_dist_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_dist_mst";
        }
    }
}