using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using runnerDotNet;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace runnerDotNet
{
	[Export(typeof(ICustomExpressionProviderCS))]
	public class CustomExpressionProviderCS : ICustomExpressionProviderCS
	{
		public XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(table == "dbo.client_apps"  &&  field == "status")
			{
string status = data["status"].ToString().ToLower(); // Get status text
string colorHex = "";

switch (status) {
    case "red":
        colorHex = "#FF0000"; // Red color code
        break;
    case "green":
        colorHex = "#008000"; // Green color code
        break;
    case "orange":
        colorHex = "#FFA500"; // Orange color code
        break;
    default:
        colorHex = "#FFFFFF"; // Default (white) if no match
        break;
}

value = "<div title='" + status + "' " +
        "style='width: 40px; height: 20px; background-color:" + colorHex + "; " +
        "border-radius: 5px; border: 1px solid #000;'></div>";
;return value;
			}
			if(table == "dbo.incoming"  &&  field == "payload")
			{

;return value;
			}
			return value;
		}

		public XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			XVar value = "";
			if(table == "dbo.documents"  &&  field == "file_name")
			{

;return value;
			}
			if(table == "dbo.incidents"  &&  field == "documents")
			{

;return value;
			}
			if(table == "dbo.SourceManagement"  &&  field == "ChangeSet")
			{

;return value;
			}
			return value;
		}

		public XVar GetLWWhere(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null)
		{
			if(table == "dbo.clients"  &&  field == "invoice_cycle")
			{
				var tmpVal = "None";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.users"  &&  field == "user_group")
			{
				var tmpVal = "customer";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.incidents"  &&  field == "category")
			{
				var tmpVal = "Application";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.incidents"  &&  field == "createdate")
			{
				var tmpVal = DateTime.Now;
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.incidents"  &&  field == "status")
			{
				var tmpVal = "Open";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.incidents"  &&  field == "severity")
			{
				var tmpVal = "Low";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.incidents"  &&  field == "createdby")
			{
				var tmpVal = XSession.Session["UserName"];
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.incidents"  &&  field == "contact_pref")
			{
				var tmpVal = "Email";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.hk_invoice_mst"  &&  field == "status")
			{
				var tmpVal = "Draft";
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.hk_invitem_mst"  &&  field == "discount")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.hk_client_inv_items"  &&  field == "discount")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.SourceManagement"  &&  field == "CreatedDate")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd");
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.SourceManagement"  &&  field == "User")
			{
				var tmpVal = XSession.Session["UserName"];
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.Clients_provisioning"  &&  field == "provision_date")
			{
				var tmpVal = DateTime.Now;
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.Clients_provisioning"  &&  field == "project_manager")
			{
				var tmpVal = "dpalensky@hubkor.com";
				return XVar.Pack(tmpVal);
			}
			return "";
		}

		public XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar getCustomMapIcon(XVar field, XVar table, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar getDashMapCustomLocationIcon(XVar dashName, XVar dashElementName, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null)
		{
			if(table == "dbo.SourceManagement"  &&  field == "ChangeSet")
			{
				XVar folder = new XVar();
folder = MVCFunctions.Concat("userfiles/", XSession.Session["User"]);;
				return folder;
			}
			return "";
		}

		public XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound)
		{
			return "";
		}
	}
}