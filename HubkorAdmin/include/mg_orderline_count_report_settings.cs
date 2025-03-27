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
	public static partial class Settings_mg_orderline_count_report
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".ShortName"] = "mg_orderline_count_report";
			tdataArray["mg_orderline_count_report"][".OwnerID"] = "clientid";
			tdataArray["mg_orderline_count_report"][".OriginalTable"] = "dbo.mg_orderline_count";
			tdataArray["mg_orderline_count_report"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}"));
			tdataArray["mg_orderline_count_report"][".originalPagesByType"] = tdataArray["mg_orderline_count_report"][".pagesByType"];
			tdataArray["mg_orderline_count_report"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}")));
			tdataArray["mg_orderline_count_report"][".originalPages"] = tdataArray["mg_orderline_count_report"][".pages"];
			tdataArray["mg_orderline_count_report"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"report\":\"report\",\"rprint\":\"rprint\",\"search\":\"search\"}"));
			tdataArray["mg_orderline_count_report"][".originalDefaultPages"] = tdataArray["mg_orderline_count_report"][".defaultPages"];
			fieldLabelsArray["mg_orderline_count_report"] = SettingsMap.GetArray();
			fieldToolTipsArray["mg_orderline_count_report"] = SettingsMap.GetArray();
			pageTitlesArray["mg_orderline_count_report"] = SettingsMap.GetArray();
			placeHoldersArray["mg_orderline_count_report"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["mg_orderline_count_report"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["mg_orderline_count_report"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["mg_orderline_count_report"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["mg_orderline_count_report"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["mg_orderline_count_report"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["mg_orderline_count_report"]["English"]["clientid"] = "";
				placeHoldersArray["mg_orderline_count_report"]["English"]["clientid"] = "";
				fieldLabelsArray["mg_orderline_count_report"]["English"]["co_num"] = "Co Num";
				fieldToolTipsArray["mg_orderline_count_report"]["English"]["co_num"] = "";
				placeHoldersArray["mg_orderline_count_report"]["English"]["co_num"] = "";
				fieldLabelsArray["mg_orderline_count_report"]["English"]["yy"] = "Yy";
				fieldToolTipsArray["mg_orderline_count_report"]["English"]["yy"] = "";
				placeHoldersArray["mg_orderline_count_report"]["English"]["yy"] = "";
				fieldLabelsArray["mg_orderline_count_report"]["English"]["mm"] = "Mm";
				fieldToolTipsArray["mg_orderline_count_report"]["English"]["mm"] = "";
				placeHoldersArray["mg_orderline_count_report"]["English"]["mm"] = "";
				fieldLabelsArray["mg_orderline_count_report"]["English"]["extprice"] = "Extprice";
				fieldToolTipsArray["mg_orderline_count_report"]["English"]["extprice"] = "";
				placeHoldersArray["mg_orderline_count_report"]["English"]["extprice"] = "";
				fieldLabelsArray["mg_orderline_count_report"]["English"]["cnt"] = "Cnt";
				fieldToolTipsArray["mg_orderline_count_report"]["English"]["cnt"] = "";
				placeHoldersArray["mg_orderline_count_report"]["English"]["cnt"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["mg_orderline_count_report"]["English"])))
				{
					tdataArray["mg_orderline_count_report"][".isUseToolTips"] = true;
				}
			}
			tdataArray["mg_orderline_count_report"][".NCSearch"] = true;
			tdataArray["mg_orderline_count_report"][".shortTableName"] = "mg_orderline_count_report";
			tdataArray["mg_orderline_count_report"][".nSecOptions"] = 1;
			tdataArray["mg_orderline_count_report"][".mainTableOwnerID"] = "clientid";
			tdataArray["mg_orderline_count_report"][".entityType"] = 2;
			tdataArray["mg_orderline_count_report"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["mg_orderline_count_report"][".strOriginalTableName"] = "dbo.mg_orderline_count";
			tdataArray["mg_orderline_count_report"][".showAddInPopup"] = false;
			tdataArray["mg_orderline_count_report"][".showEditInPopup"] = false;
			tdataArray["mg_orderline_count_report"][".showViewInPopup"] = false;
			tdataArray["mg_orderline_count_report"][".listAjax"] = false;
			tdataArray["mg_orderline_count_report"][".audit"] = false;
			tdataArray["mg_orderline_count_report"][".locking"] = false;
			GlobalVars.pages = tdataArray["mg_orderline_count_report"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["mg_orderline_count_report"][".edit"] = true;
				tdataArray["mg_orderline_count_report"][".afterEditAction"] = 1;
				tdataArray["mg_orderline_count_report"][".closePopupAfterEdit"] = 1;
				tdataArray["mg_orderline_count_report"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["mg_orderline_count_report"][".add"] = true;
				tdataArray["mg_orderline_count_report"][".afterAddAction"] = 1;
				tdataArray["mg_orderline_count_report"][".closePopupAfterAdd"] = 1;
				tdataArray["mg_orderline_count_report"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["mg_orderline_count_report"][".list"] = true;
			}
			tdataArray["mg_orderline_count_report"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["mg_orderline_count_report"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["mg_orderline_count_report"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["mg_orderline_count_report"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["mg_orderline_count_report"][".printFriendly"] = true;
			}
			tdataArray["mg_orderline_count_report"][".showSimpleSearchOptions"] = true;
			tdataArray["mg_orderline_count_report"][".allowShowHideFields"] = true;
			tdataArray["mg_orderline_count_report"][".allowFieldsReordering"] = true;
			tdataArray["mg_orderline_count_report"][".isUseAjaxSuggest"] = true;


			tdataArray["mg_orderline_count_report"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["mg_orderline_count_report"][".buttonsAdded"] = false;
			tdataArray["mg_orderline_count_report"][".addPageEvents"] = false;
			tdataArray["mg_orderline_count_report"][".isUseTimeForSearch"] = false;
			tdataArray["mg_orderline_count_report"][".badgeColor"] = "D2AF80";
			tdataArray["mg_orderline_count_report"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".googleLikeFields"].Add("clientid");
			tdataArray["mg_orderline_count_report"][".googleLikeFields"].Add("co_num");
			tdataArray["mg_orderline_count_report"][".googleLikeFields"].Add("yy");
			tdataArray["mg_orderline_count_report"][".googleLikeFields"].Add("mm");
			tdataArray["mg_orderline_count_report"][".googleLikeFields"].Add("extprice");
			tdataArray["mg_orderline_count_report"][".googleLikeFields"].Add("cnt");
			tdataArray["mg_orderline_count_report"][".tableType"] = "report";
			tdataArray["mg_orderline_count_report"][".printerPageOrientation"] = 0;
			tdataArray["mg_orderline_count_report"][".nPrinterPageScale"] = 100;
			tdataArray["mg_orderline_count_report"][".nPrinterSplitRecords"] = 40;
			tdataArray["mg_orderline_count_report"][".geocodingEnabled"] = false;
			tdataArray["mg_orderline_count_report"][".reportPrintGroupsPerPage"] = 3;
			tdataArray["mg_orderline_count_report"][".reportPrintRecordsPerPage"] = 40;
			tdataArray["mg_orderline_count_report"][".pageSizeGroups"] = 5;
			tdataArray["mg_orderline_count_report"][".pageSizeRecords"] = 20;
			tstrOrderBy = "";
			tdataArray["mg_orderline_count_report"][".strOrderBy"] = tstrOrderBy;
			tdataArray["mg_orderline_count_report"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".sqlHead"] = "SELECT clientid,  	co_num,  	yy,  	mm,  	extprice,    1 cnt";
			tdataArray["mg_orderline_count_report"][".sqlFrom"] = "FROM dbo.mg_orderline_count";
			tdataArray["mg_orderline_count_report"][".sqlWhereExpr"] = "";
			tdataArray["mg_orderline_count_report"][".sqlTail"] = "";
			arrGridTabs = SettingsMap.GetArray();
			arrGridTabs.Add(new XVar("tabId", "", "name", "All data", "nameType", "Text", "where", "", "showRowCount", 0, "hideEmpty", 0));
			tdataArray["mg_orderline_count_report"][".arrGridTabs"] = arrGridTabs;
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["mg_orderline_count_report"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["mg_orderline_count_report"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["mg_orderline_count_report"][".highlightSearchResults"] = true;
			tableKeysArray["mg_orderline_count_report"] = SettingsMap.GetArray();
			tdataArray["mg_orderline_count_report"][".Keys"] = tableKeysArray["mg_orderline_count_report"];
			tdataArray["mg_orderline_count_report"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.mg_orderline_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_orderline_count_Report","clientid");
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
			fdata["ViewFormats"]["report"] = vdata;
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
			tdataArray["mg_orderline_count_report"]["clientid"] = fdata;
			tdataArray["mg_orderline_count_report"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "co_num";
			fdata["GoodName"] = "co_num";
			fdata["ownerTable"] = "dbo.mg_orderline_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_orderline_count_Report","co_num");
			fdata["FieldType"] = 202;
			fdata["strField"] = "co_num";
			fdata["sourceSingle"] = "co_num";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "co_num";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
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
			tdataArray["mg_orderline_count_report"]["co_num"] = fdata;
			tdataArray["mg_orderline_count_report"][".searchableFields"].Add("co_num");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "yy";
			fdata["GoodName"] = "yy";
			fdata["ownerTable"] = "dbo.mg_orderline_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_orderline_count_Report","yy");
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
			fdata["ViewFormats"]["report"] = vdata;
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
			tdataArray["mg_orderline_count_report"]["yy"] = fdata;
			tdataArray["mg_orderline_count_report"][".searchableFields"].Add("yy");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "mm";
			fdata["GoodName"] = "mm";
			fdata["ownerTable"] = "dbo.mg_orderline_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_orderline_count_Report","mm");
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
			fdata["ViewFormats"]["report"] = vdata;
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
			tdataArray["mg_orderline_count_report"]["mm"] = fdata;
			tdataArray["mg_orderline_count_report"][".searchableFields"].Add("mm");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "extprice";
			fdata["GoodName"] = "extprice";
			fdata["ownerTable"] = "dbo.mg_orderline_count";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_orderline_count_Report","extprice");
			fdata["FieldType"] = 14;
			fdata["strField"] = "extprice";
			fdata["sourceSingle"] = "extprice";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "extprice";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Number");
			vdata["DecimalDigits"] = 6;
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
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
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
			tdataArray["mg_orderline_count_report"]["extprice"] = fdata;
			tdataArray["mg_orderline_count_report"][".searchableFields"].Add("extprice");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "cnt";
			fdata["GoodName"] = "cnt";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_mg_orderline_count_Report","cnt");
			fdata["FieldType"] = 3;
			fdata["strField"] = "cnt";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "1";
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
			tdataArray["mg_orderline_count_report"]["cnt"] = fdata;
			tdataArray["mg_orderline_count_report"][".searchableFields"].Add("cnt");
			GlobalVars.tables_data["dbo.mg_orderline_count Report"] = tdataArray["mg_orderline_count_report"];
			GlobalVars.field_labels["dbo_mg_orderline_count_Report"] = fieldLabelsArray["mg_orderline_count_report"];
			GlobalVars.fieldToolTips["dbo_mg_orderline_count_Report"] = fieldToolTipsArray["mg_orderline_count_report"];
			GlobalVars.placeHolders["dbo_mg_orderline_count_Report"] = placeHoldersArray["mg_orderline_count_report"];
			GlobalVars.page_titles["dbo_mg_orderline_count_Report"] = pageTitlesArray["mg_orderline_count_report"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.mg_orderline_count Report"));
			GlobalVars.detailsTablesData["dbo.mg_orderline_count Report"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.mg_orderline_count Report"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "clientid,  	co_num,  	yy,  	mm,  	extprice,    1 cnt";
protoArray["0"]["m_strFrom"] = "FROM dbo.mg_orderline_count";
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
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.mg_orderline_count", "m_srcTableName", "dbo.mg_orderline_count Report"));

protoArray["6"]["m_sql"] = "clientid";
protoArray["6"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "co_num", "m_strTable", "dbo.mg_orderline_count", "m_srcTableName", "dbo.mg_orderline_count Report"));

protoArray["8"]["m_sql"] = "co_num";
protoArray["8"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "yy", "m_strTable", "dbo.mg_orderline_count", "m_srcTableName", "dbo.mg_orderline_count Report"));

protoArray["10"]["m_sql"] = "yy";
protoArray["10"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "mm", "m_strTable", "dbo.mg_orderline_count", "m_srcTableName", "dbo.mg_orderline_count Report"));

protoArray["12"]["m_sql"] = "mm";
protoArray["12"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "extprice", "m_strTable", "dbo.mg_orderline_count", "m_srcTableName", "dbo.mg_orderline_count Report"));

protoArray["14"]["m_sql"] = "extprice";
protoArray["14"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "1"));

protoArray["16"]["m_sql"] = "1";
protoArray["16"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "cnt";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.mg_orderline_count";
protoArray["19"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("clientid");
protoArray["19"]["m_columns"].Add("co_num");
protoArray["19"]["m_columns"].Add("yy");
protoArray["19"]["m_columns"].Add("mm");
protoArray["19"]["m_columns"].Add("extprice");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.mg_orderline_count";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_sql"] = "";
protoArray["20"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["20"]["m_column"] = obj;
protoArray["20"]["m_contained"] = SettingsMap.GetArray();
protoArray["20"]["m_strCase"] = "";
protoArray["20"]["m_havingmode"] = false;
protoArray["20"]["m_inBrackets"] = false;
protoArray["20"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["20"]);

protoArray["18"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["18"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.mg_orderline_count Report";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["mg_orderline_count_report"] = obj;

				
		
			tdataArray["mg_orderline_count_report"][".sqlquery"] = queryData_Array["mg_orderline_count_report"];
			tdataArray["mg_orderline_count_report"][".hasEvents"] = false;
		}
	}

}
