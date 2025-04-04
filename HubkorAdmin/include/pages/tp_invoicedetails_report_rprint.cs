
		// dbo.tp_invoicedetails Report
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
			public static partial class Options_tp_invoicedetails_report_rprint
			{
				static public XVar options()
				{
					return new XVar( "pdf", new XVar( "pdfView", true,
"orientation", "portrait",
"scale", 100 ),
"fields", new XVar( "gridFields", new XVar( 0, "invoiceid",
1, "po",
2, "vendinv",
3, "total",
4, "vendnum" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "invoiceid", new XVar( 0, "report_grid_field1" ),
"po", new XVar( 0, "report_grid_field2" ),
"vendinv", new XVar( 0, "report_grid_field3" ),
"total", new XVar( 0, "report_grid_field4" ),
"invoicestatus", new XVar( 0, "report_group_field" ),
"vendnum", new XVar( 0, "report_grid_field" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array(),
"top", new XVar( 0, "print_header",
1, "print_subheader",
2, "print_pdf" ),
"grid", new XVar( 0, "report_group_field",
1, "report_grid_field1",
2, "report_grid_field2",
3, "report_grid_field3",
4, "report_grid_field4",
5, "report_grid_field" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "print_pages", "above-grid",
"print_header", "top",
"print_subheader", "top",
"print_pdf", "top",
"report_group_field", "grid",
"report_grid_field1", "grid",
"report_grid_field2", "grid",
"report_grid_field3", "grid",
"report_grid_field4", "grid",
"report_grid_field", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "print_header", new XVar( 0, "print_header" ),
"print_subheader", new XVar( 0, "print_subheader" ),
"print_pages", new XVar( 0, "print_pages" ),
"report_grid_field", new XVar( 0, "report_grid_field1",
1, "report_grid_field2",
2, "report_grid_field3",
3, "report_grid_field4",
4, "report_grid_field" ),
"report_group_field", new XVar( 0, "report_group_field" ),
"print_pdf", new XVar( 0, "print_pdf" ) ),
"cellMaps", new XVar(  ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "verticalBar", false,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar( "print_pages", new XVar( "tag", "PRINT_PAGES",
"type", 2 ) ),
"register_activate_message", new XVar(  ),
"details_found", new XVar(  ) ),
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", XVar.Array(),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "rprint",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"newreport", new XVar( "reportInfo", new XVar( "groupFields", new XVar( 0, new XVar( "interval", 0,
"summary", false,
"axis", 0,
"color", new XVar( "header", "7ACA7A",
"summary", "90EE90" ),
"field", "invoicestatus" ) ),
"fields", new XVar( 0, new XVar( "field", "invoiceid",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ),
1, new XVar( "field", "po",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ),
2, new XVar( "field", "vendinv",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ),
3, new XVar( "field", "total",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", true ),
4, new XVar( "field", "vendnum",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ) ),
"showData", true,
"pageSummary", false,
"globalSummary", false,
"crosstab", false,
"colors", XVar.Array(),
"horizSummary", false,
"layout", "stepped",
"vertSummary", false ) ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "rprint",
"type", "rprint",
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
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", new XVar( 0, "print_header",
1, "print_subheader" ) ),
"c1", new XVar( "model", "c1",
"items", new XVar( 0, "print_pdf" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "report-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "report_group_field" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "report_grid_field1",
1, "report_grid_field2",
2, "report_grid_field3",
3, "report_grid_field4",
4, "report_grid_field" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1,
"reportInfo", new XVar( "groupFields", new XVar( 0, new XVar( "interval", 0,
"summary", false,
"axis", 0,
"color", new XVar( "header", "7ACA7A",
"summary", "90EE90" ),
"field", "invoicestatus" ) ),
"fields", new XVar( 0, new XVar( "field", "invoiceid",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ),
1, new XVar( "field", "po",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ),
2, new XVar( "field", "vendinv",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ),
3, new XVar( "field", "total",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", true ),
4, new XVar( "field", "vendnum",
"grid", true,
"avg", false,
"max", false,
"min", false,
"sum", false ) ),
"showData", true,
"pageSummary", false,
"globalSummary", false,
"crosstab", false,
"colors", XVar.Array(),
"horizSummary", false,
"layout", "stepped",
"vertSummary", false ) ) ),
"items", new XVar( "print_header", new XVar( "type", "print_header" ),
"print_subheader", new XVar( "type", "print_subheader" ),
"print_pages", new XVar( "type", "print_pages" ),
"report_grid_field1", new XVar( "field", "invoiceid",
"type", "report_grid_field",
"reportAvg", false,
"reportMin", false,
"reportMax", false,
"reportSum", false ),
"report_grid_field2", new XVar( "field", "po",
"type", "report_grid_field",
"reportAvg", false,
"reportMin", false,
"reportMax", false,
"reportSum", false ),
"report_grid_field3", new XVar( "field", "vendinv",
"type", "report_grid_field",
"reportAvg", false,
"reportMin", false,
"reportMax", false,
"reportSum", false ),
"report_grid_field4", new XVar( "field", "total",
"type", "report_grid_field",
"reportAvg", false,
"reportMin", false,
"reportMax", false,
"reportSum", true ),
"report_group_field", new XVar( "field", "invoicestatus",
"type", "report_group_field",
"summary", false,
"axis", 0,
"interval", 0 ),
"print_pdf", new XVar( "type", "print_pdf",
"targetPages", XVar.Array(),
"splitModes", XVar.Array(),
"scopes", XVar.Array() ),
"report_grid_field", new XVar( "field", "vendnum",
"type", "report_grid_field",
"reportAvg", false,
"reportMin", false,
"reportMax", false,
"reportSum", false ) ),
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