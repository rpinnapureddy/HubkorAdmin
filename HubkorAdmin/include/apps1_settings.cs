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
	public static partial class Settings_apps1
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["apps1"] = SettingsMap.GetArray();
			tdataArray["apps1"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["apps1"][".ShortName"] = "apps1";
			tdataArray["apps1"][".OwnerID"] = "code";
			tdataArray["apps1"][".OriginalTable"] = "dbo.apps";
			tdataArray["apps1"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["apps1"][".originalPagesByType"] = tdataArray["apps1"][".pagesByType"];
			tdataArray["apps1"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["apps1"][".originalPages"] = tdataArray["apps1"][".pages"];
			tdataArray["apps1"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["apps1"][".originalDefaultPages"] = tdataArray["apps1"][".defaultPages"];
			fieldLabelsArray["apps1"] = SettingsMap.GetArray();
			fieldToolTipsArray["apps1"] = SettingsMap.GetArray();
			pageTitlesArray["apps1"] = SettingsMap.GetArray();
			placeHoldersArray["apps1"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["apps1"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["apps1"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["apps1"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["apps1"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["apps1"]["English"]["code"] = "Code";
				fieldToolTipsArray["apps1"]["English"]["code"] = "";
				placeHoldersArray["apps1"]["English"]["code"] = "";
				fieldLabelsArray["apps1"]["English"]["name"] = "Name";
				fieldToolTipsArray["apps1"]["English"]["name"] = "";
				placeHoldersArray["apps1"]["English"]["name"] = "";
				fieldLabelsArray["apps1"]["English"]["auth_type"] = "Auth Type";
				fieldToolTipsArray["apps1"]["English"]["auth_type"] = "";
				placeHoldersArray["apps1"]["English"]["auth_type"] = "";
				fieldLabelsArray["apps1"]["English"]["host_url"] = "Host Url";
				fieldToolTipsArray["apps1"]["English"]["host_url"] = "";
				placeHoldersArray["apps1"]["English"]["host_url"] = "";
				fieldLabelsArray["apps1"]["English"]["Out"] = "Out";
				fieldToolTipsArray["apps1"]["English"]["Out"] = "";
				placeHoldersArray["apps1"]["English"]["Out"] = "";
				fieldLabelsArray["apps1"]["English"]["In"] = "In";
				fieldToolTipsArray["apps1"]["English"]["In"] = "";
				placeHoldersArray["apps1"]["English"]["In"] = "";
				fieldLabelsArray["apps1"]["English"]["Last_Executed_Time"] = "Last Executed Time";
				fieldToolTipsArray["apps1"]["English"]["Last_Executed_Time"] = "";
				placeHoldersArray["apps1"]["English"]["Last_Executed_Time"] = "";
				fieldLabelsArray["apps1"]["English"]["Next_Execution_Time"] = "Next Execution Time";
				fieldToolTipsArray["apps1"]["English"]["Next_Execution_Time"] = "";
				placeHoldersArray["apps1"]["English"]["Next_Execution_Time"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["apps1"]["English"])))
				{
					tdataArray["apps1"][".isUseToolTips"] = true;
				}
			}
			tdataArray["apps1"][".NCSearch"] = true;
			tdataArray["apps1"][".shortTableName"] = "apps1";
			tdataArray["apps1"][".nSecOptions"] = 0;
			tdataArray["apps1"][".mainTableOwnerID"] = "code";
			tdataArray["apps1"][".entityType"] = 1;
			tdataArray["apps1"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["apps1"][".strOriginalTableName"] = "dbo.apps";
			tdataArray["apps1"][".showAddInPopup"] = false;
			tdataArray["apps1"][".showEditInPopup"] = false;
			tdataArray["apps1"][".showViewInPopup"] = false;
			tdataArray["apps1"][".listAjax"] = false;
			tdataArray["apps1"][".audit"] = true;
			tdataArray["apps1"][".locking"] = false;
			GlobalVars.pages = tdataArray["apps1"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["apps1"][".edit"] = true;
				tdataArray["apps1"][".afterEditAction"] = 1;
				tdataArray["apps1"][".closePopupAfterEdit"] = 1;
				tdataArray["apps1"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["apps1"][".add"] = true;
				tdataArray["apps1"][".afterAddAction"] = 1;
				tdataArray["apps1"][".closePopupAfterAdd"] = 1;
				tdataArray["apps1"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["apps1"][".list"] = true;
			}
			tdataArray["apps1"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["apps1"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["apps1"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["apps1"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["apps1"][".printFriendly"] = true;
			}
			tdataArray["apps1"][".showSimpleSearchOptions"] = true;
			tdataArray["apps1"][".allowShowHideFields"] = true;
			tdataArray["apps1"][".allowFieldsReordering"] = true;
			tdataArray["apps1"][".isUseAjaxSuggest"] = true;


			tdataArray["apps1"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["apps1"][".buttonsAdded"] = false;
			tdataArray["apps1"][".addPageEvents"] = false;
			tdataArray["apps1"][".isUseTimeForSearch"] = false;
			tdataArray["apps1"][".badgeColor"] = "CFAE83";
			tdataArray["apps1"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["apps1"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["apps1"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["apps1"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["apps1"][".googleLikeFields"].Add("code");
			tdataArray["apps1"][".googleLikeFields"].Add("name");
			tdataArray["apps1"][".googleLikeFields"].Add("auth_type");
			tdataArray["apps1"][".googleLikeFields"].Add("host_url");
			tdataArray["apps1"][".googleLikeFields"].Add("Out");
			tdataArray["apps1"][".googleLikeFields"].Add("In");
			tdataArray["apps1"][".googleLikeFields"].Add("Last_Executed_Time");
			tdataArray["apps1"][".googleLikeFields"].Add("Next_Execution_Time");
			tdataArray["apps1"][".tableType"] = "list";
			tdataArray["apps1"][".printerPageOrientation"] = 0;
			tdataArray["apps1"][".nPrinterPageScale"] = 100;
			tdataArray["apps1"][".nPrinterSplitRecords"] = 40;
			tdataArray["apps1"][".geocodingEnabled"] = false;
			tdataArray["apps1"][".pageSize"] = 20;
			tdataArray["apps1"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["apps1"][".strOrderBy"] = tstrOrderBy;
			tdataArray["apps1"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["apps1"][".sqlHead"] = "SELECT code,  name,  auth_type,  host_url,  [dbo].[HK_Status](code,'OUT') AS [Out],  [dbo].[HK_Status](code,'IN') AS [In],  Last_Executed_Time,  Next_Execution_Time";
			tdataArray["apps1"][".sqlFrom"] = "FROM dbo.apps";
			tdataArray["apps1"][".sqlWhereExpr"] = "";
			tdataArray["apps1"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["apps1"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["apps1"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["apps1"][".highlightSearchResults"] = true;
			tableKeysArray["apps1"] = SettingsMap.GetArray();
			tableKeysArray["apps1"].Add("code");
			tdataArray["apps1"][".Keys"] = tableKeysArray["apps1"];
			tdataArray["apps1"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "code";
			fdata["GoodName"] = "code";
			fdata["ownerTable"] = "dbo.apps";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","code");
			fdata["FieldType"] = 202;
			fdata["strField"] = "code";
			fdata["sourceSingle"] = "code";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "code";
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
			tdataArray["apps1"]["code"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("code");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "name";
			fdata["GoodName"] = "name";
			fdata["ownerTable"] = "dbo.apps";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","name");
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
			tdataArray["apps1"]["name"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "auth_type";
			fdata["GoodName"] = "auth_type";
			fdata["ownerTable"] = "dbo.apps";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","auth_type");
			fdata["FieldType"] = 202;
			fdata["strField"] = "auth_type";
			fdata["sourceSingle"] = "auth_type";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "auth_type";
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
			tdataArray["apps1"]["auth_type"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("auth_type");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "host_url";
			fdata["GoodName"] = "host_url";
			fdata["ownerTable"] = "dbo.apps";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","host_url");
			fdata["FieldType"] = 202;
			fdata["strField"] = "host_url";
			fdata["sourceSingle"] = "host_url";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "host_url";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=80");
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
			tdataArray["apps1"]["host_url"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("host_url");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "Out";
			fdata["GoodName"] = "Out";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","Out");
			fdata["FieldType"] = 17;
			fdata["strField"] = "Out";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[dbo].[HK_Status](code,'OUT')";
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
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
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
			tdataArray["apps1"]["Out"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("Out");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "In";
			fdata["GoodName"] = "In";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","In");
			fdata["FieldType"] = 17;
			fdata["strField"] = "IN";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[dbo].[HK_Status](code,'IN')";
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
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
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
			tdataArray["apps1"]["In"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("In");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "Last_Executed_Time";
			fdata["GoodName"] = "Last_Executed_Time";
			fdata["ownerTable"] = "dbo.apps";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","Last_Executed_Time");
			fdata["FieldType"] = 135;
			fdata["strField"] = "Last_Executed_Time";
			fdata["sourceSingle"] = "Last_Executed_Time";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Last_Executed_Time";
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
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["apps1"]["Last_Executed_Time"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("Last_Executed_Time");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "Next_Execution_Time";
			fdata["GoodName"] = "Next_Execution_Time";
			fdata["ownerTable"] = "dbo.apps";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_apps1","Next_Execution_Time");
			fdata["FieldType"] = 135;
			fdata["strField"] = "Next_Execution_Time";
			fdata["sourceSingle"] = "Next_Execution_Time";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Next_Execution_Time";
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
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["apps1"]["Next_Execution_Time"] = fdata;
			tdataArray["apps1"][".searchableFields"].Add("Next_Execution_Time");
			GlobalVars.tables_data["dbo.apps1"] = tdataArray["apps1"];
			GlobalVars.field_labels["dbo_apps1"] = fieldLabelsArray["apps1"];
			GlobalVars.fieldToolTips["dbo_apps1"] = fieldToolTipsArray["apps1"];
			GlobalVars.placeHolders["dbo_apps1"] = placeHoldersArray["apps1"];
			GlobalVars.page_titles["dbo_apps1"] = pageTitlesArray["apps1"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.apps1"));
			GlobalVars.detailsTablesData["dbo.apps1"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.apps1"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "code,  name,  auth_type,  host_url,  [dbo].[HK_Status](code,'OUT') AS [Out],  [dbo].[HK_Status](code,'IN') AS [In],  Last_Executed_Time,  Next_Execution_Time";
protoArray["0"]["m_strFrom"] = "FROM dbo.apps";
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
obj = new SQLField(new XVar("m_strName", "code", "m_strTable", "dbo.apps", "m_srcTableName", "dbo.apps1"));

protoArray["6"]["m_sql"] = "code";
protoArray["6"]["m_srcTableName"] = "dbo.apps1";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "name", "m_strTable", "dbo.apps", "m_srcTableName", "dbo.apps1"));

protoArray["8"]["m_sql"] = "name";
protoArray["8"]["m_srcTableName"] = "dbo.apps1";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "auth_type", "m_strTable", "dbo.apps", "m_srcTableName", "dbo.apps1"));

protoArray["10"]["m_sql"] = "auth_type";
protoArray["10"]["m_srcTableName"] = "dbo.apps1";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "host_url", "m_strTable", "dbo.apps", "m_srcTableName", "dbo.apps1"));

protoArray["12"]["m_sql"] = "host_url";
protoArray["12"]["m_srcTableName"] = "dbo.apps1";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "[dbo].[HK_Status](code,'OUT')"));

protoArray["14"]["m_sql"] = "[dbo].[HK_Status](code,'OUT')";
protoArray["14"]["m_srcTableName"] = "dbo.apps1";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "Out";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "[dbo].[HK_Status](code,'IN')"));

protoArray["16"]["m_sql"] = "[dbo].[HK_Status](code,'IN')";
protoArray["16"]["m_srcTableName"] = "dbo.apps1";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "In";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Last_Executed_Time", "m_strTable", "dbo.apps", "m_srcTableName", "dbo.apps1"));

protoArray["18"]["m_sql"] = "Last_Executed_Time";
protoArray["18"]["m_srcTableName"] = "dbo.apps1";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["20"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Next_Execution_Time", "m_strTable", "dbo.apps", "m_srcTableName", "dbo.apps1"));

protoArray["20"]["m_sql"] = "Next_Execution_Time";
protoArray["20"]["m_srcTableName"] = "dbo.apps1";
protoArray["20"]["m_expr"] = obj;
protoArray["20"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["20"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["22"] = SettingsMap.GetArray();
protoArray["22"]["m_link"] = "SQLL_MAIN";
protoArray["23"] = SettingsMap.GetArray();
protoArray["23"]["m_strName"] = "dbo.apps";
protoArray["23"]["m_srcTableName"] = "dbo.apps1";
protoArray["23"]["m_columns"] = SettingsMap.GetArray();
protoArray["23"]["m_columns"].Add("code");
protoArray["23"]["m_columns"].Add("name");
protoArray["23"]["m_columns"].Add("auth_type");
protoArray["23"]["m_columns"].Add("host_url");
protoArray["23"]["m_columns"].Add("Last_Executed_Time");
protoArray["23"]["m_columns"].Add("Next_Execution_Time");
obj = new SQLTable(protoArray["23"]);

protoArray["22"]["m_table"] = obj;
protoArray["22"]["m_sql"] = "dbo.apps";
protoArray["22"]["m_alias"] = "";
protoArray["22"]["m_srcTableName"] = "dbo.apps1";
protoArray["24"] = SettingsMap.GetArray();
protoArray["24"]["m_sql"] = "";
protoArray["24"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["24"]["m_column"] = obj;
protoArray["24"]["m_contained"] = SettingsMap.GetArray();
protoArray["24"]["m_strCase"] = "";
protoArray["24"]["m_havingmode"] = false;
protoArray["24"]["m_inBrackets"] = false;
protoArray["24"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["24"]);

protoArray["22"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["22"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.apps1";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["apps1"] = obj;

				
		
			tdataArray["apps1"][".sqlquery"] = queryData_Array["apps1"];
			tdataArray["apps1"][".hasEvents"] = false;
		}
	}

}
