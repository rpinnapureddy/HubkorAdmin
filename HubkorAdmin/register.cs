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
	public partial class GlobalController : BaseController
	{
		public ActionResult register()
		{
			try
			{
				dynamic id = null, pageObject = null, var_params = XVar.Array();
				XTempl xt;
				GlobalVars.init_dbcommon();
				Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", "users",
					"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
				xt = XVar.UnPackXTempl(new XTempl());
				id = XVar.Clone(CommonFunctions.postvalue_number(new XVar("id")));
				id = XVar.Clone((XVar.Pack(id) ? XVar.Pack(id) : XVar.Pack(1)));
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(id, "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(Constants.GLOBAL_PAGES, "pageTable");
				var_params.InitAndSetArrayItem(Constants.PAGE_REGISTER, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue((XVar)(MVCFunctions.Concat("value__register_captcha_", id))), "captchaValue");
				var_params.InitAndSetArrayItem(RegisterPage.readActionFromRequest(), "action");
				var_params.InitAndSetArrayItem(RegisterPage.readRegisterModeFromRequest(), "mode");
				xt.assign(new XVar("closewindow_attrs"), new XVar("style=\"display:none\" id=\"closeWindowRegister\""));
				xt.eventsObject = GlobalVars.globalEvents;
				GlobalVars.pageObject = XVar.Clone(new RegisterPage((XVar)(var_params)));
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
