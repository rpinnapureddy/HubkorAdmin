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
	public static partial class Settings_tp_invoicedetails_status_mst
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".ShortName"] = "tp_invoicedetails_status_mst";
			tdataArray["tp_invoicedetails_status_mst"][".OwnerID"] = "clientid";
			tdataArray["tp_invoicedetails_status_mst"][".OriginalTable"] = "dbo.tp_invoicedetails_status_mst";
			tdataArray["tp_invoicedetails_status_mst"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["tp_invoicedetails_status_mst"][".originalPagesByType"] = tdataArray["tp_invoicedetails_status_mst"][".pagesByType"];
			tdataArray["tp_invoicedetails_status_mst"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["tp_invoicedetails_status_mst"][".originalPages"] = tdataArray["tp_invoicedetails_status_mst"][".pages"];
			tdataArray["tp_invoicedetails_status_mst"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["tp_invoicedetails_status_mst"][".originalDefaultPages"] = tdataArray["tp_invoicedetails_status_mst"][".defaultPages"];
			fieldLabelsArray["tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			fieldToolTipsArray["tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			pageTitlesArray["tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			placeHoldersArray["tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["tp_invoicedetails_status_mst"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"]["clientid"] = "";
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"]["clientid"] = "";
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"]["invoiceid"] = "Invoiceid";
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"]["invoiceid"] = "";
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"]["invoiceid"] = "";
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"]["status"] = "Status";
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"]["status"] = "";
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"]["status"] = "";
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"]["createdate"] = "Createdate";
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"]["createdate"] = "";
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"]["createdate"] = "";
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"]["recorddate"] = "Recorddate";
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"]["recorddate"] = "";
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"]["recorddate"] = "";
				fieldLabelsArray["tp_invoicedetails_status_mst"]["English"]["total"] = "Total";
				fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"]["total"] = "";
				placeHoldersArray["tp_invoicedetails_status_mst"]["English"]["total"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["tp_invoicedetails_status_mst"]["English"])))
				{
					tdataArray["tp_invoicedetails_status_mst"][".isUseToolTips"] = true;
				}
			}
			tdataArray["tp_invoicedetails_status_mst"][".NCSearch"] = true;
			tdataArray["tp_invoicedetails_status_mst"][".shortTableName"] = "tp_invoicedetails_status_mst";
			tdataArray["tp_invoicedetails_status_mst"][".nSecOptions"] = 1;
			tdataArray["tp_invoicedetails_status_mst"][".mainTableOwnerID"] = "clientid";
			tdataArray["tp_invoicedetails_status_mst"][".entityType"] = 0;
			tdataArray["tp_invoicedetails_status_mst"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["tp_invoicedetails_status_mst"][".strOriginalTableName"] = "dbo.tp_invoicedetails_status_mst";
			tdataArray["tp_invoicedetails_status_mst"][".showAddInPopup"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".showEditInPopup"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".showViewInPopup"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".listAjax"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".audit"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".locking"] = false;
			GlobalVars.pages = tdataArray["tp_invoicedetails_status_mst"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".edit"] = true;
				tdataArray["tp_invoicedetails_status_mst"][".afterEditAction"] = 1;
				tdataArray["tp_invoicedetails_status_mst"][".closePopupAfterEdit"] = 1;
				tdataArray["tp_invoicedetails_status_mst"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".add"] = true;
				tdataArray["tp_invoicedetails_status_mst"][".afterAddAction"] = 1;
				tdataArray["tp_invoicedetails_status_mst"][".closePopupAfterAdd"] = 1;
				tdataArray["tp_invoicedetails_status_mst"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".list"] = true;
			}
			tdataArray["tp_invoicedetails_status_mst"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["tp_invoicedetails_status_mst"][".printFriendly"] = true;
			}
			tdataArray["tp_invoicedetails_status_mst"][".showSimpleSearchOptions"] = true;
			tdataArray["tp_invoicedetails_status_mst"][".allowShowHideFields"] = true;
			tdataArray["tp_invoicedetails_status_mst"][".allowFieldsReordering"] = true;
			tdataArray["tp_invoicedetails_status_mst"][".isUseAjaxSuggest"] = true;


			tdataArray["tp_invoicedetails_status_mst"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".buttonsAdded"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".addPageEvents"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".isUseTimeForSearch"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".badgeColor"] = "4169e1";
			tdataArray["tp_invoicedetails_status_mst"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"].Add("clientid");
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"].Add("invoiceid");
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"].Add("status");
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"].Add("createdate");
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"].Add("recorddate");
			tdataArray["tp_invoicedetails_status_mst"][".googleLikeFields"].Add("total");
			tdataArray["tp_invoicedetails_status_mst"][".tableType"] = "list";
			tdataArray["tp_invoicedetails_status_mst"][".printerPageOrientation"] = 0;
			tdataArray["tp_invoicedetails_status_mst"][".nPrinterPageScale"] = 100;
			tdataArray["tp_invoicedetails_status_mst"][".nPrinterSplitRecords"] = 40;
			tdataArray["tp_invoicedetails_status_mst"][".geocodingEnabled"] = false;
			tdataArray["tp_invoicedetails_status_mst"][".pageSize"] = 20;
			tdataArray["tp_invoicedetails_status_mst"][".warnLeavingPages"] = true;
			tstrOrderBy = "order by createdate";
			tdataArray["tp_invoicedetails_status_mst"][".strOrderBy"] = tstrOrderBy;
			tdataArray["tp_invoicedetails_status_mst"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".orderindexes"].Add(new XVar(0, 4, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "createdate"));
			tdataArray["tp_invoicedetails_status_mst"][".sqlHead"] = "SELECT clientid,  	invoiceid,  	status,  	createdate,  	recorddate,  	total";
			tdataArray["tp_invoicedetails_status_mst"][".sqlFrom"] = "FROM dbo.tp_invoicedetails_status_mst";
			tdataArray["tp_invoicedetails_status_mst"][".sqlWhereExpr"] = "";
			tdataArray["tp_invoicedetails_status_mst"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["tp_invoicedetails_status_mst"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["tp_invoicedetails_status_mst"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["tp_invoicedetails_status_mst"][".highlightSearchResults"] = true;
			tableKeysArray["tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_status_mst"][".Keys"] = tableKeysArray["tp_invoicedetails_status_mst"];
			tdataArray["tp_invoicedetails_status_mst"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_status_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_status_mst","clientid");
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
			tdataArray["tp_invoicedetails_status_mst"]["clientid"] = fdata;
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "invoiceid";
			fdata["GoodName"] = "invoiceid";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_status_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_status_mst","invoiceid");
			fdata["FieldType"] = 202;
			fdata["strField"] = "invoiceid";
			fdata["sourceSingle"] = "invoiceid";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "invoiceid";
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
			tdataArray["tp_invoicedetails_status_mst"]["invoiceid"] = fdata;
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"].Add("invoiceid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "status";
			fdata["GoodName"] = "status";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_status_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_status_mst","status");
			fdata["FieldType"] = 202;
			fdata["strField"] = "status";
			fdata["sourceSingle"] = "status";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "status";
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
			tdataArray["tp_invoicedetails_status_mst"]["status"] = fdata;
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"].Add("status");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "createdate";
			fdata["GoodName"] = "createdate";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_status_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_status_mst","createdate");
			fdata["FieldType"] = 135;
			fdata["strField"] = "createdate";
			fdata["sourceSingle"] = "createdate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "createdate";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Datetime");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["weekdayMessage"] = new XVar("message", "Invalid week day", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 5;
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
			tdataArray["tp_invoicedetails_status_mst"]["createdate"] = fdata;
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"].Add("createdate");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "recorddate";
			fdata["GoodName"] = "recorddate";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_status_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_status_mst","recorddate");
			fdata["FieldType"] = 135;
			fdata["strField"] = "recorddate";
			fdata["sourceSingle"] = "recorddate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "recorddate";
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
			tdataArray["tp_invoicedetails_status_mst"]["recorddate"] = fdata;
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"].Add("recorddate");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "total";
			fdata["GoodName"] = "total";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_status_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_status_mst","total");
			fdata["FieldType"] = 14;
			fdata["strField"] = "total";
			fdata["sourceSingle"] = "total";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "total";
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
			tdataArray["tp_invoicedetails_status_mst"]["total"] = fdata;
			tdataArray["tp_invoicedetails_status_mst"][".searchableFields"].Add("total");
			GlobalVars.tables_data["dbo.tp_invoicedetails_status_mst"] = tdataArray["tp_invoicedetails_status_mst"];
			GlobalVars.field_labels["dbo_tp_invoicedetails_status_mst"] = fieldLabelsArray["tp_invoicedetails_status_mst"];
			GlobalVars.fieldToolTips["dbo_tp_invoicedetails_status_mst"] = fieldToolTipsArray["tp_invoicedetails_status_mst"];
			GlobalVars.placeHolders["dbo_tp_invoicedetails_status_mst"] = placeHoldersArray["tp_invoicedetails_status_mst"];
			GlobalVars.page_titles["dbo_tp_invoicedetails_status_mst"] = pageTitlesArray["tp_invoicedetails_status_mst"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.tp_invoicedetails_status_mst"));
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails_status_mst"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.tp_aptran_mst";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.tp_aptran_mst";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "tp_aptran_mst";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0]["masterKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0]["masterKeys"].Add("invoice_id");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0]["detailKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_status_mst"][0]["detailKeys"].Add("invoiceid");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "clientid,  	invoiceid,  	status,  	createdate,  	recorddate,  	total";
protoArray["0"]["m_strFrom"] = "FROM dbo.tp_invoicedetails_status_mst";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "order by createdate";
	
		
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
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["6"]["m_sql"] = "clientid";
protoArray["6"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "invoiceid", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["8"]["m_sql"] = "invoiceid";
protoArray["8"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "status", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["10"]["m_sql"] = "status";
protoArray["10"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "createdate", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["12"]["m_sql"] = "createdate";
protoArray["12"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "recorddate", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["14"]["m_sql"] = "recorddate";
protoArray["14"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "total", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["16"]["m_sql"] = "total";
protoArray["16"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["19"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("clientid");
protoArray["19"]["m_columns"].Add("invoiceid");
protoArray["19"]["m_columns"].Add("status");
protoArray["19"]["m_columns"].Add("createdate");
protoArray["19"]["m_columns"].Add("recorddate");
protoArray["19"]["m_columns"].Add("total");
protoArray["19"]["m_columns"].Add("vendnum");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.tp_invoicedetails_status_mst";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
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
protoArray["22"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "createdate", "m_strTable", "dbo.tp_invoicedetails_status_mst", "m_srcTableName", "dbo.tp_invoicedetails_status_mst"));

protoArray["22"]["m_column"] = obj;
protoArray["22"]["m_bAsc"] = 1;
protoArray["22"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["22"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "dbo.tp_invoicedetails_status_mst";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["tp_invoicedetails_status_mst"] = obj;

				
		
			tdataArray["tp_invoicedetails_status_mst"][".sqlquery"] = queryData_Array["tp_invoicedetails_status_mst"];
			tdataArray["tp_invoicedetails_status_mst"][".hasEvents"] = false;
		}
	}

}
