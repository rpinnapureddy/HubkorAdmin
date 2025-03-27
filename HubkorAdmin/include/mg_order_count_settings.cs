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
	public static partial class Settings_mg_order_count
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["mg_order_count"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".ShortName"] = "mg_order_count";
			tdataArray["mg_order_count"][".OwnerID"] = "";
			tdataArray["mg_order_count"][".OriginalTable"] = "dbo.mg_order_count";
			tdataArray["mg_order_count"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["mg_order_count"][".originalPagesByType"] = tdataArray["mg_order_count"][".pagesByType"];
			tdataArray["mg_order_count"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["mg_order_count"][".originalPages"] = tdataArray["mg_order_count"][".pages"];
			tdataArray["mg_order_count"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["mg_order_count"][".originalDefaultPages"] = tdataArray["mg_order_count"][".defaultPages"];
			fieldLabelsArray["mg_order_count"] = SettingsMap.GetArray();
			fieldToolTipsArray["mg_order_count"] = SettingsMap.GetArray();
			pageTitlesArray["mg_order_count"] = SettingsMap.GetArray();
			placeHoldersArray["mg_order_count"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["mg_order_count"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["mg_order_count"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["mg_order_count"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["mg_order_count"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["mg_order_count"]["English"]["yy"] = "Yy";
				fieldToolTipsArray["mg_order_count"]["English"]["yy"] = "";
				placeHoldersArray["mg_order_count"]["English"]["yy"] = "";
				fieldLabelsArray["mg_order_count"]["English"]["mm"] = "Mm";
				fieldToolTipsArray["mg_order_count"]["English"]["mm"] = "";
				placeHoldersArray["mg_order_count"]["English"]["mm"] = "";
				fieldLabelsArray["mg_order_count"]["English"]["tot"] = "Tot";
				fieldToolTipsArray["mg_order_count"]["English"]["tot"] = "";
				placeHoldersArray["mg_order_count"]["English"]["tot"] = "";
				fieldLabelsArray["mg_order_count"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["mg_order_count"]["English"]["clientid"] = "";
				placeHoldersArray["mg_order_count"]["English"]["clientid"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["mg_order_count"]["English"])))
				{
					tdataArray["mg_order_count"][".isUseToolTips"] = true;
				}
			}
			tdataArray["mg_order_count"][".NCSearch"] = true;
			tdataArray["mg_order_count"][".shortTableName"] = "mg_order_count";
			tdataArray["mg_order_count"][".nSecOptions"] = 0;
			tdataArray["mg_order_count"][".mainTableOwnerID"] = "";
			tdataArray["mg_order_count"][".entityType"] = 0;
			tdataArray["mg_order_count"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["mg_order_count"][".strOriginalTableName"] = "dbo.mg_order_count";
			tdataArray["mg_order_count"][".showAddInPopup"] = false;
			tdataArray["mg_order_count"][".showEditInPopup"] = false;
			tdataArray["mg_order_count"][".showViewInPopup"] = false;
			tdataArray["mg_order_count"][".listAjax"] = false;
			tdataArray["mg_order_count"][".audit"] = false;
			tdataArray["mg_order_count"][".locking"] = false;
			GlobalVars.pages = tdataArray["mg_order_count"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["mg_order_count"][".edit"] = true;
				tdataArray["mg_order_count"][".afterEditAction"] = 1;
				tdataArray["mg_order_count"][".closePopupAfterEdit"] = 1;
				tdataArray["mg_order_count"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["mg_order_count"][".add"] = true;
				tdataArray["mg_order_count"][".afterAddAction"] = 1;
				tdataArray["mg_order_count"][".closePopupAfterAdd"] = 1;
				tdataArray["mg_order_count"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["mg_order_count"][".list"] = true;
			}
			tdataArray["mg_order_count"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["mg_order_count"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["mg_order_count"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["mg_order_count"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["mg_order_count"][".printFriendly"] = true;
			}
			tdataArray["mg_order_count"][".showSimpleSearchOptions"] = true;
			tdataArray["mg_order_count"][".allowShowHideFields"] = true;
			tdataArray["mg_order_count"][".allowFieldsReordering"] = true;
			tdataArray["mg_order_count"][".isUseAjaxSuggest"] = true;


			tdataArray["mg_order_count"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["mg_order_count"][".buttonsAdded"] = false;
			tdataArray["mg_order_count"][".addPageEvents"] = false;
			tdataArray["mg_order_count"][".isUseTimeForSearch"] = false;
			tdataArray["mg_order_count"][".badgeColor"] = "8FBC8B";
			tdataArray["mg_order_count"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".googleLikeFields"].Add("yy");
			tdataArray["mg_order_count"][".googleLikeFields"].Add("mm");
			tdataArray["mg_order_count"][".googleLikeFields"].Add("tot");
			tdataArray["mg_order_count"][".googleLikeFields"].Add("clientid");
			tdataArray["mg_order_count"][".tableType"] = "list";
			tdataArray["mg_order_count"][".printerPageOrientation"] = 0;
			tdataArray["mg_order_count"][".nPrinterPageScale"] = 100;
			tdataArray["mg_order_count"][".nPrinterSplitRecords"] = 40;
			tdataArray["mg_order_count"][".geocodingEnabled"] = false;
			tdataArray["mg_order_count"][".pageSize"] = 20;
			tdataArray["mg_order_count"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["mg_order_count"][".strOrderBy"] = tstrOrderBy;
			tdataArray["mg_order_count"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".sqlHead"] = "SELECT yy,  	mm,  	tot,  	clientid";
			tdataArray["mg_order_count"][".sqlFrom"] = "FROM dbo.mg_order_count";
			tdataArray["mg_order_count"][".sqlWhereExpr"] = "";
			tdataArray["mg_order_count"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["mg_order_count"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["mg_order_count"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["mg_order_count"][".highlightSearchResults"] = true;
			tableKeysArray["mg_order_count"] = SettingsMap.GetArray();
			tdataArray["mg_order_count"][".Keys"] = tableKeysArray["mg_order_count"];
			tdataArray["mg_order_count"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "yy";
			fdata["GoodName"] = "yy";
			fdata["ownerTable"] = "dbo.mg_order_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_order_count","yy");
			fdata["FieldType"] = 3;
			fdata["strField"] = "yy";
			fdata["sourceSingle"] = "yy";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "yy";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["mg_order_count"]["yy"] = fdata;
			tdataArray["mg_order_count"][".searchableFields"].Add("yy");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "mm";
			fdata["GoodName"] = "mm";
			fdata["ownerTable"] = "dbo.mg_order_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_order_count","mm");
			fdata["FieldType"] = 3;
			fdata["strField"] = "mm";
			fdata["sourceSingle"] = "mm";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "mm";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["mg_order_count"]["mm"] = fdata;
			tdataArray["mg_order_count"][".searchableFields"].Add("mm");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "tot";
			fdata["GoodName"] = "tot";
			fdata["ownerTable"] = "dbo.mg_order_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_order_count","tot");
			fdata["FieldType"] = 14;
			fdata["strField"] = "tot";
			fdata["sourceSingle"] = "tot";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "tot";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Number");
			vdata["DecimalDigits"] = 6;
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["mg_order_count"]["tot"] = fdata;
			tdataArray["mg_order_count"][".searchableFields"].Add("tot");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.mg_order_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_order_count","clientid");
			fdata["FieldType"] = 202;
			fdata["strField"] = "clientid";
			fdata["sourceSingle"] = "clientid";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "clientid";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=20");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["mg_order_count"]["clientid"] = fdata;
			tdataArray["mg_order_count"][".searchableFields"].Add("clientid");
			GlobalVars.tables_data["dbo.mg_order_count"] = tdataArray["mg_order_count"];
			GlobalVars.field_labels["dbo_mg_order_count"] = fieldLabelsArray["mg_order_count"];
			GlobalVars.fieldToolTips["dbo_mg_order_count"] = fieldToolTipsArray["mg_order_count"];
			GlobalVars.placeHolders["dbo_mg_order_count"] = placeHoldersArray["mg_order_count"];
			GlobalVars.page_titles["dbo_mg_order_count"] = pageTitlesArray["mg_order_count"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.mg_order_count"));
			GlobalVars.detailsTablesData["dbo.mg_order_count"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.mg_order_count"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "yy,  	mm,  	tot,  	clientid";
protoArray["0"]["m_strFrom"] = "FROM dbo.mg_order_count";
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
obj = new SQLField(new XVar("m_strName", "yy", "m_strTable", "dbo.mg_order_count", "m_srcTableName", "dbo.mg_order_count"));

protoArray["6"]["m_sql"] = "yy";
protoArray["6"]["m_srcTableName"] = "dbo.mg_order_count";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "mm", "m_strTable", "dbo.mg_order_count", "m_srcTableName", "dbo.mg_order_count"));

protoArray["8"]["m_sql"] = "mm";
protoArray["8"]["m_srcTableName"] = "dbo.mg_order_count";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "tot", "m_strTable", "dbo.mg_order_count", "m_srcTableName", "dbo.mg_order_count"));

protoArray["10"]["m_sql"] = "tot";
protoArray["10"]["m_srcTableName"] = "dbo.mg_order_count";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.mg_order_count", "m_srcTableName", "dbo.mg_order_count"));

protoArray["12"]["m_sql"] = "clientid";
protoArray["12"]["m_srcTableName"] = "dbo.mg_order_count";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.mg_order_count";
protoArray["15"]["m_srcTableName"] = "dbo.mg_order_count";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("yy");
protoArray["15"]["m_columns"].Add("mm");
protoArray["15"]["m_columns"].Add("tot");
protoArray["15"]["m_columns"].Add("clientid");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.mg_order_count";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.mg_order_count";
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
protoArray["0"]["m_srcTableName"] = "dbo.mg_order_count";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["mg_order_count"] = obj;

				
		
			tdataArray["mg_order_count"][".sqlquery"] = queryData_Array["mg_order_count"];
			tdataArray["mg_order_count"][".hasEvents"] = false;
		}
	}

}
