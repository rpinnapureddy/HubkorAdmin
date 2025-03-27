
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
			public static partial class Options____global____remind
			{
				static public XVar options()
				{
					return new XVar( "captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "message" ),
"supertop", XVar.Array(),
"top", new XVar( 0, "remind_header" ),
"grid", new XVar( 0, "username_email_label",
1, "username_email" ),
"footer", new XVar( 0, "remind_button",
1, "back_to_login" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "message", "above-grid",
"remind_header", "top",
"username_email_label", "grid",
"username_email", "grid",
"remind_button", "footer",
"back_to_login", "footer" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "username_email_label", new XVar( 0, "username_email_label" ),
"username_email", new XVar( 0, "username_email" ),
"message", new XVar( 0, "message" ),
"remind_button", new XVar( 0, "remind_button" ),
"back_to_login", new XVar( 0, "back_to_login" ),
"remind_header", new XVar( 0, "remind_header" ) ),
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
					return new XVar( "id", "remind",
"type", "remind",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "remind-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "message" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "panel-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "remind-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "remind_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "remind-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ),
1, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", new XVar( 0, "username_email_label" ) ),
"c3", new XVar( "model", "c3",
"items", new XVar( 0, "username_email" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"footer", new XVar( "modelId", "remind-footer",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "remind_button",
1, "back_to_login" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "username_email_label", new XVar( "type", "username_email_label" ),
"username_email", new XVar( "type", "username_email" ),
"message", new XVar( "type", "message" ),
"remind_button", new XVar( "type", "remind_button" ),
"back_to_login", new XVar( "type", "back_to_login" ),
"remind_header", new XVar( "type", "remind_header" ) ),
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