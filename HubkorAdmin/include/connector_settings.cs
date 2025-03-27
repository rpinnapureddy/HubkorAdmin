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
	public static partial class Settings_connector
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["connector"] = SettingsMap.GetArray();
			tdataArray["connector"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["connector"][".ShortName"] = "connector";
			tdataArray["connector"][".OwnerID"] = "";
			tdataArray["connector"][".OriginalTable"] = "dbo.connector";
			tdataArray["connector"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["connector"][".originalPagesByType"] = tdataArray["connector"][".pagesByType"];
			tdataArray["connector"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["connector"][".originalPages"] = tdataArray["connector"][".pages"];
			tdataArray["connector"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["connector"][".originalDefaultPages"] = tdataArray["connector"][".defaultPages"];
			fieldLabelsArray["connector"] = SettingsMap.GetArray();
			fieldToolTipsArray["connector"] = SettingsMap.GetArray();
			pageTitlesArray["connector"] = SettingsMap.GetArray();
			placeHoldersArray["connector"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["connector"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["connector"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["connector"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["connector"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["connector"]["English"]["connector"] = "Connector";
				fieldToolTipsArray["connector"]["English"]["connector"] = "";
				placeHoldersArray["connector"]["English"]["connector"] = "";
				fieldLabelsArray["connector"]["English"]["app"] = "App";
				fieldToolTipsArray["connector"]["English"]["app"] = "";
				placeHoldersArray["connector"]["English"]["app"] = "";
				fieldLabelsArray["connector"]["English"]["description"] = "Description";
				fieldToolTipsArray["connector"]["English"]["description"] = "";
				placeHoldersArray["connector"]["English"]["description"] = "";
				fieldLabelsArray["connector"]["English"]["active"] = "Active";
				fieldToolTipsArray["connector"]["English"]["active"] = "";
				placeHoldersArray["connector"]["English"]["active"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["connector"]["English"])))
				{
					tdataArray["connector"][".isUseToolTips"] = true;
				}
			}
			tdataArray["connector"][".NCSearch"] = true;
			tdataArray["connector"][".shortTableName"] = "connector";
			tdataArray["connector"][".nSecOptions"] = 0;
			tdataArray["connector"][".mainTableOwnerID"] = "";
			tdataArray["connector"][".entityType"] = 0;
			tdataArray["connector"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["connector"][".strOriginalTableName"] = "dbo.connector";
			tdataArray["connector"][".showAddInPopup"] = false;
			tdataArray["connector"][".showEditInPopup"] = false;
			tdataArray["connector"][".showViewInPopup"] = false;
			tdataArray["connector"][".listAjax"] = false;
			tdataArray["connector"][".audit"] = true;
			tdataArray["connector"][".locking"] = false;
			GlobalVars.pages = tdataArray["connector"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["connector"][".edit"] = true;
				tdataArray["connector"][".afterEditAction"] = 1;
				tdataArray["connector"][".closePopupAfterEdit"] = 1;
				tdataArray["connector"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["connector"][".add"] = true;
				tdataArray["connector"][".afterAddAction"] = 1;
				tdataArray["connector"][".closePopupAfterAdd"] = 1;
				tdataArray["connector"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["connector"][".list"] = true;
			}
			tdataArray["connector"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["connector"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["connector"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["connector"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["connector"][".printFriendly"] = true;
			}
			tdataArray["connector"][".showSimpleSearchOptions"] = true;
			tdataArray["connector"][".allowShowHideFields"] = true;
			tdataArray["connector"][".allowFieldsReordering"] = true;
			tdataArray["connector"][".isUseAjaxSuggest"] = true;


			tdataArray["connector"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["connector"][".buttonsAdded"] = false;
			tdataArray["connector"][".addPageEvents"] = false;
			tdataArray["connector"][".isUseTimeForSearch"] = false;
			tdataArray["connector"][".badgeColor"] = "CD853F";
			tdataArray["connector"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["connector"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["connector"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["connector"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["connector"][".googleLikeFields"].Add("connector");
			tdataArray["connector"][".googleLikeFields"].Add("app");
			tdataArray["connector"][".googleLikeFields"].Add("description");
			tdataArray["connector"][".googleLikeFields"].Add("active");
			tdataArray["connector"][".tableType"] = "list";
			tdataArray["connector"][".printerPageOrientation"] = 0;
			tdataArray["connector"][".nPrinterPageScale"] = 100;
			tdataArray["connector"][".nPrinterSplitRecords"] = 40;
			tdataArray["connector"][".geocodingEnabled"] = false;
			tdataArray["connector"][".pageSize"] = 20;
			tdataArray["connector"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["connector"][".strOrderBy"] = tstrOrderBy;
			tdataArray["connector"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["connector"][".sqlHead"] = "SELECT connector,  	app,  	description,  	active";
			tdataArray["connector"][".sqlFrom"] = "FROM dbo.connector";
			tdataArray["connector"][".sqlWhereExpr"] = "";
			tdataArray["connector"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["connector"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["connector"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["connector"][".highlightSearchResults"] = true;
			tableKeysArray["connector"] = SettingsMap.GetArray();
			tableKeysArray["connector"].Add("connector");
			tdataArray["connector"][".Keys"] = tableKeysArray["connector"];
			tdataArray["connector"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "connector";
			fdata["GoodName"] = "connector";
			fdata["ownerTable"] = "dbo.connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_connector","connector");
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
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=50");
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
			tdataArray["connector"]["connector"] = fdata;
			tdataArray["connector"][".searchableFields"].Add("connector");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "app";
			fdata["GoodName"] = "app";
			fdata["ownerTable"] = "dbo.connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_connector","app");
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
			edata["LookupTable"] = "dbo.apps";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "code";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "code";
			edata["LookupOrderBy"] = "";
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
			tdataArray["connector"]["app"] = fdata;
			tdataArray["connector"][".searchableFields"].Add("app");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "description";
			fdata["GoodName"] = "description";
			fdata["ownerTable"] = "dbo.connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_connector","description");
			fdata["FieldType"] = 202;
			fdata["strField"] = "description";
			fdata["sourceSingle"] = "description";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "description";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=200");
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
			tdataArray["connector"]["description"] = fdata;
			tdataArray["connector"][".searchableFields"].Add("description");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "active";
			fdata["GoodName"] = "active";
			fdata["ownerTable"] = "dbo.connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_connector","active");
			fdata["FieldType"] = 16;
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
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["connector"]["active"] = fdata;
			tdataArray["connector"][".searchableFields"].Add("active");
			GlobalVars.tables_data["dbo.connector"] = tdataArray["connector"];
			GlobalVars.field_labels["dbo_connector"] = fieldLabelsArray["connector"];
			GlobalVars.fieldToolTips["dbo_connector"] = fieldToolTipsArray["connector"];
			GlobalVars.placeHolders["dbo_connector"] = placeHoldersArray["connector"];
			GlobalVars.page_titles["dbo_connector"] = pageTitlesArray["connector"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.connector"));
			GlobalVars.detailsTablesData["dbo.connector"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.connector"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "connector,  	app,  	description,  	active";
protoArray["0"]["m_strFrom"] = "FROM dbo.connector";
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
obj = new SQLField(new XVar("m_strName", "connector", "m_strTable", "dbo.connector", "m_srcTableName", "dbo.connector"));

protoArray["6"]["m_sql"] = "connector";
protoArray["6"]["m_srcTableName"] = "dbo.connector";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "app", "m_strTable", "dbo.connector", "m_srcTableName", "dbo.connector"));

protoArray["8"]["m_sql"] = "app";
protoArray["8"]["m_srcTableName"] = "dbo.connector";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "description", "m_strTable", "dbo.connector", "m_srcTableName", "dbo.connector"));

protoArray["10"]["m_sql"] = "description";
protoArray["10"]["m_srcTableName"] = "dbo.connector";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "active", "m_strTable", "dbo.connector", "m_srcTableName", "dbo.connector"));

protoArray["12"]["m_sql"] = "active";
protoArray["12"]["m_srcTableName"] = "dbo.connector";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.connector";
protoArray["15"]["m_srcTableName"] = "dbo.connector";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("connector");
protoArray["15"]["m_columns"].Add("app");
protoArray["15"]["m_columns"].Add("description");
protoArray["15"]["m_columns"].Add("active");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.connector";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.connector";
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
protoArray["0"]["m_srcTableName"] = "dbo.connector";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["connector"] = obj;

				
		
			tdataArray["connector"][".sqlquery"] = queryData_Array["connector"];
			tdataArray["connector"][".hasEvents"] = false;
		}
	}

}
