
		// dbo.tp_invoice_temp
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
			public static partial class Options_tp_invoice_temp_list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", false,
"detailsAdd", false,
"inlineEdit", false,
"spreadsheetMode", false,
"reorderRows", false,
"addToBottom", false,
"delete", false,
"updateSelected", false,
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
"totals", new XVar( "invoice_id", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "invoice_id" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "invoice_id" ),
"filterFields", XVar.Array(),
"inlineAddFields", XVar.Array(),
"inlineEditFields", XVar.Array(),
"fieldItems", new XVar( "invoice_id", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1" ) ),
"hideEmptyFields", XVar.Array(),
"fieldFilterFields", XVar.Array() ),
"pageLinks", new XVar( "edit", false,
"add", true,
"view", false,
"print", true ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "add",
1, "details_found",
2, "page_size",
3, "print_panel" ),
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
"grid", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field",
2, "grid_checkbox_head",
3, "grid_checkbox",
4, "custom_button" ),
"top", XVar.Array() ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "add_link",
1, "details_found",
2, "recsPerPage",
3, "print_friendly" ),
"below-grid", new XVar( 0, "pagination" ),
"top", XVar.Array() ),
"itemForms", new XVar( "add", "above-grid",
"details_found", "above-grid",
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
"simple_grid_field1", "grid",
"simple_grid_field", "grid",
"grid_checkbox_head", "grid",
"grid_checkbox", "grid",
"custom_button", "grid" ),
"itemLocations", new XVar( "simple_grid_field1", new XVar( "location", "grid",
"cellId", "headcell_checkbox1" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "headcell_checkbox6" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_checkbox8" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "headcell_checkbox13" ),
"custom_button", new XVar( "location", "grid",
"cellId", "headcell_checkbox15" ) ),
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
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"search_panel_field", new XVar( 0, "search_panel_field" ),
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
"-", new XVar( 0, "-",
1, "-1",
2, "-2" ),
"import", new XVar( 0, "import" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"grid_field", new XVar( 0, "simple_grid_field" ),
"add", new XVar( 0, "add" ),
"grid_field_label", new XVar( 0, "simple_grid_field1" ),
"custom_button", new XVar( 0, "custom_button" ),
"expand_button", new XVar( 0, "expand_button" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_checkbox8", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox_head" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "invoice_id_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox13", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox15", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", true,
"fixedAtClient", true ),
"headcell_checkbox6", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "invoice_id_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox14", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox16", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox7", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 3,
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
"customButtons", new XVar( 0, "post1" ),
"hasNotifications", false,
"menus", new XVar( 0, new XVar( "id", "main",
"horizontal", false ) ),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "list",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", new XVar( 0, "post1" ) ),
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
"items", new XVar( 0, "add" ) ),
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
1, "search_panel" ) ) ),
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
"cells", new XVar( 0, new XVar( "cell", "headcell_checkbox8" ),
1, new XVar( "cell", "headcell_checkbox" ),
2, new XVar( "cell", "headcell_checkbox1" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "headcell_checkbox13" ),
1, new XVar( "cell", "headcell_checkbox15" ),
2, new XVar( "cell", "headcell_checkbox6" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "headcell_checkbox14" ),
1, new XVar( "cell", "headcell_checkbox16" ),
2, new XVar( "cell", "headcell_checkbox7" ) ) ) ),
"cells", new XVar( "headcell_checkbox", new XVar( "model", "headcell_checkbox",
"items", XVar.Array() ),
"headcell_checkbox1", new XVar( "model", "headcell_checkbox",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "invoice_id",
"columnName", "field" ),
"headcell_checkbox6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "invoice_id",
"columnName", "field" ),
"headcell_checkbox7", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_checkbox8", new XVar( "model", "headcell_checkbox",
"items", new XVar( 0, "grid_checkbox_head" ) ),
"headcell_checkbox13", new XVar( "model", "cell_field",
"items", new XVar( 0, "grid_checkbox" ) ),
"headcell_checkbox14", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_checkbox15", new XVar( "model", "cell_field",
"items", new XVar( 0, "custom_button" ) ),
"headcell_checkbox16", new XVar( "model", "footcell_field",
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
"items", new XVar( 0, "search_panel_field" ) ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "advsearch_link",
1, "show_search_panel",
2, "hide_search_panel",
3, "-2",
4, "export",
5, "-1",
6, "import" ) ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"search_panel_field", new XVar( "field", "invoice_id",
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
"export", new XVar( "type", "export" ),
"-", new XVar( "type", "-" ),
"import", new XVar( "type", "import" ),
"-1", new XVar( "type", "-" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-2", new XVar( "type", "-" ),
"simple_grid_field", new XVar( "field", "invoice_id",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"add", new XVar( "type", "add" ),
"simple_grid_field1", new XVar( "type", "grid_field_label",
"field", "invoice_id" ),
"custom_button", new XVar( "eventId", "post1",
"label", new XVar( "text", "Post",
"type", 0 ),
"type", "custom_button",
"buttonStyle", "primary" ),
"expand_button", new XVar( "type", "expand_button" ) ),
"dbProps", new XVar(  ),
"spreadsheetGrid", false,
"version", 14,
"reorderRows", false,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}