using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_aptran_mst : tDALTable
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
        public XVar tax;
        public XVar voided;
        public XVar isprepayment;
        public XVar idm_result;
        public XVar tpJsonResponse;
        public XVar InvoiceInternalNotes;
        public static void Init()
        {
            XVar dalTabletp_aptran_mst = XVar.Array();
            dalTabletp_aptran_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_aptran_mst["trans_num"] = new XVar("type", 20, "varname", "trans_num", "name", "trans_num", "autoInc", "1");
            dalTabletp_aptran_mst["type"] = new XVar("type", 202, "varname", "type", "name", "type", "autoInc", "0");
            dalTabletp_aptran_mst["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTabletp_aptran_mst["invoice_id"] = new XVar("type", 202, "varname", "invoice_id", "name", "invoice_id", "autoInc", "0");
            dalTabletp_aptran_mst["material"] = new XVar("type", 14, "varname", "material", "name", "material", "autoInc", "0");
            dalTabletp_aptran_mst["tax_amt"] = new XVar("type", 14, "varname", "tax_amt", "name", "tax_amt", "autoInc", "0");
            dalTabletp_aptran_mst["dist_date"] = new XVar("type", 7, "varname", "dist_date", "name", "dist_date", "autoInc", "0");
            dalTabletp_aptran_mst["vend_inv"] = new XVar("type", 202, "varname", "vend_inv", "name", "vend_inv", "autoInc", "0");
            dalTabletp_aptran_mst["inv_date"] = new XVar("type", 7, "varname", "inv_date", "name", "inv_date", "autoInc", "0");
            dalTabletp_aptran_mst["due_date"] = new XVar("type", 7, "varname", "due_date", "name", "due_date", "autoInc", "0");
            dalTabletp_aptran_mst["currency"] = new XVar("type", 202, "varname", "currency", "name", "currency", "autoInc", "0");
            dalTabletp_aptran_mst["num_lines"] = new XVar("type", 3, "varname", "num_lines", "name", "num_lines", "autoInc", "0");
            dalTabletp_aptran_mst["is_prepay"] = new XVar("type", 16, "varname", "is_prepay", "name", "is_prepay", "autoInc", "0");
            dalTabletp_aptran_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTabletp_aptran_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTabletp_aptran_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTabletp_aptran_mst["postdate"] = new XVar("type", 135, "varname", "postdate", "name", "postdate", "autoInc", "0");
            dalTabletp_aptran_mst["err_msg"] = new XVar("type", 202, "varname", "err_msg", "name", "err_msg", "autoInc", "0");
            dalTabletp_aptran_mst["bill_url"] = new XVar("type", 202, "varname", "bill_url", "name", "bill_url", "autoInc", "0");
            dalTabletp_aptran_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTabletp_aptran_mst["json_data"] = new XVar("type", 202, "varname", "json_data", "name", "json_data", "autoInc", "0");
            dalTabletp_aptran_mst["jresult"] = new XVar("type", 202, "varname", "jresult", "name", "jresult", "autoInc", "0");
            dalTabletp_aptran_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_aptran_mst["payer_entity_name"] = new XVar("type", 202, "varname", "payer_entity_name", "name", "payer_entity_name", "autoInc", "0");
            dalTabletp_aptran_mst["invoice_status"] = new XVar("type", 202, "varname", "invoice_status", "name", "invoice_status", "autoInc", "0");
            dalTabletp_aptran_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTabletp_aptran_mst["inv_internal_notes"] = new XVar("type", 202, "varname", "inv_internal_notes", "name", "inv_internal_notes", "autoInc", "0");
            dalTabletp_aptran_mst["po_num"] = new XVar("type", 202, "varname", "po_num", "name", "po_num", "autoInc", "0");
            dalTabletp_aptran_mst["approval_date"] = new XVar("type", 7, "varname", "approval_date", "name", "approval_date", "autoInc", "0");
            dalTabletp_aptran_mst["income_type"] = new XVar("type", 202, "varname", "income_type", "name", "income_type", "autoInc", "0");
            dalTabletp_aptran_mst["amt_due"] = new XVar("type", 202, "varname", "amt_due", "name", "amt_due", "autoInc", "0");
            dalTabletp_aptran_mst["freight"] = new XVar("type", 14, "varname", "freight", "name", "freight", "autoInc", "0");
            dalTabletp_aptran_mst["misc"] = new XVar("type", 14, "varname", "misc", "name", "misc", "autoInc", "0");
            dalTabletp_aptran_mst["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTabletp_aptran_mst["tax"] = new XVar("type", 14, "varname", "tax", "name", "tax", "autoInc", "0");
            dalTabletp_aptran_mst["voided"] = new XVar("type", 16, "varname", "voided", "name", "voided", "autoInc", "0");
            dalTabletp_aptran_mst["isprepayment"] = new XVar("type", 16, "varname", "isprepayment", "name", "isprepayment", "autoInc", "0");
            dalTabletp_aptran_mst["idm_result"] = new XVar("type", 202, "varname", "idm_result", "name", "idm_result", "autoInc", "0");
            dalTabletp_aptran_mst["tpJsonResponse"] = new XVar("type", 202, "varname", "tpJsonResponse", "name", "tpJsonResponse", "autoInc", "0");
            dalTabletp_aptran_mst["InvoiceInternalNotes"] = new XVar("type", 202, "varname", "InvoiceInternalNotes", "name", "InvoiceInternalNotes", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_aptran_mst"] = dalTabletp_aptran_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_aptran_mst()
        {
            			this.m_TableName = "dbo.tp_aptran_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_aptran_mst";
        }
    }
}