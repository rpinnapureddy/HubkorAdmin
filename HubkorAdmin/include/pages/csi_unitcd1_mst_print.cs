
		// dbo.csi_unitcd1_mst
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
			public static partial class Options_csi_unitcd1_mst_print
			{
				static public XVar options()
				{
					return new XVar( "pdf", new XVar( "pdfView", false ),
"totals", new XVar( "clientid", new XVar( "totalsType", "" ),
"VariationNumber", new XVar( "totalsType", "" ),
"unit1", new XVar( "totalsType", "" ),
"site_ref", new XVar( "totalsType", "" ),
"CreateDate", new XVar( "totalsType", "" ),
"CreatedBy", new XVar( "totalsType", "" ),
"description", new XVar( "totalsType", "" ),
"InWorkflow", new XVar( "totalsType", "" ),
"NoteExistsFlag", new XVar( "totalsType", "" ),
"RecordDate", new XVar( "totalsType", "" ),
"RowPointer", new XVar( "totalsType", "" ),
"UpdatedBy", new XVar( "totalsType", "" ),
"DLDeleteIndicator", new XVar( "totalsType", "" ),
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
"uf_uet10", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "clientid",
1, "unit1",
2, "site_ref",
3, "description",
4, "DLDeleteIndicator",
5, "tp_posted" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "clientid", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1" ),
"unit1", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field4" ),
"site_ref", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field5" ),
"description", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field7" ),
"DLDeleteIndicator", new XVar( 0, "simple_grid_field12",
1, "simple_grid_field13" ),
"tp_posted", new XVar( 0, "simple_grid_field14",
1, "simple_grid_field15" ) ),
"hideEmptyFields", XVar.Array() ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array(),
"top", new XVar( 0, "print_header",
1, "print_subheader" ),
"grid", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field",
2, "simple_grid_field4",
3, "simple_grid_field2",
4, "simple_grid_field5",
5, "simple_grid_field3",
6, "simple_grid_field7",
7, "simple_grid_field6",
8, "simple_grid_field13",
9, "simple_grid_field12",
10, "simple_grid_field15",
11, "simple_grid_field14" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "print_pages", "above-grid",
"print_header", "top",
"print_subheader", "top",
"simple_grid_field1", "grid",
"simple_grid_field", "grid",
"simple_grid_field4", "grid",
"simple_grid_field2", "grid",
"simple_grid_field5", "grid",
"simple_grid_field3", "grid",
"simple_grid_field7", "grid",
"simple_grid_field6", "grid",
"simple_grid_field13", "grid",
"simple_grid_field12", "grid",
"simple_grid_field15", "grid",
"simple_grid_field14", "grid" ),
"itemLocations", new XVar( "simple_grid_field1", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field15", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "cell_field5" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "print_header", new XVar( 0, "print_header" ),
"print_subheader", new XVar( 0, "print_subheader" ),
"print_pages", new XVar( 0, "print_pages" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field2",
2, "simple_grid_field3",
3, "simple_grid_field6",
4, "simple_grid_field12",
5, "simple_grid_field14" ),
"grid_field_label", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field4",
2, "simple_grid_field5",
3, "simple_grid_field7",
4, "simple_grid_field13",
5, "simple_grid_field15" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "clientid_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "unit1_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "site_ref_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "description_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "DLDeleteIndicator_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "tp_posted_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field15" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "clientid_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "unit1_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "site_ref_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "description_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "DLDeleteIndicator_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "tp_posted_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 6,
"height", 3 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "verticalBar", false,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar( "print_pages", new XVar( "tag", "PRINT_PAGES",
"type", 2 ) ),
"register_activate_message", new XVar(  ),
"details_found", new XVar(  ) ),
"gridType", 0,
"recsPerRow", 1,
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", XVar.Array(),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "print",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"dataGrid", new XVar( "groupFields", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "print",
"type", "print",
"layoutId", "basic",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "print-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "print_pages" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "print-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "print-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", new XVar( 0, "print_header",
1, "print_subheader" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_field" ),
1, new XVar( "cell", "headcell_field1" ),
2, new XVar( "cell", "headcell_field2" ),
3, new XVar( "cell", "headcell_field3" ),
4, new XVar( "cell", "headcell_field4" ),
5, new XVar( "cell", "headcell_field5" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_field" ),
1, new XVar( "cell", "cell_field1" ),
2, new XVar( "cell", "cell_field2" ),
3, new XVar( "cell", "cell_field3" ),
4, new XVar( "cell", "cell_field4" ),
5, new XVar( "cell", "cell_field5" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_field" ),
1, new XVar( "cell", "footcell_field1" ),
2, new XVar( "cell", "footcell_field2" ),
3, new XVar( "cell", "footcell_field3" ),
4, new XVar( "cell", "footcell_field4" ),
5, new XVar( "cell", "footcell_field5" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "clientid",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "clientid",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "unit1",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "unit1",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "site_ref",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "site_ref",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "description",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "description",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "DLDeleteIndicator",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "DLDeleteIndicator",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field15" ),
"field", "tp_posted",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"field", "tp_posted",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "print_header", new XVar( "type", "print_header" ),
"print_subheader", new XVar( "type", "print_subheader" ),
"print_pages", new XVar( "type", "print_pages" ),
"simple_grid_field", new XVar( "field", "clientid",
"type", "grid_field" ),
"simple_grid_field1", new XVar( "type", "grid_field_label",
"field", "clientid" ),
"simple_grid_field2", new XVar( "field", "unit1",
"type", "grid_field" ),
"simple_grid_field4", new XVar( "type", "grid_field_label",
"field", "unit1" ),
"simple_grid_field3", new XVar( "field", "site_ref",
"type", "grid_field" ),
"simple_grid_field5", new XVar( "type", "grid_field_label",
"field", "site_ref" ),
"simple_grid_field6", new XVar( "field", "description",
"type", "grid_field" ),
"simple_grid_field7", new XVar( "type", "grid_field_label",
"field", "description" ),
"simple_grid_field12", new XVar( "field", "DLDeleteIndicator",
"type", "grid_field" ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "DLDeleteIndicator" ),
"simple_grid_field14", new XVar( "field", "tp_posted",
"type", "grid_field" ),
"simple_grid_field15", new XVar( "type", "grid_field_label",
"field", "tp_posted" ) ),
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