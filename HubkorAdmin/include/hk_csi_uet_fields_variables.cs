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
	public static partial class hk_csi_uet_fields_Variables
	{
		public static void Apply()
		{
			GlobalVars.strTableName = new XVar("dbo.hk_csi_uet_fields");
			XSession.Session["OwnerID"] = XSession.Session[MVCFunctions.Concat("_", GlobalVars.strTableName, "_OwnerID")];
			GlobalVars.strOriginalTableName = new XVar("dbo.hk_csi_uet_fields");
			GlobalVars.gstrOrderBy = new XVar("order by 	Expr1,	Expr2");
			if((XVar)(MVCFunctions.strlen((XVar)(GlobalVars.gstrOrderBy)))  && (XVar)(MVCFunctions.strtolower((XVar)(MVCFunctions.substr((XVar)(GlobalVars.gstrOrderBy), new XVar(0), new XVar(8)))) != "order by"))
			{
				GlobalVars.gstrOrderBy = XVar.Clone(MVCFunctions.Concat("order by ", GlobalVars.gstrOrderBy));
			}
			GlobalVars.reportCaseSensitiveGroupFields = new XVar(false);
		}
	}

}
