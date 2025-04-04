
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
			public static partial class Options_sh_stores_mst_export
			{
				static public XVar options()
				{
					return new XVar( "totals", new XVar( "clientid", new XVar( "totalsType", "" ),
"site_ref", new XVar( "totalsType", "" ),
"whse", new XVar( "totalsType", "" ),
"cust_num", new XVar( "totalsType", "" ),
"terms_code", new XVar( "totalsType", "" ),
"ship_code", new XVar( "totalsType", "" ),
"co_prefix", new XVar( "totalsType", "" ),
"bank_code", new XVar( "totalsType", "" ),
"invcategory", new XVar( "totalsType", "" ),
"end_type", new XVar( "totalsType", "" ),
"prepaid", new XVar( "totalsType", "" ),
"locale", new XVar( "totalsType", "" ),
"shop_currency_code", new XVar( "totalsType", "" ),
"tax_code1", new XVar( "totalsType", "" ),
"frt_tax_code1", new XVar( "totalsType", "" ),
"msc_tax_code1", new XVar( "totalsType", "" ),
"default_display_currency_code", new XVar( "totalsType", "" ),
"base_currency_code", new XVar( "totalsType", "" ),
"id", new XVar( "totalsType", "" ),
"line_tax_code1", new XVar( "totalsType", "" ),
"version_sh", new XVar( "totalsType", "" ),
"shop_name", new XVar( "totalsType", "" ),
"store_name", new XVar( "totalsType", "" ),
"shipment_type", new XVar( "totalsType", "" ),
"check_only_item_and_whse", new XVar( "totalsType", "" ),
"use_itemloc_mst", new XVar( "totalsType", "" ) ),
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
"exportFields", new XVar( 0, "clientid",
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
"fieldItems", new XVar( "clientid", new XVar( 0, "export_field" ),
"site_ref", new XVar( 0, "export_field1" ),
"whse", new XVar( 0, "export_field2" ),
"cust_num", new XVar( 0, "export_field3" ),
"terms_code", new XVar( 0, "export_field4" ),
"ship_code", new XVar( 0, "export_field5" ),
"co_prefix", new XVar( 0, "export_field6" ),
"bank_code", new XVar( 0, "export_field7" ),
"invcategory", new XVar( 0, "export_field8" ),
"end_type", new XVar( 0, "export_field9" ),
"prepaid", new XVar( 0, "export_field10" ),
"locale", new XVar( 0, "export_field11" ),
"shop_currency_code", new XVar( 0, "export_field12" ),
"tax_code1", new XVar( 0, "export_field13" ),
"frt_tax_code1", new XVar( 0, "export_field14" ),
"msc_tax_code1", new XVar( 0, "export_field15" ),
"default_display_currency_code", new XVar( 0, "export_field16" ),
"base_currency_code", new XVar( 0, "export_field17" ),
"id", new XVar( 0, "export_field18" ),
"line_tax_code1", new XVar( 0, "export_field19" ),
"version_sh", new XVar( 0, "export_field20" ),
"shop_name", new XVar( 0, "export_field21" ),
"store_name", new XVar( 0, "export_field22" ),
"shipment_type", new XVar( 0, "export_field23" ),
"check_only_item_and_whse", new XVar( 0, "export_field24" ),
"use_itemloc_mst", new XVar( 0, "export_field25" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", XVar.Array(),
"top", new XVar( 0, "export_header" ),
"grid", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field6",
7, "export_field7",
8, "export_field8",
9, "export_field9",
10, "export_field10",
11, "export_field11",
12, "export_field12",
13, "export_field13",
14, "export_field14",
15, "export_field15",
16, "export_field16",
17, "export_field17",
18, "export_field18",
19, "export_field19",
20, "export_field20",
21, "export_field21",
22, "export_field22",
23, "export_field23",
24, "export_field24",
25, "export_field25" ),
"footer", new XVar( 0, "export_export",
1, "export_cancel" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "export_header", "top",
"export_field", "grid",
"export_field1", "grid",
"export_field2", "grid",
"export_field3", "grid",
"export_field4", "grid",
"export_field5", "grid",
"export_field6", "grid",
"export_field7", "grid",
"export_field8", "grid",
"export_field9", "grid",
"export_field10", "grid",
"export_field11", "grid",
"export_field12", "grid",
"export_field13", "grid",
"export_field14", "grid",
"export_field15", "grid",
"export_field16", "grid",
"export_field17", "grid",
"export_field18", "grid",
"export_field19", "grid",
"export_field20", "grid",
"export_field21", "grid",
"export_field22", "grid",
"export_field23", "grid",
"export_field24", "grid",
"export_field25", "grid",
"export_export", "footer",
"export_cancel", "footer" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "export_header", new XVar( 0, "export_header" ),
"export_export", new XVar( 0, "export_export" ),
"export_cancel", new XVar( 0, "export_cancel" ),
"export_field", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field6",
7, "export_field7",
8, "export_field8",
9, "export_field9",
10, "export_field10",
11, "export_field11",
12, "export_field12",
13, "export_field13",
14, "export_field14",
15, "export_field15",
16, "export_field16",
17, "export_field17",
18, "export_field18",
19, "export_field19",
20, "export_field20",
21, "export_field21",
22, "export_field22",
23, "export_field23",
24, "export_field24",
25, "export_field25" ) ),
"cellMaps", new XVar(  ) ),
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
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"export", new XVar( "format", 2,
"selectFields", false,
"delimiter", ",",
"selectDelimiter", false,
"exportFileTypes", new XVar( "excel", true,
"word", true,
"csv", true,
"xml", false ) ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "export",
"type", "export",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "panel-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "export-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "export-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field6",
7, "export_field7",
8, "export_field8",
9, "export_field9",
10, "export_field10",
11, "export_field11",
12, "export_field12",
13, "export_field13",
14, "export_field14",
15, "export_field15",
16, "export_field16",
17, "export_field17",
18, "export_field18",
19, "export_field19",
20, "export_field20",
21, "export_field21",
22, "export_field22",
23, "export_field23",
24, "export_field24",
25, "export_field25" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"footer", new XVar( "modelId", "export-footer",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "export_export",
1, "export_cancel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "export_header", new XVar( "type", "export_header" ),
"export_export", new XVar( "type", "export_export" ),
"export_cancel", new XVar( "type", "export_cancel" ),
"export_field", new XVar( "field", "clientid",
"type", "export_field" ),
"export_field1", new XVar( "field", "site_ref",
"type", "export_field" ),
"export_field2", new XVar( "field", "whse",
"type", "export_field" ),
"export_field3", new XVar( "field", "cust_num",
"type", "export_field" ),
"export_field4", new XVar( "field", "terms_code",
"type", "export_field" ),
"export_field5", new XVar( "field", "ship_code",
"type", "export_field" ),
"export_field6", new XVar( "field", "co_prefix",
"type", "export_field" ),
"export_field7", new XVar( "field", "bank_code",
"type", "export_field" ),
"export_field8", new XVar( "field", "invcategory",
"type", "export_field" ),
"export_field9", new XVar( "field", "end_type",
"type", "export_field" ),
"export_field10", new XVar( "field", "prepaid",
"type", "export_field" ),
"export_field11", new XVar( "field", "locale",
"type", "export_field" ),
"export_field12", new XVar( "field", "shop_currency_code",
"type", "export_field" ),
"export_field13", new XVar( "field", "tax_code1",
"type", "export_field" ),
"export_field14", new XVar( "field", "frt_tax_code1",
"type", "export_field" ),
"export_field15", new XVar( "field", "msc_tax_code1",
"type", "export_field" ),
"export_field16", new XVar( "field", "default_display_currency_code",
"type", "export_field" ),
"export_field17", new XVar( "field", "base_currency_code",
"type", "export_field" ),
"export_field18", new XVar( "field", "id",
"type", "export_field" ),
"export_field19", new XVar( "field", "line_tax_code1",
"type", "export_field" ),
"export_field20", new XVar( "field", "version_sh",
"type", "export_field" ),
"export_field21", new XVar( "field", "shop_name",
"type", "export_field" ),
"export_field22", new XVar( "field", "store_name",
"type", "export_field" ),
"export_field23", new XVar( "field", "shipment_type",
"type", "export_field" ),
"export_field24", new XVar( "field", "check_only_item_and_whse",
"type", "export_field" ),
"export_field25", new XVar( "field", "use_itemloc_mst",
"type", "export_field" ) ),
"dbProps", new XVar(  ),
"version", 14,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1,
"exportFormat", 2,
"exportDelimiter", ",",
"exportSelectDelimiter", false,
"exportSelectFields", false );
				}
			}
		}