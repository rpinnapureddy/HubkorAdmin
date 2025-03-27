using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails : tDALTable
    {
        public XVar clientid;
        public XVar po;
        public XVar invoicestatus;
        public XVar invoiceid;
        public XVar vendinv;
        public XVar total;
        public XVar vendnum;
        public static void Init()
        {
            XVar dalTabletp_invoicedetails = XVar.Array();
            dalTabletp_invoicedetails["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_invoicedetails["po"] = new XVar("type", 202, "varname", "po", "name", "po", "autoInc", "0");
            dalTabletp_invoicedetails["invoicestatus"] = new XVar("type", 202, "varname", "invoicestatus", "name", "invoicestatus", "autoInc", "0");
            dalTabletp_invoicedetails["invoiceid"] = new XVar("type", 202, "varname", "invoiceid", "name", "invoiceid", "autoInc", "0");
            dalTabletp_invoicedetails["vendinv"] = new XVar("type", 202, "varname", "vendinv", "name", "vendinv", "autoInc", "0");
            dalTabletp_invoicedetails["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTabletp_invoicedetails["vendnum"] = new XVar("type", 202, "varname", "vendnum", "name", "vendnum", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_invoicedetails"] = dalTabletp_invoicedetails;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails()
        {
            			this.m_TableName = "dbo.tp_invoicedetails";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_invoicedetails";
        }
    }
}