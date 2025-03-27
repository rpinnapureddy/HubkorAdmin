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
	public static partial class Settings_tp_invoicedetails
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".ShortName"] = "tp_invoicedetails";
			tdataArray["tp_invoicedetails"][".OwnerID"] = "clientid";
			tdataArray["tp_invoicedetails"][".OriginalTable"] = "dbo.tp_invoicedetails";
			tdataArray["tp_invoicedetails"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["tp_invoicedetails"][".originalPagesByType"] = tdataArray["tp_invoicedetails"][".pagesByType"];
			tdataArray["tp_invoicedetails"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["tp_invoicedetails"][".originalPages"] = tdataArray["tp_invoicedetails"][".pages"];
			tdataArray["tp_invoicedetails"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["tp_invoicedetails"][".originalDefaultPages"] = tdataArray["tp_invoicedetails"][".defaultPages"];
			fieldLabelsArray["tp_invoicedetails"] = SettingsMap.GetArray();
			fieldToolTipsArray["tp_invoicedetails"] = SettingsMap.GetArray();
			pageTitlesArray["tp_invoicedetails"] = SettingsMap.GetArray();
			placeHoldersArray["tp_invoicedetails"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["tp_invoicedetails"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["tp_invoicedetails"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["tp_invoicedetails"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["tp_invoicedetails"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["tp_invoicedetails"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["clientid"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["clientid"] = "";
				fieldLabelsArray["tp_invoicedetails"]["English"]["po"] = "Po";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["po"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["po"] = "";
				fieldLabelsArray["tp_invoicedetails"]["English"]["invoicestatus"] = "Invoicestatus";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["invoicestatus"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["invoicestatus"] = "";
				fieldLabelsArray["tp_invoicedetails"]["English"]["invoiceid"] = "Invoiceid";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["invoiceid"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["invoiceid"] = "";
				fieldLabelsArray["tp_invoicedetails"]["English"]["vendinv"] = "Vendinv";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["vendinv"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["vendinv"] = "";
				fieldLabelsArray["tp_invoicedetails"]["English"]["total"] = "Total";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["total"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["total"] = "";
				fieldLabelsArray["tp_invoicedetails"]["English"]["vendnum"] = "Vendnum";
				fieldToolTipsArray["tp_invoicedetails"]["English"]["vendnum"] = "";
				placeHoldersArray["tp_invoicedetails"]["English"]["vendnum"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["tp_invoicedetails"]["English"])))
				{
					tdataArray["tp_invoicedetails"][".isUseToolTips"] = true;
				}
			}
			tdataArray["tp_invoicedetails"][".NCSearch"] = true;
			tdataArray["tp_invoicedetails"][".shortTableName"] = "tp_invoicedetails";
			tdataArray["tp_invoicedetails"][".nSecOptions"] = 1;
			tdataArray["tp_invoicedetails"][".mainTableOwnerID"] = "clientid";
			tdataArray["tp_invoicedetails"][".entityType"] = 0;
			tdataArray["tp_invoicedetails"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["tp_invoicedetails"][".strOriginalTableName"] = "dbo.tp_invoicedetails";
			tdataArray["tp_invoicedetails"][".showAddInPopup"] = false;
			tdataArray["tp_invoicedetails"][".showEditInPopup"] = false;
			tdataArray["tp_invoicedetails"][".showViewInPopup"] = false;
			tdataArray["tp_invoicedetails"][".listAjax"] = false;
			tdataArray["tp_invoicedetails"][".audit"] = false;
			tdataArray["tp_invoicedetails"][".locking"] = false;
			GlobalVars.pages = tdataArray["tp_invoicedetails"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["tp_invoicedetails"][".edit"] = true;
				tdataArray["tp_invoicedetails"][".afterEditAction"] = 1;
				tdataArray["tp_invoicedetails"][".closePopupAfterEdit"] = 1;
				tdataArray["tp_invoicedetails"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["tp_invoicedetails"][".add"] = true;
				tdataArray["tp_invoicedetails"][".afterAddAction"] = 1;
				tdataArray["tp_invoicedetails"][".closePopupAfterAdd"] = 1;
				tdataArray["tp_invoicedetails"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["tp_invoicedetails"][".list"] = true;
			}
			tdataArray["tp_invoicedetails"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["tp_invoicedetails"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["tp_invoicedetails"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["tp_invoicedetails"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["tp_invoicedetails"][".printFriendly"] = true;
			}
			tdataArray["tp_invoicedetails"][".showSimpleSearchOptions"] = true;
			tdataArray["tp_invoicedetails"][".allowShowHideFields"] = true;
			tdataArray["tp_invoicedetails"][".allowFieldsReordering"] = true;
			tdataArray["tp_invoicedetails"][".isUseAjaxSuggest"] = true;


			tdataArray["tp_invoicedetails"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["tp_invoicedetails"][".buttonsAdded"] = false;
			tdataArray["tp_invoicedetails"][".addPageEvents"] = false;
			tdataArray["tp_invoicedetails"][".isUseTimeForSearch"] = false;
			tdataArray["tp_invoicedetails"][".badgeColor"] = "d2af80";
			tdataArray["tp_invoicedetails"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("clientid");
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("po");
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("invoicestatus");
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("invoiceid");
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("vendinv");
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("total");
			tdataArray["tp_invoicedetails"][".googleLikeFields"].Add("vendnum");
			tdataArray["tp_invoicedetails"][".tableType"] = "list";
			tdataArray["tp_invoicedetails"][".printerPageOrientation"] = 0;
			tdataArray["tp_invoicedetails"][".nPrinterPageScale"] = 100;
			tdataArray["tp_invoicedetails"][".nPrinterSplitRecords"] = 40;
			tdataArray["tp_invoicedetails"][".geocodingEnabled"] = false;
			tdataArray["tp_invoicedetails"][".pageSize"] = 20;
			tdataArray["tp_invoicedetails"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["tp_invoicedetails"][".strOrderBy"] = tstrOrderBy;
			tdataArray["tp_invoicedetails"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".sqlHead"] = "SELECT clientid,  	po,  	invoicestatus,  	invoiceid,  	vendinv,  	total,  	vendnum";
			tdataArray["tp_invoicedetails"][".sqlFrom"] = "FROM dbo.tp_invoicedetails";
			tdataArray["tp_invoicedetails"][".sqlWhereExpr"] = "";
			tdataArray["tp_invoicedetails"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["tp_invoicedetails"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["tp_invoicedetails"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["tp_invoicedetails"][".highlightSearchResults"] = true;
			tableKeysArray["tp_invoicedetails"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails"][".Keys"] = tableKeysArray["tp_invoicedetails"];
			tdataArray["tp_invoicedetails"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","clientid");
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
			tdataArray["tp_invoicedetails"]["clientid"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "po";
			fdata["GoodName"] = "po";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","po");
			fdata["FieldType"] = 202;
			fdata["strField"] = "po";
			fdata["sourceSingle"] = "po";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "po";
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
			tdataArray["tp_invoicedetails"]["po"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("po");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "invoicestatus";
			fdata["GoodName"] = "invoicestatus";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","invoicestatus");
			fdata["FieldType"] = 202;
			fdata["strField"] = "invoicestatus";
			fdata["sourceSingle"] = "invoicestatus";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "invoicestatus";
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
			tdataArray["tp_invoicedetails"]["invoicestatus"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("invoicestatus");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "invoiceid";
			fdata["GoodName"] = "invoiceid";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","invoiceid");
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
			tdataArray["tp_invoicedetails"]["invoiceid"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("invoiceid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "vendinv";
			fdata["GoodName"] = "vendinv";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","vendinv");
			fdata["FieldType"] = 202;
			fdata["strField"] = "vendinv";
			fdata["sourceSingle"] = "vendinv";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "vendinv";
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
			tdataArray["tp_invoicedetails"]["vendinv"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("vendinv");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "total";
			fdata["GoodName"] = "total";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","total");
			fdata["FieldType"] = 14;
			fdata["strField"] = "total";
			fdata["sourceSingle"] = "total";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "total";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Number");
			vdata["DecimalDigits"] = 2;
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
			tdataArray["tp_invoicedetails"]["total"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("total");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "vendnum";
			fdata["GoodName"] = "vendnum";
			fdata["ownerTable"] = "dbo.tp_invoicedetails";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails","vendnum");
			fdata["FieldType"] = 202;
			fdata["strField"] = "vendnum";
			fdata["sourceSingle"] = "vendnum";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "vendnum";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=7");
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
			tdataArray["tp_invoicedetails"]["vendnum"] = fdata;
			tdataArray["tp_invoicedetails"][".searchableFields"].Add("vendnum");
			GlobalVars.tables_data["dbo.tp_invoicedetails"] = tdataArray["tp_invoicedetails"];
			GlobalVars.field_labels["dbo_tp_invoicedetails"] = fieldLabelsArray["tp_invoicedetails"];
			GlobalVars.fieldToolTips["dbo_tp_invoicedetails"] = fieldToolTipsArray["tp_invoicedetails"];
			GlobalVars.placeHolders["dbo_tp_invoicedetails"] = placeHoldersArray["tp_invoicedetails"];
			GlobalVars.page_titles["dbo_tp_invoicedetails"] = pageTitlesArray["tp_invoicedetails"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.tp_invoicedetails"));
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.tp_aptrandist_mst";
			detailsParam["dOriginalTable"] = "dbo.tp_aptrandist_mst";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "tp_aptrandist_mst";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_tp_aptrandist_mst"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex]["masterKeys"].Add("invoiceid");
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex]["masterKeys"].Add("clientid");
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex]["detailKeys"].Add("invoice_id");
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails"][dIndex]["detailKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.tp_po";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.tp_po";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "tp_po";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0]["masterKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0]["masterKeys"].Add("po_num");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0]["detailKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails"][0]["detailKeys"].Add("po");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "clientid,  	po,  	invoicestatus,  	invoiceid,  	vendinv,  	total,  	vendnum";
protoArray["0"]["m_strFrom"] = "FROM dbo.tp_invoicedetails";
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
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["6"]["m_sql"] = "clientid";
protoArray["6"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "po", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["8"]["m_sql"] = "po";
protoArray["8"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "invoicestatus", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["10"]["m_sql"] = "invoicestatus";
protoArray["10"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "invoiceid", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["12"]["m_sql"] = "invoiceid";
protoArray["12"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "vendinv", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["14"]["m_sql"] = "vendinv";
protoArray["14"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "total", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["16"]["m_sql"] = "total";
protoArray["16"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "vendnum", "m_strTable", "dbo.tp_invoicedetails", "m_srcTableName", "dbo.tp_invoicedetails"));

protoArray["18"]["m_sql"] = "vendnum";
protoArray["18"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_link"] = "SQLL_MAIN";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_strName"] = "dbo.tp_invoicedetails";
protoArray["21"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["21"]["m_columns"] = SettingsMap.GetArray();
protoArray["21"]["m_columns"].Add("clientid");
protoArray["21"]["m_columns"].Add("po");
protoArray["21"]["m_columns"].Add("invoicestatus");
protoArray["21"]["m_columns"].Add("invoiceid");
protoArray["21"]["m_columns"].Add("vendinv");
protoArray["21"]["m_columns"].Add("total");
protoArray["21"]["m_columns"].Add("vendnum");
obj = new SQLTable(protoArray["21"]);

protoArray["20"]["m_table"] = obj;
protoArray["20"]["m_sql"] = "dbo.tp_invoicedetails";
protoArray["20"]["m_alias"] = "";
protoArray["20"]["m_srcTableName"] = "dbo.tp_invoicedetails";
protoArray["22"] = SettingsMap.GetArray();
protoArray["22"]["m_sql"] = "";
protoArray["22"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["22"]["m_column"] = obj;
protoArray["22"]["m_contained"] = SettingsMap.GetArray();
protoArray["22"]["m_strCase"] = "";
protoArray["22"]["m_havingmode"] = false;
protoArray["22"]["m_inBrackets"] = false;
protoArray["22"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["22"]);

protoArray["20"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["20"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.tp_invoicedetails";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["tp_invoicedetails"] = obj;

				
		
			tdataArray["tp_invoicedetails"][".sqlquery"] = queryData_Array["tp_invoicedetails"];
			tdataArray["tp_invoicedetails"][".hasEvents"] = false;
		}
	}

}
