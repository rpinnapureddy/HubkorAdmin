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
	public partial class EditColorPicker : UserControl
	{
		protected static bool skipEditColorPickerCtor = false;
		public EditColorPicker(dynamic _param_field, dynamic _param_pageObject, dynamic _param_id, dynamic _param_connection) // proxy constructor
			:base((XVar)_param_field, (XVar)_param_pageObject, (XVar)_param_id, (XVar)_param_connection) {}

		public override XVar initUserControl()
		{
			return null;
		}
		public override XVar buildUserControl(dynamic _param_value, dynamic _param_mode, dynamic _param_fieldNum, dynamic _param_validate, dynamic _param_additionalCtrlParams, dynamic _param_data)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			dynamic mode = XVar.Clone(_param_mode);
			dynamic fieldNum = XVar.Clone(_param_fieldNum);
			dynamic validate = XVar.Clone(_param_validate);
			dynamic additionalCtrlParams = XVar.Clone(_param_additionalCtrlParams);
			dynamic data = XVar.Clone(_param_data);
			#endregion

			MVCFunctions.Echo(MVCFunctions.Concat(this.getSetting(new XVar("label")), "<input id=\"", this.cfield, "\" ", this.inputStyle, " type=\"text\" class=\"color-picker black\" ", (XVar.Pack(mode == Constants.MODE_SEARCH) ? XVar.Pack("autocomplete=\"off\" ") : XVar.Pack("")), (XVar.Pack((XVar)((XVar)(mode == Constants.MODE_INLINE_EDIT)  || (XVar)(mode == Constants.MODE_INLINE_ADD))  && (XVar)(this.is508 == true)) ? XVar.Pack(MVCFunctions.Concat("alt=\"", this.strLabel, "\" ")) : XVar.Pack("")), "name=\"", this.cfield, "\" ", this.pageObject.pSetEdit.getEditParams((XVar)(this.field)), " value=\"", MVCFunctions.runner_htmlspecialchars((XVar)(value)), "\">"));
			return null;
		}
		public override XVar getUserSearchOptions()
		{
			return new XVar(0, Constants.EQUALS, 1, Constants.STARTS_WITH, 2, Constants.NOT_EMPTY, 3, Constants.NOT_EQUALS);
		}
		public override XVar addJSFiles()
		{
			this.pageObject.AddJSFile(new XVar("jquery.miniColors.min.js"));
			this.pageObject.AddJSFile(new XVar("include/js/jquery-migrate-1.2.1.min.js"));
			return null;
		}
		public override XVar addCSSFiles()
		{
			this.pageObject.AddCSSFile(new XVar("jquery.miniColors.css"));
			return null;
		}
	}
}
