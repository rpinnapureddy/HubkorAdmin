using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Web;

namespace runnerDotNet
{
    public class tDAL : XClass
    {

        public static XVar CustomQuery(XVar dalSQL)
        {
	    var connection = CommonFunctions.getDefaultConnection();
            dynamic data = connection.query(dalSQL);
            if (data!=null)
                return data.getQueryHandle();
            else
                return null;
        }

        public static XVar UsersTableName()
        {
			var connection = GlobalVars.cman.byId( "Hubkoratec218206166241compute1" );
			return connection.addTableWrappers("dbo.users");
        }

        public static XVar DBLookup(XVar sql)
		{
			var connection = CommonFunctions.getDefaultConnection();
			XVar data = connection.query(sql).fetchAssoc();
			if (data)
				return data.GetEnumerator().First().Value; // return first value

			return null;
		}


	    public XVar lstTables = XVar.Array();

        public XVar tObjects = XVar.Array();

        public void FillTablesList()
        {
            if(this.lstTables.Count() > 0)
            {
                return;
            }
			
			this.lstTables.Add(new XVar("name", "Adminuggroups", "varname", "Hubkoratec218206166241compute1_dbo_Adminuggroups", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "Adminugmembers", "varname", "Hubkoratec218206166241compute1_dbo_Adminugmembers", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "Adminugrights", "varname", "Hubkoratec218206166241compute1_dbo_Adminugrights", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "apps", "varname", "Hubkoratec218206166241compute1_dbo_apps", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "auditlog_mst", "varname", "Hubkoratec218206166241compute1_dbo_auditlog_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "client_apps", "varname", "Hubkoratec218206166241compute1_dbo_client_apps", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "client_apps_table", "varname", "Hubkoratec218206166241compute1_dbo_client_apps_table", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "client_authorizations", "varname", "Hubkoratec218206166241compute1_dbo_client_authorizations", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "client_connections", "varname", "Hubkoratec218206166241compute1_dbo_client_connections", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "client_connector", "varname", "Hubkoratec218206166241compute1_dbo_client_connector", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "clients", "varname", "Hubkoratec218206166241compute1_dbo_clients", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "Clients_provisioning", "varname", "Hubkoratec218206166241compute1_dbo_Clients_provisioning", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "connector", "varname", "Hubkoratec218206166241compute1_dbo_connector", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_chart_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_chart_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_ido_prop_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_ido_prop_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_lc_rcpt_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_lc_rcpt_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_po_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_po_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_site_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_site_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_terms_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_terms_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_u_m_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_u_m_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_unitcd1_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd1_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_unitcd2_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd2_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_unitcd3_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd3_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "csi_unitcd4_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd4_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "documents", "varname", "Hubkoratec218206166241compute1_dbo_documents", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "fieldaudit", "varname", "Hubkoratec218206166241compute1_dbo_fieldaudit", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_audit", "varname", "Hubkoratec218206166241compute1_dbo_hk_audit", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_client_app_connector", "varname", "Hubkoratec218206166241compute1_dbo_hk_client_app_connector", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_client_inv_items", "varname", "Hubkoratec218206166241compute1_dbo_hk_client_inv_items", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_csi_uet_fields", "varname", "Hubkoratec218206166241compute1_dbo_hk_csi_uet_fields", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_csi_uet_tables", "varname", "Hubkoratec218206166241compute1_dbo_hk_csi_uet_tables", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_inv_items", "varname", "Hubkoratec218206166241compute1_dbo_hk_inv_items", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_invitem_mst", "varname", "Hubkoratec218206166241compute1_dbo_hk_invitem_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_invoice_mst", "varname", "Hubkoratec218206166241compute1_dbo_hk_invoice_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_job", "varname", "Hubkoratec218206166241compute1_dbo_hk_job", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_schema_field", "varname", "Hubkoratec218206166241compute1_dbo_hk_schema_field", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_schema_table", "varname", "Hubkoratec218206166241compute1_dbo_hk_schema_table", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "hk_uet", "varname", "Hubkoratec218206166241compute1_dbo_hk_uet", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "incidents", "varname", "Hubkoratec218206166241compute1_dbo_incidents", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "incoming", "varname", "Hubkoratec218206166241compute1_dbo_incoming", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "indcode", "varname", "Hubkoratec218206166241compute1_dbo_indcode", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_customer_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_customer_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_order_count", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_count", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_order_line_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_line_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_order_lines_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_lines_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_order_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_orderline_count", "varname", "Hubkoratec218206166241compute1_dbo_mg_orderline_count", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_products_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_products_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "mg_stores_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_stores_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "recordcounts", "varname", "Hubkoratec218206166241compute1_dbo_recordcounts", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_aptran_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_aptran_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_aptrandist_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_aptrandist_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_expensereport_line_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_expensereport_line_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_expensereport_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_expensereport_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_indcode", "varname", "Hubkoratec218206166241compute1_dbo_sc_indcode", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_invoice_line_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_invoice_line_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_invoice_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_invoice_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sc_sro_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_sro_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sf_customer_map_mst", "varname", "Hubkoratec218206166241compute1_dbo_sf_customer_map_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sf_customer_master", "varname", "Hubkoratec218206166241compute1_dbo_sf_customer_master", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sh_fulfillment_orders_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_fulfillment_orders_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sh_get_order_lines_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_get_order_lines_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sh_get_orders_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_get_orders_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sh_products_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_products_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "sh_stores_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_stores_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "SourceManagement", "varname", "Hubkoratec218206166241compute1_dbo_SourceManagement", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "timezone", "varname", "Hubkoratec218206166241compute1_dbo_timezone", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_aptran_clear_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_aptran_clear_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_aptran_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_aptran_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_aptrandist_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_aptrandist_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_chart_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_chart_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_invoice_temp", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoice_temp", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_invoicedetails", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_invoicedetails_dist_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_dist_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_invoicedetails_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_invoicedetails_status_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_status_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_payments_hdr_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_payments_hdr_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_payments_lines_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_payments_lines_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_po", "varname", "Hubkoratec218206166241compute1_dbo_tp_po", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_po_audit", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_audit", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_po_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_po_rcpt", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_rcpt", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_po_rcpt_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_rcpt_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_poitem", "varname", "Hubkoratec218206166241compute1_dbo_tp_poitem", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_vendor", "varname", "Hubkoratec218206166241compute1_dbo_tp_vendor", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_vendor_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_vendor_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "tp_vendor_not_match_tosyteline", "varname", "Hubkoratec218206166241compute1_dbo_tp_vendor_not_match_tosyteline", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
			this.lstTables.Add(new XVar("name", "users", "varname", "Hubkoratec218206166241compute1_dbo_users", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"));
        }

        /// <summary>
        /// Returns table object by table name
        /// </summary>
        /// <param name="strTable">Table name</param>
        /// <returns></returns>
        public dynamic Table( XVar strTable, string schema = "", string connName = "" )
	    {
		    this.FillTablesList();
		    foreach(var tbl in this.lstTables.GetEnumerator())
		    {
			    if(MVCFunctions.strtoupper(strTable) == MVCFunctions.strtoupper(tbl.Value["name"]) &&
					( schema == "" || MVCFunctions.strtoupper(schema) == MVCFunctions.strtoupper(tbl.Value["schema"]) ) &&
					( connName == "" || MVCFunctions.strtoupper(connName) == MVCFunctions.strtoupper(tbl.Value["connName"]) ) )
			    {
				    this.CreateClass(tbl.Value);
				    return this.tObjects[tbl.Value["varname"]];
			    }
		    }
            //	check table names without dbo. and other prefixes
		    foreach(var tbl in this.lstTables.GetEnumerator())
		    {
			    if(MVCFunctions.strtoupper(tDAL.cutprefix(strTable)) == MVCFunctions.strtoupper(tDAL.cutprefix(tbl.Value["name"])))
			    {
				    this.CreateClass(tbl.Value);
				    return this.tObjects[tbl.Value["varname"]];
			    }
		    }
		    return null;
	    }

        public void CreateClass(XVar tbl)
	    {
		    if(this.tObjects[tbl["varname"]])
            {
			    return;
            }
            //	load table info

            XVar classname = "runnerDotNet.dalTable_" + tbl["varname"].ToString();
            Type tableType = Type.GetType(classname);
		    tableType.GetMethod("Init", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).Invoke(null, null);
        
            //	create class and object
			
			// TODO: init connection somewhere?

            this.tObjects[tbl["varname"]] = (XVar)Activator.CreateInstance(tableType);
			((tDALTable)this.tObjects[tbl["varname"]]).setConnection( tbl["connId"] );
	    }

        /// <summary>
        /// Returns list of table names
        /// </summary>
        /// <returns></returns>
        public XVar GetTablesList()
	    {
		    this.FillTablesList();
		    XVar res = XVar.Array();
		    foreach(var tbl in this.lstTables.GetEnumerator())
		    {
			    res.Add(tbl.Value["name"]);
            }
		    return res;
        }

        /// <summary>
        /// Get list of table fields by table name
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public XVar GetFieldsList(XVar table)
	    {
		    tDALTable tbl = this.Table(table);
		    return tbl.GetFieldsList();
	    }

        /// <summary>
        /// Get field type by table name and field name
        /// </summary>
        /// <param name="table"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public XVar GetFieldType(XVar table, XVar field)
	    {
		    tDALTable tbl = this.Table(table);
		    return tbl.GetFieldType(field);
	    }

        /// <summary>
        /// Get table key fields by table name
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public XVar GetDBTableKeys(XVar table)
	    {
		    tDALTable tbl = this.Table(table);
		    return tbl.GetDBTableKeys();
	    }


        public static XVar cutprefix(XVar table)
        {
	        XVar pos = MVCFunctions.strpos(table, ".");
	        if(pos.Equals(false))
            {
		        return table;
            }
	        return MVCFunctions.substr(table, pos + 1);
        }
    }

    /// <summary>
    /// Data Access Layer table class
    /// </summary>
    public class tDALTable : XClass
    {
	    public XVar m_TableName;
	    public XVar m_infoKey;
	    public XVar Param = XVar.Array();
	    public XVar Value = XVar.Array();
		public Connection _connection;

		public void setConnection(XVar connId)
		{
			_connection = GlobalVars.cman.byId(connId);
		}
		
        public XVar GetDBTableKeys()
	    {
		    if(!GlobalVars.dal_info.KeyExists(this.m_infoKey) || ! MVCFunctions.is_array(GlobalVars.dal_info[this.m_infoKey]))
		    {
			    return XVar.Array();
		    }
		    XVar ret = XVar.Array();
		    foreach(var f in GlobalVars.dal_info[this.m_infoKey].GetEnumerator())
		    {
			    if(f.Value["key"] != null)
                {
				    ret.Add(f.Key);
                }
		    }
		    return ret;
	    }

        public XVar GetFieldsList()
	    {
		    return GlobalVars.dal_info[this.m_infoKey].ArrayKeys();
	    }

        public XVar GetFieldType(XVar field)
	    {
		    if(!GlobalVars.dal_info.KeyExists(this.m_infoKey))
            {
                return 200;
            }
		    return GlobalVars.dal_info[this.m_infoKey][field]["type"];
	    }

        public XVar PrepareValue(XVar value, XVar type)
	    {
		
			if(_connection.dbType == Constants.nDATABASE_Oracle)
			{
				if(CommonFunctions.IsBinaryType(type))
				{
					return "EMPTY_BLOB()";
				}
			}
	
		    if(CommonFunctions.IsDateFieldType(type))
            {
				return _connection.addDateQuotes(value);
            }
		    if (CommonFunctions.NeedQuotes(type))
			    return _connection.prepareString(value);
		    else
			{
				if(XVar.Pack(MVCFunctions.IsNumeric(value)))
				{
					return MVCFunctions.str_replace(new XVar(","), new XVar("."), (XVar)(value));
				}
				else
				{
					return 0;
				}
			}
	    }

        /// <summary>
        /// Get table name
        /// </summary>
        /// <returns></returns>
        public XVar TableName()
	    {
		    return _connection.addTableWrappers(this.m_TableName);
	    } 

        public void Execute_Query(XVar blobs, XVar dalSQL, XVar tableinfo)
	    {
			XVar blobTypes = XVar.Array();
			_connection.execWithBlobProcessing( dalSQL, blobs, blobTypes );
	    }

        /// <summary>
        /// Add new record to the table
        /// </summary>
        public void Add() 
	    {
		    XVar insertFields = "";
		    XVar insertValues = "";
		    XVar tableinfo = GlobalVars.dal_info[this.m_infoKey];
		    XVar blobs = XVar.Array();
    //	prepare parameters		
		    foreach(var f in tableinfo.GetEnumerator())
		    {
                var fieldInfo = this.GetType().GetField(f.Value["varname"]);
			    if(fieldInfo != null && fieldInfo.GetValue(this) != null)
			    {
				    this.Value[f.Key] = fieldInfo.GetValue(this);
			    }
			    foreach(var fieldValue in this.Value.GetEnumerator())
			    {
				    if (MVCFunctions.strtoupper(fieldValue.Key) != MVCFunctions.strtoupper(f.Key))
					    continue;
						
				    insertFields = MVCFunctions.Concat(insertFields, _connection.addFieldWrappers(f.Key), ",");
				    insertValues = MVCFunctions.Concat(insertValues, this.PrepareValue(fieldValue.Value, f.Value["type"]), ",");
					if(_connection.dbType == Constants.nDATABASE_Oracle)
					{
						if(CommonFunctions.IsBinaryType(f.Value["type"]))
						{
							blobs[fieldValue.Key] = fieldValue.Value;
						}
					}
				    break;
			    }
		    }
    //	prepare and exec SQL
		    if (insertFields != "" && insertValues != "")
		    {
			    insertFields = MVCFunctions.substr(insertFields, 0, -1);
			    insertValues = MVCFunctions.substr(insertValues, 0, -1);
			
				
			    XVar dalSQL = MVCFunctions.Concat("insert into ", _connection.addTableWrappers(this.m_TableName), " (", insertFields, ") values (", insertValues, ")");
			    this.Execute_Query(blobs, dalSQL, tableinfo);
				
		    }
    //	cleanup		
	        this.Reset();
	    }

        /// <summary>
        /// Query all records from the table
        /// </summary>
        /// <returns></returns>
        public XVar QueryAll()
	    {
		    XVar dalSQL = MVCFunctions.Concat("select * from ", _connection.addTableWrappers(this.m_TableName));
		    return _connection.query(dalSQL).getQueryHandle();
	    }

        /// <summary>
        /// Do a custom query on the table
        /// </summary>
        /// <param name="swhere"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public XVar Query(XVar swhere = null, XVar orderby = null)
	    {
		    if (swhere)
            {
			    swhere = MVCFunctions.Concat(" where ", swhere);
            }
		    if (orderby)
            {
			    orderby = MVCFunctions.Concat(" order by ", orderby);
            }
		    XVar dalSQL = MVCFunctions.Concat("select * from ", _connection.addTableWrappers(this.m_TableName), swhere, orderby);
		    return _connection.query(dalSQL).getQueryHandle();
	    }

        /// <summary>
        /// Delete a record from the table
        /// </summary>
        /// <returns></returns>
        public void Delete()
	    {
		    XVar deleteFields = "";
		    XVar tableinfo = GlobalVars.dal_info[this.m_infoKey];
    //	prepare parameters		
		    foreach(var f in tableinfo.GetEnumerator())
		    {
                var fieldInfo = this.GetType().GetField(f.Value["varname"]);
			    if(fieldInfo != null && fieldInfo.GetValue(this) != null)
			    {
				    this.Param[f.Key] = fieldInfo.GetValue(this);
			    }
			    foreach(var paramValue in this.Param.GetEnumerator())
			    {
				    if (MVCFunctions.strtoupper(paramValue.Key) != MVCFunctions.strtoupper(f.Key))
                    {
					    continue;
                    }
				    deleteFields = MVCFunctions.Concat(deleteFields, _connection.addFieldWrappers(f.Key), "=", this.PrepareValue(paramValue.Value, f.Value["type"]), " and ");
				    break;
			    }
		    }
    //	do delete
		    if (deleteFields)
		    {
			    deleteFields = MVCFunctions.substr(deleteFields,0,-5);
			    XVar dalSQL = MVCFunctions.Concat("delete from ", _connection.addTableWrappers(this.m_TableName), " where ", deleteFields);
			    _connection.exec(dalSQL);
		    }
	
    //	cleanup
	        this.Reset();
	    }

        /// <summary>
        /// Reset table object
        /// </summary>
        public void Reset()
	    {
		    this.Value = XVar.Array();
		    this.Param = XVar.Array();
		    XVar tableinfo = GlobalVars.dal_info[this.m_infoKey];
    //	prepare parameters		
		    foreach(var f in tableinfo.GetEnumerator())
		    {
                var fieldInfo = this.GetType().GetField(f.Value["varname"]);
			    if(fieldInfo != null)
			    {
				    fieldInfo.SetValue(this, null);
			    }
		    }
	    }

        /// <summary>
        /// Update record in the table
        /// </summary>
        public void Update()
	    {
		    XVar tableinfo = GlobalVars.dal_info[this.m_infoKey];
		    XVar updateParam = "";
		    XVar updateValue = "";
		    XVar blobs = XVar.Array();

		    foreach(var f in tableinfo.GetEnumerator())
		    {
                var fieldInfo = this.GetType().GetField(f.Value["varname"]);
                if(fieldInfo != null && fieldInfo.GetValue(this) != null)
                {
                    if(f.Value["key"] != null)
                    {
                        this.Param[ f.Value["varname"] ] = fieldInfo.GetValue(this);
                    }
                    else
                    {
                        this.Value[ f.Value["varname"] ] = fieldInfo.GetValue(this);
                    }
                }
			    if(f.Value["key"] == null && !MVCFunctions.array_change_key_case(this.Param, Constants.CASE_UPPER).KeyExists(MVCFunctions.strtoupper(f.Key)))
			    {
				    foreach(var fieldValue in this.Value.GetEnumerator())
				    {
					    if (MVCFunctions.strtoupper(fieldValue.Key) != MVCFunctions.strtoupper(f.Key))
                        {
						    continue;
                        }
					    updateValue = MVCFunctions.Concat(updateValue, _connection.addFieldWrappers(f.Key), "=", this.PrepareValue(fieldValue.Value, f.Value["type"]), ", ");
						
						if(_connection.dbType == Constants.nDATABASE_Oracle)
						{
							if(CommonFunctions.IsBinaryType(f.Value["type"]))
							{
								blobs[f.Key] = fieldValue.Value;
							}
						}
					    break;
				    }
			    }
			    else
			    {
				    foreach(var fieldValue in this.Param.GetEnumerator())
				    {
					    if (MVCFunctions.strtoupper(fieldValue.Key) != MVCFunctions.strtoupper(f.Key))
                        {
						    continue;
                        }
					    updateParam = MVCFunctions.Concat(updateParam, _connection.addFieldWrappers(f.Key), "=", this.PrepareValue(fieldValue.Value, f.Value["type"]) , " and ");
					    break;
				    }
			    }
		    }

    //	construct SQL and do update	
		    if (updateParam)
            {
			    updateParam = MVCFunctions.substr(updateParam,0,-5);
            }
		    if (updateValue)
            {
			    updateValue = MVCFunctions.substr(updateValue,0,-2);
            }
		    if (updateValue && updateParam)
		    {
			    XVar dalSQL = MVCFunctions.Concat("update ", _connection.addTableWrappers(this.m_TableName), " set ", updateValue, " where ", updateParam);
			    this.Execute_Query(blobs, dalSQL, tableinfo);
		    }

    //	cleanup
		    this.Reset();
	    }

        public XVar FetchByID()
	    {
		    XVar tableinfo = GlobalVars.dal_info[this.m_infoKey];

		    XVar dal_where = "";
		    foreach(var f in tableinfo.GetEnumerator())
		    {
                var fieldInfo = this.GetType().GetField(f.Value["varname"]);
                if(fieldInfo != null && fieldInfo.GetValue(this) != null)
                {
                    this.Value[ f.Value["varname"] ] = fieldInfo.GetValue(this);
                }
			    foreach(var fieldValue in this.Param.GetEnumerator())
			    {
				    if (MVCFunctions.strtoupper(fieldValue.Key) != MVCFunctions.strtoupper(f.Key))
                    {
				        continue;
                    }
				    dal_where =  MVCFunctions.Concat(_connection.addFieldWrappers(f.Key), "=", this.PrepareValue(fieldValue.Value, f.Value["type"]), " and ");
				    break;
			    }
		    }
		    // cleanup
		    this.Reset();
		    // construct and run SQL
		    if (dal_where)
            {
			    dal_where =  MVCFunctions.Concat(" where ", MVCFunctions.substr(dal_where,0,-5));
            }
		    XVar dalSQL =  MVCFunctions.Concat("select * from ", _connection.addTableWrappers(this.m_TableName), dal_where);
		    return _connection.query(dalSQL).getQueryHandle();
	    }
    }
}