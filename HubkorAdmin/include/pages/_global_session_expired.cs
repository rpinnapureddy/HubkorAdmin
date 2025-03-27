
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
			public static partial class Options____global____session_expired
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "session_expired_message",
1, "session_expired_comment" ),
"grid", new XVar( 0, "expired_stay",
1, "expired_logout" ) ),
"formXtTags", new XVar(  ),
"itemForms", new XVar( "session_expired_message", "above-grid",
"session_expired_comment", "above-grid",
"expired_stay", "grid",
"expired_logout", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "session_expired_message", new XVar( 0, "session_expired_message" ),
"session_expired_comment", new XVar( 0, "session_expired_comment" ),
"expired_stay", new XVar( 0, "expired_stay" ),
"expired_logout", new XVar( 0, "expired_logout" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "verticalBar", false,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
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
					return new XVar( "id", "session_expired",
"type", "session_expired",
"layoutId", "session_expired",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "session_expired-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "session_expired_message",
1, "session_expired_comment" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "session_expired-footer",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "expired_stay",
1, "expired_logout" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "session_expired_message", new XVar( "type", "session_expired_message",
"color", "#55768e",
"font-size", "22px" ),
"session_expired_comment", new XVar( "type", "session_expired_comment" ),
"expired_stay", new XVar( "type", "expired_stay" ),
"expired_logout", new XVar( "type", "expired_logout" ) ),
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