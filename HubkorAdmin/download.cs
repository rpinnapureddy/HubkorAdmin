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
		public XVar download()
		{
			try
			{
				MVCFunctions.Echo(new XVar(""));
				return MVCFunctions.GetBuferContentAndClearBufer();
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
