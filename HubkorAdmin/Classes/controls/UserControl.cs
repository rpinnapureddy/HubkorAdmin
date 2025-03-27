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
	public partial class UserControl : EditControl
	{
		protected static bool skipUserControlCtor = false;
		public UserControl(dynamic _param_field, dynamic _param_pageObject, dynamic _param_id, dynamic _param_connection) // proxy constructor
			:base((XVar)_param_field, (XVar)_param_pageObject, (XVar)_param_id, (XVar)_param_connection) {}

		public override XVar buildControl(dynamic _param_value, dynamic _param_mode, dynamic _param_fieldNum, dynamic _param_validate, dynamic _param_additionalCtrlParams, dynamic _param_data)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			dynamic mode = XVar.Clone(_param_mode);
			dynamic fieldNum = XVar.Clone(_param_fieldNum);
			dynamic validate = XVar.Clone(_param_validate);
			dynamic additionalCtrlParams = XVar.Clone(_param_additionalCtrlParams);
			dynamic data = XVar.Clone(_param_data);
			#endregion

			base.buildControl((XVar)(value), (XVar)(mode), (XVar)(fieldNum), (XVar)(validate), (XVar)(additionalCtrlParams), (XVar)(data));
			this.buildUserControl((XVar)(value), (XVar)(mode), (XVar)(fieldNum), (XVar)(validate), (XVar)(additionalCtrlParams), (XVar)(data));
			this.buildControlEnd((XVar)(validate), (XVar)(mode));
			return null;
		}
		public virtual XVar buildUserControl(dynamic _param_value, dynamic _param_mode, dynamic _param_fieldNum, dynamic _param_validate, dynamic _param_additionalCtrlParams, dynamic _param_data)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			dynamic mode = XVar.Clone(_param_mode);
			dynamic fieldNum = XVar.Clone(_param_fieldNum);
			dynamic validate = XVar.Clone(_param_validate);
			dynamic additionalCtrlParams = XVar.Clone(_param_additionalCtrlParams);
			dynamic data = XVar.Clone(_param_data);
			#endregion

			return null;
		}
		public virtual XVar initUserControl()
		{
			return null;
		}
		public virtual XVar getUserSearchOptions()
		{
			return XVar.Array();
		}
		public override XVar getSearchOptions(dynamic _param_selOpt, dynamic _param_not, dynamic _param_both)
		{
			#region pass-by-value parameters
			dynamic selOpt = XVar.Clone(_param_selOpt);
			dynamic var_not = XVar.Clone(_param_not);
			dynamic both = XVar.Clone(_param_both);
			#endregion

			return this.buildSearchOptions((XVar)(this.getUserSearchOptions()), (XVar)(selOpt), (XVar)(var_not), (XVar)(both));
		}
		public override XVar init()
		{
			dynamic field = null, tName = null;
			tName = XVar.Clone(this.pageObject.tName);
			field = XVar.Clone(this.field);
			if(XVar.Pack(this.pageObject.pSet))
			{
				if((XVar)(this.pageObject.pageType == Constants.PAGE_SEARCH)  && (XVar)(this.pageObject.pSet.getTableType() == Constants.PAGE_DASHBOARD))
				{
					dynamic dashFields = XVar.Array();
					dashFields = XVar.Clone(this.pageObject.pSet.getDashboardSearchFields());
					tName = XVar.Clone(dashFields[field][0]["table"]);
					field = XVar.Clone(dashFields[field][0]["field"]);
				}
			}
			if((XVar)(tName == "dbo.client_apps")  && (XVar)(field == "email_flash"))
			{
				settings["option1"] = "value";
settings["option2"] = 0;
				return null;
			}
			return null;
		}
	}
}
