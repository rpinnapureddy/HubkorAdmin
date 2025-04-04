
		// dbo.mg_orderline_count Report
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
			public static partial class Options_mg_orderline_count_report_report
			{
				static public XVar options()
				{
					return new XVar( "pdf", new XVar( "pdfView", false ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"fixedSearchPanel", false,
"simpleSearchOptions", false,
"searchSaving", false ),
"fields", new XVar( "gridFields", new XVar( 0, "cnt" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "cnt",
1, "yy",
2, "mm",
3, "extprice",
4, "co_num",
5, "clientid" ),
"filterFields", XVar.Array(),
"fieldItems", new XVar( "cnt", new XVar( 0, "report_grid_field1" ),
"yy", new XVar( 0, "report_group_field" ),
"mm", new XVar( 0, "report_group_field1" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "details_found",
1, "page_size",
2, "print_panel" ),
"below-grid", new XVar( 0, "pagination" ),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu",
3, "search_panel" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb",
3, "simple_search",
4, "list_options",
5, "loginform_login",
6, "username_button" ),
"grid", new XVar( 0, "report_group_field",
1, "report_group_field1",
2, "report_grid_field1" ),
"top", XVar.Array() ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "details_found",
1, "grpsPerPage",
2, "print_friendly" ),
"below-grid", new XVar( 0, "pagination" ),
"top", XVar.Array() ),
"itemForms", new XVar( "details_found", "above-grid",
"page_size", "above-grid",
"print_panel", "above-grid",
"pagination", "below-grid",
"logo", "left",
"expand_button", "left",
"menu", "left",
"search_panel", "left",
"expand_menu_button", "supertop",
"collapse_button", "supertop",
"breadcrumb", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"loginform_login", "supertop",
"username_button", "supertop",
"report_group_field", "grid",
"report_group_field1", "grid",
"report_grid_field1", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar( "breadcrumb", 5,
"expand_menu_button", 2,
"print_panel", 5,
"expand_button", 5 ) ),
"itemsByType", new XVar( "page_size", new XVar( 0, "page_size" ),
"details_found", new XVar( 0, "details_found" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"pagination", new XVar( 0, "pagination" ),
"list_options", new XVar( 0, "list_options" ),
"export_report_excel", new XVar( 0, "export_report_excel" ),
"export_report_word", new XVar( 0, "export_report_word" ),
"search_panel", new XVar( 0, "search_panel" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"-", new XVar( 0, "-",
1, "-1" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"search_panel_field", new XVar( 0, "search_panel_field1",
1, "search_panel_field2",
2, "search_panel_field3",
3, "search_panel_field4",
4, "search_panel_field5",
5, "search_panel_field6" ),
"username_button", new XVar( 0, "username_button" ),
"loginform_login", new XVar( 0, "loginform_login" ),
"userinfo_link", new XVar( 0, "userinfo_link" ),
"logout_link", new XVar( 0, "logout_link" ),
"adminarea_link", new XVar( 0, "adminarea_link" ),
"changepassword_link", new XVar( 0, "changepassword_link" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"print_panel", new XVar( 0, "print_panel" ),
"print_scope", new XVar( 0, "print_scope" ),
"print_button", new XVar( 0, "print_button" ),
"print_records", new XVar( 0, "print_records" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"report_grid_field", new XVar( 0, "report_grid_field1" ),
"report_group_field", new XVar( 0, "report_group_field",
1, "report_group_field1" ),
"expand_button", new XVar( 0, "expand_button" ) ),
"cellMaps", new XVar(  ) ),
"loginForm", new XVar( "loginForm", 0 ),
"page", new XVar( "verticalBar", true,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar( "details_found", new XVar( "tag", "DISPLAYING",
"type", 2 ) ) ),
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", new XVar( 0, new XVar( "id", "main",
"horizontal", false ) ),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "report",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"newreport", new XVar( "reportInfo", new XVar( "groupFields", new XVar( 0, new XVar( "interval", 0,
"summary", false,
"field", "yy",
"color", new XVar( "header", "7aca7a",
"summary", "90ee90" ),
"axis", 1 ),
1, new XVar( "interval", 0,
"summary", false,
"field", "mm",
"color", new XVar( "header", "93b8c4",
"summary", "add8e6" ),
"axis", 0 ) ),
"fields", new XVar( 0, new XVar( "field", "cnt",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", true ) ),
"showData", true,
"pageSummary", false,
"globalSummary", false,
"crosstab", true,
"colors", XVar.Array(),
"horizSummary", true,
"layout", "plain",
"vertSummary", true ) ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "report",
"type", "report",
"layoutId", "leftbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "report-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "details_found",
1, "page_size",
2, "print_panel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "report-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "pagination" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"left", new XVar( "modelId", "leftbar-menu",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c0" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c0", new XVar( "model", "c0",
"items", new XVar( 0, "logo",
1, "expand_button" ) ),
"c1", new XVar( "model", "c1",
"items", new XVar( 0, "menu",
1, "search_panel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "leftbar-top-chart",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "simple_search",
1, "list_options",
2, "loginform_login",
3, "username_button" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "report-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "report_group_field",
1, "report_group_field1" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "report_grid_field1" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1,
"reportInfo", new XVar( "groupFields", new XVar( 0, new XVar( "interval", 0,
"summary", false,
"field", "yy",
"color", new XVar( "header", "7aca7a",
"summary", "90ee90" ),
"axis", 1 ),
1, new XVar( "interval", 0,
"summary", false,
"field", "mm",
"color", new XVar( "header", "93b8c4",
"summary", "add8e6" ),
"axis", 0 ) ),
"fields", new XVar( 0, new XVar( "field", "cnt",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", true ) ),
"showData", true,
"pageSummary", false,
"globalSummary", false,
"crosstab", true,
"colors", XVar.Array(),
"horizSummary", true,
"layout", "plain",
"vertSummary", true ) ),
"top", new XVar( "modelId", "list-sidebar-top",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "page_size", new XVar( "type", "page_size" ),
"details_found", new XVar( "type", "details_found" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"pagination", new XVar( "type", "pagination" ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "advsearch_link",
1, "show_search_panel",
2, "hide_search_panel",
3, "-1",
4, "export_report_excel",
5, "export_report_word" ) ),
"export_report_excel", new XVar( "type", "export_report_excel" ),
"export_report_word", new XVar( "type", "export_report_word" ),
"search_panel", new XVar( "type", "search_panel",
"items", new XVar( 0, "search_panel_field6",
1, "search_panel_field5",
2, "search_panel_field4",
3, "search_panel_field3",
4, "search_panel_field2",
5, "search_panel_field1" ) ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"-", new XVar( "type", "-" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"search_panel_field1", new XVar( "field", "clientid",
"type", "search_panel_field",
"required", false ),
"search_panel_field2", new XVar( "field", "co_num",
"type", "search_panel_field",
"required", false ),
"search_panel_field3", new XVar( "field", "extprice",
"type", "search_panel_field",
"required", false ),
"search_panel_field4", new XVar( "field", "mm",
"type", "search_panel_field",
"required", false ),
"search_panel_field5", new XVar( "field", "yy",
"type", "search_panel_field",
"required", false ),
"username_button", new XVar( "type", "username_button",
"items", new XVar( 0, "userinfo_link",
1, "logout_link",
2, "adminarea_link",
3, "changepassword_link" ) ),
"loginform_login", new XVar( "type", "loginform_login",
"popup", false ),
"userinfo_link", new XVar( "type", "userinfo_link" ),
"logout_link", new XVar( "type", "logout_link" ),
"adminarea_link", new XVar( "type", "adminarea_link" ),
"changepassword_link", new XVar( "type", "changepassword_link" ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"print_panel", new XVar( "type", "print_panel",
"items", new XVar( 0, "print_scope",
1, "print_records",
2, "print_button" ) ),
"print_scope", new XVar( "type", "print_scope" ),
"print_button", new XVar( "type", "print_button" ),
"print_records", new XVar( "type", "print_records" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-1", new XVar( "type", "-" ),
"report_grid_field1", new XVar( "field", "cnt",
"type", "report_grid_field",
"reportAvg", false,
"reportMin", false,
"reportMax", false,
"reportSum", true ),
"report_group_field", new XVar( "field", "yy",
"type", "report_group_field",
"summary", false,
"axis", 1,
"interval", 0 ),
"report_group_field1", new XVar( "field", "mm",
"type", "report_group_field",
"summary", false,
"axis", 0,
"interval", 0 ),
"search_panel_field6", new XVar( "field", "cnt",
"type", "search_panel_field",
"required", false ),
"expand_button", new XVar( "type", "expand_button" ) ),
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