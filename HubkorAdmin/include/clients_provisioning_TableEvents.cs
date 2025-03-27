using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using System.Web;
using runnerDotNet;


namespace runnerDotNet
{
	[Export(typeof(IEventProviderCS_clients_provisioning))]
	public class eventclassCS_clients_provisioning : IEventProviderCS_clients_provisioning
	{


		//	handlers
// Before record added
		public XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject)
		{
values["shortcode"] = values["shortcode"].ToUpper();

// Place event code here.
// Use "Add Action" button to add code snippets.

return true;
return null;

		} // BeforeAdd





	}

}