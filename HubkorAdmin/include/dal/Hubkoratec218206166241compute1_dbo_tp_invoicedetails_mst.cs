using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails_mst : tDALTable
    {
        public XVar clientid;
        public XVar invoiceid;
        public XVar vendnum;
        public XVar vendinv;
        public XVar invoicestatus;
        public XVar total;
        public XVar type;
        public XVar dataFrom;
        public XVar voided;
        public XVar payer_entity_name;
        public XVar createdate;
        public XVar recorddate;
        public static void Init()
        {
            XVar dalTabletp_invoicedetails_mst = XVar.Array();
            dalTabletp_invoicedetails_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_invoicedetails_mst["invoiceid"] = new XVar("type", 202, "varname", "invoiceid", "name", "invoiceid", "autoInc", "0");
            dalTabletp_invoicedetails_mst["vendnum"] = new XVar("type", 202, "varname", "vendnum", "name", "vendnum", "autoInc", "0");
            dalTabletp_invoicedetails_mst["vendinv"] = new XVar("type", 202, "varname", "vendinv", "name", "vendinv", "autoInc", "0");
            dalTabletp_invoicedetails_mst["invoicestatus"] = new XVar("type", 202, "varname", "invoicestatus", "name", "invoicestatus", "autoInc", "0");
            dalTabletp_invoicedetails_mst["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTabletp_invoicedetails_mst["type"] = new XVar("type", 202, "varname", "type", "name", "type", "autoInc", "0");
            dalTabletp_invoicedetails_mst["dataFrom"] = new XVar("type", 200, "varname", "dataFrom", "name", "dataFrom", "autoInc", "0");
            dalTabletp_invoicedetails_mst["voided"] = new XVar("type", 16, "varname", "voided", "name", "voided", "autoInc", "0");
            dalTabletp_invoicedetails_mst["payer_entity_name"] = new XVar("type", 202, "varname", "payer_entity_name", "name", "payer_entity_name", "autoInc", "0");
            dalTabletp_invoicedetails_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTabletp_invoicedetails_mst["recorddate"] = new XVar("type", 135, "varname", "recorddate", "name", "recorddate", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_invoicedetails_mst"] = dalTabletp_invoicedetails_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_invoicedetails_mst()
        {
            			this.m_TableName = "dbo.tp_invoicedetails_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_mst";
        }
    }
}