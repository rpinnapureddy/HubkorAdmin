using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
namespace runnerDotNet
{
	public partial class ConnectionManager_Base : XClass
	{
		protected dynamic cache = XVar.Array();
		protected dynamic _connectionsData;
		protected dynamic _connectionsIdByName = XVar.Array();
		protected dynamic _tablesConnectionIds;
		public ConnectionManager_Base()
		{
			this._setConnectionsData();
			this._setTablesConnectionIds();
		}
		public virtual XVar getTableConnId(dynamic _param_tName)
		{
			#region pass-by-value parameters
			dynamic tName = XVar.Clone(_param_tName);
			#endregion

			return this._tablesConnectionIds[tName];
		}
		public virtual XVar byTable(dynamic _param_tName)
		{
			#region pass-by-value parameters
			dynamic tName = XVar.Clone(_param_tName);
			#endregion

			dynamic connId = null;
			connId = XVar.Clone(this._tablesConnectionIds[tName]);
			if(XVar.Pack(!(XVar)(connId)))
			{
				return this.getDefault();
			}
			return this.byId((XVar)(connId));
		}
		public virtual XVar byName(dynamic _param_connName)
		{
			#region pass-by-value parameters
			dynamic connName = XVar.Clone(_param_connName);
			#endregion

			dynamic connId = null;
			connId = XVar.Clone(this.getIdByName((XVar)(connName)));
			if(XVar.Pack(!(XVar)(connId)))
			{
				return this.getDefault();
			}
			return this.byId((XVar)(connId));
		}
		protected virtual XVar getIdByName(dynamic _param_connName)
		{
			#region pass-by-value parameters
			dynamic connName = XVar.Clone(_param_connName);
			#endregion

			return this._connectionsIdByName[connName];
		}
		public virtual XVar byId(dynamic _param_connId)
		{
			#region pass-by-value parameters
			dynamic connId = XVar.Clone(_param_connId);
			#endregion

			if(XVar.Pack(!(XVar)(this.cache.KeyExists(connId))))
			{
				dynamic conn = null;
				conn = XVar.Clone(this.getConnection((XVar)(connId)));
				if(XVar.Pack(!(XVar)(conn)))
				{
					conn = XVar.Clone(GlobalVars.restApis.getConnection((XVar)(connId)));
				}
				if(XVar.Pack(!(XVar)(conn)))
				{
					conn = XVar.Clone(this.getDefault());
				}
				this.cache.InitAndSetArrayItem(conn, connId);
			}
			return this.cache[connId];
		}
		public virtual XVar getDefault()
		{
			return this.byId(new XVar("Hubkoratec218206166241compute1"));
		}
		public virtual XVar getDefaultConnId()
		{
			return "Hubkoratec218206166241compute1";
		}
		public virtual XVar getForLogin()
		{
			return this.byId((XVar)(this.getLoginConnId()));
		}
		public virtual XVar getLoginConnId()
		{
			dynamic db = XVar.Array();
			db = Security.dbProvider();
			if(XVar.Pack(db))
			{
				return db["table"]["connId"];
			}
			return "";
		}
		public virtual XVar getForAudit()
		{
			return this.byId(new XVar("Hubkoratec218206166241compute1"));
			return null;
		}
		public virtual XVar getForLocking()
		{
			return this.byId(new XVar("Hubkoratec218206166241compute1"));
			return null;
		}
		public virtual XVar getForUserGroups()
		{
			return this.byId((XVar)(this.getUserGroupsConnId()));
		}
		public virtual XVar getUserGroupsConnId()
		{
			return "Hubkoratec218206166241compute1";
			return null;
		}
		public virtual XVar getForSavedSearches()
		{
			return this.byId((XVar)(this.getSavedSearchesConnId()));
		}
		public virtual XVar getSavedSearchesConnId()
		{
			return "Hubkoratec218206166241compute1";
			return null;
		}
		public virtual XVar getForWebReports()
		{
			return this.byId((XVar)(this.getSavedSearchesConnId()));
		}
		public virtual XVar getWebReportsConnId()
		{
			return "Hubkoratec218206166241compute1";
			return null;
		}
		protected virtual XVar getConnection(dynamic _param_connId)
		{
			#region pass-by-value parameters
			dynamic connId = XVar.Clone(_param_connId);
			#endregion

			return false;
		}
		public virtual XVar getConectionsIds()
		{
			dynamic connectionsIds = XVar.Array();
			connectionsIds = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> data in this._connectionsData.GetEnumerator())
			{
				connectionsIds.InitAndSetArrayItem(data.Key, null);
			}
			return connectionsIds;
		}
		protected virtual XVar _setConnectionsData()
		{
			return null;
		}
		protected virtual XVar _setTablesConnectionIds()
		{
			dynamic connectionsIds = XVar.Array();
			connectionsIds = XVar.Clone(XVar.Array());
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.apps");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.auditlog_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.client_apps");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.client_apps_table");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.client_authorizations");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.client_connections");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.clients");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.incoming");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.users");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.recordcounts");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "admin_rights");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "admin_members");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "admin_users");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_site_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sf_customer_map_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sf_customer_master");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_audit");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_order_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_order_line_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_csi_uet_tables");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_csi_uet_fields");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_uet");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_stores_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_products_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_order_lines_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.connector");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.client_connector");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_client_app_connector");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_aptran_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_payments_lines_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_payments_hdr_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_chart_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_ido_prop_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_schema_field Report");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_schema_table Report");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.documents");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.incidents");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_customer_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_job");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_invoice_line_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_invoice_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_expensereport_line_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_expensereport_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_aptran_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_aptrandist_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sc_sro_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_invoice_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_invitem_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_client_inv_items");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.hk_inv_items");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.Adminuggroups");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_invoicedetails_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_po");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_poitem");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_po_rcpt");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_invoicedetails");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_invoicedetails Report");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_vendor");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_invoicedetails_dist_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.timezone");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_po_audit");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_po_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_po_rcpt_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_aptrandist_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.fieldaudit");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_vendor_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_invoicedetails_status_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_orderline_count");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_order_count");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_order_count Report");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.mg_orderline_count Report");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_chart_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_unitcd1_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_unitcd2_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_unitcd3_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_unitcd4_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_terms_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_u_m_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.csi_lc_rcpt_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_aptran_clear_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.SourceManagement");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.apps1");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_vendor_not_match_tosyteline");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sh_fulfillment_orders_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sh_get_order_lines_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sh_get_orders_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sh_products_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.sh_stores_mst");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.Clients_provisioning");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.tp_invoice_temp");
			connectionsIds.InitAndSetArrayItem("Hubkoratec218206166241compute1", "dbo.indcode");
			this._tablesConnectionIds = connectionsIds;
			return null;
		}
		public virtual XVar checkTablesSubqueriesSupport(dynamic _param_dataSourceTName1, dynamic _param_dataSourceTName2)
		{
			#region pass-by-value parameters
			dynamic dataSourceTName1 = XVar.Clone(_param_dataSourceTName1);
			dynamic dataSourceTName2 = XVar.Clone(_param_dataSourceTName2);
			#endregion

			dynamic connId1 = null, connId2 = null;
			connId1 = XVar.Clone(this._tablesConnectionIds[dataSourceTName1]);
			connId2 = XVar.Clone(this._tablesConnectionIds[dataSourceTName2]);
			if(connId1 != connId2)
			{
				return false;
			}
			if((XVar)(this._connectionsData[connId1]["dbType"] == Constants.nDATABASE_Access)  && (XVar)(dataSourceTName1 == dataSourceTName2))
			{
				return false;
			}
			return true;
		}
		public virtual XVar CloseConnections()
		{
			foreach (KeyValuePair<XVar, dynamic> connection in this.cache.GetEnumerator())
			{
				if(XVar.Pack(connection.Value))
				{
					connection.Value.close();
				}
			}
			return null;
		}
	}
}
