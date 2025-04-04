
		// dbo.tp_vendor
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
			public static partial class Options_tp_vendor_import
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "clientid",
1, "site_ref",
2, "tp_posted",
3, "vend_num",
4, "RowPointer",
5, "contact",
6, "phone",
7, "vend_type",
8, "terms_code",
9, "ship_code",
10, "stat",
11, "curr_code",
12, "pay_type",
13, "delterm",
14, "tax_code1",
15, "tax_code2",
16, "cust_num",
17, "vend_bank",
18, "name",
19, "city",
20, "state",
21, "zip",
22, "county",
23, "country",
24, "fax_num",
25, "telex_num",
26, "addr1",
27, "addr2",
28, "addr3",
29, "addr4",
30, "internet_url",
31, "internal_email_addr",
32, "external_email_addr",
33, "long_name",
34, "vend_remit",
35, "PendInv" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "clientid", new XVar( 0, "import_field" ),
"site_ref", new XVar( 0, "import_field1" ),
"tp_posted", new XVar( 0, "import_field2" ),
"vend_num", new XVar( 0, "import_field3" ),
"RowPointer", new XVar( 0, "import_field4" ),
"contact", new XVar( 0, "import_field5" ),
"phone", new XVar( 0, "import_field6" ),
"vend_type", new XVar( 0, "import_field7" ),
"terms_code", new XVar( 0, "import_field8" ),
"ship_code", new XVar( 0, "import_field9" ),
"stat", new XVar( 0, "import_field10" ),
"curr_code", new XVar( 0, "import_field11" ),
"pay_type", new XVar( 0, "import_field13" ),
"delterm", new XVar( 0, "import_field14" ),
"tax_code1", new XVar( 0, "import_field15" ),
"tax_code2", new XVar( 0, "import_field16" ),
"cust_num", new XVar( 0, "import_field17" ),
"vend_bank", new XVar( 0, "import_field18" ),
"name", new XVar( 0, "import_field19" ),
"city", new XVar( 0, "import_field20" ),
"state", new XVar( 0, "import_field21" ),
"zip", new XVar( 0, "import_field22" ),
"county", new XVar( 0, "import_field23" ),
"country", new XVar( 0, "import_field24" ),
"fax_num", new XVar( 0, "import_field25" ),
"telex_num", new XVar( 0, "import_field26" ),
"addr1", new XVar( 0, "import_field27" ),
"addr2", new XVar( 0, "import_field28" ),
"addr3", new XVar( 0, "import_field29" ),
"addr4", new XVar( 0, "import_field30" ),
"internet_url", new XVar( 0, "import_field32" ),
"internal_email_addr", new XVar( 0, "import_field33" ),
"external_email_addr", new XVar( 0, "import_field34" ),
"long_name", new XVar( 0, "import_field35" ),
"vend_remit", new XVar( 0, "import_field36" ),
"PendInv", new XVar( 0, "import_field12" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", XVar.Array(),
"top", new XVar( 0, "import_header" ),
"grid", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4",
5, "import_field5",
6, "import_field6",
7, "import_field7",
8, "import_field8",
9, "import_field9",
10, "import_field10",
11, "import_field11",
12, "import_field13",
13, "import_field14",
14, "import_field15",
15, "import_field16",
16, "import_field17",
17, "import_field18",
18, "import_field19",
19, "import_field20",
20, "import_field21",
21, "import_field22",
22, "import_field23",
23, "import_field24",
24, "import_field25",
25, "import_field26",
26, "import_field27",
27, "import_field28",
28, "import_field29",
29, "import_field30",
30, "import_field32",
31, "import_field33",
32, "import_field34",
33, "import_field35",
34, "import_field36",
35, "import_field12" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "import_header", "top",
"import_field", "grid",
"import_field1", "grid",
"import_field2", "grid",
"import_field3", "grid",
"import_field4", "grid",
"import_field5", "grid",
"import_field6", "grid",
"import_field7", "grid",
"import_field8", "grid",
"import_field9", "grid",
"import_field10", "grid",
"import_field11", "grid",
"import_field13", "grid",
"import_field14", "grid",
"import_field15", "grid",
"import_field16", "grid",
"import_field17", "grid",
"import_field18", "grid",
"import_field19", "grid",
"import_field20", "grid",
"import_field21", "grid",
"import_field22", "grid",
"import_field23", "grid",
"import_field24", "grid",
"import_field25", "grid",
"import_field26", "grid",
"import_field27", "grid",
"import_field28", "grid",
"import_field29", "grid",
"import_field30", "grid",
"import_field32", "grid",
"import_field33", "grid",
"import_field34", "grid",
"import_field35", "grid",
"import_field36", "grid",
"import_field12", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "import_header", new XVar( 0, "import_header" ),
"import_field", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4",
5, "import_field5",
6, "import_field6",
7, "import_field7",
8, "import_field8",
9, "import_field9",
10, "import_field10",
11, "import_field11",
12, "import_field13",
13, "import_field14",
14, "import_field15",
15, "import_field16",
16, "import_field17",
17, "import_field18",
18, "import_field19",
19, "import_field20",
20, "import_field21",
21, "import_field22",
22, "import_field23",
23, "import_field24",
24, "import_field25",
25, "import_field26",
26, "import_field27",
27, "import_field28",
28, "import_field29",
29, "import_field30",
30, "import_field32",
31, "import_field33",
32, "import_field34",
33, "import_field35",
34, "import_field36",
35, "import_field12" ) ),
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
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "import",
"type", "import",
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
"top", new XVar( "modelId", "import-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "import_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "import-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4",
5, "import_field5",
6, "import_field6",
7, "import_field7",
8, "import_field8",
9, "import_field9",
10, "import_field10",
11, "import_field11",
12, "import_field13",
13, "import_field14",
14, "import_field15",
15, "import_field16",
16, "import_field17",
17, "import_field18",
18, "import_field19",
19, "import_field20",
20, "import_field21",
21, "import_field22",
22, "import_field23",
23, "import_field24",
24, "import_field25",
25, "import_field26",
26, "import_field27",
27, "import_field28",
28, "import_field29",
29, "import_field30",
30, "import_field32",
31, "import_field33",
32, "import_field34",
33, "import_field35",
34, "import_field36",
35, "import_field12" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "import_header", new XVar( "type", "import_header" ),
"import_field", new XVar( "field", "clientid",
"type", "import_field" ),
"import_field1", new XVar( "field", "site_ref",
"type", "import_field" ),
"import_field2", new XVar( "field", "tp_posted",
"type", "import_field" ),
"import_field3", new XVar( "field", "vend_num",
"type", "import_field" ),
"import_field4", new XVar( "field", "RowPointer",
"type", "import_field" ),
"import_field5", new XVar( "field", "contact",
"type", "import_field" ),
"import_field6", new XVar( "field", "phone",
"type", "import_field" ),
"import_field7", new XVar( "field", "vend_type",
"type", "import_field" ),
"import_field8", new XVar( "field", "terms_code",
"type", "import_field" ),
"import_field9", new XVar( "field", "ship_code",
"type", "import_field" ),
"import_field10", new XVar( "field", "stat",
"type", "import_field" ),
"import_field11", new XVar( "field", "curr_code",
"type", "import_field" ),
"import_field13", new XVar( "field", "pay_type",
"type", "import_field" ),
"import_field14", new XVar( "field", "delterm",
"type", "import_field" ),
"import_field15", new XVar( "field", "tax_code1",
"type", "import_field" ),
"import_field16", new XVar( "field", "tax_code2",
"type", "import_field" ),
"import_field17", new XVar( "field", "cust_num",
"type", "import_field" ),
"import_field18", new XVar( "field", "vend_bank",
"type", "import_field" ),
"import_field19", new XVar( "field", "name",
"type", "import_field" ),
"import_field20", new XVar( "field", "city",
"type", "import_field" ),
"import_field21", new XVar( "field", "state",
"type", "import_field" ),
"import_field22", new XVar( "field", "zip",
"type", "import_field" ),
"import_field23", new XVar( "field", "county",
"type", "import_field" ),
"import_field24", new XVar( "field", "country",
"type", "import_field" ),
"import_field25", new XVar( "field", "fax_num",
"type", "import_field" ),
"import_field26", new XVar( "field", "telex_num",
"type", "import_field" ),
"import_field27", new XVar( "field", "addr1",
"type", "import_field" ),
"import_field28", new XVar( "field", "addr2",
"type", "import_field" ),
"import_field29", new XVar( "field", "addr3",
"type", "import_field" ),
"import_field30", new XVar( "field", "addr4",
"type", "import_field" ),
"import_field32", new XVar( "field", "internet_url",
"type", "import_field" ),
"import_field33", new XVar( "field", "internal_email_addr",
"type", "import_field" ),
"import_field34", new XVar( "field", "external_email_addr",
"type", "import_field" ),
"import_field35", new XVar( "field", "long_name",
"type", "import_field" ),
"import_field36", new XVar( "field", "vend_remit",
"type", "import_field" ),
"import_field12", new XVar( "field", "PendInv",
"type", "import_field" ) ),
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