
		// <global>
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
			public static partial class Options____global____register_success
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "register_activate_message",
1, "register_activated_message" ),
"supertop", XVar.Array(),
"top", new XVar( 0, "register_success_header" ),
"grid", new XVar( 0, "register_proceed",
1, "register_close" ),
"footer", XVar.Array() ),
"formXtTags", new XVar( "supertop", XVar.Array(),
"footer", XVar.Array() ),
"itemForms", new XVar( "register_activate_message", "above-grid",
"register_activated_message", "above-grid",
"register_success_header", "top",
"register_proceed", "grid",
"register_close", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "register_proceed", new XVar( 0, "register_proceed" ),
"register_success_header", new XVar( 0, "register_success_header" ),
"register_close", new XVar( 0, "register_close" ),
"register_activate_message", new XVar( 0, "register_activate_message" ),
"register_activated_message", new XVar( 0, "register_activated_message" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "verticalBar", false,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar( "register_activate_message", new XVar( "tag", "REGISTER_ACTIVATE",
"type", 2 ) ),
"details_found", new XVar(  ) ),
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", XVar.Array(),
"calcTotalsFor", 1 ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "register_success",
"type", "register_success",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "register_success-above",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "register_activate_message",
1, "register_activated_message" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "panel-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "register_success-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "register_success_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "register_success-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", new XVar( 0, "register_proceed",
1, "register_close" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"footer", new XVar( "modelId", "register_success-footer",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "register_proceed", new XVar( "type", "register_proceed" ),
"register_success_header", new XVar( "type", "register_success_header" ),
"register_close", new XVar( "type", "register_close" ),
"register_activate_message", new XVar( "type", "register_activate_message" ),
"register_activated_message", new XVar( "type", "register_activated_message" ) ),
"dbProps", new XVar(  ),
"version", 14,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}