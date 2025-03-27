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
		public ActionResult remind()
		{
			try
			{
				dynamic pageObject = null, var_params = XVar.Array();
				XTempl xt;
				GlobalVars.init_dbcommon();
				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(Constants.PAGE_REMIND, "pageType");
				var_params.InitAndSetArrayItem(Security.loginTable(), "tName");
				var_params.InitAndSetArrayItem(Constants.GLOBAL_PAGES, "pageTable");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("value_captcha_1")), "captchaValue");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("username_email")), "userEmail");
				var_params.InitAndSetArrayItem(RemindPasswordPage.readActionFromRequest(), "action");
				var_params.InitAndSetArrayItem(RemindPasswordPage.readRemindModeFromRequest(), "mode");
				GlobalVars.pageObject = XVar.Clone(new RemindPasswordPage((XVar)(var_params)));
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
