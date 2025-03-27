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
	public static partial class Settings_tp_invoicedetails_dist_mst
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".ShortName"] = "tp_invoicedetails_dist_mst";
			tdataArray["tp_invoicedetails_dist_mst"][".OwnerID"] = "clientid";
			tdataArray["tp_invoicedetails_dist_mst"][".OriginalTable"] = "dbo.tp_invoicedetails_dist_mst";
			tdataArray["tp_invoicedetails_dist_mst"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["tp_invoicedetails_dist_mst"][".originalPagesByType"] = tdataArray["tp_invoicedetails_dist_mst"][".pagesByType"];
			tdataArray["tp_invoicedetails_dist_mst"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["tp_invoicedetails_dist_mst"][".originalPages"] = tdataArray["tp_invoicedetails_dist_mst"][".pages"];
			tdataArray["tp_invoicedetails_dist_mst"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["tp_invoicedetails_dist_mst"][".originalDefaultPages"] = tdataArray["tp_invoicedetails_dist_mst"][".defaultPages"];
			fieldLabelsArray["tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			fieldToolTipsArray["tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			pageTitlesArray["tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			placeHoldersArray["tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["tp_invoicedetails_dist_mst"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["tp_invoicedetails_dist_mst"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["tp_invoicedetails_dist_mst"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["tp_invoicedetails_dist_mst"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"]["clientid"] = "";
				placeHoldersArray["tp_invoicedetails_dist_mst"]["English"]["clientid"] = "";
				fieldLabelsArray["tp_invoicedetails_dist_mst"]["English"]["invoiceid"] = "Invoiceid";
				fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"]["invoiceid"] = "";
				placeHoldersArray["tp_invoicedetails_dist_mst"]["English"]["invoiceid"] = "";
				fieldLabelsArray["tp_invoicedetails_dist_mst"]["English"]["po"] = "Po";
				fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"]["po"] = "";
				placeHoldersArray["tp_invoicedetails_dist_mst"]["English"]["po"] = "";
				fieldLabelsArray["tp_invoicedetails_dist_mst"]["English"]["createdate"] = "Createdate";
				fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"]["createdate"] = "";
				placeHoldersArray["tp_invoicedetails_dist_mst"]["English"]["createdate"] = "";
				fieldLabelsArray["tp_invoicedetails_dist_mst"]["English"]["recorddate"] = "Recorddate";
				fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"]["recorddate"] = "";
				placeHoldersArray["tp_invoicedetails_dist_mst"]["English"]["recorddate"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["tp_invoicedetails_dist_mst"]["English"])))
				{
					tdataArray["tp_invoicedetails_dist_mst"][".isUseToolTips"] = true;
				}
			}
			tdataArray["tp_invoicedetails_dist_mst"][".NCSearch"] = true;
			tdataArray["tp_invoicedetails_dist_mst"][".shortTableName"] = "tp_invoicedetails_dist_mst";
			tdataArray["tp_invoicedetails_dist_mst"][".nSecOptions"] = 1;
			tdataArray["tp_invoicedetails_dist_mst"][".mainTableOwnerID"] = "clientid";
			tdataArray["tp_invoicedetails_dist_mst"][".entityType"] = 0;
			tdataArray["tp_invoicedetails_dist_mst"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["tp_invoicedetails_dist_mst"][".strOriginalTableName"] = "dbo.tp_invoicedetails_dist_mst";
			tdataArray["tp_invoicedetails_dist_mst"][".showAddInPopup"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".showEditInPopup"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".showViewInPopup"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".listAjax"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".audit"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".locking"] = false;
			GlobalVars.pages = tdataArray["tp_invoicedetails_dist_mst"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".edit"] = true;
				tdataArray["tp_invoicedetails_dist_mst"][".afterEditAction"] = 1;
				tdataArray["tp_invoicedetails_dist_mst"][".closePopupAfterEdit"] = 1;
				tdataArray["tp_invoicedetails_dist_mst"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".add"] = true;
				tdataArray["tp_invoicedetails_dist_mst"][".afterAddAction"] = 1;
				tdataArray["tp_invoicedetails_dist_mst"][".closePopupAfterAdd"] = 1;
				tdataArray["tp_invoicedetails_dist_mst"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".list"] = true;
			}
			tdataArray["tp_invoicedetails_dist_mst"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["tp_invoicedetails_dist_mst"][".printFriendly"] = true;
			}
			tdataArray["tp_invoicedetails_dist_mst"][".showSimpleSearchOptions"] = true;
			tdataArray["tp_invoicedetails_dist_mst"][".allowShowHideFields"] = true;
			tdataArray["tp_invoicedetails_dist_mst"][".allowFieldsReordering"] = true;
			tdataArray["tp_invoicedetails_dist_mst"][".isUseAjaxSuggest"] = true;


			tdataArray["tp_invoicedetails_dist_mst"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".buttonsAdded"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".addPageEvents"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".isUseTimeForSearch"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".badgeColor"] = "2f4f4f";
			tdataArray["tp_invoicedetails_dist_mst"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".googleLikeFields"].Add("clientid");
			tdataArray["tp_invoicedetails_dist_mst"][".googleLikeFields"].Add("invoiceid");
			tdataArray["tp_invoicedetails_dist_mst"][".googleLikeFields"].Add("po");
			tdataArray["tp_invoicedetails_dist_mst"][".googleLikeFields"].Add("createdate");
			tdataArray["tp_invoicedetails_dist_mst"][".googleLikeFields"].Add("recorddate");
			tdataArray["tp_invoicedetails_dist_mst"][".tableType"] = "list";
			tdataArray["tp_invoicedetails_dist_mst"][".printerPageOrientation"] = 0;
			tdataArray["tp_invoicedetails_dist_mst"][".nPrinterPageScale"] = 100;
			tdataArray["tp_invoicedetails_dist_mst"][".nPrinterSplitRecords"] = 40;
			tdataArray["tp_invoicedetails_dist_mst"][".geocodingEnabled"] = false;
			tdataArray["tp_invoicedetails_dist_mst"][".pageSize"] = 20;
			tdataArray["tp_invoicedetails_dist_mst"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["tp_invoicedetails_dist_mst"][".strOrderBy"] = tstrOrderBy;
			tdataArray["tp_invoicedetails_dist_mst"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".sqlHead"] = "SELECT clientid,  	invoiceid,  	po,  	createdate,  	recorddate";
			tdataArray["tp_invoicedetails_dist_mst"][".sqlFrom"] = "FROM dbo.tp_invoicedetails_dist_mst";
			tdataArray["tp_invoicedetails_dist_mst"][".sqlWhereExpr"] = "";
			tdataArray["tp_invoicedetails_dist_mst"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["tp_invoicedetails_dist_mst"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["tp_invoicedetails_dist_mst"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["tp_invoicedetails_dist_mst"][".highlightSearchResults"] = true;
			tableKeysArray["tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			tdataArray["tp_invoicedetails_dist_mst"][".Keys"] = tableKeysArray["tp_invoicedetails_dist_mst"];
			tdataArray["tp_invoicedetails_dist_mst"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_dist_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_dist_mst","clientid");
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
			tdataArray["tp_invoicedetails_dist_mst"]["clientid"] = fdata;
			tdataArray["tp_invoicedetails_dist_mst"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "invoiceid";
			fdata["GoodName"] = "invoiceid";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_dist_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_dist_mst","invoiceid");
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
			tdataArray["tp_invoicedetails_dist_mst"]["invoiceid"] = fdata;
			tdataArray["tp_invoicedetails_dist_mst"][".searchableFields"].Add("invoiceid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "po";
			fdata["GoodName"] = "po";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_dist_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_dist_mst","po");
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
			tdataArray["tp_invoicedetails_dist_mst"]["po"] = fdata;
			tdataArray["tp_invoicedetails_dist_mst"][".searchableFields"].Add("po");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "createdate";
			fdata["GoodName"] = "createdate";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_dist_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_dist_mst","createdate");
			fdata["FieldType"] = 135;
			fdata["strField"] = "createdate";
			fdata["sourceSingle"] = "createdate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "createdate";
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
			tdataArray["tp_invoicedetails_dist_mst"]["createdate"] = fdata;
			tdataArray["tp_invoicedetails_dist_mst"][".searchableFields"].Add("createdate");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "recorddate";
			fdata["GoodName"] = "recorddate";
			fdata["ownerTable"] = "dbo.tp_invoicedetails_dist_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoicedetails_dist_mst","recorddate");
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
			tdataArray["tp_invoicedetails_dist_mst"]["recorddate"] = fdata;
			tdataArray["tp_invoicedetails_dist_mst"][".searchableFields"].Add("recorddate");
			GlobalVars.tables_data["dbo.tp_invoicedetails_dist_mst"] = tdataArray["tp_invoicedetails_dist_mst"];
			GlobalVars.field_labels["dbo_tp_invoicedetails_dist_mst"] = fieldLabelsArray["tp_invoicedetails_dist_mst"];
			GlobalVars.fieldToolTips["dbo_tp_invoicedetails_dist_mst"] = fieldToolTipsArray["tp_invoicedetails_dist_mst"];
			GlobalVars.placeHolders["dbo_tp_invoicedetails_dist_mst"] = placeHoldersArray["tp_invoicedetails_dist_mst"];
			GlobalVars.page_titles["dbo_tp_invoicedetails_dist_mst"] = pageTitlesArray["tp_invoicedetails_dist_mst"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.tp_invoicedetails_dist_mst"));
			GlobalVars.detailsTablesData["dbo.tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.tp_invoicedetails_mst";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.tp_invoicedetails_mst";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "tp_invoicedetails_mst";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0]["masterKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0]["masterKeys"].Add("invoiceid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0]["detailKeys"].Add("clientid");
			GlobalVars.masterTablesData["dbo.tp_invoicedetails_dist_mst"][0]["detailKeys"].Add("invoiceid");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "clientid,  	invoiceid,  	po,  	createdate,  	recorddate";
protoArray["0"]["m_strFrom"] = "FROM dbo.tp_invoicedetails_dist_mst";
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
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.tp_invoicedetails_dist_mst", "m_srcTableName", "dbo.tp_invoicedetails_dist_mst"));

protoArray["6"]["m_sql"] = "clientid";
protoArray["6"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "invoiceid", "m_strTable", "dbo.tp_invoicedetails_dist_mst", "m_srcTableName", "dbo.tp_invoicedetails_dist_mst"));

protoArray["8"]["m_sql"] = "invoiceid";
protoArray["8"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "po", "m_strTable", "dbo.tp_invoicedetails_dist_mst", "m_srcTableName", "dbo.tp_invoicedetails_dist_mst"));

protoArray["10"]["m_sql"] = "po";
protoArray["10"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "createdate", "m_strTable", "dbo.tp_invoicedetails_dist_mst", "m_srcTableName", "dbo.tp_invoicedetails_dist_mst"));

protoArray["12"]["m_sql"] = "createdate";
protoArray["12"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "recorddate", "m_strTable", "dbo.tp_invoicedetails_dist_mst", "m_srcTableName", "dbo.tp_invoicedetails_dist_mst"));

protoArray["14"]["m_sql"] = "recorddate";
protoArray["14"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["17"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("clientid");
protoArray["17"]["m_columns"].Add("invoiceid");
protoArray["17"]["m_columns"].Add("po");
protoArray["17"]["m_columns"].Add("createdate");
protoArray["17"]["m_columns"].Add("recorddate");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.tp_invoicedetails_dist_mst";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
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
protoArray["0"]["m_srcTableName"] = "dbo.tp_invoicedetails_dist_mst";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["tp_invoicedetails_dist_mst"] = obj;

				
		
			tdataArray["tp_invoicedetails_dist_mst"][".sqlquery"] = queryData_Array["tp_invoicedetails_dist_mst"];
			tdataArray["tp_invoicedetails_dist_mst"][".hasEvents"] = false;
		}
	}

}
