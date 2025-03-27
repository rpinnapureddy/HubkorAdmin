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
	public static partial class Settings_client_connector
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["client_connector"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".ShortName"] = "client_connector";
			tdataArray["client_connector"][".OwnerID"] = "client";
			tdataArray["client_connector"][".OriginalTable"] = "dbo.client_connector";
			tdataArray["client_connector"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["client_connector"][".originalPagesByType"] = tdataArray["client_connector"][".pagesByType"];
			tdataArray["client_connector"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["client_connector"][".originalPages"] = tdataArray["client_connector"][".pages"];
			tdataArray["client_connector"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["client_connector"][".originalDefaultPages"] = tdataArray["client_connector"][".defaultPages"];
			fieldLabelsArray["client_connector"] = SettingsMap.GetArray();
			fieldToolTipsArray["client_connector"] = SettingsMap.GetArray();
			pageTitlesArray["client_connector"] = SettingsMap.GetArray();
			placeHoldersArray["client_connector"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["client_connector"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["client_connector"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["client_connector"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["client_connector"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["client_connector"]["English"]["client"] = "Client";
				fieldToolTipsArray["client_connector"]["English"]["client"] = "";
				placeHoldersArray["client_connector"]["English"]["client"] = "";
				fieldLabelsArray["client_connector"]["English"]["connector"] = "Connector";
				fieldToolTipsArray["client_connector"]["English"]["connector"] = "";
				placeHoldersArray["client_connector"]["English"]["connector"] = "";
				fieldLabelsArray["client_connector"]["English"]["active"] = "Active";
				fieldToolTipsArray["client_connector"]["English"]["active"] = "";
				placeHoldersArray["client_connector"]["English"]["active"] = "";
				fieldLabelsArray["client_connector"]["English"]["app"] = "App";
				fieldToolTipsArray["client_connector"]["English"]["app"] = "";
				placeHoldersArray["client_connector"]["English"]["app"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["client_connector"]["English"])))
				{
					tdataArray["client_connector"][".isUseToolTips"] = true;
				}
			}
			tdataArray["client_connector"][".NCSearch"] = true;
			tdataArray["client_connector"][".shortTableName"] = "client_connector";
			tdataArray["client_connector"][".nSecOptions"] = 1;
			tdataArray["client_connector"][".mainTableOwnerID"] = "client";
			tdataArray["client_connector"][".entityType"] = 0;
			tdataArray["client_connector"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["client_connector"][".strOriginalTableName"] = "dbo.client_connector";
			tdataArray["client_connector"][".showAddInPopup"] = false;
			tdataArray["client_connector"][".showEditInPopup"] = false;
			tdataArray["client_connector"][".showViewInPopup"] = false;
			tdataArray["client_connector"][".listAjax"] = false;
			tdataArray["client_connector"][".audit"] = true;
			tdataArray["client_connector"][".locking"] = false;
			GlobalVars.pages = tdataArray["client_connector"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["client_connector"][".edit"] = true;
				tdataArray["client_connector"][".afterEditAction"] = 1;
				tdataArray["client_connector"][".closePopupAfterEdit"] = 1;
				tdataArray["client_connector"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["client_connector"][".add"] = true;
				tdataArray["client_connector"][".afterAddAction"] = 1;
				tdataArray["client_connector"][".closePopupAfterAdd"] = 1;
				tdataArray["client_connector"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["client_connector"][".list"] = true;
			}
			tdataArray["client_connector"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["client_connector"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["client_connector"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["client_connector"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["client_connector"][".printFriendly"] = true;
			}
			tdataArray["client_connector"][".showSimpleSearchOptions"] = true;
			tdataArray["client_connector"][".allowShowHideFields"] = true;
			tdataArray["client_connector"][".allowFieldsReordering"] = true;
			tdataArray["client_connector"][".isUseAjaxSuggest"] = true;


			tdataArray["client_connector"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["client_connector"][".buttonsAdded"] = false;
			tdataArray["client_connector"][".addPageEvents"] = false;
			tdataArray["client_connector"][".isUseTimeForSearch"] = false;
			tdataArray["client_connector"][".badgeColor"] = "6DA5C8";
			tdataArray["client_connector"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".googleLikeFields"].Add("client");
			tdataArray["client_connector"][".googleLikeFields"].Add("connector");
			tdataArray["client_connector"][".googleLikeFields"].Add("app");
			tdataArray["client_connector"][".googleLikeFields"].Add("active");
			tdataArray["client_connector"][".tableType"] = "list";
			tdataArray["client_connector"][".printerPageOrientation"] = 0;
			tdataArray["client_connector"][".nPrinterPageScale"] = 100;
			tdataArray["client_connector"][".nPrinterSplitRecords"] = 40;
			tdataArray["client_connector"][".geocodingEnabled"] = false;
			tdataArray["client_connector"][".pageSize"] = 20;
			tdataArray["client_connector"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["client_connector"][".strOrderBy"] = tstrOrderBy;
			tdataArray["client_connector"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["client_connector"][".sqlHead"] = "SELECT client,  	connector,  	app,  	active";
			tdataArray["client_connector"][".sqlFrom"] = "FROM dbo.client_connector";
			tdataArray["client_connector"][".sqlWhereExpr"] = "";
			tdataArray["client_connector"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["client_connector"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["client_connector"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["client_connector"][".highlightSearchResults"] = true;
			tableKeysArray["client_connector"] = SettingsMap.GetArray();
			tableKeysArray["client_connector"].Add("client");
			tableKeysArray["client_connector"].Add("connector");
			tdataArray["client_connector"][".Keys"] = tableKeysArray["client_connector"];
			tdataArray["client_connector"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "client";
			fdata["GoodName"] = "client";
			fdata["ownerTable"] = "dbo.client_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_connector","client");
			fdata["FieldType"] = 202;
			fdata["strField"] = "client";
			fdata["sourceSingle"] = "client";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "client";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.clients";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "shortcode";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "shortcode";
			edata["LookupOrderBy"] = "";
			edata["DependentLookups"] = SettingsMap.GetArray();
			edata["DependentLookups"].Add("connector");
			edata["DependentLookups"] = SettingsMap.GetArray();
			edata["DependentLookups"].Add("app");
			edata["SelectSize"] = 1;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["client_connector"]["client"] = fdata;
			tdataArray["client_connector"][".searchableFields"].Add("client");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "connector";
			fdata["GoodName"] = "connector";
			fdata["ownerTable"] = "dbo.client_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_connector","connector");
			fdata["FieldType"] = 202;
			fdata["strField"] = "connector";
			fdata["sourceSingle"] = "connector";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "connector";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.hk_client_app_connector";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "connector";
			edata["LinkFieldType"] = 202;
			edata["DisplayField"] = "connector";
			edata["LookupOrderBy"] = "connector";
			edata["UseCategory"] = true;
			edata["categoryFields"] = SettingsMap.GetArray();
			edata["categoryFields"].Add(new XVar("main", "client", "lookup", "client"));
			edata["categoryFields"].Add(new XVar("main", "app", "lookup", "app"));
			edata["SelectSize"] = 1;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["client_connector"]["connector"] = fdata;
			tdataArray["client_connector"][".searchableFields"].Add("connector");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "app";
			fdata["GoodName"] = "app";
			fdata["ownerTable"] = "dbo.client_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_connector","app");
			fdata["FieldType"] = 202;
			fdata["strField"] = "app";
			fdata["sourceSingle"] = "app";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "app";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.client_apps";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "app";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "app";
			edata["LookupOrderBy"] = "app";
			edata["UseCategory"] = true;
			edata["categoryFields"] = SettingsMap.GetArray();
			edata["categoryFields"].Add(new XVar("main", "client", "lookup", "client"));
			edata["DependentLookups"] = SettingsMap.GetArray();
			edata["DependentLookups"].Add("connector");
			edata["SelectSize"] = 1;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["client_connector"]["app"] = fdata;
			tdataArray["client_connector"][".searchableFields"].Add("app");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "active";
			fdata["GoodName"] = "active";
			fdata["ownerTable"] = "dbo.client_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_connector","active");
			fdata["FieldType"] = 11;
			fdata["strField"] = "active";
			fdata["sourceSingle"] = "active";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "active";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Checkbox");
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Checkbox");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterFormat"] = "Options list";
			fdata["showCollapsed"] = false;
			fdata["filterCheckedMessageType"] = "Text";
			fdata["filterCheckedMessageText"] = "Checked";
			fdata["filterUncheckedMessageType"] = "Text";
			fdata["filterUncheckedMessageText"] = "Unchecked";
			tdataArray["client_connector"]["active"] = fdata;
			tdataArray["client_connector"][".searchableFields"].Add("active");
			GlobalVars.tables_data["dbo.client_connector"] = tdataArray["client_connector"];
			GlobalVars.field_labels["dbo_client_connector"] = fieldLabelsArray["client_connector"];
			GlobalVars.fieldToolTips["dbo_client_connector"] = fieldToolTipsArray["client_connector"];
			GlobalVars.placeHolders["dbo_client_connector"] = placeHoldersArray["client_connector"];
			GlobalVars.page_titles["dbo_client_connector"] = pageTitlesArray["client_connector"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.client_connector"));
			GlobalVars.detailsTablesData["dbo.client_connector"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_connector"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "client,  	connector,  	app,  	active";
protoArray["0"]["m_strFrom"] = "FROM dbo.client_connector";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "";
	
		
protoArray["0"]["cipherer"] = null;
protoArray["2"] = SettingsMap.GetArray();
protoArray["2"]["m_sql"] = "";
protoArray["2"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["2"]["m_column"] = obj;
protoArray["2"]["m_contained"] = SettingsMap.GetArray();
protoArray["2"]["m_strCase"] = "";
protoArray["2"]["m_havingmode"] = false;
protoArray["2"]["m_inBrackets"] = false;
protoArray["2"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["2"]);

protoArray["0"]["m_where"] = obj;
protoArray["4"] = SettingsMap.GetArray();
protoArray["4"]["m_sql"] = "";
protoArray["4"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["4"]["m_column"] = obj;
protoArray["4"]["m_contained"] = SettingsMap.GetArray();
protoArray["4"]["m_strCase"] = "";
protoArray["4"]["m_havingmode"] = false;
protoArray["4"]["m_inBrackets"] = false;
protoArray["4"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["4"]);

protoArray["0"]["m_having"] = obj;
protoArray["0"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["6"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "client", "m_strTable", "dbo.client_connector", "m_srcTableName", "dbo.client_connector"));

protoArray["6"]["m_sql"] = "client";
protoArray["6"]["m_srcTableName"] = "dbo.client_connector";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "connector", "m_strTable", "dbo.client_connector", "m_srcTableName", "dbo.client_connector"));

protoArray["8"]["m_sql"] = "connector";
protoArray["8"]["m_srcTableName"] = "dbo.client_connector";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "app", "m_strTable", "dbo.client_connector", "m_srcTableName", "dbo.client_connector"));

protoArray["10"]["m_sql"] = "app";
protoArray["10"]["m_srcTableName"] = "dbo.client_connector";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "active", "m_strTable", "dbo.client_connector", "m_srcTableName", "dbo.client_connector"));

protoArray["12"]["m_sql"] = "active";
protoArray["12"]["m_srcTableName"] = "dbo.client_connector";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.client_connector";
protoArray["15"]["m_srcTableName"] = "dbo.client_connector";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("client");
protoArray["15"]["m_columns"].Add("connector");
protoArray["15"]["m_columns"].Add("app");
protoArray["15"]["m_columns"].Add("active");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.client_connector";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.client_connector";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_sql"] = "";
protoArray["16"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["16"]["m_column"] = obj;
protoArray["16"]["m_contained"] = SettingsMap.GetArray();
protoArray["16"]["m_strCase"] = "";
protoArray["16"]["m_havingmode"] = false;
protoArray["16"]["m_inBrackets"] = false;
protoArray["16"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["16"]);

protoArray["14"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["14"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.client_connector";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["client_connector"] = obj;

				
		
			tdataArray["client_connector"][".sqlquery"] = queryData_Array["client_connector"];
			tdataArray["client_connector"][".hasEvents"] = false;
		}
	}

}
