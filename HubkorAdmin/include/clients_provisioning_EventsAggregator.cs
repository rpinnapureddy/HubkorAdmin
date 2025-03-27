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
using System.Web;
using System.Reflection;

namespace runnerDotNet
{
	public interface IEventProviderCS_clients_provisioning
	{
		//	handlers

		XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject);







	}

	public interface IEventProviderVB_clients_provisioning
	{
		//	handlers



	}

	public class eventclass_clients_provisioning : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_clients_provisioning))]
		public IEventProviderCS_clients_provisioning EventProviderCS;

		//[Import(typeof(IEventProviderVB_clients_provisioning))]
		public IEventProviderVB_clients_provisioning EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_clients_provisioning();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_clients_provisioning");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_clients_provisioning)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_clients_provisioning()
		{
			CreateEvents();

			// fill list of events

			events["BeforeAdd"]=true;




		}


		//	handlers

		
		public XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeAdd(values, sqlValues, ref message, inline, pageObject);
		}







	}
}