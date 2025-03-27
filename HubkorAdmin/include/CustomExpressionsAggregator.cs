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
	public interface ICustomExpressionProvider
	{
		XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null);
		XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null);
		XVar GetLWWhere(XVar field, XVar ptype, XVar table = null);
		XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null);
		XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null);
		XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null);
		XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound);
		XVar getCustomMapIcon(XVar field, XVar table, XVar data);
		XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data);
		XVar getDashMapCustomLocationIcon(XVar dashName, XVar dashElementName, XVar data);
	}

	public interface ICustomExpressionProviderVB : ICustomExpressionProvider {}

	public interface ICustomExpressionProviderCS : ICustomExpressionProvider {}

	public class CustomExpressionProvider
	{
		private static CustomExpressionProvider _instance;

		public static CustomExpressionProvider Instance
		{
			get
			{
				if(_instance == null)
					_instance = new CustomExpressionProvider();

				return _instance;
			}
		}

		//[Import(typeof(ICustomExpressionProviderCS))]
		public ICustomExpressionProviderCS CustomExpressionProviderCS;

		//[Import(typeof(ICustomExpressionProviderVB))]
		public ICustomExpressionProviderVB CustomExpressionProviderVB;

        public void CreateEvents()
        {
			CustomExpressionProviderCS = new CustomExpressionProviderCS();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.CustomExpressionProviderVB");
				if(eType != null)
				{
					CustomExpressionProviderVB = (ICustomExpressionProviderVB)Activator.CreateInstance(eType);
				}
			}
        }

		private CustomExpressionProvider()
		{
			CreateEvents();
		}

		public XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.client_apps"  &&  field == "status")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.incoming"  &&  field == "payload")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			return value;
		}

		public XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.documents"  &&  field == "file_name")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "documents")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "dbo.SourceManagement"  &&  field == "ChangeSet")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			return "";
		}

		public XVar GetLWWhere(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.clients"  &&  field == "invoice_cycle")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.users"  &&  field == "user_group")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "category")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "createdate")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "status")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "severity")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "createdby")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.incidents"  &&  field == "contact_pref")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.hk_invoice_mst"  &&  field == "status")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.hk_invitem_mst"  &&  field == "discount")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.hk_client_inv_items"  &&  field == "discount")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.SourceManagement"  &&  field == "CreatedDate")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.SourceManagement"  &&  field == "User")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.Clients_provisioning"  &&  field == "provision_date")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.Clients_provisioning"  &&  field == "project_manager")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			return "";
		}

		public XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar getCustomMapIcon(XVar field, XVar ptype, XVar table, XVar data)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data)
		{

			return "";
		}

		public XVar getDashMapCustomLocationIcon(XVar dashName, XVar dashElementName, XVar data)
		{

			return "";
		}

		public XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.SourceManagement"  &&  field == "ChangeSet")
			{
				return CustomExpressionProviderCS.GetUploadFolderExpression(field, file, table);
			}
			return "";
		}

		public XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound)
		{
			return "";
		}
	}
}