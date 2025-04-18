
		// dbo.Clients_provisioning
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
			public static partial class Options_clients_provisioning_add
			{
				static public XVar options()
				{
					return new XVar( "details", new XVar( "dbo.client_apps", new XVar( "displayPreview", 2,
"previewPageId", "" ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "name",
1, "shortcode",
2, "provision_date",
3, "project_manager",
4, "primary_contact",
5, "primary_email",
6, "primary_phone",
7, "onprem",
8, "apps" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "name", new XVar( 0, "integrated_edit_field1" ),
"shortcode", new XVar( 0, "integrated_edit_field2" ),
"provision_date", new XVar( 0, "integrated_edit_field3" ),
"project_manager", new XVar( 0, "integrated_edit_field4" ),
"primary_contact", new XVar( 0, "integrated_edit_field5" ),
"primary_email", new XVar( 0, "integrated_edit_field6" ),
"primary_phone", new XVar( 0, "integrated_edit_field7" ),
"onprem", new XVar( 0, "integrated_edit_field8" ),
"apps", new XVar( 0, "integrated_edit_field" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "add_message",
1, "step_nav" ),
"below-grid", new XVar( 0, "next_step",
1, "add_save",
2, "add_reset",
3, "add_back_list",
4, "add_cancel" ),
"top", new XVar( 0, "add_header" ),
"grid", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field8",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7" ),
"step2", new XVar( 0, "integrated_edit_field" ) ),
"formXtTags", new XVar(  ),
"itemForms", new XVar( "add_message", "above-grid",
"step_nav", "above-grid",
"next_step", "below-grid",
"add_save", "below-grid",
"add_reset", "below-grid",
"add_back_list", "below-grid",
"add_cancel", "below-grid",
"add_header", "top",
"integrated_edit_field1", "grid",
"integrated_edit_field2", "grid",
"integrated_edit_field8", "grid",
"integrated_edit_field3", "grid",
"integrated_edit_field4", "grid",
"integrated_edit_field5", "grid",
"integrated_edit_field6", "grid",
"integrated_edit_field7", "grid",
"integrated_edit_field", "step2" ),
"itemLocations", new XVar( "integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field3", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field5", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field6", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field7", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field", new XVar( "location", "step2",
"cellId", "c1" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "add_header", new XVar( 0, "add_header" ),
"add_back_list", new XVar( 0, "add_back_list" ),
"add_cancel", new XVar( 0, "add_cancel" ),
"add_message", new XVar( 0, "add_message" ),
"add_save", new XVar( 0, "add_save" ),
"add_reset", new XVar( 0, "add_reset" ),
"integrated_edit_field", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field3",
3, "integrated_edit_field4",
4, "integrated_edit_field5",
5, "integrated_edit_field6",
6, "integrated_edit_field7",
7, "integrated_edit_field8",
8, "integrated_edit_field" ),
"next_step", new XVar( 0, "next_step" ),
"step_nav", new XVar( 0, "step_nav" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field8",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"step2", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "verticalBar", false,
"multiStep", true,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar(  ) ),
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", XVar.Array(),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "add",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "add",
"type", "add",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "add-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_message" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "step_nav" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "add-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "next_step",
1, "add_save",
2, "add_reset",
3, "add_back_list",
4, "add_cancel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "add-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field8",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"step2", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ) ),
"items", new XVar( "add_header", new XVar( "type", "add_header" ),
"add_back_list", new XVar( "type", "add_back_list" ),
"add_cancel", new XVar( "type", "add_cancel" ),
"add_message", new XVar( "type", "add_message" ),
"add_save", new XVar( "type", "add_save" ),
"add_reset", new XVar( "type", "add_reset" ),
"integrated_edit_field1", new XVar( "field", "name",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field2", new XVar( "field", "shortcode",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field3", new XVar( "field", "provision_date",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field4", new XVar( "field", "project_manager",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field5", new XVar( "field", "primary_contact",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field6", new XVar( "field", "primary_email",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field7", new XVar( "field", "primary_phone",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field8", new XVar( "field", "onprem",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field", new XVar( "field", "apps",
"type", "integrated_edit_field",
"orientation", 0 ),
"next_step", new XVar( "type", "next_step" ),
"step_nav", new XVar( "type", "step_nav" ) ),
"dbProps", new XVar(  ),
"steps", new XVar( 0, new XVar( "location", "grid",
"label", new XVar( "text", "ClientsProvision",
"type", 0 ) ),
1, new XVar( "location", "step2",
"label", new XVar( "text", "ClientApps",
"type", 0 ) ) ),
"version", 14,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}