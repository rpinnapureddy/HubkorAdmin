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
	public partial class CommonFunctions
	{
		public static XVar getLookupMainTableSettings(dynamic _param_lookupTable, dynamic _param_mainTableShortName, dynamic _param_mainField, dynamic _param_desiredPage = null)
		{
			#region default values
			if(_param_desiredPage as Object == null) _param_desiredPage = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic lookupTable = XVar.Clone(_param_lookupTable);
			dynamic mainTableShortName = XVar.Clone(_param_mainTableShortName);
			dynamic mainField = XVar.Clone(_param_mainField);
			dynamic desiredPage = XVar.Clone(_param_desiredPage);
			#endregion

			dynamic arr = XVar.Array(), effectivePage = null;
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists(lookupTable))))
			{
				return null;
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks[lookupTable].KeyExists(MVCFunctions.Concat(mainTableShortName, ".", mainField)))))
			{
				return null;
			}
			arr = GlobalVars.lookupTableLinks[lookupTable][MVCFunctions.Concat(mainTableShortName, ".", mainField)];
			effectivePage = XVar.Clone(desiredPage);
			if(XVar.Pack(!(XVar)(arr.KeyExists(effectivePage))))
			{
				effectivePage = new XVar(Constants.PAGE_EDIT);
				if(XVar.Pack(!(XVar)(arr.KeyExists(effectivePage))))
				{
					if((XVar)(desiredPage == XVar.Pack(""))  && (XVar)(0 < MVCFunctions.count(arr)))
					{
						effectivePage = XVar.Clone(arr[0]);
					}
					else
					{
						return null;
					}
				}
			}
			return new ProjectSettings((XVar)(arr[effectivePage]["table"]), (XVar)(effectivePage));
		}
		public static XVar InitLookupLinks()
		{
			GlobalVars.lookupTableLinks = XVar.Clone(XVar.Array());
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("client_apps.client"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "client_apps.client");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_apps", "field", "client", "page", "edit"), "dbo.clients", "client_apps.client", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("client_apps.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "client_apps.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_apps", "field", "app", "page", "edit"), "dbo.apps", "client_apps.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.client_connections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_connections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.client_connections"].KeyExists("client_apps.profile_id"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_connections", "client_apps.profile_id");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_apps", "field", "profile_id", "page", "edit"), "dbo.client_connections", "client_apps.profile_id", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("client_connections.client"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "client_connections.client");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_connections", "field", "client", "page", "edit"), "dbo.clients", "client_connections.client", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("client_connections.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "client_connections.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_connections", "field", "app", "page", "edit"), "dbo.apps", "client_connections.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.csi_site_mst"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.csi_site_mst");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.csi_site_mst"].KeyExists("clients.sl_master_site"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.csi_site_mst", "clients.sl_master_site");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.clients", "field", "sl_master_site", "page", "edit"), "dbo.csi_site_mst", "clients.sl_master_site", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.users"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.users"].KeyExists("clients.account_manager"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users", "clients.account_manager");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.clients", "field", "account_manager", "page", "edit"), "dbo.users", "clients.account_manager", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.users"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.users"].KeyExists("clients.service_manager"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users", "clients.service_manager");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.clients", "field", "service_manager", "page", "edit"), "dbo.users", "clients.service_manager", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.users"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.users"].KeyExists("clients.project_manager"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users", "clients.project_manager");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.clients", "field", "project_manager", "page", "edit"), "dbo.users", "clients.project_manager", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.users"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.users"].KeyExists("clients.primary_contact"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.users", "clients.primary_contact");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.clients", "field", "primary_contact", "page", "edit"), "dbo.users", "clients.primary_contact", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("users.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "users.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.users", "field", "clientid", "page", "edit"), "dbo.clients", "users.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.timezone"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.timezone");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.timezone"].KeyExists("users.time_zone"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.timezone", "users.time_zone");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.users", "field", "time_zone", "page", "edit"), "dbo.timezone", "users.time_zone", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("sf_customer_map_mst.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "sf_customer_map_mst.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.sf_customer_map_mst", "field", "clientid", "page", "edit"), "dbo.clients", "sf_customer_map_mst.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("hk_uet.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "hk_uet.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_uet", "field", "clientid", "page", "edit"), "dbo.clients", "hk_uet.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.hk_csi_uet_tables"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_csi_uet_tables");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.hk_csi_uet_tables"].KeyExists("hk_uet.table"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_csi_uet_tables", "hk_uet.table");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_uet", "field", "table", "page", "edit"), "dbo.hk_csi_uet_tables", "hk_uet.table", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.hk_csi_uet_fields"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_csi_uet_fields");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.hk_csi_uet_fields"].KeyExists("hk_uet.field_to"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_csi_uet_fields", "hk_uet.field_to");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_uet", "field", "field_to", "page", "edit"), "dbo.hk_csi_uet_fields", "hk_uet.field_to", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("mg_stores_mst.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "mg_stores_mst.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.mg_stores_mst", "field", "clientid", "page", "edit"), "dbo.clients", "mg_stores_mst.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.csi_site_mst"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.csi_site_mst");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.csi_site_mst"].KeyExists("mg_stores_mst.site_ref"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.csi_site_mst", "mg_stores_mst.site_ref");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.mg_stores_mst", "field", "site_ref", "page", "edit"), "dbo.csi_site_mst", "mg_stores_mst.site_ref", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("connector.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "connector.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.connector", "field", "app", "page", "edit"), "dbo.apps", "connector.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("client_connector.client"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "client_connector.client");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_connector", "field", "client", "page", "edit"), "dbo.clients", "client_connector.client", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.hk_client_app_connector"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_client_app_connector");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.hk_client_app_connector"].KeyExists("client_connector.connector"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_client_app_connector", "client_connector.connector");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_connector", "field", "connector", "page", "edit"), "dbo.hk_client_app_connector", "client_connector.connector", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.client_apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.client_apps"].KeyExists("client_connector.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps", "client_connector.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.client_connector", "field", "app", "page", "edit"), "dbo.client_apps", "client_connector.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("tp_chart_mst.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "tp_chart_mst.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.tp_chart_mst", "field", "clientid", "page", "edit"), "dbo.clients", "tp_chart_mst.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("csi_ido_prop_mst.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "csi_ido_prop_mst.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.csi_ido_prop_mst", "field", "clientid", "page", "edit"), "dbo.clients", "csi_ido_prop_mst.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.client_apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.client_apps"].KeyExists("csi_ido_prop_mst.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps", "csi_ido_prop_mst.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.csi_ido_prop_mst", "field", "app", "page", "edit"), "dbo.client_apps", "csi_ido_prop_mst.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("documents.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "documents.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.documents", "field", "clientid", "page", "edit"), "dbo.clients", "documents.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("documents.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "documents.apps");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.documents", "field", "apps", "page", "edit"), "dbo.apps", "documents.apps", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("incidents.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "incidents.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.incidents", "field", "clientid", "page", "edit"), "dbo.clients", "incidents.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.client_apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.client_apps"].KeyExists("incidents.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps", "incidents.apps");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.incidents", "field", "apps", "page", "edit"), "dbo.client_apps", "incidents.apps", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("hk_invoice_mst.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "hk_invoice_mst.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_invoice_mst", "field", "clientid", "page", "edit"), "dbo.clients", "hk_invoice_mst.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.client_apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.client_apps"].KeyExists("hk_invitem_mst.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps", "hk_invitem_mst.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_invitem_mst", "field", "app", "page", "edit"), "dbo.client_apps", "hk_invitem_mst.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.hk_client_inv_items"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_client_inv_items");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.hk_client_inv_items"].KeyExists("hk_invitem_mst.item"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_client_inv_items", "hk_invitem_mst.item");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_invitem_mst", "field", "item", "page", "edit"), "dbo.hk_client_inv_items", "hk_invitem_mst.item", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("hk_invitem_mst.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "hk_invitem_mst.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_invitem_mst", "field", "clientid", "page", "edit"), "dbo.clients", "hk_invitem_mst.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.clients"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.clients"].KeyExists("hk_client_inv_items.clientid"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.clients", "hk_client_inv_items.clientid");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_client_inv_items", "field", "clientid", "page", "edit"), "dbo.clients", "hk_client_inv_items.clientid", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.client_apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.client_apps"].KeyExists("hk_client_inv_items.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.client_apps", "hk_client_inv_items.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_client_inv_items", "field", "app", "page", "edit"), "dbo.client_apps", "hk_client_inv_items.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.hk_inv_items"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_inv_items");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.hk_inv_items"].KeyExists("hk_client_inv_items.item"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.hk_inv_items", "hk_client_inv_items.item");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_client_inv_items", "field", "item", "page", "edit"), "dbo.hk_inv_items", "hk_client_inv_items.item", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("hk_inv_items.app"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "hk_inv_items.app");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.hk_inv_items", "field", "app", "page", "edit"), "dbo.apps", "hk_inv_items.app", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("sourcemanagement.Application"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "sourcemanagement.Application");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.SourceManagement", "field", "Application", "page", "edit"), "dbo.apps", "sourcemanagement.Application", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.apps"].KeyExists("clients_provisioning.apps"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.apps", "clients_provisioning.apps");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Clients_provisioning", "field", "apps", "page", "edit"), "dbo.apps", "clients_provisioning.apps", "edit");
			return null;
		}
	}
}
