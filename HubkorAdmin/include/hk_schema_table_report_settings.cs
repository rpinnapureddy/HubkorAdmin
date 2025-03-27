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
	public static partial class Settings_hk_schema_table_report
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".ShortName"] = "hk_schema_table_report";
			tdataArray["hk_schema_table_report"][".OwnerID"] = "";
			tdataArray["hk_schema_table_report"][".OriginalTable"] = "dbo.hk_schema_table";
			tdataArray["hk_schema_table_report"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}"));
			tdataArray["hk_schema_table_report"][".originalPagesByType"] = tdataArray["hk_schema_table_report"][".pagesByType"];
			tdataArray["hk_schema_table_report"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}")));
			tdataArray["hk_schema_table_report"][".originalPages"] = tdataArray["hk_schema_table_report"][".pages"];
			tdataArray["hk_schema_table_report"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"report\":\"report\",\"rprint\":\"rprint\",\"search\":\"search\"}"));
			tdataArray["hk_schema_table_report"][".originalDefaultPages"] = tdataArray["hk_schema_table_report"][".defaultPages"];
			fieldLabelsArray["hk_schema_table_report"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_schema_table_report"] = SettingsMap.GetArray();
			pageTitlesArray["hk_schema_table_report"] = SettingsMap.GetArray();
			placeHoldersArray["hk_schema_table_report"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_schema_table_report"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_schema_table_report"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_schema_table_report"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_schema_table_report"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_schema_table_report"]["English"]["app"] = "App";
				fieldToolTipsArray["hk_schema_table_report"]["English"]["app"] = "";
				placeHoldersArray["hk_schema_table_report"]["English"]["app"] = "";
				fieldLabelsArray["hk_schema_table_report"]["English"]["name"] = "Name";
				fieldToolTipsArray["hk_schema_table_report"]["English"]["name"] = "";
				placeHoldersArray["hk_schema_table_report"]["English"]["name"] = "";
				fieldLabelsArray["hk_schema_table_report"]["English"]["TABLE_NAME"] = "TABLE NAME";
				fieldToolTipsArray["hk_schema_table_report"]["English"]["TABLE_NAME"] = "";
				placeHoldersArray["hk_schema_table_report"]["English"]["TABLE_NAME"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_schema_table_report"]["English"])))
				{
					tdataArray["hk_schema_table_report"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_schema_table_report"][".NCSearch"] = true;
			tdataArray["hk_schema_table_report"][".shortTableName"] = "hk_schema_table_report";
			tdataArray["hk_schema_table_report"][".nSecOptions"] = 0;
			tdataArray["hk_schema_table_report"][".mainTableOwnerID"] = "";
			tdataArray["hk_schema_table_report"][".entityType"] = 2;
			tdataArray["hk_schema_table_report"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_schema_table_report"][".strOriginalTableName"] = "dbo.hk_schema_table";
			tdataArray["hk_schema_table_report"][".showAddInPopup"] = false;
			tdataArray["hk_schema_table_report"][".showEditInPopup"] = false;
			tdataArray["hk_schema_table_report"][".showViewInPopup"] = false;
			tdataArray["hk_schema_table_report"][".listAjax"] = false;
			tdataArray["hk_schema_table_report"][".audit"] = false;
			tdataArray["hk_schema_table_report"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_schema_table_report"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_schema_table_report"][".edit"] = true;
				tdataArray["hk_schema_table_report"][".afterEditAction"] = 1;
				tdataArray["hk_schema_table_report"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_schema_table_report"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_schema_table_report"][".add"] = true;
				tdataArray["hk_schema_table_report"][".afterAddAction"] = 1;
				tdataArray["hk_schema_table_report"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_schema_table_report"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_schema_table_report"][".list"] = true;
			}
			tdataArray["hk_schema_table_report"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_schema_table_report"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_schema_table_report"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_schema_table_report"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_schema_table_report"][".printFriendly"] = true;
			}
			tdataArray["hk_schema_table_report"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_schema_table_report"][".allowShowHideFields"] = true;
			tdataArray["hk_schema_table_report"][".allowFieldsReordering"] = true;
			tdataArray["hk_schema_table_report"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_schema_table_report"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_schema_table_report"][".buttonsAdded"] = false;
			tdataArray["hk_schema_table_report"][".addPageEvents"] = false;
			tdataArray["hk_schema_table_report"][".isUseTimeForSearch"] = false;
			tdataArray["hk_schema_table_report"][".badgeColor"] = "3CB371";
			tdataArray["hk_schema_table_report"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".googleLikeFields"].Add("app");
			tdataArray["hk_schema_table_report"][".googleLikeFields"].Add("name");
			tdataArray["hk_schema_table_report"][".googleLikeFields"].Add("TABLE_NAME");
			tdataArray["hk_schema_table_report"][".tableType"] = "report";
			tdataArray["hk_schema_table_report"][".printerPageOrientation"] = 0;
			tdataArray["hk_schema_table_report"][".nPrinterPageScale"] = 100;
			tdataArray["hk_schema_table_report"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_schema_table_report"][".geocodingEnabled"] = false;
			tdataArray["hk_schema_table_report"][".reportPrintGroupsPerPage"] = 3;
			tdataArray["hk_schema_table_report"][".reportPrintRecordsPerPage"] = 40;
			tdataArray["hk_schema_table_report"][".pageSizeGroups"] = 5;
			tdataArray["hk_schema_table_report"][".pageSizeRecords"] = 20;
			tstrOrderBy = "";
			tdataArray["hk_schema_table_report"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_schema_table_report"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".sqlHead"] = "SELECT app,  	name,  	TABLE_NAME";
			tdataArray["hk_schema_table_report"][".sqlFrom"] = "FROM dbo.hk_schema_table";
			tdataArray["hk_schema_table_report"][".sqlWhereExpr"] = "";
			tdataArray["hk_schema_table_report"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_schema_table_report"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_schema_table_report"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_schema_table_report"][".highlightSearchResults"] = true;
			tableKeysArray["hk_schema_table_report"] = SettingsMap.GetArray();
			tdataArray["hk_schema_table_report"][".Keys"] = tableKeysArray["hk_schema_table_report"];
			tdataArray["hk_schema_table_report"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "app";
			fdata["GoodName"] = "app";
			fdata["ownerTable"] = "dbo.hk_schema_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_schema_table_Report","app");
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
			fdata["ViewFormats"]["report"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=128");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["search"] = edata;
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
			tdataArray["hk_schema_table_report"]["app"] = fdata;
			tdataArray["hk_schema_table_report"][".searchableFields"].Add("app");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "name";
			fdata["GoodName"] = "name";
			fdata["ownerTable"] = "dbo.hk_schema_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_schema_table_Report","name");
			fdata["FieldType"] = 202;
			fdata["strField"] = "name";
			fdata["sourceSingle"] = "name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "name";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["report"] = vdata;
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
			fdata["EditFormats"]["search"] = edata;
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
			tdataArray["hk_schema_table_report"]["name"] = fdata;
			tdataArray["hk_schema_table_report"][".searchableFields"].Add("name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "TABLE_NAME";
			fdata["GoodName"] = "TABLE_NAME";
			fdata["ownerTable"] = "dbo.hk_schema_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_schema_table_Report","TABLE_NAME");
			fdata["FieldType"] = 202;
			fdata["strField"] = "TABLE_NAME";
			fdata["sourceSingle"] = "TABLE_NAME";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "TABLE_NAME";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["report"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=128");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["search"] = edata;
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
			tdataArray["hk_schema_table_report"]["TABLE_NAME"] = fdata;
			tdataArray["hk_schema_table_report"][".searchableFields"].Add("TABLE_NAME");
			GlobalVars.tables_data["dbo.hk_schema_table Report"] = tdataArray["hk_schema_table_report"];
			GlobalVars.field_labels["dbo_hk_schema_table_Report"] = fieldLabelsArray["hk_schema_table_report"];
			GlobalVars.fieldToolTips["dbo_hk_schema_table_Report"] = fieldToolTipsArray["hk_schema_table_report"];
			GlobalVars.placeHolders["dbo_hk_schema_table_Report"] = placeHoldersArray["hk_schema_table_report"];
			GlobalVars.page_titles["dbo_hk_schema_table_Report"] = pageTitlesArray["hk_schema_table_report"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_schema_table Report"));
			GlobalVars.detailsTablesData["dbo.hk_schema_table Report"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_schema_table Report"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "app,  	name,  	TABLE_NAME";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_schema_table";
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
obj = new SQLField(new XVar("m_strName", "app", "m_strTable", "dbo.hk_schema_table", "m_srcTableName", "dbo.hk_schema_table Report"));

protoArray["6"]["m_sql"] = "app";
protoArray["6"]["m_srcTableName"] = "dbo.hk_schema_table Report";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "name", "m_strTable", "dbo.hk_schema_table", "m_srcTableName", "dbo.hk_schema_table Report"));

protoArray["8"]["m_sql"] = "name";
protoArray["8"]["m_srcTableName"] = "dbo.hk_schema_table Report";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "TABLE_NAME", "m_strTable", "dbo.hk_schema_table", "m_srcTableName", "dbo.hk_schema_table Report"));

protoArray["10"]["m_sql"] = "TABLE_NAME";
protoArray["10"]["m_srcTableName"] = "dbo.hk_schema_table Report";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.hk_schema_table";
protoArray["13"]["m_srcTableName"] = "dbo.hk_schema_table Report";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("app");
protoArray["13"]["m_columns"].Add("name");
protoArray["13"]["m_columns"].Add("TABLE_NAME");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.hk_schema_table";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.hk_schema_table Report";
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_sql"] = "";
protoArray["14"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["14"]["m_column"] = obj;
protoArray["14"]["m_contained"] = SettingsMap.GetArray();
protoArray["14"]["m_strCase"] = "";
protoArray["14"]["m_havingmode"] = false;
protoArray["14"]["m_inBrackets"] = false;
protoArray["14"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["14"]);

protoArray["12"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["12"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.hk_schema_table Report";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_schema_table_report"] = obj;

				
		
			tdataArray["hk_schema_table_report"][".sqlquery"] = queryData_Array["hk_schema_table_report"];
			tdataArray["hk_schema_table_report"][".hasEvents"] = false;
		}
	}

}
