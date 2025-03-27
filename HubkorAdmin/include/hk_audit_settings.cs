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
	public static partial class Settings_hk_audit
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_audit"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".ShortName"] = "hk_audit";
			tdataArray["hk_audit"][".OwnerID"] = "";
			tdataArray["hk_audit"][".OriginalTable"] = "dbo.hk_audit";
			tdataArray["hk_audit"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["hk_audit"][".originalPagesByType"] = tdataArray["hk_audit"][".pagesByType"];
			tdataArray["hk_audit"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["hk_audit"][".originalPages"] = tdataArray["hk_audit"][".pages"];
			tdataArray["hk_audit"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["hk_audit"][".originalDefaultPages"] = tdataArray["hk_audit"][".defaultPages"];
			fieldLabelsArray["hk_audit"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_audit"] = SettingsMap.GetArray();
			pageTitlesArray["hk_audit"] = SettingsMap.GetArray();
			placeHoldersArray["hk_audit"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_audit"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_audit"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_audit"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_audit"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_audit"]["English"]["id"] = "Id";
				fieldToolTipsArray["hk_audit"]["English"]["id"] = "";
				placeHoldersArray["hk_audit"]["English"]["id"] = "";
				fieldLabelsArray["hk_audit"]["English"]["datetime"] = "Datetime";
				fieldToolTipsArray["hk_audit"]["English"]["datetime"] = "";
				placeHoldersArray["hk_audit"]["English"]["datetime"] = "";
				fieldLabelsArray["hk_audit"]["English"]["ip"] = "Ip";
				fieldToolTipsArray["hk_audit"]["English"]["ip"] = "";
				placeHoldersArray["hk_audit"]["English"]["ip"] = "";
				fieldLabelsArray["hk_audit"]["English"]["user"] = "User";
				fieldToolTipsArray["hk_audit"]["English"]["user"] = "";
				placeHoldersArray["hk_audit"]["English"]["user"] = "";
				fieldLabelsArray["hk_audit"]["English"]["table"] = "Table";
				fieldToolTipsArray["hk_audit"]["English"]["table"] = "";
				placeHoldersArray["hk_audit"]["English"]["table"] = "";
				fieldLabelsArray["hk_audit"]["English"]["action"] = "Action";
				fieldToolTipsArray["hk_audit"]["English"]["action"] = "";
				placeHoldersArray["hk_audit"]["English"]["action"] = "";
				fieldLabelsArray["hk_audit"]["English"]["description"] = "Description";
				fieldToolTipsArray["hk_audit"]["English"]["description"] = "";
				placeHoldersArray["hk_audit"]["English"]["description"] = "";
				fieldLabelsArray["hk_audit"]["English"]["tz_create_date"] = "Tz Create Date";
				fieldToolTipsArray["hk_audit"]["English"]["tz_create_date"] = "";
				placeHoldersArray["hk_audit"]["English"]["tz_create_date"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_audit"]["English"])))
				{
					tdataArray["hk_audit"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_audit"][".NCSearch"] = true;
			tdataArray["hk_audit"][".shortTableName"] = "hk_audit";
			tdataArray["hk_audit"][".nSecOptions"] = 0;
			tdataArray["hk_audit"][".mainTableOwnerID"] = "";
			tdataArray["hk_audit"][".entityType"] = 0;
			tdataArray["hk_audit"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_audit"][".strOriginalTableName"] = "dbo.hk_audit";
			tdataArray["hk_audit"][".showAddInPopup"] = false;
			tdataArray["hk_audit"][".showEditInPopup"] = false;
			tdataArray["hk_audit"][".showViewInPopup"] = false;
			tdataArray["hk_audit"][".listAjax"] = false;
			tdataArray["hk_audit"][".audit"] = true;
			tdataArray["hk_audit"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_audit"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_audit"][".edit"] = true;
				tdataArray["hk_audit"][".afterEditAction"] = 1;
				tdataArray["hk_audit"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_audit"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_audit"][".add"] = true;
				tdataArray["hk_audit"][".afterAddAction"] = 1;
				tdataArray["hk_audit"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_audit"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_audit"][".list"] = true;
			}
			tdataArray["hk_audit"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_audit"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_audit"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_audit"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_audit"][".printFriendly"] = true;
			}
			tdataArray["hk_audit"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_audit"][".allowShowHideFields"] = true;
			tdataArray["hk_audit"][".allowFieldsReordering"] = true;
			tdataArray["hk_audit"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_audit"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_audit"][".buttonsAdded"] = false;
			tdataArray["hk_audit"][".addPageEvents"] = false;
			tdataArray["hk_audit"][".isUseTimeForSearch"] = false;
			tdataArray["hk_audit"][".badgeColor"] = "DC143C";
			tdataArray["hk_audit"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".googleLikeFields"].Add("id");
			tdataArray["hk_audit"][".googleLikeFields"].Add("datetime");
			tdataArray["hk_audit"][".googleLikeFields"].Add("tz_create_date");
			tdataArray["hk_audit"][".googleLikeFields"].Add("ip");
			tdataArray["hk_audit"][".googleLikeFields"].Add("user");
			tdataArray["hk_audit"][".googleLikeFields"].Add("table");
			tdataArray["hk_audit"][".googleLikeFields"].Add("action");
			tdataArray["hk_audit"][".googleLikeFields"].Add("description");
			tdataArray["hk_audit"][".tableType"] = "list";
			tdataArray["hk_audit"][".printerPageOrientation"] = 0;
			tdataArray["hk_audit"][".nPrinterPageScale"] = 100;
			tdataArray["hk_audit"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_audit"][".geocodingEnabled"] = false;
			tdataArray["hk_audit"][".pageSize"] = 20;
			tdataArray["hk_audit"][".warnLeavingPages"] = true;
			tstrOrderBy = "order by id desc";
			tdataArray["hk_audit"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_audit"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_audit"][".orderindexes"].Add(new XVar(0, 1, 1, (XVar.Pack(0) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "id"));
			tdataArray["hk_audit"][".sqlHead"] = "SELECT id,  	[datetime],  dbo.HK_TimeZone(':session.user_name',datetime) tz_create_date,  	ip,  	[user],  	[table],  	[action],  	description";
			tdataArray["hk_audit"][".sqlFrom"] = "FROM dbo.hk_audit";
			tdataArray["hk_audit"][".sqlWhereExpr"] = "";
			tdataArray["hk_audit"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_audit"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_audit"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_audit"][".highlightSearchResults"] = true;
			tableKeysArray["hk_audit"] = SettingsMap.GetArray();
			tableKeysArray["hk_audit"].Add("id");
			tdataArray["hk_audit"][".Keys"] = tableKeysArray["hk_audit"];
			tdataArray["hk_audit"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","id");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id";
			fdata["sourceSingle"] = "id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id";
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
			tdataArray["hk_audit"]["id"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "datetime";
			fdata["GoodName"] = "datetime";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","datetime");
			fdata["FieldType"] = 135;
			fdata["strField"] = "datetime";
			fdata["sourceSingle"] = "datetime";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[datetime]";
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
			tdataArray["hk_audit"]["datetime"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("datetime");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "tz_create_date";
			fdata["GoodName"] = "tz_create_date";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","tz_create_date");
			fdata["FieldType"] = 200;
			fdata["strField"] = "tz_create_date";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.HK_TimeZone(':session.user_name',datetime)";
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
			tdataArray["hk_audit"]["tz_create_date"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("tz_create_date");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "ip";
			fdata["GoodName"] = "ip";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","ip");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ip";
			fdata["sourceSingle"] = "ip";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ip";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=40");
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
			tdataArray["hk_audit"]["ip"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("ip");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "user";
			fdata["GoodName"] = "user";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","user");
			fdata["FieldType"] = 200;
			fdata["strField"] = "user";
			fdata["sourceSingle"] = "user";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[user]";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=255");
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
			tdataArray["hk_audit"]["user"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("user");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "table";
			fdata["GoodName"] = "table";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","table");
			fdata["FieldType"] = 200;
			fdata["strField"] = "table";
			fdata["sourceSingle"] = "table";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[table]";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=300");
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
			tdataArray["hk_audit"]["table"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("table");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "action";
			fdata["GoodName"] = "action";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","action");
			fdata["FieldType"] = 200;
			fdata["strField"] = "action";
			fdata["sourceSingle"] = "action";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[action]";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=250");
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
			tdataArray["hk_audit"]["action"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("action");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "description";
			fdata["GoodName"] = "description";
			fdata["ownerTable"] = "dbo.hk_audit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_audit","description");
			fdata["FieldType"] = 201;
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
			edata = new XVar("EditFormat", "Text area");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
			edata["nRows"] = 100;
			edata["nCols"] = 200;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["CreateThumbnail"] = true;
			edata["StrThumbnail"] = "th";
			edata["ThumbnailSize"] = 600;
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
			tdataArray["hk_audit"]["description"] = fdata;
			tdataArray["hk_audit"][".searchableFields"].Add("description");
			GlobalVars.tables_data["dbo.hk_audit"] = tdataArray["hk_audit"];
			GlobalVars.field_labels["dbo_hk_audit"] = fieldLabelsArray["hk_audit"];
			GlobalVars.fieldToolTips["dbo_hk_audit"] = fieldToolTipsArray["hk_audit"];
			GlobalVars.placeHolders["dbo_hk_audit"] = placeHoldersArray["hk_audit"];
			GlobalVars.page_titles["dbo_hk_audit"] = pageTitlesArray["hk_audit"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_audit"));
			GlobalVars.detailsTablesData["dbo.hk_audit"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_audit"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	[datetime],  dbo.HK_TimeZone(':session.user_name',datetime) tz_create_date,  	ip,  	[user],  	[table],  	[action],  	description";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_audit";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "order by id desc";
	
		
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "datetime", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["8"]["m_sql"] = "[datetime]";
protoArray["8"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_functiontype"] = "SQLF_CUSTOM";
protoArray["11"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "':session.user_name'"));

protoArray["11"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "datetime"));

protoArray["11"]["m_arguments"].Add(obj);
protoArray["11"]["m_strFunctionName"] = "dbo.HK_TimeZone";
obj = new SQLFunctionCall(protoArray["11"]);

protoArray["10"]["m_sql"] = "dbo.HK_TimeZone(':session.user_name',datetime)";
protoArray["10"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "tz_create_date";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ip", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["14"]["m_sql"] = "ip";
protoArray["14"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "user", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["16"]["m_sql"] = "[user]";
protoArray["16"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "table", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["18"]["m_sql"] = "[table]";
protoArray["18"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["20"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "action", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["20"]["m_sql"] = "[action]";
protoArray["20"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["20"]["m_expr"] = obj;
protoArray["20"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["20"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["22"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "description", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["22"]["m_sql"] = "description";
protoArray["22"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["22"]["m_expr"] = obj;
protoArray["22"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["22"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["24"] = SettingsMap.GetArray();
protoArray["24"]["m_link"] = "SQLL_MAIN";
protoArray["25"] = SettingsMap.GetArray();
protoArray["25"]["m_strName"] = "dbo.hk_audit";
protoArray["25"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["25"]["m_columns"] = SettingsMap.GetArray();
protoArray["25"]["m_columns"].Add("id");
protoArray["25"]["m_columns"].Add("datetime");
protoArray["25"]["m_columns"].Add("ip");
protoArray["25"]["m_columns"].Add("user");
protoArray["25"]["m_columns"].Add("table");
protoArray["25"]["m_columns"].Add("action");
protoArray["25"]["m_columns"].Add("description");
obj = new SQLTable(protoArray["25"]);

protoArray["24"]["m_table"] = obj;
protoArray["24"]["m_sql"] = "dbo.hk_audit";
protoArray["24"]["m_alias"] = "";
protoArray["24"]["m_srcTableName"] = "dbo.hk_audit";
protoArray["26"] = SettingsMap.GetArray();
protoArray["26"]["m_sql"] = "";
protoArray["26"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["26"]["m_column"] = obj;
protoArray["26"]["m_contained"] = SettingsMap.GetArray();
protoArray["26"]["m_strCase"] = "";
protoArray["26"]["m_havingmode"] = false;
protoArray["26"]["m_inBrackets"] = false;
protoArray["26"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["26"]);

protoArray["24"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["24"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["28"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "dbo.hk_audit", "m_srcTableName", "dbo.hk_audit"));

protoArray["28"]["m_column"] = obj;
protoArray["28"]["m_bAsc"] = 0;
protoArray["28"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["28"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "dbo.hk_audit";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_audit"] = obj;

				
		
			tdataArray["hk_audit"][".sqlquery"] = queryData_Array["hk_audit"];
			tdataArray["hk_audit"][".hasEvents"] = false;
		}
	}

}
