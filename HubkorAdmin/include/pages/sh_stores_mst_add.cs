
		// dbo.sh_stores_mst
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
			public static partial class Options_sh_stores_mst_add
			{
				static public XVar options()
				{
					return new XVar( "captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "clientid",
1, "site_ref",
2, "whse",
3, "cust_num",
4, "terms_code",
5, "ship_code",
6, "co_prefix",
7, "bank_code",
8, "invcategory",
9, "end_type",
10, "prepaid",
11, "locale",
12, "shop_currency_code",
13, "tax_code1",
14, "frt_tax_code1",
15, "msc_tax_code1",
16, "default_display_currency_code",
17, "base_currency_code",
18, "id",
19, "line_tax_code1",
20, "version_sh",
21, "shop_name",
22, "store_name",
23, "shipment_type",
24, "check_only_item_and_whse",
25, "use_itemloc_mst" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "clientid", new XVar( 0, "integrated_edit_field" ),
"site_ref", new XVar( 0, "integrated_edit_field1" ),
"whse", new XVar( 0, "integrated_edit_field2" ),
"cust_num", new XVar( 0, "integrated_edit_field3" ),
"terms_code", new XVar( 0, "integrated_edit_field4" ),
"ship_code", new XVar( 0, "integrated_edit_field5" ),
"co_prefix", new XVar( 0, "integrated_edit_field6" ),
"bank_code", new XVar( 0, "integrated_edit_field7" ),
"invcategory", new XVar( 0, "integrated_edit_field8" ),
"end_type", new XVar( 0, "integrated_edit_field9" ),
"prepaid", new XVar( 0, "integrated_edit_field10" ),
"locale", new XVar( 0, "integrated_edit_field11" ),
"shop_currency_code", new XVar( 0, "integrated_edit_field12" ),
"tax_code1", new XVar( 0, "integrated_edit_field13" ),
"frt_tax_code1", new XVar( 0, "integrated_edit_field14" ),
"msc_tax_code1", new XVar( 0, "integrated_edit_field15" ),
"default_display_currency_code", new XVar( 0, "integrated_edit_field16" ),
"base_currency_code", new XVar( 0, "integrated_edit_field17" ),
"id", new XVar( 0, "integrated_edit_field18" ),
"line_tax_code1", new XVar( 0, "integrated_edit_field19" ),
"version_sh", new XVar( 0, "integrated_edit_field20" ),
"shop_name", new XVar( 0, "integrated_edit_field21" ),
"store_name", new XVar( 0, "integrated_edit_field22" ),
"shipment_type", new XVar( 0, "integrated_edit_field23" ),
"check_only_item_and_whse", new XVar( 0, "integrated_edit_field24" ),
"use_itemloc_mst", new XVar( 0, "integrated_edit_field25" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "add_message" ),
"below-grid", new XVar( 0, "add_save",
1, "add_reset",
2, "add_back_list",
3, "add_cancel" ),
"top", new XVar( 0, "add_header" ),
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
12, "integrated_edit_field12",
13, "integrated_edit_field13",
14, "integrated_edit_field14",
15, "integrated_edit_field15",
16, "integrated_edit_field16",
17, "integrated_edit_field17",
18, "integrated_edit_field18",
19, "integrated_edit_field19",
20, "integrated_edit_field20",
21, "integrated_edit_field21",
22, "integrated_edit_field22",
23, "integrated_edit_field23",
24, "integrated_edit_field24",
25, "integrated_edit_field25" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "message_block" ) ),
"itemForms", new XVar( "add_message", "above-grid",
"add_save", "below-grid",
"add_reset", "below-grid",
"add_back_list", "below-grid",
"add_cancel", "below-grid",
"add_header", "top",
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
"integrated_edit_field12", "grid",
"integrated_edit_field13", "grid",
"integrated_edit_field14", "grid",
"integrated_edit_field15", "grid",
"integrated_edit_field16", "grid",
"integrated_edit_field17", "grid",
"integrated_edit_field18", "grid",
"integrated_edit_field19", "grid",
"integrated_edit_field20", "grid",
"integrated_edit_field21", "grid",
"integrated_edit_field22", "grid",
"integrated_edit_field23", "grid",
"integrated_edit_field24", "grid",
"integrated_edit_field25", "grid" ),
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
"cellId", "c3" ),
"integrated_edit_field13", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field14", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field15", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field16", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field17", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field18", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field19", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field20", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field21", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field22", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field23", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field24", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field25", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "add_header", new XVar( 0, "add_header" ),
"add_back_list", new XVar( 0, "add_back_list" ),
"add_cancel", new XVar( 0, "add_cancel" ),
"add_message", new XVar( 0, "add_message" ),
"add_save", new XVar( 0, "add_save" ),
"add_reset", new XVar( 0, "add_reset" ),
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
12, "integrated_edit_field12",
13, "integrated_edit_field13",
14, "integrated_edit_field14",
15, "integrated_edit_field15",
16, "integrated_edit_field16",
17, "integrated_edit_field17",
18, "integrated_edit_field18",
19, "integrated_edit_field19",
20, "integrated_edit_field20",
21, "integrated_edit_field21",
22, "integrated_edit_field22",
23, "integrated_edit_field23",
24, "integrated_edit_field24",
25, "integrated_edit_field25" ) ),
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
12, "integrated_edit_field12",
13, "integrated_edit_field13",
14, "integrated_edit_field14",
15, "integrated_edit_field15",
16, "integrated_edit_field16",
17, "integrated_edit_field17",
18, "integrated_edit_field18",
19, "integrated_edit_field19",
20, "integrated_edit_field20",
21, "integrated_edit_field21",
22, "integrated_edit_field22",
23, "integrated_edit_field23",
24, "integrated_edit_field24",
25, "integrated_edit_field25" ),
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
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_message" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "add-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_save",
1, "add_reset",
2, "add_back_list",
3, "add_cancel" ) ) ),
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
12, "integrated_edit_field12",
13, "integrated_edit_field13",
14, "integrated_edit_field14",
15, "integrated_edit_field15",
16, "integrated_edit_field16",
17, "integrated_edit_field17",
18, "integrated_edit_field18",
19, "integrated_edit_field19",
20, "integrated_edit_field20",
21, "integrated_edit_field21",
22, "integrated_edit_field22",
23, "integrated_edit_field23",
24, "integrated_edit_field24",
25, "integrated_edit_field25" ) ) ),
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
"integrated_edit_field", new XVar( "field", "clientid",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field1", new XVar( "field", "site_ref",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field2", new XVar( "field", "whse",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field3", new XVar( "field", "cust_num",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field4", new XVar( "field", "terms_code",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field5", new XVar( "field", "ship_code",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field6", new XVar( "field", "co_prefix",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field7", new XVar( "field", "bank_code",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field8", new XVar( "field", "invcategory",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field9", new XVar( "field", "end_type",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field10", new XVar( "field", "prepaid",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field11", new XVar( "field", "locale",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field12", new XVar( "field", "shop_currency_code",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field13", new XVar( "field", "tax_code1",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field14", new XVar( "field", "frt_tax_code1",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field15", new XVar( "field", "msc_tax_code1",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field16", new XVar( "field", "default_display_currency_code",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field17", new XVar( "field", "base_currency_code",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field18", new XVar( "field", "id",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field19", new XVar( "field", "line_tax_code1",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field20", new XVar( "field", "version_sh",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field21", new XVar( "field", "shop_name",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field22", new XVar( "field", "store_name",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field23", new XVar( "field", "shipment_type",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field24", new XVar( "field", "check_only_item_and_whse",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field25", new XVar( "field", "use_itemloc_mst",
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