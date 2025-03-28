
		// dbo.mg_products_mst
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
			public static partial class Options_mg_products_mst_view
			{
				static public XVar options()
				{
					return new XVar( "pdf", new XVar( "pdfView", false ),
"fields", new XVar( "gridFields", new XVar( 0, "clientid",
1, "site_ref",
2, "id",
3, "sku",
4, "attribute_set_id",
5, "price",
6, "status",
7, "visibility",
8, "type_id",
9, "created_at",
10, "updated_at",
11, "weight",
12, "custom_attributes" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "clientid", new XVar( 0, "integrated_edit_field" ),
"site_ref", new XVar( 0, "integrated_edit_field1" ),
"id", new XVar( 0, "integrated_edit_field2" ),
"sku", new XVar( 0, "integrated_edit_field3" ),
"attribute_set_id", new XVar( 0, "integrated_edit_field4" ),
"price", new XVar( 0, "integrated_edit_field5" ),
"status", new XVar( 0, "integrated_edit_field6" ),
"visibility", new XVar( 0, "integrated_edit_field7" ),
"type_id", new XVar( 0, "integrated_edit_field8" ),
"created_at", new XVar( 0, "integrated_edit_field9" ),
"updated_at", new XVar( 0, "integrated_edit_field10" ),
"weight", new XVar( 0, "integrated_edit_field11" ),
"custom_attributes", new XVar( 0, "integrated_edit_field12" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "view_back_list",
1, "view_close" ),
"top", new XVar( 0, "view_header" ),
"grid", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10",
11, "integrated_edit_field11",
12, "integrated_edit_field12" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "back_button",
1, "close_button" ) ),
"itemForms", new XVar( "view_back_list", "below-grid",
"view_close", "below-grid",
"view_header", "top",
"integrated_edit_field", "grid",
"integrated_edit_field1", "grid",
"integrated_edit_field2", "grid",
"integrated_edit_field3", "grid",
"integrated_edit_field4", "grid",
"integrated_edit_field5", "grid",
"integrated_edit_field6", "grid",
"integrated_edit_field7", "grid",
"integrated_edit_field8", "grid",
"integrated_edit_field9", "grid",
"integrated_edit_field10", "grid",
"integrated_edit_field11", "grid",
"integrated_edit_field12", "grid" ),
"itemLocations", new XVar( "integrated_edit_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field2", new XVar( "location", "grid",
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
"integrated_edit_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field9", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field10", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field11", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field12", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "view_header", new XVar( 0, "view_header" ),
"view_back_list", new XVar( 0, "view_back_list" ),
"view_close", new XVar( 0, "view_close" ),
"integrated_edit_field", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10",
11, "integrated_edit_field11",
12, "integrated_edit_field12" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10",
11, "integrated_edit_field11",
12, "integrated_edit_field12" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
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
"misc", new XVar( "type", "view",
"breadcrumb", false,
"nextPrev", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "view",
"type", "view",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "view-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1",
"colspan", 2 ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "view-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "view_back_list",
1, "view_close" ) ),
"c2", new XVar( "model", "c2",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "view-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "view_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field5",
6, "integrated_edit_field6",
7, "integrated_edit_field7",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10",
11, "integrated_edit_field11",
12, "integrated_edit_field12" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ) ),
"items", new XVar( "view_header", new XVar( "type", "view_header" ),
"view_back_list", new XVar( "type", "view_back_list" ),
"view_close", new XVar( "type", "view_close" ),
"integrated_edit_field", new XVar( "field", "clientid",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field1", new XVar( "field", "site_ref",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field2", new XVar( "field", "id",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field3", new XVar( "field", "sku",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field4", new XVar( "field", "attribute_set_id",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field5", new XVar( "field", "price",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field6", new XVar( "field", "status",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field7", new XVar( "field", "visibility",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field8", new XVar( "field", "type_id",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field9", new XVar( "field", "created_at",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field10", new XVar( "field", "updated_at",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field11", new XVar( "field", "weight",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field12", new XVar( "field", "custom_attributes",
"type", "integrated_edit_field",
"orientation", 0 ) ),
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