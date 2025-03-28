
		// dbo.csi_chart_mst
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
			public static partial class Options_csi_chart_mst_list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", false,
"detailsAdd", false,
"inlineEdit", false,
"spreadsheetMode", false,
"addToBottom", false,
"delete", false,
"updateSelected", false,
"addInPopup", null,
"editInPopup", null,
"viewInPopup", null,
"clickSort", true,
"sortDropdown", false,
"showHideFields", false,
"reorderFields", false,
"fieldFilter", false,
"hideNumberOfRecords", false ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"fixedSearchPanel", false,
"simpleSearchOptions", false,
"searchSaving", false ),
"totals", new XVar( "clientid", new XVar( "totalsType", "" ),
"acct", new XVar( "totalsType", "" ),
"site_ref", new XVar( "totalsType", "" ),
"access_unit1", new XVar( "totalsType", "" ),
"access_unit2", new XVar( "totalsType", "" ),
"access_unit3", new XVar( "totalsType", "" ),
"access_unit4", new XVar( "totalsType", "" ),
"acct_class", new XVar( "totalsType", "" ),
"CreateDate", new XVar( "totalsType", "" ),
"CreatedBy", new XVar( "totalsType", "" ),
"description", new XVar( "totalsType", "" ),
"eff_date", new XVar( "totalsType", "" ),
"InWorkflow", new XVar( "totalsType", "" ),
"is_control", new XVar( "totalsType", "" ),
"ledger_dim_name", new XVar( "totalsType", "" ),
"MX_applies_to_ietu", new XVar( "totalsType", "" ),
"MX_diot_trans_type", new XVar( "totalsType", "" ),
"MX_ietu_class", new XVar( "totalsType", "" ),
"MX_ietu_deduction_pct", new XVar( "totalsType", "" ),
"NoteExistsFlag", new XVar( "totalsType", "" ),
"obs_date", new XVar( "totalsType", "" ),
"RecordDate", new XVar( "totalsType", "" ),
"reports_to_acct", new XVar( "totalsType", "" ),
"RowPointer", new XVar( "totalsType", "" ),
"trans_method", new XVar( "totalsType", "" ),
"type", new XVar( "totalsType", "" ),
"UpdatedBy", new XVar( "totalsType", "" ),
"use_buy_rate", new XVar( "totalsType", "" ),
"DLDeleteIndicator", new XVar( "totalsType", "" ),
"VariationNumber", new XVar( "totalsType", "" ),
"tp_id", new XVar( "totalsType", "" ),
"tp_posted", new XVar( "totalsType", "" ),
"sc_id", new XVar( "totalsType", "" ),
"sc_posted", new XVar( "totalsType", "" ),
"sf_id", new XVar( "totalsType", "" ),
"sf_posted", new XVar( "totalsType", "" ),
"mg_id", new XVar( "totalsType", "" ),
"mg_posted", new XVar( "totalsType", "" ),
"uf_uet1", new XVar( "totalsType", "" ),
"uf_uet2", new XVar( "totalsType", "" ),
"uf_uet3", new XVar( "totalsType", "" ),
"uf_uet4", new XVar( "totalsType", "" ),
"uf_uet5", new XVar( "totalsType", "" ),
"uf_uet6", new XVar( "totalsType", "" ),
"uf_uet7", new XVar( "totalsType", "" ),
"uf_uet8", new XVar( "totalsType", "" ),
"uf_uet9", new XVar( "totalsType", "" ),
"uf_uet10", new XVar( "totalsType", "" ),
"tp_status", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "clientid",
1, "site_ref",
2, "tp_status",
3, "acct" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "tp_status",
1, "site_ref",
2, "description",
3, "clientid",
4, "acct" ),
"filterFields", new XVar( 0, "clientid",
1, "site_ref" ),
"inlineAddFields", XVar.Array(),
"inlineEditFields", XVar.Array(),
"fieldItems", new XVar( "tp_status", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field5" ),
"acct", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field4" ),
"clientid", new XVar( 0, "simple_grid_field",
1, "simple_grid_field3" ),
"site_ref", new XVar( 0, "grid_field",
1, "grid_field_label" ) ),
"hideEmptyFields", XVar.Array(),
"fieldFilterFields", XVar.Array() ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", true ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "details_found",
1, "page_size",
2, "print_panel" ),
"below-grid", new XVar( 0, "pagination" ),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu",
3, "search_panel",
4, "filter_panel" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb",
3, "simple_search",
4, "list_options",
5, "loginform_login",
6, "username_button" ),
"grid", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field",
2, "grid_field_label",
3, "grid_field",
4, "simple_grid_field4",
5, "simple_grid_field1",
6, "simple_grid_field5",
7, "simple_grid_field2",
8, "grid_checkbox_head",
9, "grid_checkbox",
10, "custom_button" ),
"top", XVar.Array() ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "details_found",
1, "recsPerPage",
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
"filter_panel", "left",
"expand_menu_button", "supertop",
"collapse_button", "supertop",
"breadcrumb", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"loginform_login", "supertop",
"username_button", "supertop",
"simple_grid_field3", "grid",
"simple_grid_field", "grid",
"grid_field_label", "grid",
"grid_field", "grid",
"simple_grid_field4", "grid",
"simple_grid_field1", "grid",
"simple_grid_field5", "grid",
"simple_grid_field2", "grid",
"grid_checkbox_head", "grid",
"grid_checkbox", "grid",
"custom_button", "grid" ),
"itemLocations", new XVar( "simple_grid_field3", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"grid_field_label", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"grid_field", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "headcell_field10" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field10" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_checkbox" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "cell_checkbox" ),
"custom_button", new XVar( "location", "grid",
"cellId", "headcell_checkbox2" ) ),
"itemVisiblity", new XVar( "breadcrumb", 5,
"expand_menu_button", 2,
"print_panel", 5,
"expand_button", 5 ) ),
"itemsByType", new XVar( "page_size", new XVar( 0, "page_size" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"pagination", new XVar( 0, "pagination" ),
"grid_checkbox", new XVar( 0, "grid_checkbox" ),
"grid_checkbox_head", new XVar( 0, "grid_checkbox_head" ),
"details_found", new XVar( 0, "details_found" ),
"search_panel", new XVar( 0, "search_panel" ),
"list_options", new XVar( 0, "list_options" ),
"grid_field", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field1",
2, "simple_grid_field",
3, "grid_field" ),
"-", new XVar( 0, "-2",
1, "-",
2, "-1" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
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
"export", new XVar( 0, "export" ),
"import", new XVar( 0, "import" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"filter_panel", new XVar( 0, "filter_panel" ),
"filter_panel_field", new XVar( 0, "filter_panel_field",
1, "filter_panel_field1" ),
"search_panel_field", new XVar( 0, "search_panel_field17",
1, "search_panel_field19",
2, "search_panel_field20",
3, "search_panel_field",
4, "search_panel_field1" ),
"grid_field_label", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field4",
2, "simple_grid_field5",
3, "grid_field_label" ),
"custom_button", new XVar( 0, "custom_button" ),
"expand_button", new XVar( 0, "expand_button" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_checkbox", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox_head" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "clientid_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "site_ref_fieldheadercolumn" ),
"items", new XVar( 0, "grid_field_label" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field10", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "tp_status_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "acct_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_checkbox", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox2", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", true,
"fixedAtClient", true ),
"cell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "clientid_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "site_ref_fieldcolumn" ),
"items", new XVar( 0, "grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field10", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "tp_status_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "acct_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_checkbox", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox3", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field10", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 6,
"height", 3 ) ) ),
"loginForm", new XVar( "loginForm", 0 ),
"page", new XVar( "verticalBar", true,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar( "details_found", new XVar( "tag", "DISPLAYING",
"type", 2 ) ) ),
"gridType", 0,
"recsPerRow", 1,
"hasCustomButtons", true,
"customButtons", new XVar( 0, "New_Button9" ),
"hasNotifications", false,
"menus", new XVar( 0, new XVar( "id", "main",
"horizontal", false ) ),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "list",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", new XVar( 0, "New_Button9" ) ),
"dataGrid", new XVar( "groupFields", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "list",
"type", "list",
"layoutId", "leftbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "list-above-grid",
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
"below-grid", new XVar( "modelId", "list-below-grid",
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
1, "search_panel",
2, "filter_panel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "leftbar-top",
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
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_checkbox" ),
1, new XVar( "cell", "headcell_checkbox1" ),
2, new XVar( "cell", "headcell_field" ),
3, new XVar( "cell", "headcell_field1" ),
4, new XVar( "cell", "headcell_field10" ),
5, new XVar( "cell", "headcell_field3" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_checkbox" ),
1, new XVar( "cell", "headcell_checkbox2" ),
2, new XVar( "cell", "cell_field" ),
3, new XVar( "cell", "cell_field1" ),
4, new XVar( "cell", "cell_field10" ),
5, new XVar( "cell", "cell_field3" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_checkbox" ),
1, new XVar( "cell", "headcell_checkbox3" ),
2, new XVar( "cell", "footcell_field" ),
3, new XVar( "cell", "footcell_field1" ),
4, new XVar( "cell", "footcell_field10" ),
5, new XVar( "cell", "footcell_field3" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "clientid",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "clientid",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "grid_field_label" ),
"field", "site_ref",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "grid_field" ),
"field", "site_ref",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "acct",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "acct",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field10", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "tp_status",
"columnName", "field" ),
"cell_field10", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "tp_status",
"columnName", "field" ),
"footcell_field10", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_checkbox", new XVar( "model", "headcell_checkbox",
"items", new XVar( 0, "grid_checkbox_head" ) ),
"cell_checkbox", new XVar( "model", "cell_checkbox",
"items", new XVar( 0, "grid_checkbox" ) ),
"footcell_checkbox", new XVar( "model", "footcell_checkbox",
"items", XVar.Array() ),
"headcell_checkbox1", new XVar( "model", "headcell_checkbox",
"items", XVar.Array() ),
"headcell_checkbox2", new XVar( "model", "cell_checkbox",
"items", new XVar( 0, "custom_button" ) ),
"headcell_checkbox3", new XVar( "model", "footcell_checkbox",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "list-sidebar-top",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "page_size", new XVar( "type", "page_size" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"pagination", new XVar( "type", "pagination" ),
"grid_checkbox", new XVar( "type", "grid_checkbox" ),
"grid_checkbox_head", new XVar( "type", "grid_checkbox_head" ),
"details_found", new XVar( "type", "details_found" ),
"search_panel", new XVar( "type", "search_panel",
"items", new XVar( 0, "search_panel_field",
1, "search_panel_field1",
2, "search_panel_field20",
3, "search_panel_field19",
4, "search_panel_field17" ),
"_flexiblePanel", true ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "advsearch_link",
1, "show_search_panel",
2, "hide_search_panel",
3, "-2",
4, "export",
5, "-1",
6, "import" ) ),
"simple_grid_field2", new XVar( "field", "tp_status",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field1", new XVar( "field", "acct",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field", new XVar( "field", "clientid",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"-2", new XVar( "type", "-" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
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
"export", new XVar( "type", "export" ),
"-", new XVar( "type", "-" ),
"import", new XVar( "type", "import" ),
"-1", new XVar( "type", "-" ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"filter_panel", new XVar( "type", "filter_panel",
"items", new XVar( 0, "filter_panel_field",
1, "filter_panel_field1" ) ),
"filter_panel_field", new XVar( "field", "clientid",
"type", "filter_panel_field" ),
"filter_panel_field1", new XVar( "field", "site_ref",
"type", "filter_panel_field" ),
"search_panel_field17", new XVar( "field", "acct",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field19", new XVar( "field", "clientid",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field20", new XVar( "field", "description",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field", new XVar( "field", "tp_status",
"type", "search_panel_field",
"required", false ),
"simple_grid_field3", new XVar( "type", "grid_field_label",
"field", "clientid" ),
"simple_grid_field4", new XVar( "type", "grid_field_label",
"field", "acct" ),
"simple_grid_field5", new XVar( "type", "grid_field_label",
"field", "tp_status" ),
"custom_button", new XVar( "eventId", "New_Button9",
"label", new XVar( "text", "update/close",
"type", 0 ),
"type", "custom_button",
"buttonStyle", "primary" ),
"grid_field", new XVar( "field", "site_ref",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"grid_field_label", new XVar( "type", "grid_field_label",
"field", "site_ref" ),
"search_panel_field1", new XVar( "field", "site_ref",
"type", "search_panel_field" ),
"expand_button", new XVar( "type", "expand_button" ) ),
"dbProps", new XVar(  ),
"spreadsheetGrid", false,
"version", 14,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}