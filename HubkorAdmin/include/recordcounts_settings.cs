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
	public static partial class Settings_recordcounts
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["recordcounts"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".ShortName"] = "recordcounts";
			tdataArray["recordcounts"][".OwnerID"] = "clientid";
			tdataArray["recordcounts"][".OriginalTable"] = "dbo.recordcounts";
			tdataArray["recordcounts"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["recordcounts"][".originalPagesByType"] = tdataArray["recordcounts"][".pagesByType"];
			tdataArray["recordcounts"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["recordcounts"][".originalPages"] = tdataArray["recordcounts"][".pages"];
			tdataArray["recordcounts"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["recordcounts"][".originalDefaultPages"] = tdataArray["recordcounts"][".defaultPages"];
			fieldLabelsArray["recordcounts"] = SettingsMap.GetArray();
			fieldToolTipsArray["recordcounts"] = SettingsMap.GetArray();
			pageTitlesArray["recordcounts"] = SettingsMap.GetArray();
			placeHoldersArray["recordcounts"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["recordcounts"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["recordcounts"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["recordcounts"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["recordcounts"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["recordcounts"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["recordcounts"]["English"]["clientid"] = "";
				placeHoldersArray["recordcounts"]["English"]["clientid"] = "";
				fieldLabelsArray["recordcounts"]["English"]["table_name"] = "Table Name";
				fieldToolTipsArray["recordcounts"]["English"]["table_name"] = "";
				placeHoldersArray["recordcounts"]["English"]["table_name"] = "";
				fieldLabelsArray["recordcounts"]["English"]["count"] = "Count";
				fieldToolTipsArray["recordcounts"]["English"]["count"] = "";
				placeHoldersArray["recordcounts"]["English"]["count"] = "";
				fieldLabelsArray["recordcounts"]["English"]["site_ref"] = "Site Ref";
				fieldToolTipsArray["recordcounts"]["English"]["site_ref"] = "";
				placeHoldersArray["recordcounts"]["English"]["site_ref"] = "";
				fieldLabelsArray["recordcounts"]["English"]["siteCnt"] = "Site Cnt";
				fieldToolTipsArray["recordcounts"]["English"]["siteCnt"] = "";
				placeHoldersArray["recordcounts"]["English"]["siteCnt"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["recordcounts"]["English"])))
				{
					tdataArray["recordcounts"][".isUseToolTips"] = true;
				}
			}
			tdataArray["recordcounts"][".NCSearch"] = true;
			tdataArray["recordcounts"][".shortTableName"] = "recordcounts";
			tdataArray["recordcounts"][".nSecOptions"] = 1;
			tdataArray["recordcounts"][".mainTableOwnerID"] = "clientid";
			tdataArray["recordcounts"][".entityType"] = 0;
			tdataArray["recordcounts"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["recordcounts"][".strOriginalTableName"] = "dbo.recordcounts";
			tdataArray["recordcounts"][".showAddInPopup"] = false;
			tdataArray["recordcounts"][".showEditInPopup"] = false;
			tdataArray["recordcounts"][".showViewInPopup"] = false;
			tdataArray["recordcounts"][".listAjax"] = false;
			tdataArray["recordcounts"][".audit"] = true;
			tdataArray["recordcounts"][".locking"] = false;
			GlobalVars.pages = tdataArray["recordcounts"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["recordcounts"][".edit"] = true;
				tdataArray["recordcounts"][".afterEditAction"] = 1;
				tdataArray["recordcounts"][".closePopupAfterEdit"] = 1;
				tdataArray["recordcounts"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["recordcounts"][".add"] = true;
				tdataArray["recordcounts"][".afterAddAction"] = 1;
				tdataArray["recordcounts"][".closePopupAfterAdd"] = 1;
				tdataArray["recordcounts"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["recordcounts"][".list"] = true;
			}
			tdataArray["recordcounts"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["recordcounts"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["recordcounts"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["recordcounts"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["recordcounts"][".printFriendly"] = true;
			}
			tdataArray["recordcounts"][".showSimpleSearchOptions"] = true;
			tdataArray["recordcounts"][".allowShowHideFields"] = true;
			tdataArray["recordcounts"][".allowFieldsReordering"] = true;
			tdataArray["recordcounts"][".isUseAjaxSuggest"] = true;


			tdataArray["recordcounts"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["recordcounts"][".buttonsAdded"] = false;
			tdataArray["recordcounts"][".addPageEvents"] = false;
			tdataArray["recordcounts"][".isUseTimeForSearch"] = false;
			tdataArray["recordcounts"][".badgeColor"] = "cfae83";
			tdataArray["recordcounts"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".googleLikeFields"].Add("clientid");
			tdataArray["recordcounts"][".googleLikeFields"].Add("table_name");
			tdataArray["recordcounts"][".googleLikeFields"].Add("count");
			tdataArray["recordcounts"][".googleLikeFields"].Add("site_ref");
			tdataArray["recordcounts"][".googleLikeFields"].Add("siteCnt");
			tdataArray["recordcounts"][".tableType"] = "list";
			tdataArray["recordcounts"][".printerPageOrientation"] = 0;
			tdataArray["recordcounts"][".nPrinterPageScale"] = 100;
			tdataArray["recordcounts"][".nPrinterSplitRecords"] = 40;
			tdataArray["recordcounts"][".geocodingEnabled"] = false;
			tdataArray["recordcounts"][".pageSize"] = 20;
			tdataArray["recordcounts"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["recordcounts"][".strOrderBy"] = tstrOrderBy;
			tdataArray["recordcounts"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["recordcounts"][".sqlHead"] = "SELECT clientid,  	table_name,  	[count],  	site_ref,  	siteCnt";
			tdataArray["recordcounts"][".sqlFrom"] = "FROM dbo.recordcounts";
			tdataArray["recordcounts"][".sqlWhereExpr"] = "";
			tdataArray["recordcounts"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["recordcounts"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["recordcounts"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["recordcounts"][".highlightSearchResults"] = true;
			tableKeysArray["recordcounts"] = SettingsMap.GetArray();
			tableKeysArray["recordcounts"].Add("clientid");
			tableKeysArray["recordcounts"].Add("table_name");
			tdataArray["recordcounts"][".Keys"] = tableKeysArray["recordcounts"];
			tdataArray["recordcounts"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.recordcounts";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_recordcounts","clientid");
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
			tdataArray["recordcounts"]["clientid"] = fdata;
			tdataArray["recordcounts"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "table_name";
			fdata["GoodName"] = "table_name";
			fdata["ownerTable"] = "dbo.recordcounts";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_recordcounts","table_name");
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
			tdataArray["recordcounts"]["table_name"] = fdata;
			tdataArray["recordcounts"][".searchableFields"].Add("table_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "count";
			fdata["GoodName"] = "count";
			fdata["ownerTable"] = "dbo.recordcounts";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_recordcounts","count");
			fdata["FieldType"] = 3;
			fdata["strField"] = "count";
			fdata["sourceSingle"] = "count";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[count]";
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
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			edata["validateAs"]["basicValidate"].Add("IsRequired");
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
			tdataArray["recordcounts"]["count"] = fdata;
			tdataArray["recordcounts"][".searchableFields"].Add("count");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "site_ref";
			fdata["GoodName"] = "site_ref";
			fdata["ownerTable"] = "dbo.recordcounts";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_recordcounts","site_ref");
			fdata["FieldType"] = 202;
			fdata["strField"] = "site_ref";
			fdata["sourceSingle"] = "site_ref";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "site_ref";
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
			tdataArray["recordcounts"]["site_ref"] = fdata;
			tdataArray["recordcounts"][".searchableFields"].Add("site_ref");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "siteCnt";
			fdata["GoodName"] = "siteCnt";
			fdata["ownerTable"] = "dbo.recordcounts";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_recordcounts","siteCnt");
			fdata["FieldType"] = 3;
			fdata["strField"] = "siteCnt";
			fdata["sourceSingle"] = "siteCnt";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "siteCnt";
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
			tdataArray["recordcounts"]["siteCnt"] = fdata;
			tdataArray["recordcounts"][".searchableFields"].Add("siteCnt");
			GlobalVars.tables_data["dbo.recordcounts"] = tdataArray["recordcounts"];
			GlobalVars.field_labels["dbo_recordcounts"] = fieldLabelsArray["recordcounts"];
			GlobalVars.fieldToolTips["dbo_recordcounts"] = fieldToolTipsArray["recordcounts"];
			GlobalVars.placeHolders["dbo_recordcounts"] = placeHoldersArray["recordcounts"];
			GlobalVars.page_titles["dbo_recordcounts"] = pageTitlesArray["recordcounts"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.recordcounts"));
			GlobalVars.detailsTablesData["dbo.recordcounts"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.incoming";
			detailsParam["dOriginalTable"] = "dbo.incoming";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "incoming";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_incoming"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex]["masterKeys"].Add("clientid");
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex]["masterKeys"].Add("table_name");
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex]["detailKeys"].Add("client");
			GlobalVars.detailsTablesData["dbo.recordcounts"][dIndex]["detailKeys"].Add("recordname");
			GlobalVars.masterTablesData["dbo.recordcounts"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.clients";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.clients";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "clients";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.recordcounts"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.recordcounts"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.recordcounts"][0]["masterKeys"].Add("shortcode");
			GlobalVars.masterTablesData["dbo.recordcounts"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.recordcounts"][0]["detailKeys"].Add("clientid");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "clientid,  	table_name,  	[count],  	site_ref,  	siteCnt";
protoArray["0"]["m_strFrom"] = "FROM dbo.recordcounts";
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
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.recordcounts", "m_srcTableName", "dbo.recordcounts"));

protoArray["6"]["m_sql"] = "clientid";
protoArray["6"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "table_name", "m_strTable", "dbo.recordcounts", "m_srcTableName", "dbo.recordcounts"));

protoArray["8"]["m_sql"] = "table_name";
protoArray["8"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "count", "m_strTable", "dbo.recordcounts", "m_srcTableName", "dbo.recordcounts"));

protoArray["10"]["m_sql"] = "[count]";
protoArray["10"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "site_ref", "m_strTable", "dbo.recordcounts", "m_srcTableName", "dbo.recordcounts"));

protoArray["12"]["m_sql"] = "site_ref";
protoArray["12"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "siteCnt", "m_strTable", "dbo.recordcounts", "m_srcTableName", "dbo.recordcounts"));

protoArray["14"]["m_sql"] = "siteCnt";
protoArray["14"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.recordcounts";
protoArray["17"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("clientid");
protoArray["17"]["m_columns"].Add("table_name");
protoArray["17"]["m_columns"].Add("count");
protoArray["17"]["m_columns"].Add("site_ref");
protoArray["17"]["m_columns"].Add("siteCnt");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.recordcounts";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.recordcounts";
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_sql"] = "";
protoArray["18"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["18"]["m_column"] = obj;
protoArray["18"]["m_contained"] = SettingsMap.GetArray();
protoArray["18"]["m_strCase"] = "";
protoArray["18"]["m_havingmode"] = false;
protoArray["18"]["m_inBrackets"] = false;
protoArray["18"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["18"]);

protoArray["16"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["16"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.recordcounts";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["recordcounts"] = obj;

				
		
			tdataArray["recordcounts"][".sqlquery"] = queryData_Array["recordcounts"];
			tdataArray["recordcounts"][".hasEvents"] = false;
		}
	}

}
