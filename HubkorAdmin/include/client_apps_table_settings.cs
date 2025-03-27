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
	public static partial class Settings_client_apps_table
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["client_apps_table"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".ShortName"] = "client_apps_table";
			tdataArray["client_apps_table"][".OwnerID"] = "client";
			tdataArray["client_apps_table"][".OriginalTable"] = "dbo.client_apps_table";
			tdataArray["client_apps_table"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["client_apps_table"][".originalPagesByType"] = tdataArray["client_apps_table"][".pagesByType"];
			tdataArray["client_apps_table"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["client_apps_table"][".originalPages"] = tdataArray["client_apps_table"][".pages"];
			tdataArray["client_apps_table"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["client_apps_table"][".originalDefaultPages"] = tdataArray["client_apps_table"][".defaultPages"];
			fieldLabelsArray["client_apps_table"] = SettingsMap.GetArray();
			fieldToolTipsArray["client_apps_table"] = SettingsMap.GetArray();
			pageTitlesArray["client_apps_table"] = SettingsMap.GetArray();
			placeHoldersArray["client_apps_table"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["client_apps_table"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["client_apps_table"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["client_apps_table"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["client_apps_table"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["client_apps_table"]["English"]["client"] = "Client";
				fieldToolTipsArray["client_apps_table"]["English"]["client"] = "";
				placeHoldersArray["client_apps_table"]["English"]["client"] = "";
				fieldLabelsArray["client_apps_table"]["English"]["app"] = "App";
				fieldToolTipsArray["client_apps_table"]["English"]["app"] = "";
				placeHoldersArray["client_apps_table"]["English"]["app"] = "";
				fieldLabelsArray["client_apps_table"]["English"]["table_name"] = "Table Name";
				fieldToolTipsArray["client_apps_table"]["English"]["table_name"] = "";
				placeHoldersArray["client_apps_table"]["English"]["table_name"] = "";
				fieldLabelsArray["client_apps_table"]["English"]["active"] = "Active";
				fieldToolTipsArray["client_apps_table"]["English"]["active"] = "";
				placeHoldersArray["client_apps_table"]["English"]["active"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["client_apps_table"]["English"])))
				{
					tdataArray["client_apps_table"][".isUseToolTips"] = true;
				}
			}
			tdataArray["client_apps_table"][".NCSearch"] = true;
			tdataArray["client_apps_table"][".shortTableName"] = "client_apps_table";
			tdataArray["client_apps_table"][".nSecOptions"] = 1;
			tdataArray["client_apps_table"][".mainTableOwnerID"] = "client";
			tdataArray["client_apps_table"][".entityType"] = 0;
			tdataArray["client_apps_table"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["client_apps_table"][".strOriginalTableName"] = "dbo.client_apps_table";
			tdataArray["client_apps_table"][".showAddInPopup"] = false;
			tdataArray["client_apps_table"][".showEditInPopup"] = false;
			tdataArray["client_apps_table"][".showViewInPopup"] = false;
			tdataArray["client_apps_table"][".listAjax"] = false;
			tdataArray["client_apps_table"][".audit"] = true;
			tdataArray["client_apps_table"][".locking"] = false;
			GlobalVars.pages = tdataArray["client_apps_table"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["client_apps_table"][".edit"] = true;
				tdataArray["client_apps_table"][".afterEditAction"] = 1;
				tdataArray["client_apps_table"][".closePopupAfterEdit"] = 1;
				tdataArray["client_apps_table"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["client_apps_table"][".add"] = true;
				tdataArray["client_apps_table"][".afterAddAction"] = 1;
				tdataArray["client_apps_table"][".closePopupAfterAdd"] = 1;
				tdataArray["client_apps_table"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["client_apps_table"][".list"] = true;
			}
			tdataArray["client_apps_table"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["client_apps_table"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["client_apps_table"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["client_apps_table"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["client_apps_table"][".printFriendly"] = true;
			}
			tdataArray["client_apps_table"][".showSimpleSearchOptions"] = true;
			tdataArray["client_apps_table"][".allowShowHideFields"] = true;
			tdataArray["client_apps_table"][".allowFieldsReordering"] = true;
			tdataArray["client_apps_table"][".isUseAjaxSuggest"] = true;


			tdataArray["client_apps_table"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["client_apps_table"][".buttonsAdded"] = false;
			tdataArray["client_apps_table"][".addPageEvents"] = false;
			tdataArray["client_apps_table"][".isUseTimeForSearch"] = false;
			tdataArray["client_apps_table"][".badgeColor"] = "bc8f8f";
			tdataArray["client_apps_table"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".googleLikeFields"].Add("client");
			tdataArray["client_apps_table"][".googleLikeFields"].Add("app");
			tdataArray["client_apps_table"][".googleLikeFields"].Add("table_name");
			tdataArray["client_apps_table"][".googleLikeFields"].Add("active");
			tdataArray["client_apps_table"][".tableType"] = "list";
			tdataArray["client_apps_table"][".printerPageOrientation"] = 0;
			tdataArray["client_apps_table"][".nPrinterPageScale"] = 100;
			tdataArray["client_apps_table"][".nPrinterSplitRecords"] = 40;
			tdataArray["client_apps_table"][".geocodingEnabled"] = false;
			tdataArray["client_apps_table"][".pageSize"] = 20;
			tdataArray["client_apps_table"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["client_apps_table"][".strOrderBy"] = tstrOrderBy;
			tdataArray["client_apps_table"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["client_apps_table"][".sqlHead"] = "SELECT client,  	app,  	table_name,  	active";
			tdataArray["client_apps_table"][".sqlFrom"] = "FROM dbo.client_apps_table";
			tdataArray["client_apps_table"][".sqlWhereExpr"] = "";
			tdataArray["client_apps_table"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["client_apps_table"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["client_apps_table"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["client_apps_table"][".highlightSearchResults"] = true;
			tableKeysArray["client_apps_table"] = SettingsMap.GetArray();
			tableKeysArray["client_apps_table"].Add("client");
			tableKeysArray["client_apps_table"].Add("app");
			tableKeysArray["client_apps_table"].Add("table_name");
			tdataArray["client_apps_table"][".Keys"] = tableKeysArray["client_apps_table"];
			tdataArray["client_apps_table"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "client";
			fdata["GoodName"] = "client";
			fdata["ownerTable"] = "dbo.client_apps_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_apps_table","client");
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
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
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
			tdataArray["client_apps_table"]["client"] = fdata;
			tdataArray["client_apps_table"][".searchableFields"].Add("client");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "app";
			fdata["GoodName"] = "app";
			fdata["ownerTable"] = "dbo.client_apps_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_apps_table","app");
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
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
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
			tdataArray["client_apps_table"]["app"] = fdata;
			tdataArray["client_apps_table"][".searchableFields"].Add("app");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "table_name";
			fdata["GoodName"] = "table_name";
			fdata["ownerTable"] = "dbo.client_apps_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_apps_table","table_name");
			fdata["FieldType"] = 202;
			fdata["strField"] = "table_name";
			fdata["sourceSingle"] = "table_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "table_name";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["client_apps_table"]["table_name"] = fdata;
			tdataArray["client_apps_table"][".searchableFields"].Add("table_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "active";
			fdata["GoodName"] = "active";
			fdata["ownerTable"] = "dbo.client_apps_table";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_apps_table","active");
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
			tdataArray["client_apps_table"]["active"] = fdata;
			tdataArray["client_apps_table"][".searchableFields"].Add("active");
			GlobalVars.tables_data["dbo.client_apps_table"] = tdataArray["client_apps_table"];
			GlobalVars.field_labels["dbo_client_apps_table"] = fieldLabelsArray["client_apps_table"];
			GlobalVars.fieldToolTips["dbo_client_apps_table"] = fieldToolTipsArray["client_apps_table"];
			GlobalVars.placeHolders["dbo_client_apps_table"] = placeHoldersArray["client_apps_table"];
			GlobalVars.page_titles["dbo_client_apps_table"] = pageTitlesArray["client_apps_table"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.client_apps_table"));
			GlobalVars.detailsTablesData["dbo.client_apps_table"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_apps_table"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.client_apps";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.client_apps";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "client_apps";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.client_apps_table"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.client_apps_table"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_apps_table"][0]["masterKeys"].Add("client");
			GlobalVars.masterTablesData["dbo.client_apps_table"][0]["masterKeys"].Add("app");
			GlobalVars.masterTablesData["dbo.client_apps_table"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_apps_table"][0]["detailKeys"].Add("client");
			GlobalVars.masterTablesData["dbo.client_apps_table"][0]["detailKeys"].Add("app");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "client,  	app,  	table_name,  	active";
protoArray["0"]["m_strFrom"] = "FROM dbo.client_apps_table";
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
obj = new SQLField(new XVar("m_strName", "client", "m_strTable", "dbo.client_apps_table", "m_srcTableName", "dbo.client_apps_table"));

protoArray["6"]["m_sql"] = "client";
protoArray["6"]["m_srcTableName"] = "dbo.client_apps_table";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "app", "m_strTable", "dbo.client_apps_table", "m_srcTableName", "dbo.client_apps_table"));

protoArray["8"]["m_sql"] = "app";
protoArray["8"]["m_srcTableName"] = "dbo.client_apps_table";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "table_name", "m_strTable", "dbo.client_apps_table", "m_srcTableName", "dbo.client_apps_table"));

protoArray["10"]["m_sql"] = "table_name";
protoArray["10"]["m_srcTableName"] = "dbo.client_apps_table";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "active", "m_strTable", "dbo.client_apps_table", "m_srcTableName", "dbo.client_apps_table"));

protoArray["12"]["m_sql"] = "active";
protoArray["12"]["m_srcTableName"] = "dbo.client_apps_table";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.client_apps_table";
protoArray["15"]["m_srcTableName"] = "dbo.client_apps_table";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("client");
protoArray["15"]["m_columns"].Add("app");
protoArray["15"]["m_columns"].Add("table_name");
protoArray["15"]["m_columns"].Add("active");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.client_apps_table";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.client_apps_table";
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
protoArray["0"]["m_srcTableName"] = "dbo.client_apps_table";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["client_apps_table"] = obj;

				
		
			tdataArray["client_apps_table"][".sqlquery"] = queryData_Array["client_apps_table"];
			tdataArray["client_apps_table"][".hasEvents"] = false;
		}
	}

}
