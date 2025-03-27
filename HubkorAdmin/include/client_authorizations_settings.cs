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
	public static partial class Settings_client_authorizations
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["client_authorizations"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".ShortName"] = "client_authorizations";
			tdataArray["client_authorizations"][".OwnerID"] = "client";
			tdataArray["client_authorizations"][".OriginalTable"] = "dbo.client_authorizations";
			tdataArray["client_authorizations"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["client_authorizations"][".originalPagesByType"] = tdataArray["client_authorizations"][".pagesByType"];
			tdataArray["client_authorizations"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["client_authorizations"][".originalPages"] = tdataArray["client_authorizations"][".pages"];
			tdataArray["client_authorizations"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["client_authorizations"][".originalDefaultPages"] = tdataArray["client_authorizations"][".defaultPages"];
			fieldLabelsArray["client_authorizations"] = SettingsMap.GetArray();
			fieldToolTipsArray["client_authorizations"] = SettingsMap.GetArray();
			pageTitlesArray["client_authorizations"] = SettingsMap.GetArray();
			placeHoldersArray["client_authorizations"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["client_authorizations"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["client_authorizations"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["client_authorizations"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["client_authorizations"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["client_authorizations"]["English"]["client"] = "Client";
				fieldToolTipsArray["client_authorizations"]["English"]["client"] = "";
				placeHoldersArray["client_authorizations"]["English"]["client"] = "";
				fieldLabelsArray["client_authorizations"]["English"]["api_key"] = "Api Key";
				fieldToolTipsArray["client_authorizations"]["English"]["api_key"] = "";
				placeHoldersArray["client_authorizations"]["English"]["api_key"] = "";
				fieldLabelsArray["client_authorizations"]["English"]["date_created"] = "Date Created";
				fieldToolTipsArray["client_authorizations"]["English"]["date_created"] = "";
				placeHoldersArray["client_authorizations"]["English"]["date_created"] = "";
				fieldLabelsArray["client_authorizations"]["English"]["date_expired"] = "Date Expired";
				fieldToolTipsArray["client_authorizations"]["English"]["date_expired"] = "";
				placeHoldersArray["client_authorizations"]["English"]["date_expired"] = "";
				fieldLabelsArray["client_authorizations"]["English"]["role"] = "Role";
				fieldToolTipsArray["client_authorizations"]["English"]["role"] = "";
				placeHoldersArray["client_authorizations"]["English"]["role"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["client_authorizations"]["English"])))
				{
					tdataArray["client_authorizations"][".isUseToolTips"] = true;
				}
			}
			tdataArray["client_authorizations"][".NCSearch"] = true;
			tdataArray["client_authorizations"][".shortTableName"] = "client_authorizations";
			tdataArray["client_authorizations"][".nSecOptions"] = 1;
			tdataArray["client_authorizations"][".mainTableOwnerID"] = "client";
			tdataArray["client_authorizations"][".entityType"] = 0;
			tdataArray["client_authorizations"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["client_authorizations"][".strOriginalTableName"] = "dbo.client_authorizations";
			tdataArray["client_authorizations"][".showAddInPopup"] = false;
			tdataArray["client_authorizations"][".showEditInPopup"] = false;
			tdataArray["client_authorizations"][".showViewInPopup"] = false;
			tdataArray["client_authorizations"][".listAjax"] = false;
			tdataArray["client_authorizations"][".audit"] = true;
			tdataArray["client_authorizations"][".locking"] = false;
			GlobalVars.pages = tdataArray["client_authorizations"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["client_authorizations"][".edit"] = true;
				tdataArray["client_authorizations"][".afterEditAction"] = 1;
				tdataArray["client_authorizations"][".closePopupAfterEdit"] = 1;
				tdataArray["client_authorizations"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["client_authorizations"][".add"] = true;
				tdataArray["client_authorizations"][".afterAddAction"] = 1;
				tdataArray["client_authorizations"][".closePopupAfterAdd"] = 1;
				tdataArray["client_authorizations"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["client_authorizations"][".list"] = true;
			}
			tdataArray["client_authorizations"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["client_authorizations"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["client_authorizations"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["client_authorizations"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["client_authorizations"][".printFriendly"] = true;
			}
			tdataArray["client_authorizations"][".showSimpleSearchOptions"] = true;
			tdataArray["client_authorizations"][".allowShowHideFields"] = true;
			tdataArray["client_authorizations"][".allowFieldsReordering"] = true;
			tdataArray["client_authorizations"][".isUseAjaxSuggest"] = true;


			tdataArray["client_authorizations"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["client_authorizations"][".buttonsAdded"] = false;
			tdataArray["client_authorizations"][".addPageEvents"] = false;
			tdataArray["client_authorizations"][".isUseTimeForSearch"] = false;
			tdataArray["client_authorizations"][".badgeColor"] = "6493ea";
			tdataArray["client_authorizations"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".googleLikeFields"].Add("client");
			tdataArray["client_authorizations"][".googleLikeFields"].Add("api_key");
			tdataArray["client_authorizations"][".googleLikeFields"].Add("date_created");
			tdataArray["client_authorizations"][".googleLikeFields"].Add("date_expired");
			tdataArray["client_authorizations"][".googleLikeFields"].Add("role");
			tdataArray["client_authorizations"][".tableType"] = "list";
			tdataArray["client_authorizations"][".printerPageOrientation"] = 0;
			tdataArray["client_authorizations"][".nPrinterPageScale"] = 100;
			tdataArray["client_authorizations"][".nPrinterSplitRecords"] = 40;
			tdataArray["client_authorizations"][".geocodingEnabled"] = false;
			tdataArray["client_authorizations"][".pageSize"] = 20;
			tdataArray["client_authorizations"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["client_authorizations"][".strOrderBy"] = tstrOrderBy;
			tdataArray["client_authorizations"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["client_authorizations"][".sqlHead"] = "SELECT client,  	api_key,  	date_created,  	date_expired,  	[role]";
			tdataArray["client_authorizations"][".sqlFrom"] = "FROM dbo.client_authorizations";
			tdataArray["client_authorizations"][".sqlWhereExpr"] = "";
			tdataArray["client_authorizations"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["client_authorizations"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["client_authorizations"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["client_authorizations"][".highlightSearchResults"] = true;
			tableKeysArray["client_authorizations"] = SettingsMap.GetArray();
			tableKeysArray["client_authorizations"].Add("client");
			tdataArray["client_authorizations"][".Keys"] = tableKeysArray["client_authorizations"];
			tdataArray["client_authorizations"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "client";
			fdata["GoodName"] = "client";
			fdata["ownerTable"] = "dbo.client_authorizations";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_authorizations","client");
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
			tdataArray["client_authorizations"]["client"] = fdata;
			tdataArray["client_authorizations"][".searchableFields"].Add("client");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "api_key";
			fdata["GoodName"] = "api_key";
			fdata["ownerTable"] = "dbo.client_authorizations";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_authorizations","api_key");
			fdata["FieldType"] = 202;
			fdata["strField"] = "api_key";
			fdata["sourceSingle"] = "api_key";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "api_key";
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
			tdataArray["client_authorizations"]["api_key"] = fdata;
			tdataArray["client_authorizations"][".searchableFields"].Add("api_key");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "date_created";
			fdata["GoodName"] = "date_created";
			fdata["ownerTable"] = "dbo.client_authorizations";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_authorizations","date_created");
			fdata["FieldType"] = 135;
			fdata["strField"] = "date_created";
			fdata["sourceSingle"] = "date_created";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "date_created";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Equals", 1, "More than", 2, "Less than", 3, "Between", 4, Constants.EMPTY_SEARCH, 5, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["client_authorizations"]["date_created"] = fdata;
			tdataArray["client_authorizations"][".searchableFields"].Add("date_created");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "date_expired";
			fdata["GoodName"] = "date_expired";
			fdata["ownerTable"] = "dbo.client_authorizations";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_authorizations","date_expired");
			fdata["FieldType"] = 135;
			fdata["strField"] = "date_expired";
			fdata["sourceSingle"] = "date_expired";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "date_expired";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Equals", 1, "More than", 2, "Less than", 3, "Between", 4, Constants.EMPTY_SEARCH, 5, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["client_authorizations"]["date_expired"] = fdata;
			tdataArray["client_authorizations"][".searchableFields"].Add("date_expired");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "role";
			fdata["GoodName"] = "role";
			fdata["ownerTable"] = "dbo.client_authorizations";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_client_authorizations","role");
			fdata["FieldType"] = 202;
			fdata["strField"] = "role";
			fdata["sourceSingle"] = "role";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[role]";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=30");
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
			tdataArray["client_authorizations"]["role"] = fdata;
			tdataArray["client_authorizations"][".searchableFields"].Add("role");
			GlobalVars.tables_data["dbo.client_authorizations"] = tdataArray["client_authorizations"];
			GlobalVars.field_labels["dbo_client_authorizations"] = fieldLabelsArray["client_authorizations"];
			GlobalVars.fieldToolTips["dbo_client_authorizations"] = fieldToolTipsArray["client_authorizations"];
			GlobalVars.placeHolders["dbo_client_authorizations"] = placeHoldersArray["client_authorizations"];
			GlobalVars.page_titles["dbo_client_authorizations"] = pageTitlesArray["client_authorizations"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.client_authorizations"));
			GlobalVars.detailsTablesData["dbo.client_authorizations"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_authorizations"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.clients";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.clients";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "clients";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.client_authorizations"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.client_authorizations"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_authorizations"][0]["masterKeys"].Add("shortcode");
			GlobalVars.masterTablesData["dbo.client_authorizations"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.client_authorizations"][0]["detailKeys"].Add("client");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "client,  	api_key,  	date_created,  	date_expired,  	[role]";
protoArray["0"]["m_strFrom"] = "FROM dbo.client_authorizations";
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
obj = new SQLField(new XVar("m_strName", "client", "m_strTable", "dbo.client_authorizations", "m_srcTableName", "dbo.client_authorizations"));

protoArray["6"]["m_sql"] = "client";
protoArray["6"]["m_srcTableName"] = "dbo.client_authorizations";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "api_key", "m_strTable", "dbo.client_authorizations", "m_srcTableName", "dbo.client_authorizations"));

protoArray["8"]["m_sql"] = "api_key";
protoArray["8"]["m_srcTableName"] = "dbo.client_authorizations";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "date_created", "m_strTable", "dbo.client_authorizations", "m_srcTableName", "dbo.client_authorizations"));

protoArray["10"]["m_sql"] = "date_created";
protoArray["10"]["m_srcTableName"] = "dbo.client_authorizations";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "date_expired", "m_strTable", "dbo.client_authorizations", "m_srcTableName", "dbo.client_authorizations"));

protoArray["12"]["m_sql"] = "date_expired";
protoArray["12"]["m_srcTableName"] = "dbo.client_authorizations";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "role", "m_strTable", "dbo.client_authorizations", "m_srcTableName", "dbo.client_authorizations"));

protoArray["14"]["m_sql"] = "[role]";
protoArray["14"]["m_srcTableName"] = "dbo.client_authorizations";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.client_authorizations";
protoArray["17"]["m_srcTableName"] = "dbo.client_authorizations";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("client");
protoArray["17"]["m_columns"].Add("api_key");
protoArray["17"]["m_columns"].Add("date_created");
protoArray["17"]["m_columns"].Add("date_expired");
protoArray["17"]["m_columns"].Add("role");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.client_authorizations";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.client_authorizations";
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
protoArray["0"]["m_srcTableName"] = "dbo.client_authorizations";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["client_authorizations"] = obj;

				
		
			tdataArray["client_authorizations"][".sqlquery"] = queryData_Array["client_authorizations"];
			tdataArray["client_authorizations"][".hasEvents"] = false;
		}
	}

}
