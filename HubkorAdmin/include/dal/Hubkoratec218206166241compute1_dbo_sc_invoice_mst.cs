using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sc_invoice_mst : tDALTable
    {
        public XVar site_ref;
        public XVar trans_num;
        public XVar type;
        public XVar vend_num;
        public XVar invoice_id;
        public XVar material;
        public XVar tax_amt;
        public XVar dist_date;
        public XVar vend_inv;
        public XVar inv_date;
        public XVar due_date;
        public XVar currency;
        public XVar num_lines;
        public XVar is_prepay;
        public XVar rowpointer;
        public XVar createdate;
        public XVar posted;
        public XVar postdate;
        public XVar err_msg;
        public XVar bill_url;
        public XVar terms_code;
        public XVar json_data;
        public XVar jresult;
        public XVar clientid;
        public XVar payer_entity_name;
        public XVar invoice_status;
        public XVar description;
        public XVar inv_internal_notes;
        public XVar po_num;
        public XVar approval_date;
        public XVar income_type;
        public XVar amt_due;
        public XVar freight;
        public XVar misc;
        public XVar total;
        public XVar vendorcode;
        public XVar vendorname;
        public XVar inv_num;
        public XVar Billable;
        public XVar SRO;
        public XVar line;
        public XVar transaction;
        public XVar lastmodifieddate;
        public static void Init()
        {
            XVar dalTablesc_invoice_mst = XVar.Array();
            dalTablesc_invoice_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesc_invoice_mst["trans_num"] = new XVar("type", 20, "varname", "trans_num", "name", "trans_num", "autoInc", "1");
            dalTablesc_invoice_mst["type"] = new XVar("type", 202, "varname", "type", "name", "type", "autoInc", "0");
            dalTablesc_invoice_mst["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTablesc_invoice_mst["invoice_id"] = new XVar("type", 202, "varname", "invoice_id", "name", "invoice_id", "autoInc", "0");
            dalTablesc_invoice_mst["material"] = new XVar("type", 14, "varname", "material", "name", "material", "autoInc", "0");
            dalTablesc_invoice_mst["tax_amt"] = new XVar("type", 14, "varname", "tax_amt", "name", "tax_amt", "autoInc", "0");
            dalTablesc_invoice_mst["dist_date"] = new XVar("type", 7, "varname", "dist_date", "name", "dist_date", "autoInc", "0");
            dalTablesc_invoice_mst["vend_inv"] = new XVar("type", 202, "varname", "vend_inv", "name", "vend_inv", "autoInc", "0");
            dalTablesc_invoice_mst["inv_date"] = new XVar("type", 7, "varname", "inv_date", "name", "inv_date", "autoInc", "0");
            dalTablesc_invoice_mst["due_date"] = new XVar("type", 7, "varname", "due_date", "name", "due_date", "autoInc", "0");
            dalTablesc_invoice_mst["currency"] = new XVar("type", 202, "varname", "currency", "name", "currency", "autoInc", "0");
            dalTablesc_invoice_mst["num_lines"] = new XVar("type", 3, "varname", "num_lines", "name", "num_lines", "autoInc", "0");
            dalTablesc_invoice_mst["is_prepay"] = new XVar("type", 16, "varname", "is_prepay", "name", "is_prepay", "autoInc", "0");
            dalTablesc_invoice_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTablesc_invoice_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTablesc_invoice_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablesc_invoice_mst["postdate"] = new XVar("type", 135, "varname", "postdate", "name", "postdate", "autoInc", "0");
            dalTablesc_invoice_mst["err_msg"] = new XVar("type", 202, "varname", "err_msg", "name", "err_msg", "autoInc", "0");
            dalTablesc_invoice_mst["bill_url"] = new XVar("type", 202, "varname", "bill_url", "name", "bill_url", "autoInc", "0");
            dalTablesc_invoice_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablesc_invoice_mst["json_data"] = new XVar("type", 202, "varname", "json_data", "name", "json_data", "autoInc", "0");
            dalTablesc_invoice_mst["jresult"] = new XVar("type", 202, "varname", "jresult", "name", "jresult", "autoInc", "0");
            dalTablesc_invoice_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesc_invoice_mst["payer_entity_name"] = new XVar("type", 202, "varname", "payer_entity_name", "name", "payer_entity_name", "autoInc", "0");
            dalTablesc_invoice_mst["invoice_status"] = new XVar("type", 202, "varname", "invoice_status", "name", "invoice_status", "autoInc", "0");
            dalTablesc_invoice_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablesc_invoice_mst["inv_internal_notes"] = new XVar("type", 202, "varname", "inv_internal_notes", "name", "inv_internal_notes", "autoInc", "0");
            dalTablesc_invoice_mst["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTablesc_invoice_mst["approval_date"] = new XVar("type", 7, "varname", "approval_date", "name", "approval_date", "autoInc", "0");
            dalTablesc_invoice_mst["income_type"] = new XVar("type", 202, "varname", "income_type", "name", "income_type", "autoInc", "0");
            dalTablesc_invoice_mst["amt_due"] = new XVar("type", 202, "varname", "amt_due", "name", "amt_due", "autoInc", "0");
            dalTablesc_invoice_mst["freight"] = new XVar("type", 14, "varname", "freight", "name", "freight", "autoInc", "0");
            dalTablesc_invoice_mst["misc"] = new XVar("type", 14, "varname", "misc", "name", "misc", "autoInc", "0");
            dalTablesc_invoice_mst["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTablesc_invoice_mst["vendorcode"] = new XVar("type", 202, "varname", "vendorcode", "name", "vendorcode", "autoInc", "0");
            dalTablesc_invoice_mst["vendorname"] = new XVar("type", 202, "varname", "vendorname", "name", "vendorname", "autoInc", "0");
            dalTablesc_invoice_mst["inv_num"] = new XVar("type", 202, "varname", "inv_num", "name", "inv_num", "autoInc", "0");
            dalTablesc_invoice_mst["Billable"] = new XVar("type", 202, "varname", "Billable", "name", "Billable", "autoInc", "0");
            dalTablesc_invoice_mst["SRO"] = new XVar("type", 202, "varname", "SRO", "name", "SRO", "autoInc", "0");
            dalTablesc_invoice_mst["line"] = new XVar("type", 202, "varname", "line", "name", "line", "autoInc", "0");
            dalTablesc_invoice_mst["transaction"] = new XVar("type", 3, "varname", "transaction", "name", "transaction", "autoInc", "0");
            dalTablesc_invoice_mst["lastmodifieddate"] = new XVar("type", 135, "varname", "lastmodifieddate", "name", "lastmodifieddate", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sc_invoice_mst"] = dalTablesc_invoice_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sc_invoice_mst()
        {
            			this.m_TableName = "dbo.sc_invoice_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sc_invoice_mst";
        }
    }
}