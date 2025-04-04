
		// dbo.tp_payments_hdr_mst
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
			public static partial class Options_tp_payments_hdr_mst_search
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id",
1, "SequenceRefCode",
2, "submissionDate",
3, "AmountSubmitted",
4, "AmountSubmittedCur",
5, "PaymentMethod",
6, "Status",
7, "PayerFees",
8, "PayeeFxfees",
9, "PayerFxfees",
10, "withdrawCurr",
11, "withdrawAmt",
12, "NetAmountCurr",
13, "NetAmount",
14, "Message",
15, "BankingMessage",
16, "EmailSubject",
17, "TxnReference",
18, "paymentcurr",
19, "PayerEntityName",
20, "PayerEntityCountryISO",
21, "Provider",
22, "AccountIdentifier",
23, "PayerExchangeRate",
24, "PaymentAmountInWithdrawCurrency",
25, "vendor",
26, "TxnDate",
27, "posted",
28, "clientid",
29, "trans_num",
30, "site_ref",
31, "rowpointer",
32, "RelatedBills",
33, "err_msg",
34, "json_data",
35, "jresult",
36, "postdate" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id", new XVar( 0, "integrated_search_field" ),
"SequenceRefCode", new XVar( 0, "integrated_search_field1" ),
"submissionDate", new XVar( 0, "integrated_search_field2" ),
"AmountSubmitted", new XVar( 0, "integrated_search_field3" ),
"AmountSubmittedCur", new XVar( 0, "integrated_search_field4" ),
"PaymentMethod", new XVar( 0, "integrated_search_field5" ),
"Status", new XVar( 0, "integrated_search_field6" ),
"PayerFees", new XVar( 0, "integrated_search_field7" ),
"PayeeFxfees", new XVar( 0, "integrated_search_field8" ),
"PayerFxfees", new XVar( 0, "integrated_search_field9" ),
"withdrawCurr", new XVar( 0, "integrated_search_field10" ),
"withdrawAmt", new XVar( 0, "integrated_search_field11" ),
"NetAmountCurr", new XVar( 0, "integrated_search_field12" ),
"NetAmount", new XVar( 0, "integrated_search_field13" ),
"Message", new XVar( 0, "integrated_search_field14" ),
"BankingMessage", new XVar( 0, "integrated_search_field15" ),
"EmailSubject", new XVar( 0, "integrated_search_field16" ),
"TxnReference", new XVar( 0, "integrated_search_field17" ),
"paymentcurr", new XVar( 0, "integrated_search_field18" ),
"PayerEntityName", new XVar( 0, "integrated_search_field19" ),
"PayerEntityCountryISO", new XVar( 0, "integrated_search_field20" ),
"Provider", new XVar( 0, "integrated_search_field21" ),
"AccountIdentifier", new XVar( 0, "integrated_search_field22" ),
"PayerExchangeRate", new XVar( 0, "integrated_search_field23" ),
"PaymentAmountInWithdrawCurrency", new XVar( 0, "integrated_search_field24" ),
"vendor", new XVar( 0, "integrated_search_field25" ),
"TxnDate", new XVar( 0, "integrated_search_field26" ),
"posted", new XVar( 0, "integrated_search_field27" ),
"clientid", new XVar( 0, "integrated_search_field28" ),
"trans_num", new XVar( 0, "integrated_search_field29" ),
"site_ref", new XVar( 0, "integrated_search_field30" ),
"rowpointer", new XVar( 0, "integrated_search_field31" ),
"RelatedBills", new XVar( 0, "integrated_search_field32" ),
"err_msg", new XVar( 0, "integrated_search_field33" ),
"json_data", new XVar( 0, "integrated_search_field34" ),
"jresult", new XVar( 0, "integrated_search_field35" ),
"postdate", new XVar( 0, "integrated_search_field36" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list",
3, "search_cancel" ),
"top", new XVar( 0, "search_header" ),
"grid", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field9",
10, "integrated_search_field10",
11, "integrated_search_field11",
12, "integrated_search_field12",
13, "integrated_search_field13",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16",
17, "integrated_search_field17",
18, "integrated_search_field18",
19, "integrated_search_field19",
20, "integrated_search_field20",
21, "integrated_search_field21",
22, "integrated_search_field22",
23, "integrated_search_field23",
24, "integrated_search_field24",
25, "integrated_search_field25",
26, "integrated_search_field26",
27, "integrated_search_field27",
28, "integrated_search_field28",
29, "integrated_search_field29",
30, "integrated_search_field30",
31, "integrated_search_field31",
32, "integrated_search_field32",
33, "integrated_search_field33",
34, "integrated_search_field34",
35, "integrated_search_field35",
36, "integrated_search_field36" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "search_search", "below-grid",
"search_reset", "below-grid",
"search_back_list", "below-grid",
"search_cancel", "below-grid",
"search_header", "top",
"integrated_search_field", "grid",
"integrated_search_field1", "grid",
"integrated_search_field2", "grid",
"integrated_search_field3", "grid",
"integrated_search_field4", "grid",
"integrated_search_field5", "grid",
"integrated_search_field6", "grid",
"integrated_search_field7", "grid",
"integrated_search_field8", "grid",
"integrated_search_field9", "grid",
"integrated_search_field10", "grid",
"integrated_search_field11", "grid",
"integrated_search_field12", "grid",
"integrated_search_field13", "grid",
"integrated_search_field14", "grid",
"integrated_search_field15", "grid",
"integrated_search_field16", "grid",
"integrated_search_field17", "grid",
"integrated_search_field18", "grid",
"integrated_search_field19", "grid",
"integrated_search_field20", "grid",
"integrated_search_field21", "grid",
"integrated_search_field22", "grid",
"integrated_search_field23", "grid",
"integrated_search_field24", "grid",
"integrated_search_field25", "grid",
"integrated_search_field26", "grid",
"integrated_search_field27", "grid",
"integrated_search_field28", "grid",
"integrated_search_field29", "grid",
"integrated_search_field30", "grid",
"integrated_search_field31", "grid",
"integrated_search_field32", "grid",
"integrated_search_field33", "grid",
"integrated_search_field34", "grid",
"integrated_search_field35", "grid",
"integrated_search_field36", "grid" ),
"itemLocations", new XVar( "integrated_search_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field3", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field5", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field6", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field7", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field9", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field10", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field11", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field12", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field13", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field14", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field15", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field16", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field17", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field18", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field19", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field20", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field21", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field22", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field23", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field24", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field25", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field26", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field27", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field28", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field29", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field30", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field31", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field32", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field33", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field34", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field35", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field36", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "search_header", new XVar( 0, "search_header" ),
"search_reset", new XVar( 0, "search_reset" ),
"search_back_list", new XVar( 0, "search_back_list" ),
"search_search", new XVar( 0, "search_search" ),
"search_cancel", new XVar( 0, "search_cancel" ),
"integrated_search_field", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field9",
10, "integrated_search_field10",
11, "integrated_search_field11",
12, "integrated_search_field12",
13, "integrated_search_field13",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16",
17, "integrated_search_field17",
18, "integrated_search_field18",
19, "integrated_search_field19",
20, "integrated_search_field20",
21, "integrated_search_field21",
22, "integrated_search_field22",
23, "integrated_search_field23",
24, "integrated_search_field24",
25, "integrated_search_field25",
26, "integrated_search_field26",
27, "integrated_search_field27",
28, "integrated_search_field28",
29, "integrated_search_field29",
30, "integrated_search_field30",
31, "integrated_search_field31",
32, "integrated_search_field32",
33, "integrated_search_field33",
34, "integrated_search_field34",
35, "integrated_search_field35",
36, "integrated_search_field36" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field9",
10, "integrated_search_field10",
11, "integrated_search_field11",
12, "integrated_search_field12",
13, "integrated_search_field13",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16",
17, "integrated_search_field17",
18, "integrated_search_field18",
19, "integrated_search_field19",
20, "integrated_search_field20",
21, "integrated_search_field21",
22, "integrated_search_field22",
23, "integrated_search_field23",
24, "integrated_search_field24",
25, "integrated_search_field25",
26, "integrated_search_field26",
27, "integrated_search_field27",
28, "integrated_search_field28",
29, "integrated_search_field29",
30, "integrated_search_field30",
31, "integrated_search_field31",
32, "integrated_search_field32",
33, "integrated_search_field33",
34, "integrated_search_field34",
35, "integrated_search_field35",
36, "integrated_search_field36" ),
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
"misc", new XVar( "type", "search",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "search",
"type", "search",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "search-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1",
"colspan", 2 ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "search-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list",
3, "search_cancel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "search-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-search",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field9",
10, "integrated_search_field10",
11, "integrated_search_field11",
12, "integrated_search_field12",
13, "integrated_search_field13",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16",
17, "integrated_search_field17",
18, "integrated_search_field18",
19, "integrated_search_field19",
20, "integrated_search_field20",
21, "integrated_search_field21",
22, "integrated_search_field22",
23, "integrated_search_field23",
24, "integrated_search_field24",
25, "integrated_search_field25",
26, "integrated_search_field26",
27, "integrated_search_field27",
28, "integrated_search_field28",
29, "integrated_search_field29",
30, "integrated_search_field30",
31, "integrated_search_field31",
32, "integrated_search_field32",
33, "integrated_search_field33",
34, "integrated_search_field34",
35, "integrated_search_field35",
36, "integrated_search_field36" ) ) ),
"deferredItems", XVar.Array(),
"separateLabels", false ) ),
"items", new XVar( "search_header", new XVar( "type", "search_header" ),
"search_reset", new XVar( "type", "search_reset" ),
"search_back_list", new XVar( "type", "search_back_list" ),
"search_search", new XVar( "type", "search_search" ),
"search_cancel", new XVar( "type", "search_cancel" ),
"integrated_search_field", new XVar( "field", "id",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field1", new XVar( "field", "SequenceRefCode",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field2", new XVar( "field", "submissionDate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field3", new XVar( "field", "AmountSubmitted",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field4", new XVar( "field", "AmountSubmittedCur",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field5", new XVar( "field", "PaymentMethod",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field6", new XVar( "field", "Status",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field7", new XVar( "field", "PayerFees",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field8", new XVar( "field", "PayeeFxfees",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field9", new XVar( "field", "PayerFxfees",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field10", new XVar( "field", "withdrawCurr",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field11", new XVar( "field", "withdrawAmt",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field12", new XVar( "field", "NetAmountCurr",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field13", new XVar( "field", "NetAmount",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field14", new XVar( "field", "Message",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field15", new XVar( "field", "BankingMessage",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field16", new XVar( "field", "EmailSubject",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field17", new XVar( "field", "TxnReference",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field18", new XVar( "field", "paymentcurr",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field19", new XVar( "field", "PayerEntityName",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field20", new XVar( "field", "PayerEntityCountryISO",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field21", new XVar( "field", "Provider",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field22", new XVar( "field", "AccountIdentifier",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field23", new XVar( "field", "PayerExchangeRate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field24", new XVar( "field", "PaymentAmountInWithdrawCurrency",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field25", new XVar( "field", "vendor",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field26", new XVar( "field", "TxnDate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field27", new XVar( "field", "posted",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field28", new XVar( "field", "clientid",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field29", new XVar( "field", "trans_num",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field30", new XVar( "field", "site_ref",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field31", new XVar( "field", "rowpointer",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field32", new XVar( "field", "RelatedBills",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field33", new XVar( "field", "err_msg",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field34", new XVar( "field", "json_data",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field35", new XVar( "field", "jresult",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field36", new XVar( "field", "postdate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ) ),
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