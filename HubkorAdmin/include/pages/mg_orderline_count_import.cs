
		// dbo.mg_orderline_count
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
			public static partial class Options_mg_orderline_count_import
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "clientid",
1, "co_num",
2, "yy",
3, "mm",
4, "extprice" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "clientid", new XVar( 0, "import_field" ),
"co_num", new XVar( 0, "import_field2" ),
"yy", new XVar( 0, "import_field3" ),
"mm", new XVar( 0, "import_field4" ),
"extprice", new XVar( 0, "import_field5" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", XVar.Array(),
"top", new XVar( 0, "import_header" ),
"grid", new XVar( 0, "import_field",
1, "import_field2",
2, "import_field3",
3, "import_field4",
4, "import_field5" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "import_header", "top",
"import_field", "grid",
"import_field2", "grid",
"import_field3", "grid",
"import_field4", "grid",
"import_field5", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "import_header", new XVar( 0, "import_header" ),
"import_field", new XVar( 0, "import_field",
1, "import_field2",
2, "import_field3",
3, "import_field4",
4, "import_field5" ) ),
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
1, "import_field2",
2, "import_field3",
3, "import_field4",
4, "import_field5" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "import_header", new XVar( "type", "import_header" ),
"import_field", new XVar( "field", "clientid",
"type", "import_field" ),
"import_field2", new XVar( "field", "co_num",
"type", "import_field" ),
"import_field3", new XVar( "field", "yy",
"type", "import_field" ),
"import_field4", new XVar( "field", "mm",
"type", "import_field" ),
"import_field5", new XVar( "field", "extprice",
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