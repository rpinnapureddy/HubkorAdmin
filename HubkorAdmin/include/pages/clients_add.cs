
		// dbo.clients
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
			public static partial class Options_clients_add
			{
				static public XVar options()
				{
					return new XVar( "details", new XVar( "dbo.client_authorizations", new XVar( "displayPreview", 1,
"previewPageId", "list" ),
"dbo.client_apps", new XVar( "displayPreview", 1,
"previewPageId", "list" ),
"dbo.client_connections", new XVar( "displayPreview", 1,
"previewPageId", "list" ),
"dbo.users", new XVar( "displayPreview", 1,
"previewPageId", "list" ),
"dbo.recordcounts", new XVar( "displayPreview", 1,
"previewPageId", "list" ),
"dbo.csi_site_mst", new XVar( "displayPreview", 1,
"previewPageId", "list" ),
"dbo.hk_invoice_mst", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"dbo.incidents", new XVar( "displayPreview", 2,
"previewPageId", "" ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "sf_auto_create_accounts",
1, "name",
2, "shortcode",
3, "date_created",
4, "active",
5, "sf_bill_to_only_sync",
6, "sl_master_site",
7, "num_days_incoming",
8, "num_days_outgoing",
9, "uet_auto_map",
10, "tp_inv_acct",
11, "tp_vend_stat",
12, "provision_date",
13, "termination_date",
14, "account_manager",
15, "service_manager",
16, "project_manager",
17, "primary_contact",
18, "primary_email",
19, "primary_phone",
20, "onprem",
21, "invoice_cycle",
22, "effective_invoice",
23, "next_invoice",
24, "last_invoice",
25, "termination_invoice",
26, "terms_days",
27, "sc_expense_process",
28, "email_flash",
29, "tp_distribution_date",
30, "tp_post_unreceived_po",
31, "tp_posttype",
32, "NotConsiderItem",
33, "tp_multisite",
34, "tp_consider_inv_acct",
35, "Shipment_Type",
36, "tp_consider_external_email",
37, "tp_consider_decimals",
38, "ship_flag" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "sf_auto_create_accounts", new XVar( 0, "integrated_edit_field" ),
"name", new XVar( 0, "integrated_edit_field1" ),
"shortcode", new XVar( 0, "integrated_edit_field2" ),
"date_created", new XVar( 0, "integrated_edit_field3" ),
"active", new XVar( 0, "integrated_edit_field4" ),
"sf_bill_to_only_sync", new XVar( 0, "integrated_edit_field6" ),
"sl_master_site", new XVar( 0, "integrated_edit_field7" ),
"num_days_incoming", new XVar( 0, "integrated_edit_field8" ),
"num_days_outgoing", new XVar( 0, "integrated_edit_field9" ),
"uet_auto_map", new XVar( 0, "integrated_edit_field10" ),
"tp_inv_acct", new XVar( 0, "integrated_edit_field11" ),
"tp_vend_stat", new XVar( 0, "integrated_edit_field12" ),
"provision_date", new XVar( 0, "integrated_edit_field13" ),
"termination_date", new XVar( 0, "integrated_edit_field14" ),
"account_manager", new XVar( 0, "integrated_edit_field15" ),
"service_manager", new XVar( 0, "integrated_edit_field16" ),
"project_manager", new XVar( 0, "integrated_edit_field17" ),
"primary_contact", new XVar( 0, "integrated_edit_field18" ),
"primary_email", new XVar( 0, "integrated_edit_field19" ),
"primary_phone", new XVar( 0, "integrated_edit_field20" ),
"onprem", new XVar( 0, "integrated_edit_field5" ),
"invoice_cycle", new XVar( 0, "integrated_edit_field22" ),
"effective_invoice", new XVar( 0, "integrated_edit_field23" ),
"next_invoice", new XVar( 0, "integrated_edit_field24" ),
"last_invoice", new XVar( 0, "integrated_edit_field25" ),
"termination_invoice", new XVar( 0, "integrated_edit_field26" ),
"terms_days", new XVar( 0, "integrated_edit_field21" ),
"sc_expense_process", new XVar( 0, "integrated_edit_field27" ),
"email_flash", new XVar( 0, "integrated_edit_field28" ),
"tp_distribution_date", new XVar( 0, "integrated_edit_field29" ),
"tp_post_unreceived_po", new XVar( 0, "integrated_edit_field30" ),
"tp_posttype", new XVar( 0, "integrated_edit_field31" ),
"NotConsiderItem", new XVar( 0, "integrated_edit_field32" ),
"tp_multisite", new XVar( 0, "integrated_edit_field33" ),
"tp_consider_inv_acct", new XVar( 0, "integrated_edit_field34" ),
"Shipment_Type", new XVar( 0, "integrated_edit_field35" ),
"tp_consider_external_email", new XVar( 0, "integrated_edit_field36" ),
"tp_consider_decimals", new XVar( 0, "integrated_edit_field37" ),
"ship_flag", new XVar( 0, "integrated_edit_field38" ) ) ),
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
"grid", new XVar( 0, "integrated_edit_field2",
1, "integrated_edit_field1",
2, "integrated_edit_field3",
3, "integrated_edit_field4",
4, "integrated_edit_field5",
5, "tabs",
6, "details_preview1",
7, "details_preview",
8, "details_preview2",
9, "details_preview3",
10, "details_preview4",
11, "details_preview5",
12, "integrated_edit_field21",
13, "integrated_edit_field31",
14, "integrated_edit_field36",
15, "integrated_edit_field27",
16, "integrated_edit_field32",
17, "integrated_edit_field37",
18, "integrated_edit_field28",
19, "integrated_edit_field33",
20, "integrated_edit_field38",
21, "integrated_edit_field29",
22, "integrated_edit_field34",
23, "integrated_edit_field30",
24, "integrated_edit_field35" ),
"section6", new XVar( 0, "integrated_edit_field13",
1, "integrated_edit_field14",
2, "integrated_edit_field15",
3, "integrated_edit_field16",
4, "integrated_edit_field17",
5, "integrated_edit_field18",
6, "integrated_edit_field19",
7, "integrated_edit_field20" ),
"section5", new XVar( 0, "integrated_edit_field22",
1, "integrated_edit_field23",
2, "integrated_edit_field26",
3, "integrated_edit_field25",
4, "integrated_edit_field24" ),
"section", new XVar( 0, "integrated_edit_field7",
1, "integrated_edit_field6",
2, "integrated_edit_field" ),
"section1", new XVar( 0, "integrated_edit_field11",
1, "integrated_edit_field12" ),
"section2", XVar.Array(),
"section3", XVar.Array(),
"section4", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field9",
2, "integrated_edit_field10" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "message_block" ) ),
"itemForms", new XVar( "add_message", "above-grid",
"add_save", "below-grid",
"add_reset", "below-grid",
"add_back_list", "below-grid",
"add_cancel", "below-grid",
"add_header", "top",
"integrated_edit_field2", "grid",
"integrated_edit_field1", "grid",
"integrated_edit_field3", "grid",
"integrated_edit_field4", "grid",
"integrated_edit_field5", "grid",
"tabs", "grid",
"details_preview1", "grid",
"details_preview", "grid",
"details_preview2", "grid",
"details_preview3", "grid",
"details_preview4", "grid",
"details_preview5", "grid",
"integrated_edit_field21", "grid",
"integrated_edit_field31", "grid",
"integrated_edit_field36", "grid",
"integrated_edit_field27", "grid",
"integrated_edit_field32", "grid",
"integrated_edit_field37", "grid",
"integrated_edit_field28", "grid",
"integrated_edit_field33", "grid",
"integrated_edit_field38", "grid",
"integrated_edit_field29", "grid",
"integrated_edit_field34", "grid",
"integrated_edit_field30", "grid",
"integrated_edit_field35", "grid",
"integrated_edit_field13", "section6",
"integrated_edit_field14", "section6",
"integrated_edit_field15", "section6",
"integrated_edit_field16", "section6",
"integrated_edit_field17", "section6",
"integrated_edit_field18", "section6",
"integrated_edit_field19", "section6",
"integrated_edit_field20", "section6",
"integrated_edit_field22", "section5",
"integrated_edit_field23", "section5",
"integrated_edit_field26", "section5",
"integrated_edit_field25", "section5",
"integrated_edit_field24", "section5",
"integrated_edit_field7", "section",
"integrated_edit_field6", "section",
"integrated_edit_field", "section",
"integrated_edit_field11", "section1",
"integrated_edit_field12", "section1",
"integrated_edit_field8", "section4",
"integrated_edit_field9", "section4",
"integrated_edit_field10", "section4" ),
"itemLocations", new XVar( "integrated_edit_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c" ),
"integrated_edit_field3", new XVar( "location", "grid",
"cellId", "c4" ),
"integrated_edit_field4", new XVar( "location", "grid",
"cellId", "c5" ),
"integrated_edit_field5", new XVar( "location", "grid",
"cellId", "c6" ),
"tabs", new XVar( "location", "grid",
"cellId", "c7" ),
"details_preview1", new XVar( "location", "grid",
"cellId", "c7" ),
"details_preview", new XVar( "location", "grid",
"cellId", "c7" ),
"details_preview2", new XVar( "location", "grid",
"cellId", "c7" ),
"details_preview3", new XVar( "location", "grid",
"cellId", "c7" ),
"details_preview4", new XVar( "location", "grid",
"cellId", "c7" ),
"details_preview5", new XVar( "location", "grid",
"cellId", "c7" ),
"integrated_edit_field21", new XVar( "location", "grid",
"cellId", "c8" ),
"integrated_edit_field31", new XVar( "location", "grid",
"cellId", "c8" ),
"integrated_edit_field36", new XVar( "location", "grid",
"cellId", "c8" ),
"integrated_edit_field27", new XVar( "location", "grid",
"cellId", "c9" ),
"integrated_edit_field32", new XVar( "location", "grid",
"cellId", "c9" ),
"integrated_edit_field37", new XVar( "location", "grid",
"cellId", "c9" ),
"integrated_edit_field28", new XVar( "location", "grid",
"cellId", "c10" ),
"integrated_edit_field33", new XVar( "location", "grid",
"cellId", "c10" ),
"integrated_edit_field38", new XVar( "location", "grid",
"cellId", "c10" ),
"integrated_edit_field29", new XVar( "location", "grid",
"cellId", "c11" ),
"integrated_edit_field34", new XVar( "location", "grid",
"cellId", "c11" ),
"integrated_edit_field30", new XVar( "location", "grid",
"cellId", "c12" ),
"integrated_edit_field35", new XVar( "location", "grid",
"cellId", "c12" ),
"integrated_edit_field13", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field14", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field15", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field16", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field17", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field18", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field19", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field20", new XVar( "location", "section6",
"cellId", "c1" ),
"integrated_edit_field22", new XVar( "location", "section5",
"cellId", "c1" ),
"integrated_edit_field23", new XVar( "location", "section5",
"cellId", "c1" ),
"integrated_edit_field26", new XVar( "location", "section5",
"cellId", "c1" ),
"integrated_edit_field25", new XVar( "location", "section5",
"cellId", "c1" ),
"integrated_edit_field24", new XVar( "location", "section5",
"cellId", "c1" ),
"integrated_edit_field7", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field6", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field11", new XVar( "location", "section1",
"cellId", "c1" ),
"integrated_edit_field12", new XVar( "location", "section1",
"cellId", "c1" ),
"integrated_edit_field8", new XVar( "location", "section4",
"cellId", "c1" ),
"integrated_edit_field9", new XVar( "location", "section4",
"cellId", "c1" ),
"integrated_edit_field10", new XVar( "location", "section4",
"cellId", "c1" ) ),
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
5, "integrated_edit_field6",
6, "integrated_edit_field7",
7, "integrated_edit_field8",
8, "integrated_edit_field9",
9, "integrated_edit_field10",
10, "integrated_edit_field11",
11, "integrated_edit_field12",
12, "integrated_edit_field13",
13, "integrated_edit_field14",
14, "integrated_edit_field15",
15, "integrated_edit_field16",
16, "integrated_edit_field17",
17, "integrated_edit_field18",
18, "integrated_edit_field19",
19, "integrated_edit_field20",
20, "integrated_edit_field5",
21, "integrated_edit_field22",
22, "integrated_edit_field23",
23, "integrated_edit_field24",
24, "integrated_edit_field25",
25, "integrated_edit_field26",
26, "integrated_edit_field21",
27, "integrated_edit_field27",
28, "integrated_edit_field28",
29, "integrated_edit_field29",
30, "integrated_edit_field30",
31, "integrated_edit_field31",
32, "integrated_edit_field32",
33, "integrated_edit_field33",
34, "integrated_edit_field34",
35, "integrated_edit_field35",
36, "integrated_edit_field36",
37, "integrated_edit_field37",
38, "integrated_edit_field38" ),
"details_preview", new XVar( 0, "details_preview",
1, "details_preview1",
2, "details_preview2",
3, "details_preview3",
4, "details_preview4",
5, "details_preview5" ),
"tabs", new XVar( 0, "tabs" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field2" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field1" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c4", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field3" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c5", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field4" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c6", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field5" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c7", new XVar( "cols", new XVar( 0, 0,
1, 1,
2, 2,
3, 3,
4, 4 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", new XVar( 0, "tabs",
1, "details_preview1",
2, "details_preview",
3, "details_preview2",
4, "details_preview3",
5, "details_preview4",
6, "details_preview5" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c8", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field21",
1, "integrated_edit_field31",
2, "integrated_edit_field36" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c9", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field27",
1, "integrated_edit_field32",
2, "integrated_edit_field37" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c10", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field28",
1, "integrated_edit_field33",
2, "integrated_edit_field38" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c11", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field29",
1, "integrated_edit_field34" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c12", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field30",
1, "integrated_edit_field35" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 5,
"height", 3 ),
"section6", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field13",
1, "integrated_edit_field14",
2, "integrated_edit_field15",
3, "integrated_edit_field16",
4, "integrated_edit_field17",
5, "integrated_edit_field18",
6, "integrated_edit_field19",
7, "integrated_edit_field20" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section5", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field22",
1, "integrated_edit_field23",
2, "integrated_edit_field26",
3, "integrated_edit_field25",
4, "integrated_edit_field24" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field7",
1, "integrated_edit_field6",
2, "integrated_edit_field" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section1", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field11",
1, "integrated_edit_field12" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section2", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section3", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section4", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field9",
2, "integrated_edit_field10" ),
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
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ),
1, new XVar( "cell", "c" ),
2, new XVar( "cell", "c4" ),
3, new XVar( "cell", "c5" ),
4, new XVar( "cell", "c6" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c7",
"colspan", 5 ) ),
"section", "" ),
2, new XVar( "cells", new XVar( 0, new XVar( "cell", "c8" ),
1, new XVar( "cell", "c9" ),
2, new XVar( "cell", "c10" ),
3, new XVar( "cell", "c11" ),
4, new XVar( "cell", "c12" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field2" ) ),
"c", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field1" ) ),
"c4", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field3" ) ),
"c5", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field4" ) ),
"c6", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field5" ) ),
"c7", new XVar( "model", "c3",
"items", new XVar( 0, "tabs",
1, "details_preview1",
2, "details_preview",
3, "details_preview2",
4, "details_preview3",
5, "details_preview4",
6, "details_preview5" ) ),
"c8", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field21",
1, "integrated_edit_field31",
2, "integrated_edit_field36" ) ),
"c9", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field27",
1, "integrated_edit_field32",
2, "integrated_edit_field37" ) ),
"c10", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field28",
1, "integrated_edit_field33",
2, "integrated_edit_field38" ) ),
"c11", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field29",
1, "integrated_edit_field34" ) ),
"c12", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field30",
1, "integrated_edit_field35" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 5,
"inlineLabels", true,
"separateLabels", false ),
"section6", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field13",
1, "integrated_edit_field14",
2, "integrated_edit_field15",
3, "integrated_edit_field16",
4, "integrated_edit_field17",
5, "integrated_edit_field18",
6, "integrated_edit_field19",
7, "integrated_edit_field20" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section5", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field22",
1, "integrated_edit_field23",
2, "integrated_edit_field26",
3, "integrated_edit_field25",
4, "integrated_edit_field24" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field7",
1, "integrated_edit_field6",
2, "integrated_edit_field" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section1", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field11",
1, "integrated_edit_field12" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section2", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section3", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section4", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field9",
2, "integrated_edit_field10" ) ) ),
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
"integrated_edit_field", new XVar( "field", "sf_auto_create_accounts",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field1", new XVar( "field", "name",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field2", new XVar( "field", "shortcode",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field3", new XVar( "field", "date_created",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field4", new XVar( "field", "active",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field6", new XVar( "field", "sf_bill_to_only_sync",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field7", new XVar( "field", "sl_master_site",
"type", "integrated_edit_field",
"orientation", 0,
"updateOnEdit", false ),
"integrated_edit_field8", new XVar( "field", "num_days_incoming",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field9", new XVar( "field", "num_days_outgoing",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field10", new XVar( "field", "uet_auto_map",
"type", "integrated_edit_field",
"orientation", 0,
"updateOnEdit", false ),
"integrated_edit_field11", new XVar( "field", "tp_inv_acct",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field12", new XVar( "field", "tp_vend_stat",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field13", new XVar( "field", "provision_date",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field14", new XVar( "field", "termination_date",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field15", new XVar( "field", "account_manager",
"type", "integrated_edit_field",
"orientation", 0 ),
"details_preview", new XVar( "type", "details_preview",
"table", "dbo.client_authorizations",
"items", XVar.Array(),
"popup", false,
"pageId", "list" ),
"details_preview1", new XVar( "type", "details_preview",
"table", "dbo.client_connections",
"items", XVar.Array(),
"popup", false,
"pageId", "list" ),
"details_preview2", new XVar( "type", "details_preview",
"table", "dbo.users",
"items", XVar.Array(),
"popup", false,
"pageId", "list" ),
"integrated_edit_field16", new XVar( "field", "service_manager",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field17", new XVar( "field", "project_manager",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field18", new XVar( "field", "primary_contact",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field19", new XVar( "field", "primary_email",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field20", new XVar( "field", "primary_phone",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field5", new XVar( "field", "onprem",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field22", new XVar( "field", "invoice_cycle",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field23", new XVar( "field", "effective_invoice",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field24", new XVar( "field", "next_invoice",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field25", new XVar( "field", "last_invoice",
"type", "integrated_edit_field",
"orientation", 0 ),
"tabs", new XVar( "type", "tabs",
"titles", new XVar( 0, new XVar( "text", "Contacts",
"type", 0 ),
1, new XVar( "text", "Billings",
"type", 0 ),
2, new XVar( "text", "Salesforce",
"type", 0 ),
3, new XVar( "text", "Tipalti",
"type", 0 ),
4, new XVar( "text", "Magento",
"type", 0 ),
5, new XVar( "text", "Concur",
"type", 0 ),
6, new XVar( "text", "Syteline",
"type", 0 ) ),
"locations", new XVar( 0, "section6",
1, "section5",
2, "section",
3, "section1",
4, "section2",
5, "section3",
6, "section4" ),
"bsStyle", "default",
"panelType", 2 ),
"integrated_edit_field26", new XVar( "field", "termination_invoice",
"type", "integrated_edit_field",
"orientation", 0 ),
"details_preview3", new XVar( "type", "details_preview",
"table", "dbo.client_apps",
"items", XVar.Array(),
"popup", false,
"pageId", "list" ),
"details_preview4", new XVar( "type", "details_preview",
"table", "dbo.csi_site_mst",
"items", XVar.Array(),
"popup", false,
"pageId", "list" ),
"details_preview5", new XVar( "type", "details_preview",
"table", "dbo.recordcounts",
"items", XVar.Array(),
"popup", false,
"pageId", "list" ),
"integrated_edit_field21", new XVar( "field", "terms_days",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field27", new XVar( "field", "sc_expense_process",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field28", new XVar( "field", "email_flash",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field29", new XVar( "field", "tp_distribution_date",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field30", new XVar( "field", "tp_post_unreceived_po",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field31", new XVar( "field", "tp_posttype",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field32", new XVar( "field", "NotConsiderItem",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field33", new XVar( "field", "tp_multisite",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field34", new XVar( "field", "tp_consider_inv_acct",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field35", new XVar( "field", "Shipment_Type",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field36", new XVar( "field", "tp_consider_external_email",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field37", new XVar( "field", "tp_consider_decimals",
"type", "integrated_edit_field",
"orientation", 1 ),
"integrated_edit_field38", new XVar( "field", "ship_flag",
"type", "integrated_edit_field",
"orientation", 1 ) ),
"dbProps", new XVar(  ),
"version", 14,
"pageWidth", "full",
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}