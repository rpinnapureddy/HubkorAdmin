using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails_status_mst : tDALTable
    {
        public XVar clientid;
        public XVar invoiceid;
        public XVar status;
        public XVar createdate;
        public XVar recorddate;
        public XVar total;
        public XVar vendnum;
        public static void Init()
        {
            XVar dalTabletp_invoicedetails_status_mst = XVar.Array();
            dalTabletp_invoicedetails_status_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_invoicedetails_status_mst["invoiceid"] = new XVar("type", 202, "varname", "invoiceid", "name", "invoiceid", "autoInc", "0");
            dalTabletp_invoicedetails_status_mst["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            dalTabletp_invoicedetails_status_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTabletp_invoicedetails_status_mst["recorddate"] = new XVar("type", 135, "varname", "recorddate", "name", "recorddate", "autoInc", "0");
            dalTabletp_invoicedetails_status_mst["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTabletp_invoicedetails_status_mst["vendnum"] = new XVar("type", 202, "varname", "vendnum", "name", "vendnum", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_invoicedetails_status_mst"] = dalTabletp_invoicedetails_status_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails_status_mst()
        {
            			this.m_TableName = "dbo.tp_invoicedetails_status_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_status_mst";
        }
    }
}