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
	public partial class admin_rightsController : BaseController
	{
		public ActionResult list()
		{
			try
			{
				dynamic mask = null, options = XVar.Array(), pageMask = XVar.Array(), pageObject = null, table = null, tables = XVar.Array();
				XTempl xt;
				GlobalVars.init_dbcommon();
				MVCFunctions.Header("Expires", "Thu, 01 Jan 1970 00:00:01 GMT");
				admin_rights_Variables.Apply();
				if(XVar.Pack(!(XVar)(Security.processAdminPageSecurity(new XVar(false)))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				tables = XVar.Clone(XVar.Array());
				pageMask = XVar.Clone(XVar.Array());
				table = new XVar("dbo.apps");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "apps", 1, MVCFunctions.Concat(" ", "Apps")), table);
				table = new XVar("dbo.auditlog_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "auditlog_mst", 1, MVCFunctions.Concat(" ", "Auditlog Mst")), table);
				table = new XVar("dbo.client_apps");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "client_apps", 1, MVCFunctions.Concat(" ", "Client Apps")), table);
				table = new XVar("dbo.client_apps_table");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "client_apps_table", 1, MVCFunctions.Concat(" ", "Client Apps Table")), table);
				table = new XVar("dbo.client_authorizations");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "client_authorizations", 1, MVCFunctions.Concat(" ", "Client Authorizations")), table);
				table = new XVar("dbo.client_connections");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "client_connections", 1, MVCFunctions.Concat(" ", "Client Connections")), table);
				table = new XVar("dbo.clients");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "clients", 1, MVCFunctions.Concat(" ", "Clients")), table);
				table = new XVar("dbo.incoming");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "incoming", 1, MVCFunctions.Concat(" ", "Incoming")), table);
				table = new XVar("dbo.users");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "users", 1, MVCFunctions.Concat(" ", "Users")), table);
				table = new XVar("dbo.recordcounts");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "recordcounts", 1, MVCFunctions.Concat(" ", "Recordcounts")), table);
				table = new XVar("dbo.csi_site_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_site_mst", 1, MVCFunctions.Concat(" ", "Csi Site Mst")), table);
				table = new XVar("dbo.sf_customer_map_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sf_customer_map_mst", 1, MVCFunctions.Concat(" ", "Sf Customer Map Mst")), table);
				table = new XVar("dbo.sf_customer_master");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sf_customer_master", 1, MVCFunctions.Concat(" ", "Sf Customer Master")), table);
				table = new XVar("dbo.hk_audit");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_audit", 1, MVCFunctions.Concat(" ", "Hk Audit")), table);
				table = new XVar("dbo.mg_order_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_order_mst", 1, MVCFunctions.Concat(" ", "Mg Order Mst")), table);
				table = new XVar("dbo.mg_order_line_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_order_line_mst", 1, MVCFunctions.Concat(" ", "MG Lines")), table);
				table = new XVar("dbo.hk_csi_uet_tables");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_csi_uet_tables", 1, MVCFunctions.Concat(" ", "Hk Csi Uet Tables")), table);
				table = new XVar("dbo.hk_csi_uet_fields");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_csi_uet_fields", 1, MVCFunctions.Concat(" ", "Hk Csi Uet Fields")), table);
				table = new XVar("dbo.hk_uet");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_uet", 1, MVCFunctions.Concat(" ", "Hk Uet")), table);
				table = new XVar("dbo.mg_stores_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_stores_mst", 1, MVCFunctions.Concat(" ", "Mg Stores Mst")), table);
				table = new XVar("dbo.mg_products_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_products_mst", 1, MVCFunctions.Concat(" ", "Mg Products Mst")), table);
				table = new XVar("dbo.mg_order_lines_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_order_lines_mst", 1, MVCFunctions.Concat(" ", "CO Lines")), table);
				table = new XVar("dbo.connector");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "connector", 1, MVCFunctions.Concat(" ", "Connector")), table);
				table = new XVar("dbo.client_connector");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "client_connector", 1, MVCFunctions.Concat(" ", "Client Connector")), table);
				table = new XVar("dbo.hk_client_app_connector");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_client_app_connector", 1, MVCFunctions.Concat(" ", "Hk Client App Connector")), table);
				table = new XVar("dbo.tp_aptran_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_aptran_mst", 1, MVCFunctions.Concat(" ", "AP Transactions")), table);
				table = new XVar("dbo.tp_payments_lines_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_payments_lines_mst", 1, MVCFunctions.Concat(" ", "Payments Lines")), table);
				table = new XVar("dbo.tp_payments_hdr_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_payments_hdr_mst", 1, MVCFunctions.Concat(" ", "Payments")), table);
				table = new XVar("dbo.tp_chart_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_chart_mst", 1, MVCFunctions.Concat(" ", "Tp Chart Mst")), table);
				table = new XVar("dbo.csi_ido_prop_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_ido_prop_mst", 1, MVCFunctions.Concat(" ", "Csi Ido Prop Mst")), table);
				table = new XVar("dbo.hk_schema_field Report");
				mask = new XVar("");
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_schema_field_report", 1, MVCFunctions.Concat(" ", "Hk Schema Field Report")), table);
				table = new XVar("dbo.hk_schema_table Report");
				mask = new XVar("");
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_schema_table_report", 1, MVCFunctions.Concat(" ", "Hk Schema Table Report")), table);
				table = new XVar("dbo.documents");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "documents", 1, MVCFunctions.Concat(" ", "Documents")), table);
				table = new XVar("dbo.incidents");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "incidents", 1, MVCFunctions.Concat(" ", "Incidents")), table);
				table = new XVar("dbo.mg_customer_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_customer_mst", 1, MVCFunctions.Concat(" ", "Mg Customer Mst")), table);
				table = new XVar("dbo.hk_job");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_job", 1, MVCFunctions.Concat(" ", "Hk Job")), table);
				table = new XVar("dbo.sc_invoice_line_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_invoice_line_mst", 1, MVCFunctions.Concat(" ", "Sc Invoice Line Mst")), table);
				table = new XVar("dbo.sc_invoice_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_invoice_mst", 1, MVCFunctions.Concat(" ", "Sc Invoice Mst")), table);
				table = new XVar("dbo.sc_expensereport_line_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_expensereport_line_mst", 1, MVCFunctions.Concat(" ", "Sc Expensereport Line Mst")), table);
				table = new XVar("dbo.sc_expensereport_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_expensereport_mst", 1, MVCFunctions.Concat(" ", "Sc Expensereport Mst")), table);
				table = new XVar("dbo.sc_aptran_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_aptran_mst", 1, MVCFunctions.Concat(" ", "Sc Aptran Mst")), table);
				table = new XVar("dbo.sc_aptrandist_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_aptrandist_mst", 1, MVCFunctions.Concat(" ", "Sc Aptrandist Mst")), table);
				table = new XVar("dbo.sc_sro_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sc_sro_mst", 1, MVCFunctions.Concat(" ", "Sc Sro Mst")), table);
				table = new XVar("dbo.hk_invoice_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_invoice_mst", 1, MVCFunctions.Concat(" ", "Hk Invoice Mst")), table);
				table = new XVar("dbo.hk_invitem_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_invitem_mst", 1, MVCFunctions.Concat(" ", "Hk Invitem Mst")), table);
				table = new XVar("dbo.hk_client_inv_items");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_client_inv_items", 1, MVCFunctions.Concat(" ", "Hk Client Inv Items")), table);
				table = new XVar("dbo.hk_inv_items");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "hk_inv_items", 1, MVCFunctions.Concat(" ", "Hk Inv Items")), table);
				table = new XVar("dbo.Adminuggroups");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "adminuggroups", 1, MVCFunctions.Concat(" ", "Adminuggroups")), table);
				table = new XVar("dbo.tp_invoicedetails_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_invoicedetails_mst", 1, MVCFunctions.Concat(" ", "Tp Invoicedetails Mst")), table);
				table = new XVar("dbo.tp_po");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_po", 1, MVCFunctions.Concat(" ", "PO")), table);
				table = new XVar("dbo.tp_poitem");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_poitem", 1, MVCFunctions.Concat(" ", "Po Lines")), table);
				table = new XVar("dbo.tp_po_rcpt");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_po_rcpt", 1, MVCFunctions.Concat(" ", "PO Receipts")), table);
				table = new XVar("dbo.tp_invoicedetails");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_invoicedetails", 1, MVCFunctions.Concat(" ", "Tipalti Invoices")), table);
				table = new XVar("dbo.tp_invoicedetails Report");
				mask = new XVar("");
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_invoicedetails_report", 1, MVCFunctions.Concat(" ", "Tp Invoicedetails Report")), table);
				table = new XVar("dbo.tp_vendor");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_vendor", 1, MVCFunctions.Concat(" ", "Vendors")), table);
				table = new XVar("dbo.tp_invoicedetails_dist_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_invoicedetails_dist_mst", 1, MVCFunctions.Concat(" ", "Tp Invoicedetails Dist Mst")), table);
				table = new XVar("dbo.timezone");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "timezone", 1, MVCFunctions.Concat(" ", "Timezone")), table);
				table = new XVar("dbo.tp_po_audit");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_po_audit", 1, MVCFunctions.Concat(" ", "Tp Po Audit")), table);
				table = new XVar("dbo.tp_po_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_po_mst", 1, MVCFunctions.Concat(" ", "Tp Po Mst")), table);
				table = new XVar("dbo.tp_po_rcpt_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_po_rcpt_mst", 1, MVCFunctions.Concat(" ", "Tp Po Rcpt Mst")), table);
				table = new XVar("dbo.tp_aptrandist_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_aptrandist_mst", 1, MVCFunctions.Concat(" ", "Tp Aptrandist Mst")), table);
				table = new XVar("dbo.fieldaudit");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "fieldaudit", 1, MVCFunctions.Concat(" ", "Fieldaudit")), table);
				table = new XVar("dbo.tp_vendor_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_vendor_mst", 1, MVCFunctions.Concat(" ", "Tp Vendor Mst")), table);
				table = new XVar("dbo.tp_invoicedetails_status_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_invoicedetails_status_mst", 1, MVCFunctions.Concat(" ", "Tp Invoicedetails Status Mst")), table);
				table = new XVar("dbo.mg_orderline_count");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_orderline_count", 1, MVCFunctions.Concat(" ", "Mg Orderline Count")), table);
				table = new XVar("dbo.mg_order_count");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_order_count", 1, MVCFunctions.Concat(" ", "Mg Order Count")), table);
				table = new XVar("dbo.mg_order_count Report");
				mask = new XVar("");
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_order_count_report", 1, MVCFunctions.Concat(" ", "Mg Order Count Report")), table);
				table = new XVar("dbo.mg_orderline_count Report");
				mask = new XVar("");
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "mg_orderline_count_report", 1, MVCFunctions.Concat(" ", "Mg Orderline Count Report")), table);
				table = new XVar("dbo.csi_chart_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_chart_mst", 1, MVCFunctions.Concat(" ", "Csi Chart Mst")), table);
				table = new XVar("dbo.csi_unitcd1_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_unitcd1_mst", 1, MVCFunctions.Concat(" ", "Csi Unitcd1 Mst")), table);
				table = new XVar("dbo.csi_unitcd2_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_unitcd2_mst", 1, MVCFunctions.Concat(" ", "Csi Unitcd2 Mst")), table);
				table = new XVar("dbo.csi_unitcd3_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_unitcd3_mst", 1, MVCFunctions.Concat(" ", "Csi Unitcd3 Mst")), table);
				table = new XVar("dbo.csi_unitcd4_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_unitcd4_mst", 1, MVCFunctions.Concat(" ", "Csi Unitcd4 Mst")), table);
				table = new XVar("dbo.csi_terms_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_terms_mst", 1, MVCFunctions.Concat(" ", "Csi Terms Mst")), table);
				table = new XVar("dbo.csi_u_m_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_u_m_mst", 1, MVCFunctions.Concat(" ", "Csi U M Mst")), table);
				table = new XVar("dbo.csi_lc_rcpt_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "csi_lc_rcpt_mst", 1, MVCFunctions.Concat(" ", "Csi Lc Rcpt Mst")), table);
				table = new XVar("dbo.tp_aptran_clear_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_aptran_clear_mst", 1, MVCFunctions.Concat(" ", "Tp Aptran Clear Mst")), table);
				table = new XVar("dbo.SourceManagement");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sourcemanagement", 1, MVCFunctions.Concat(" ", "Source Management")), table);
				table = new XVar("dbo.apps1");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "apps1", 1, MVCFunctions.Concat(" ", "Apps1")), table);
				table = new XVar("dbo.tp_vendor_not_match_tosyteline");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				mask = MVCFunctions.Concat(mask, "M");
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_vendor_not_match_tosyteline", 1, MVCFunctions.Concat(" ", "Tp Vendor Not Match Tosyteline")), table);
				table = new XVar("dbo.sh_fulfillment_orders_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sh_fulfillment_orders_mst", 1, MVCFunctions.Concat(" ", "Sh Fulfillment Orders Mst")), table);
				table = new XVar("dbo.sh_get_order_lines_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sh_get_order_lines_mst", 1, MVCFunctions.Concat(" ", "Sh Get Order Lines Mst")), table);
				table = new XVar("dbo.sh_get_orders_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sh_get_orders_mst", 1, MVCFunctions.Concat(" ", "Sh Get Orders Mst")), table);
				table = new XVar("dbo.sh_products_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sh_products_mst", 1, MVCFunctions.Concat(" ", "Sh Products Mst")), table);
				table = new XVar("dbo.sh_stores_mst");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "sh_stores_mst", 1, MVCFunctions.Concat(" ", "Sh Stores Mst")), table);
				table = new XVar("dbo.Clients_provisioning");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "clients_provisioning", 1, MVCFunctions.Concat(" ", "Clients Provisioning")), table);
				table = new XVar("dbo.tp_invoice_temp");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "tp_invoice_temp", 1, MVCFunctions.Concat(" ", "Tp Invoice Temp")), table);
				table = new XVar("dbo.indcode");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "indcode", 1, MVCFunctions.Concat(" ", "Indcode")), table);
				if(XVar.Pack(CommonFunctions.pageEnabled(new XVar(Constants.GLOBAL_PAGES), new XVar("menu"))))
				{
					pageMask.InitAndSetArrayItem("S", Constants.GLOBAL_PAGES);
				}
				else
				{
					pageMask.InitAndSetArrayItem("", Constants.GLOBAL_PAGES);
				}
				tables.InitAndSetArrayItem(new XVar(0, MVCFunctions.GoodFieldName(new XVar(Constants.GLOBAL_PAGES_SHORT)), 1, MVCFunctions.Concat(" ", Constants.GLOBAL_PAGES)), Constants.GLOBAL_PAGES);
				xt = XVar.UnPackXTempl(new XTempl());
				options = XVar.Clone(XVar.Array());
				options.InitAndSetArrayItem("admin_rights_list", "pageType");
				options.InitAndSetArrayItem(Constants.GLOBAL_PAGES, "pageTable");
				options.InitAndSetArrayItem((XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) ? XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) : XVar.Pack(1)), "id");
				options.InitAndSetArrayItem(Constants.RIGHTS_PAGE, "mode");
				options.InitAndSetArrayItem(xt, "xt");
				options.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("goto")), "requestGoto");
				options.InitAndSetArrayItem(tables, "tables");
				options.InitAndSetArrayItem(pageMask, "pageMasks");
				GlobalVars.pageObject = XVar.Clone(ListPage.createListPage((XVar)(GlobalVars.strTableName), (XVar)(options)));
				if(MVCFunctions.postvalue(new XVar("a")) == "saveRights")
				{
					dynamic modifiedRights = null;
					if(XVar.Pack(!(XVar)(CommonFunctions.isPostRequest())))
					{
						return MVCFunctions.GetBuferContentAndClearBufer();
					}
					modifiedRights = XVar.Clone(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("data")))));
					GlobalVars.pageObject.saveRights((XVar)(modifiedRights));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.pageObject.prepareForBuildPage();
				GlobalVars.pageObject.showPage();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
