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
	public interface IEventProviderCS_incoming
	{
		//	handlers






	}

	public interface IEventProviderVB_incoming
	{
		//	handlers



	}

	public class eventclass_incoming : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_incoming))]
		public IEventProviderCS_incoming EventProviderCS;

		//[Import(typeof(IEventProviderVB_incoming))]
		public IEventProviderVB_incoming EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_incoming();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_incoming");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_incoming)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_incoming()
		{
			CreateEvents();

			// fill list of events



		}


		//	handlers






	}
}