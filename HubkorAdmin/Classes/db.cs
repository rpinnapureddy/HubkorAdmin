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
	public partial class DB : XClass
	{
		public static dynamic CurrentConnection()
		{
			return (XVar.Pack(GlobalVars.currentConnection) ? XVar.Pack(GlobalVars.currentConnection) : XVar.Pack(DB.DefaultConnection()));
		}
		public static XVar CurrentConnectionId()
		{
			dynamic conn = null;
			conn = XVar.Clone(DB.CurrentConnection());
			return conn.connId;
		}
		public static XVar DefaultConnection()
		{
			return GlobalVars.cman.getDefault();
		}
		public static XVar ConnectionByTable(dynamic _param_table)
		{
			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			#endregion

			return GlobalVars.cman.byTable((XVar)(table));
		}
		public static XVar ConnectionByName(dynamic _param_name)
		{
			#region pass-by-value parameters
			dynamic name = XVar.Clone(_param_name);
			#endregion

			return GlobalVars.cman.byName((XVar)(name));
		}
		public static XVar SetConnection(dynamic _param_connection)
		{
			#region pass-by-value parameters
			dynamic connection = XVar.Clone(_param_connection);
			#endregion

			if(XVar.Pack(MVCFunctions.is_string((XVar)(connection))))
			{
				GlobalVars.currentConnection = XVar.Clone(DB.ConnectionByName((XVar)(connection)));
			}
			else
			{
				if(XVar.Pack(MVCFunctions.is_a((XVar)(connection), new XVar("Connection"))))
				{
					GlobalVars.currentConnection = XVar.Clone(connection);
				}
			}
			return null;
		}
		public static XVar LastId()
		{
			return DB.CurrentConnection().getInsertedId();
		}
		public static dynamic Query(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			return DB.CurrentConnection().querySilent((XVar)(sql));
		}
		public static XVar Exec(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			return DB.CurrentConnection().execSilent((XVar)(sql)) != null;
		}
		public static XVar LastError()
		{
			return DB.CurrentConnection().lastError();
		}
		public static XVar Select(dynamic _param_table, dynamic _param_userConditions = null, dynamic _param_userOrders = null)
		{
			#region default values
			if(_param_userConditions as Object == null) _param_userConditions = new XVar(XVar.Array());
			if(_param_userOrders as Object == null) _param_userOrders = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic userConditions = XVar.Clone(_param_userConditions);
			dynamic userOrders = XVar.Clone(_param_userOrders);
			#endregion

			dynamic dataSource = null, dc = null, queryResult = null;
			dataSource = XVar.Clone(CommonFunctions.getDbTableDataSource((XVar)(table), (XVar)(DB.CurrentConnectionId())));
			if(XVar.Pack(!(XVar)(dataSource)))
			{
				return false;
			}
			dc = XVar.Clone(new DsCommand());
			dc.filter = XVar.Clone(DB._createFilterCondition((XVar)(userConditions)));
			dc.order = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> userOrder in userOrders.GetEnumerator())
			{
				dynamic orderClause = XVar.Array();
				if(XVar.Pack(MVCFunctions.is_array((XVar)(userOrder.Value))))
				{
					dynamic dir = null;
					orderClause = XVar.Clone(new XVar("column", userOrder.Value[0]));
					dir = XVar.Clone(userOrder.Value[1]);
					switch(((XVar)dir).ToString())
					{
						case "a":
							orderClause.InitAndSetArrayItem("ASC", "dir");
							break;
						case "d":
							orderClause.InitAndSetArrayItem("DESC", "dir");
							break;
					}
				}
				else
				{
					orderClause = XVar.Clone(new XVar("column", userOrder.Value));
				}
				dc.order.InitAndSetArrayItem(orderClause, null);
			}
			queryResult = XVar.Clone(dataSource.getList((XVar)(dc)));
			return queryResult;
		}
		public static XVar SelectValue(dynamic _param_field, dynamic _param_table, dynamic _param_userConditions = null, dynamic _param_order = null)
		{
			#region default values
			if(_param_userConditions as Object == null) _param_userConditions = new XVar(XVar.Array());
			if(_param_order as Object == null) _param_order = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic table = XVar.Clone(_param_table);
			dynamic userConditions = XVar.Clone(_param_userConditions);
			dynamic order = XVar.Clone(_param_order);
			#endregion

			dynamic data = XVar.Array(), rs = null;
			rs = XVar.Clone(DB.Select((XVar)(table), (XVar)(userConditions), (XVar)(order)));
			if(XVar.Pack(!(XVar)(rs)))
			{
				return false;
			}
			data = XVar.Clone(rs.fetchAssoc());
			if(XVar.Pack(data[field]))
			{
				return data[field];
			}
			return false;
		}
		public static XVar Delete(dynamic _param_table, dynamic _param_userConditions = null)
		{
			#region default values
			if(_param_userConditions as Object == null) _param_userConditions = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic userConditions = XVar.Clone(_param_userConditions);
			#endregion

			dynamic dataSource = null, dc = null, prep = XVar.Array(), ret = null;
			dataSource = XVar.Clone(CommonFunctions.getDbTableDataSource((XVar)(table), (XVar)(DB.CurrentConnectionId())));
			if(XVar.Pack(!(XVar)(dataSource)))
			{
				return false;
			}
			dc = XVar.Clone(new DsCommand());
			dc.filter = XVar.Clone(DB._createFilterCondition((XVar)(userConditions)));
			prep = XVar.Clone(dataSource.prepareSQL((XVar)(dc)));
			if(prep["where"] == "")
			{
				return false;
			}
			ret = XVar.Clone(dataSource.deleteSingle((XVar)(dc), new XVar(false)));
			return ret;
		}
		public static XVar Insert(dynamic _param_table, dynamic _param_data)
		{
			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic data = XVar.Clone(_param_data);
			#endregion

			dynamic dataSource = null, dc = null, result = null;
			dataSource = XVar.Clone(CommonFunctions.getDbTableDataSource((XVar)(table), (XVar)(DB.CurrentConnectionId())));
			if(XVar.Pack(!(XVar)(dataSource)))
			{
				return false;
			}
			dc = XVar.Clone(new DsCommand());
			dc.values = XVar.Clone(data);
			result = XVar.Clone(dataSource.insertSingle((XVar)(dc)));
			return !(XVar)(!(XVar)(result));
		}
		public static XVar Update(dynamic _param_table, dynamic _param_data, dynamic _param_userConditions)
		{
			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic data = XVar.Clone(_param_data);
			dynamic userConditions = XVar.Clone(_param_userConditions);
			#endregion

			dynamic dataSource = null, dc = null, result = null;
			dataSource = XVar.Clone(CommonFunctions.getDbTableDataSource((XVar)(table), (XVar)(DB.CurrentConnectionId())));
			if(XVar.Pack(!(XVar)(dataSource)))
			{
				return false;
			}
			if(XVar.Pack(!(XVar)(userConditions)))
			{
				return false;
			}
			dc = XVar.Clone(new DsCommand());
			dc.values = XVar.Clone(data);
			dc.filter = XVar.Clone(DB._createFilterCondition((XVar)(userConditions)));
			result = XVar.Clone(dataSource.updateSingle((XVar)(dc), new XVar(false)));
			return !(XVar)(!(XVar)(result));
		}
		public static XVar Count(dynamic _param_table, dynamic _param_userConditions = null)
		{
			#region default values
			if(_param_userConditions as Object == null) _param_userConditions = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic userConditions = XVar.Clone(_param_userConditions);
			#endregion

			dynamic count = null, dataSource = null, dc = null;
			dataSource = XVar.Clone(CommonFunctions.getDbTableDataSource((XVar)(table), (XVar)(DB.CurrentConnectionId())));
			if(XVar.Pack(!(XVar)(dataSource)))
			{
				return false;
			}
			dc = XVar.Clone(new DsCommand());
			dc.filter = XVar.Clone(DB._createFilterCondition((XVar)(userConditions)));
			count = XVar.Clone(dataSource.getCount((XVar)(dc)));
			return count;
		}
		protected static XVar _createFilterCondition(dynamic _param_userConditions)
		{
			#region pass-by-value parameters
			dynamic userConditions = XVar.Clone(_param_userConditions);
			#endregion

			dynamic conditions = XVar.Array();
			if(XVar.Pack(!(XVar)(MVCFunctions.is_array((XVar)(userConditions)))))
			{
				return DataCondition.SQLCondition((XVar)(userConditions));
			}
			conditions = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> value in userConditions.GetEnumerator())
			{
				if(XVar.Pack(XVar.Equals(XVar.Pack(value.Value), XVar.Pack(null))))
				{
					conditions.InitAndSetArrayItem(DataCondition.FieldIs((XVar)(value.Key), new XVar(Constants.dsopEMPTY), new XVar("")), null);
				}
				else
				{
					conditions.InitAndSetArrayItem(DataCondition.FieldEquals((XVar)(value.Key), (XVar)(value.Value)), null);
				}
			}
			return DataCondition._And((XVar)(conditions));
		}
		protected static XVar _execSilentWithBlobProcessing(dynamic _param_blobs, dynamic _param_dalSQL, dynamic _param_tableinfo, dynamic _param_autoincField = null)
		{
			#region default values
			if(_param_autoincField as Object == null) _param_autoincField = new XVar();
			#endregion

			#region pass-by-value parameters
			dynamic blobs = XVar.Clone(_param_blobs);
			dynamic dalSQL = XVar.Clone(_param_dalSQL);
			dynamic tableinfo = XVar.Clone(_param_tableinfo);
			dynamic autoincField = XVar.Clone(_param_autoincField);
			#endregion

			dynamic blobTypes = XVar.Array();
			blobTypes = XVar.Clone(XVar.Array());
			if(DB.CurrentConnection().dbType == Constants.nDATABASE_Informix)
			{
				foreach (KeyValuePair<XVar, dynamic> fvalue in blobs.GetEnumerator())
				{
					blobTypes.InitAndSetArrayItem(tableinfo[fvalue.Key]["type"], fvalue.Key);
				}
			}
			DB.CurrentConnection().execSilentWithBlobProcessing((XVar)(dalSQL), (XVar)(blobs), (XVar)(blobTypes), (XVar)(autoincField));
			return null;
		}
		protected static XVar _prepareValue(dynamic _param_value, dynamic _param_type)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			dynamic var_type = XVar.Clone(_param_type);
			#endregion

			if(XVar.Pack(XVar.Equals(XVar.Pack(value), XVar.Pack(null))))
			{
				return "NULL";
			}
			if((XVar)((XVar)(DB.CurrentConnection().dbType == Constants.nDATABASE_Oracle)  || (XVar)(DB.CurrentConnection().dbType == Constants.nDATABASE_DB2))  || (XVar)(DB.CurrentConnection().dbType == Constants.nDATABASE_Informix))
			{
				if(XVar.Pack(CommonFunctions.IsBinaryType((XVar)(var_type))))
				{
					if(DB.CurrentConnection().dbType == Constants.nDATABASE_Oracle)
					{
						return "EMPTY_BLOB()";
					}
					return "?";
				}
				if((XVar)(DB.CurrentConnection().dbType == Constants.nDATABASE_Informix)  && (XVar)(CommonFunctions.IsTextType((XVar)(var_type))))
				{
					return "?";
				}
			}
			if((XVar)(CommonFunctions.IsNumberType((XVar)(var_type)))  && (XVar)(!(XVar)(MVCFunctions.IsNumeric(value))))
			{
				value = XVar.Clone(MVCFunctions.trim((XVar)(value)));
				value = XVar.Clone(MVCFunctions.str_replace(new XVar(","), new XVar("."), (XVar)(value)));
				if(XVar.Pack(!(XVar)(MVCFunctions.IsNumeric(value))))
				{
					return "NULL";
				}
			}
			if((XVar)(CommonFunctions.IsDateFieldType((XVar)(var_type)))  || (XVar)(CommonFunctions.IsTimeType((XVar)(var_type))))
			{
				if(XVar.Pack(!(XVar)(value)))
				{
					return "NULL";
				}
				if(XVar.Pack(MVCFunctions.IsNumeric(value)))
				{
					if(XVar.Pack(CommonFunctions.IsDateFieldType((XVar)(var_type))))
					{
						value = XVar.Clone(MVCFunctions.Concat(MVCFunctions.getYMDdate((XVar)(value)), " ", MVCFunctions.getHISdate((XVar)(value))));
					}
					else
					{
						if(XVar.Pack(CommonFunctions.IsTimeType((XVar)(var_type))))
						{
							value = XVar.Clone(MVCFunctions.getHISdate((XVar)(value)));
						}
					}
				}
				return DB.CurrentConnection().addDateQuotes((XVar)(value));
			}
			if(XVar.Pack(CommonFunctions.NeedQuotes((XVar)(var_type))))
			{
				return DB.CurrentConnection().prepareString((XVar)(value));
			}
			return value;
		}
		public static XVar _findDalTable(dynamic _param_table, dynamic _param_conn = null)
		{
			#region default values
			if(_param_conn as Object == null) _param_conn = new XVar();
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic conn = XVar.Clone(_param_conn);
			#endregion

			dynamic tableName = XVar.Array();
			if(XVar.Pack(!(XVar)(conn)))
			{
				conn = XVar.Clone(DB.CurrentConnection());
			}
			tableName = XVar.Clone(conn.getTableNameComponents((XVar)(table)));
			DB._fillTablesList((XVar)(conn));
			foreach (KeyValuePair<XVar, dynamic> t in GlobalVars.dalTables[conn.connId].GetEnumerator())
			{
				if((XVar)((XVar)(!(XVar)(tableName["schema"]))  || (XVar)(t.Value["schema"] == tableName["schema"]))  && (XVar)(t.Value["name"] == tableName["table"]))
				{
					return t.Value;
				}
			}
			tableName.InitAndSetArrayItem(MVCFunctions.strtoupper((XVar)(tableName["schema"])), "schema");
			tableName.InitAndSetArrayItem(MVCFunctions.strtoupper((XVar)(tableName["table"])), "table");
			foreach (KeyValuePair<XVar, dynamic> t in GlobalVars.dalTables[conn.connId].GetEnumerator())
			{
				if((XVar)((XVar)(!(XVar)(tableName["schema"]))  || (XVar)(MVCFunctions.strtoupper((XVar)(t.Value["schema"])) == tableName["schema"]))  && (XVar)(MVCFunctions.strtoupper((XVar)(t.Value["name"])) == tableName["table"]))
				{
					return t.Value;
				}
			}
			return null;
		}
		public static XVar _getTableInfo(dynamic _param_table, dynamic _param_connId = null)
		{
			#region default values
			if(_param_connId as Object == null) _param_connId = new XVar();
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic connId = XVar.Clone(_param_connId);
			#endregion

			dynamic tableDescriptor = XVar.Array(), tableInfo = XVar.Array();
			if(XVar.Pack(!(XVar)(connId)))
			{
				connId = XVar.Clone(DB.CurrentConnectionId());
			}
			if(XVar.Pack(!(XVar)(GlobalVars.tableinfo_cache.KeyExists(connId))))
			{
				GlobalVars.tableinfo_cache.InitAndSetArrayItem(XVar.Array(), connId);
			}
			tableInfo = XVar.Clone(XVar.Array());
			tableDescriptor = XVar.Clone(DB._findDalTable((XVar)(table), (XVar)(GlobalVars.cman.byId((XVar)(connId)))));
			if(XVar.Pack(tableDescriptor))
			{
				MVCFunctions.importTableInfo((XVar)(tableDescriptor["varname"]));
				tableInfo.InitAndSetArrayItem(GlobalVars.dal_info[tableDescriptor["varname"]], "fields");
				if(XVar.Pack(tableDescriptor["schema"]))
				{
					tableInfo.InitAndSetArrayItem(MVCFunctions.Concat(tableDescriptor["schema"], ".", tableDescriptor["name"]), "fullName");
				}
				else
				{
					tableInfo.InitAndSetArrayItem(tableDescriptor["name"], "fullName");
				}
			}
			else
			{
				dynamic fieldList = XVar.Array(), helpSql = null;
				if(XVar.Pack(GlobalVars.tableinfo_cache[connId].KeyExists(table)))
				{
					return GlobalVars.tableinfo_cache[connId][table];
				}
				helpSql = XVar.Clone(MVCFunctions.Concat("select * from ", DB.CurrentConnection().addTableWrappers((XVar)(table)), " where 1=0"));
				tableInfo.InitAndSetArrayItem(table, "fullName");
				tableInfo.InitAndSetArrayItem(XVar.Array(), "fields");
				GlobalVars.tableinfo_cache.InitAndSetArrayItem(false, connId, table);
				fieldList = XVar.Clone(DB.CurrentConnection().getFieldsList((XVar)(helpSql)));
				foreach (KeyValuePair<XVar, dynamic> f in fieldList.GetEnumerator())
				{
					tableInfo.InitAndSetArrayItem(new XVar("type", f.Value["type"], "name", f.Value["fieldname"]), "fields", f.Value["fieldname"]);
				}
				GlobalVars.tableinfo_cache.InitAndSetArrayItem(tableInfo, connId, table);
			}
			return tableInfo;
		}
		protected static XVar _fillTablesList(dynamic _param_conn)
		{
			#region pass-by-value parameters
			dynamic conn = XVar.Clone(_param_conn);
			#endregion

			if(XVar.Pack(!(XVar)(conn)))
			{
				conn = XVar.Clone(DB.CurrentConnection());
			}
			if(XVar.Pack(GlobalVars.dalTables.KeyExists(conn.connId)))
			{
				return null;
			}
			GlobalVars.dalTables.InitAndSetArrayItem(XVar.Array(), conn.connId);
			if("Hubkoratec218206166241compute1" == conn.connId)
			{
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "Adminuggroups", "varname", "Hubkoratec218206166241compute1_dbo_Adminuggroups", "altvarname", "Adminuggroups", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "Adminugmembers", "varname", "Hubkoratec218206166241compute1_dbo_Adminugmembers", "altvarname", "Adminugmembers", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "Adminugrights", "varname", "Hubkoratec218206166241compute1_dbo_Adminugrights", "altvarname", "Adminugrights", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "apps", "varname", "Hubkoratec218206166241compute1_dbo_apps", "altvarname", "apps", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "auditlog_mst", "varname", "Hubkoratec218206166241compute1_dbo_auditlog_mst", "altvarname", "auditlog_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "client_apps", "varname", "Hubkoratec218206166241compute1_dbo_client_apps", "altvarname", "client_apps", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "client_apps_table", "varname", "Hubkoratec218206166241compute1_dbo_client_apps_table", "altvarname", "client_apps_table", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "client_authorizations", "varname", "Hubkoratec218206166241compute1_dbo_client_authorizations", "altvarname", "client_authorizations", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "client_connections", "varname", "Hubkoratec218206166241compute1_dbo_client_connections", "altvarname", "client_connections", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "client_connector", "varname", "Hubkoratec218206166241compute1_dbo_client_connector", "altvarname", "client_connector", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "clients", "varname", "Hubkoratec218206166241compute1_dbo_clients", "altvarname", "clients", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "Clients_provisioning", "varname", "Hubkoratec218206166241compute1_dbo_Clients_provisioning", "altvarname", "Clients_provisioning", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "connector", "varname", "Hubkoratec218206166241compute1_dbo_connector", "altvarname", "connector", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_chart_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_chart_mst", "altvarname", "csi_chart_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_ido_prop_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_ido_prop_mst", "altvarname", "csi_ido_prop_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_lc_rcpt_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_lc_rcpt_mst", "altvarname", "csi_lc_rcpt_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_po_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_po_mst", "altvarname", "csi_po_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_site_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_site_mst", "altvarname", "csi_site_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_terms_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_terms_mst", "altvarname", "csi_terms_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_u_m_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_u_m_mst", "altvarname", "csi_u_m_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_unitcd1_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd1_mst", "altvarname", "csi_unitcd1_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_unitcd2_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd2_mst", "altvarname", "csi_unitcd2_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_unitcd3_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd3_mst", "altvarname", "csi_unitcd3_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "csi_unitcd4_mst", "varname", "Hubkoratec218206166241compute1_dbo_csi_unitcd4_mst", "altvarname", "csi_unitcd4_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "documents", "varname", "Hubkoratec218206166241compute1_dbo_documents", "altvarname", "documents", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "fieldaudit", "varname", "Hubkoratec218206166241compute1_dbo_fieldaudit", "altvarname", "fieldaudit", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_audit", "varname", "Hubkoratec218206166241compute1_dbo_hk_audit", "altvarname", "hk_audit", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_client_app_connector", "varname", "Hubkoratec218206166241compute1_dbo_hk_client_app_connector", "altvarname", "hk_client_app_connector", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_client_inv_items", "varname", "Hubkoratec218206166241compute1_dbo_hk_client_inv_items", "altvarname", "hk_client_inv_items", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_csi_uet_fields", "varname", "Hubkoratec218206166241compute1_dbo_hk_csi_uet_fields", "altvarname", "hk_csi_uet_fields", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_csi_uet_tables", "varname", "Hubkoratec218206166241compute1_dbo_hk_csi_uet_tables", "altvarname", "hk_csi_uet_tables", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_inv_items", "varname", "Hubkoratec218206166241compute1_dbo_hk_inv_items", "altvarname", "hk_inv_items", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_invitem_mst", "varname", "Hubkoratec218206166241compute1_dbo_hk_invitem_mst", "altvarname", "hk_invitem_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_invoice_mst", "varname", "Hubkoratec218206166241compute1_dbo_hk_invoice_mst", "altvarname", "hk_invoice_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_job", "varname", "Hubkoratec218206166241compute1_dbo_hk_job", "altvarname", "hk_job", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_schema_field", "varname", "Hubkoratec218206166241compute1_dbo_hk_schema_field", "altvarname", "hk_schema_field", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_schema_table", "varname", "Hubkoratec218206166241compute1_dbo_hk_schema_table", "altvarname", "hk_schema_table", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "hk_uet", "varname", "Hubkoratec218206166241compute1_dbo_hk_uet", "altvarname", "hk_uet", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "incidents", "varname", "Hubkoratec218206166241compute1_dbo_incidents", "altvarname", "incidents", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "incoming", "varname", "Hubkoratec218206166241compute1_dbo_incoming", "altvarname", "incoming", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "indcode", "varname", "Hubkoratec218206166241compute1_dbo_indcode", "altvarname", "indcode", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_customer_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_customer_mst", "altvarname", "mg_customer_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_order_count", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_count", "altvarname", "mg_order_count", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_order_line_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_line_mst", "altvarname", "mg_order_line_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_order_lines_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_lines_mst", "altvarname", "mg_order_lines_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_order_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_order_mst", "altvarname", "mg_order_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_orderline_count", "varname", "Hubkoratec218206166241compute1_dbo_mg_orderline_count", "altvarname", "mg_orderline_count", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_products_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_products_mst", "altvarname", "mg_products_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "mg_stores_mst", "varname", "Hubkoratec218206166241compute1_dbo_mg_stores_mst", "altvarname", "mg_stores_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "recordcounts", "varname", "Hubkoratec218206166241compute1_dbo_recordcounts", "altvarname", "recordcounts", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_aptran_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_aptran_mst", "altvarname", "sc_aptran_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_aptrandist_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_aptrandist_mst", "altvarname", "sc_aptrandist_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_expensereport_line_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_expensereport_line_mst", "altvarname", "sc_expensereport_line_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_expensereport_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_expensereport_mst", "altvarname", "sc_expensereport_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_indcode", "varname", "Hubkoratec218206166241compute1_dbo_sc_indcode", "altvarname", "sc_indcode", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_invoice_line_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_invoice_line_mst", "altvarname", "sc_invoice_line_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_invoice_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_invoice_mst", "altvarname", "sc_invoice_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sc_sro_mst", "varname", "Hubkoratec218206166241compute1_dbo_sc_sro_mst", "altvarname", "sc_sro_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sf_customer_map_mst", "varname", "Hubkoratec218206166241compute1_dbo_sf_customer_map_mst", "altvarname", "sf_customer_map_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sf_customer_master", "varname", "Hubkoratec218206166241compute1_dbo_sf_customer_master", "altvarname", "sf_customer_master", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sh_fulfillment_orders_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_fulfillment_orders_mst", "altvarname", "sh_fulfillment_orders_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sh_get_order_lines_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_get_order_lines_mst", "altvarname", "sh_get_order_lines_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sh_get_orders_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_get_orders_mst", "altvarname", "sh_get_orders_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sh_products_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_products_mst", "altvarname", "sh_products_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "sh_stores_mst", "varname", "Hubkoratec218206166241compute1_dbo_sh_stores_mst", "altvarname", "sh_stores_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "SourceManagement", "varname", "Hubkoratec218206166241compute1_dbo_SourceManagement", "altvarname", "SourceManagement", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "timezone", "varname", "Hubkoratec218206166241compute1_dbo_timezone", "altvarname", "timezone", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_aptran_clear_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_aptran_clear_mst", "altvarname", "tp_aptran_clear_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_aptran_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_aptran_mst", "altvarname", "tp_aptran_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_aptrandist_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_aptrandist_mst", "altvarname", "tp_aptrandist_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_chart_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_chart_mst", "altvarname", "tp_chart_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_invoice_temp", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoice_temp", "altvarname", "tp_invoice_temp", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_invoicedetails", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails", "altvarname", "tp_invoicedetails", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_invoicedetails_dist_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_dist_mst", "altvarname", "tp_invoicedetails_dist_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_invoicedetails_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_mst", "altvarname", "tp_invoicedetails_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_invoicedetails_status_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_invoicedetails_status_mst", "altvarname", "tp_invoicedetails_status_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_payments_hdr_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_payments_hdr_mst", "altvarname", "tp_payments_hdr_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_payments_lines_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_payments_lines_mst", "altvarname", "tp_payments_lines_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_po", "varname", "Hubkoratec218206166241compute1_dbo_tp_po", "altvarname", "tp_po", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_po_audit", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_audit", "altvarname", "tp_po_audit", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_po_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_mst", "altvarname", "tp_po_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_po_rcpt", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_rcpt", "altvarname", "tp_po_rcpt", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_po_rcpt_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_po_rcpt_mst", "altvarname", "tp_po_rcpt_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_poitem", "varname", "Hubkoratec218206166241compute1_dbo_tp_poitem", "altvarname", "tp_poitem", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_vendor", "varname", "Hubkoratec218206166241compute1_dbo_tp_vendor", "altvarname", "tp_vendor", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_vendor_mst", "varname", "Hubkoratec218206166241compute1_dbo_tp_vendor_mst", "altvarname", "tp_vendor_mst", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "tp_vendor_not_match_tosyteline", "varname", "Hubkoratec218206166241compute1_dbo_tp_vendor_not_match_tosyteline", "altvarname", "tp_vendor_not_match_tosyteline", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
				GlobalVars.dalTables.InitAndSetArrayItem(new XVar("name", "users", "varname", "Hubkoratec218206166241compute1_dbo_users", "altvarname", "users", "connId", "Hubkoratec218206166241compute1", "schema", "dbo", "connName", "PortalL"), conn.connId, null);
			}
			return null;
		}
		public static XVar PrepareConnectionSQL(dynamic _param_conn, dynamic _param_sql, dynamic _param_arg1 = null, dynamic _param_arg2 = null, dynamic _param_arg3 = null, dynamic _param_arg4 = null, dynamic _param_arg5 = null, dynamic _param_arg6 = null, dynamic _param_arg7 = null, dynamic _param_arg8 = null, dynamic _param_arg9 = null, dynamic _param_arg10 = null)
		{
			#region default values
			if(_param_arg1 as Object == null) _param_arg1 = new XVar();
			if(_param_arg2 as Object == null) _param_arg2 = new XVar();
			if(_param_arg3 as Object == null) _param_arg3 = new XVar();
			if(_param_arg4 as Object == null) _param_arg4 = new XVar();
			if(_param_arg5 as Object == null) _param_arg5 = new XVar();
			if(_param_arg6 as Object == null) _param_arg6 = new XVar();
			if(_param_arg7 as Object == null) _param_arg7 = new XVar();
			if(_param_arg8 as Object == null) _param_arg8 = new XVar();
			if(_param_arg9 as Object == null) _param_arg9 = new XVar();
			if(_param_arg10 as Object == null) _param_arg10 = new XVar();
			#endregion

			#region pass-by-value parameters
			dynamic conn = XVar.Clone(_param_conn);
			dynamic sql = XVar.Clone(_param_sql);
			dynamic arg1 = XVar.Clone(_param_arg1);
			dynamic arg2 = XVar.Clone(_param_arg2);
			dynamic arg3 = XVar.Clone(_param_arg3);
			dynamic arg4 = XVar.Clone(_param_arg4);
			dynamic arg5 = XVar.Clone(_param_arg5);
			dynamic arg6 = XVar.Clone(_param_arg6);
			dynamic arg7 = XVar.Clone(_param_arg7);
			dynamic arg8 = XVar.Clone(_param_arg8);
			dynamic arg9 = XVar.Clone(_param_arg9);
			dynamic arg10 = XVar.Clone(_param_arg10);
			#endregion

			dynamic prevConn = null, result = null;
			prevConn = XVar.Clone(DB.CurrentConnection());
			DB.SetConnection((XVar)(conn));
			result = XVar.Clone(DB.PrepareSQL((XVar)(sql), (XVar)(arg1), (XVar)(arg2), (XVar)(arg3), (XVar)(arg4), (XVar)(arg5), (XVar)(arg6), (XVar)(arg7), (XVar)(arg8), (XVar)(arg9), (XVar)(arg10)));
			DB.SetConnection((XVar)(prevConn));
			return result;
		}
		public static XVar PrepareSQL(dynamic _param_sql, params dynamic[] _param_args)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			dynamic args = XVar.Clone(_param_args);
			#endregion

			dynamic conn = null, replacements = XVar.Array(), tokens = XVar.Array();
			args = XVar.Clone(CommonFunctions.func_get_args(_param_sql, _param_args));
			conn = XVar.Clone(DB.CurrentConnection());
			tokens = XVar.Clone(DB.scanTokenString((XVar)(sql)));
			replacements = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> match in tokens["matches"].GetEnumerator())
			{
				dynamic inQuotes = null, offset = null, repl = XVar.Array(), token = null, val = XVar.Array();
				offset = XVar.Clone(tokens["offsets"][match.Key]);
				token = XVar.Clone(tokens["tokens"][match.Key]);
				repl = XVar.Clone(new XVar("offset", offset, "len", MVCFunctions.strlen((XVar)(match.Value))));
				val = new XVar("");
				if((XVar)(MVCFunctions.IsNumeric(token))  && (XVar)(token < MVCFunctions.count(args)))
				{
					val = XVar.Clone(args[(int)token]);
				}
				else
				{
					val = XVar.Clone(RunnerContext.getValue((XVar)(token)));
				}
				inQuotes = XVar.Clone(conn.positionQuoted((XVar)(sql), (XVar)(offset)));
				if(XVar.Pack(MVCFunctions.is_array((XVar)(val))))
				{
					dynamic _values = XVar.Array(), glued = null;
					_values = XVar.Clone(XVar.Array());
					foreach (KeyValuePair<XVar, dynamic> v in val.GetEnumerator())
					{
						if(XVar.Pack(inQuotes))
						{
							_values.InitAndSetArrayItem(MVCFunctions.Concat("'", conn.addSlashes((XVar)(v.Value)), "'"), null);
						}
						else
						{
							_values.InitAndSetArrayItem(DB.prepareNumberValue((XVar)(v.Value)), null);
						}
					}
					glued = XVar.Clone(MVCFunctions.implode(new XVar(","), (XVar)(_values)));
					repl.InitAndSetArrayItem((XVar.Pack(inQuotes) ? XVar.Pack(MVCFunctions.substr((XVar)(glued), new XVar(1), (XVar)(MVCFunctions.strlen((XVar)(glued)) - 2))) : XVar.Pack(glued)), "insert");
				}
				else
				{
					if(XVar.Pack(inQuotes))
					{
						repl.InitAndSetArrayItem(conn.addSlashes((XVar)(val)), "insert");
					}
					else
					{
						repl.InitAndSetArrayItem(DB.prepareNumberValue((XVar)(val)), "insert");
					}
				}
				replacements.InitAndSetArrayItem(repl, null);
			}
			return RunnerContext.doReplacements((XVar)(sql), (XVar)(replacements));
		}
		public static XVar readSQLTokens(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			dynamic arr = XVar.Array();
			arr = XVar.Clone(DB.scanTokenString((XVar)(sql)));
			return arr["tokens"];
		}
		public static XVar readMasterTokens(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			dynamic allTokens = XVar.Array(), masterTokens = XVar.Array();
			masterTokens = XVar.Clone(XVar.Array());
			allTokens = XVar.Clone(DB.readSQLTokens((XVar)(sql)));
			foreach (KeyValuePair<XVar, dynamic> token in allTokens.GetEnumerator())
			{
				dynamic dotPos = null;
				dotPos = XVar.Clone(MVCFunctions.strpos((XVar)(token.Value), new XVar(".")));
				if((XVar)(!XVar.Equals(XVar.Pack(dotPos), XVar.Pack(false)))  && (XVar)(MVCFunctions.strtolower((XVar)(MVCFunctions.substr((XVar)(token.Value), new XVar(0), (XVar)(dotPos)))) == "master"))
				{
					masterTokens.InitAndSetArrayItem(token.Value, null);
				}
			}
			return masterTokens;
		}
		public static XVar scanTokenString(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			dynamic matches = XVar.Array(), offsets = XVar.Array(), pattern = null, result = XVar.Array(), tokens = XVar.Array();
			tokens = XVar.Clone(XVar.Array());
			offsets = XVar.Clone(XVar.Array());
			matches = XVar.Clone(XVar.Array());
			pattern = new XVar("/(?:[^\\w\\:]|^)(\\:([a-zA-Z_]{1}[\\w\\.]*))|\\:\\{([^\\:]*?)\\}|(?:[^\\w\\:]|^)(\\:([1-9]+[0-9]*))/");
			result = XVar.Clone(MVCFunctions.findMatches((XVar)(pattern), (XVar)(sql)));
			foreach (KeyValuePair<XVar, dynamic> m in result.GetEnumerator())
			{
				if(m.Value["submatches"][0] != "")
				{
					matches.InitAndSetArrayItem(m.Value["submatches"][0], null);
					tokens.InitAndSetArrayItem(m.Value["submatches"][1], null);
					offsets.InitAndSetArrayItem(m.Value["offset"] + MVCFunctions.strpos((XVar)(m.Value["match"]), (XVar)(m.Value["submatches"][0])), null);
				}
				else
				{
					if(m.Value["submatches"][2] != "")
					{
						matches.InitAndSetArrayItem(m.Value["match"], null);
						tokens.InitAndSetArrayItem(m.Value["submatches"][2], null);
						offsets.InitAndSetArrayItem(m.Value["offset"], null);
					}
					else
					{
						if(m.Value["submatches"][3] != "")
						{
							matches.InitAndSetArrayItem(m.Value["submatches"][3], null);
							tokens.InitAndSetArrayItem(m.Value["submatches"][4], null);
							offsets.InitAndSetArrayItem(m.Value["offset"] + MVCFunctions.strpos((XVar)(m.Value["match"]), (XVar)(m.Value["submatches"][3])), null);
						}
					}
				}
			}
			return new XVar("tokens", tokens, "matches", matches, "offsets", offsets);
		}
		public static XVar scanNewTokenString(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			dynamic matches = XVar.Array(), offsets = XVar.Array(), pattern = null, result = XVar.Array(), tokens = XVar.Array();
			tokens = XVar.Clone(XVar.Array());
			offsets = XVar.Clone(XVar.Array());
			matches = XVar.Clone(XVar.Array());
			pattern = new XVar("/\\${[^\\s\\{\\}]+}/");
			result = XVar.Clone(MVCFunctions.findMatches((XVar)(pattern), (XVar)(sql)));
			foreach (KeyValuePair<XVar, dynamic> m in result.GetEnumerator())
			{
				dynamic match = null;
				match = XVar.Clone(m.Value["match"]);
				if(match != XVar.Pack(""))
				{
					matches.InitAndSetArrayItem(match, null);
					tokens.InitAndSetArrayItem(MVCFunctions.substr((XVar)(match), new XVar(2), (XVar)(MVCFunctions.strlen((XVar)(match)) - 3)), null);
					offsets.InitAndSetArrayItem(m.Value["offset"], null);
				}
			}
			return new XVar("tokens", tokens, "matches", matches, "offsets", offsets);
		}
		public static XVar prepareNumberValue(dynamic _param_value)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			#endregion

			dynamic strvalue = null;
			strvalue = XVar.Clone(MVCFunctions.str_replace(new XVar(","), new XVar("."), (XVar)(XVar.Pack(value).ToString())));
			if(XVar.Pack(MVCFunctions.IsNumeric(strvalue)))
			{
				return strvalue;
			}
			return 0;
		}
		public static XVar Lookup(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			dynamic data = XVar.Array(), result = null;
			result = XVar.Clone(DB.Query((XVar)(sql)));
			if(XVar.Pack(!(XVar)(result)))
			{
				return null;
			}
			data = XVar.Clone(result.fetchNumeric());
			if(XVar.Pack(!(XVar)(data)))
			{
				return null;
			}
			return data[0];
		}
		public static XVar DBLookup(dynamic _param_sql)
		{
			#region pass-by-value parameters
			dynamic sql = XVar.Clone(_param_sql);
			#endregion

			return DB.Lookup((XVar)(sql));
		}
	}
}
