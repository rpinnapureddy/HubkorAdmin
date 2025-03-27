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
	public static partial class Settings_tp_payments_lines_mst
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".ShortName"] = "tp_payments_lines_mst";
			tdataArray["tp_payments_lines_mst"][".OwnerID"] = "clientid";
			tdataArray["tp_payments_lines_mst"][".OriginalTable"] = "dbo.tp_payments_lines_mst";
			tdataArray["tp_payments_lines_mst"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["tp_payments_lines_mst"][".originalPagesByType"] = tdataArray["tp_payments_lines_mst"][".pagesByType"];
			tdataArray["tp_payments_lines_mst"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["tp_payments_lines_mst"][".originalPages"] = tdataArray["tp_payments_lines_mst"][".pages"];
			tdataArray["tp_payments_lines_mst"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["tp_payments_lines_mst"][".originalDefaultPages"] = tdataArray["tp_payments_lines_mst"][".defaultPages"];
			fieldLabelsArray["tp_payments_lines_mst"] = SettingsMap.GetArray();
			fieldToolTipsArray["tp_payments_lines_mst"] = SettingsMap.GetArray();
			pageTitlesArray["tp_payments_lines_mst"] = SettingsMap.GetArray();
			placeHoldersArray["tp_payments_lines_mst"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["tp_payments_lines_mst"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["tp_payments_lines_mst"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["tp_payments_lines_mst"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["tp_payments_lines_mst"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["tp_payments_lines_mst"]["English"]["payment_id"] = "Payment Id";
				fieldToolTipsArray["tp_payments_lines_mst"]["English"]["payment_id"] = "";
				placeHoldersArray["tp_payments_lines_mst"]["English"]["payment_id"] = "";
				fieldLabelsArray["tp_payments_lines_mst"]["English"]["payment_amount"] = "Payment Amount";
				fieldToolTipsArray["tp_payments_lines_mst"]["English"]["payment_amount"] = "";
				placeHoldersArray["tp_payments_lines_mst"]["English"]["payment_amount"] = "";
				fieldLabelsArray["tp_payments_lines_mst"]["English"]["AP_Account_External_Id"] = "AP Account External Id";
				fieldToolTipsArray["tp_payments_lines_mst"]["English"]["AP_Account_External_Id"] = "";
				placeHoldersArray["tp_payments_lines_mst"]["English"]["AP_Account_External_Id"] = "";
				fieldLabelsArray["tp_payments_lines_mst"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["tp_payments_lines_mst"]["English"]["clientid"] = "";
				placeHoldersArray["tp_payments_lines_mst"]["English"]["clientid"] = "";
				fieldLabelsArray["tp_payments_lines_mst"]["English"]["trans_num"] = "Trans Num";
				fieldToolTipsArray["tp_payments_lines_mst"]["English"]["trans_num"] = "";
				placeHoldersArray["tp_payments_lines_mst"]["English"]["trans_num"] = "";
				fieldLabelsArray["tp_payments_lines_mst"]["English"]["site_ref"] = "Site Ref";
				fieldToolTipsArray["tp_payments_lines_mst"]["English"]["site_ref"] = "";
				placeHoldersArray["tp_payments_lines_mst"]["English"]["site_ref"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["tp_payments_lines_mst"]["English"])))
				{
					tdataArray["tp_payments_lines_mst"][".isUseToolTips"] = true;
				}
			}
			tdataArray["tp_payments_lines_mst"][".NCSearch"] = true;
			tdataArray["tp_payments_lines_mst"][".shortTableName"] = "tp_payments_lines_mst";
			tdataArray["tp_payments_lines_mst"][".nSecOptions"] = 1;
			tdataArray["tp_payments_lines_mst"][".mainTableOwnerID"] = "clientid";
			tdataArray["tp_payments_lines_mst"][".entityType"] = 0;
			tdataArray["tp_payments_lines_mst"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["tp_payments_lines_mst"][".strOriginalTableName"] = "dbo.tp_payments_lines_mst";
			tdataArray["tp_payments_lines_mst"][".showAddInPopup"] = false;
			tdataArray["tp_payments_lines_mst"][".showEditInPopup"] = false;
			tdataArray["tp_payments_lines_mst"][".showViewInPopup"] = false;
			tdataArray["tp_payments_lines_mst"][".listAjax"] = false;
			tdataArray["tp_payments_lines_mst"][".audit"] = false;
			tdataArray["tp_payments_lines_mst"][".locking"] = false;
			GlobalVars.pages = tdataArray["tp_payments_lines_mst"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["tp_payments_lines_mst"][".edit"] = true;
				tdataArray["tp_payments_lines_mst"][".afterEditAction"] = 1;
				tdataArray["tp_payments_lines_mst"][".closePopupAfterEdit"] = 1;
				tdataArray["tp_payments_lines_mst"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["tp_payments_lines_mst"][".add"] = true;
				tdataArray["tp_payments_lines_mst"][".afterAddAction"] = 1;
				tdataArray["tp_payments_lines_mst"][".closePopupAfterAdd"] = 1;
				tdataArray["tp_payments_lines_mst"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["tp_payments_lines_mst"][".list"] = true;
			}
			tdataArray["tp_payments_lines_mst"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["tp_payments_lines_mst"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["tp_payments_lines_mst"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["tp_payments_lines_mst"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["tp_payments_lines_mst"][".printFriendly"] = true;
			}
			tdataArray["tp_payments_lines_mst"][".showSimpleSearchOptions"] = true;
			tdataArray["tp_payments_lines_mst"][".allowShowHideFields"] = true;
			tdataArray["tp_payments_lines_mst"][".allowFieldsReordering"] = true;
			tdataArray["tp_payments_lines_mst"][".isUseAjaxSuggest"] = true;


			tdataArray["tp_payments_lines_mst"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["tp_payments_lines_mst"][".buttonsAdded"] = false;
			tdataArray["tp_payments_lines_mst"][".addPageEvents"] = false;
			tdataArray["tp_payments_lines_mst"][".isUseTimeForSearch"] = false;
			tdataArray["tp_payments_lines_mst"][".badgeColor"] = "6b8e23";
			tdataArray["tp_payments_lines_mst"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"].Add("payment_id");
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"].Add("payment_amount");
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"].Add("AP_Account_External_Id");
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"].Add("clientid");
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"].Add("trans_num");
			tdataArray["tp_payments_lines_mst"][".googleLikeFields"].Add("site_ref");
			tdataArray["tp_payments_lines_mst"][".tableType"] = "list";
			tdataArray["tp_payments_lines_mst"][".printerPageOrientation"] = 0;
			tdataArray["tp_payments_lines_mst"][".nPrinterPageScale"] = 100;
			tdataArray["tp_payments_lines_mst"][".nPrinterSplitRecords"] = 40;
			tdataArray["tp_payments_lines_mst"][".geocodingEnabled"] = false;
			tdataArray["tp_payments_lines_mst"][".pageSize"] = 20;
			tdataArray["tp_payments_lines_mst"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["tp_payments_lines_mst"][".strOrderBy"] = tstrOrderBy;
			tdataArray["tp_payments_lines_mst"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".sqlHead"] = "SELECT payment_id,  	payment_amount,  	AP_Account_External_Id,  	clientid,  	trans_num,  	site_ref";
			tdataArray["tp_payments_lines_mst"][".sqlFrom"] = "FROM dbo.tp_payments_lines_mst";
			tdataArray["tp_payments_lines_mst"][".sqlWhereExpr"] = "";
			tdataArray["tp_payments_lines_mst"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["tp_payments_lines_mst"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["tp_payments_lines_mst"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["tp_payments_lines_mst"][".highlightSearchResults"] = true;
			tableKeysArray["tp_payments_lines_mst"] = SettingsMap.GetArray();
			tdataArray["tp_payments_lines_mst"][".Keys"] = tableKeysArray["tp_payments_lines_mst"];
			tdataArray["tp_payments_lines_mst"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "payment_id";
			fdata["GoodName"] = "payment_id";
			fdata["ownerTable"] = "dbo.tp_payments_lines_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_payments_lines_mst","payment_id");
			fdata["FieldType"] = 202;
			fdata["strField"] = "payment_id";
			fdata["sourceSingle"] = "payment_id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "payment_id";
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
			tdataArray["tp_payments_lines_mst"]["payment_id"] = fdata;
			tdataArray["tp_payments_lines_mst"][".searchableFields"].Add("payment_id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "payment_amount";
			fdata["GoodName"] = "payment_amount";
			fdata["ownerTable"] = "dbo.tp_payments_lines_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_payments_lines_mst","payment_amount");
			fdata["FieldType"] = 202;
			fdata["strField"] = "payment_amount";
			fdata["sourceSingle"] = "payment_amount";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "payment_amount";
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
			tdataArray["tp_payments_lines_mst"]["payment_amount"] = fdata;
			tdataArray["tp_payments_lines_mst"][".searchableFields"].Add("payment_amount");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "AP_Account_External_Id";
			fdata["GoodName"] = "AP_Account_External_Id";
			fdata["ownerTable"] = "dbo.tp_payments_lines_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_payments_lines_mst","AP_Account_External_Id");
			fdata["FieldType"] = 202;
			fdata["strField"] = "AP_Account_External_Id";
			fdata["sourceSingle"] = "AP_Account_External_Id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "AP_Account_External_Id";
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
			tdataArray["tp_payments_lines_mst"]["AP_Account_External_Id"] = fdata;
			tdataArray["tp_payments_lines_mst"][".searchableFields"].Add("AP_Account_External_Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.tp_payments_lines_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_payments_lines_mst","clientid");
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
			tdataArray["tp_payments_lines_mst"]["clientid"] = fdata;
			tdataArray["tp_payments_lines_mst"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "trans_num";
			fdata["GoodName"] = "trans_num";
			fdata["ownerTable"] = "dbo.tp_payments_lines_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_payments_lines_mst","trans_num");
			fdata["FieldType"] = 20;
			fdata["strField"] = "trans_num";
			fdata["sourceSingle"] = "trans_num";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "trans_num";
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
			tdataArray["tp_payments_lines_mst"]["trans_num"] = fdata;
			tdataArray["tp_payments_lines_mst"][".searchableFields"].Add("trans_num");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "site_ref";
			fdata["GoodName"] = "site_ref";
			fdata["ownerTable"] = "dbo.tp_payments_lines_mst";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_payments_lines_mst","site_ref");
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
			tdataArray["tp_payments_lines_mst"]["site_ref"] = fdata;
			tdataArray["tp_payments_lines_mst"][".searchableFields"].Add("site_ref");
			GlobalVars.tables_data["dbo.tp_payments_lines_mst"] = tdataArray["tp_payments_lines_mst"];
			GlobalVars.field_labels["dbo_tp_payments_lines_mst"] = fieldLabelsArray["tp_payments_lines_mst"];
			GlobalVars.fieldToolTips["dbo_tp_payments_lines_mst"] = fieldToolTipsArray["tp_payments_lines_mst"];
			GlobalVars.placeHolders["dbo_tp_payments_lines_mst"] = placeHoldersArray["tp_payments_lines_mst"];
			GlobalVars.page_titles["dbo_tp_payments_lines_mst"] = pageTitlesArray["tp_payments_lines_mst"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.tp_payments_lines_mst"));
			GlobalVars.detailsTablesData["dbo.tp_payments_lines_mst"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.tp_payments_hdr_mst";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.tp_payments_hdr_mst";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "tp_payments_hdr_mst";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][0]["masterKeys"].Add("trans_num");
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][0]["detailKeys"].Add("trans_num");


			strOriginalDetailsTable = "dbo.tp_aptran_mst";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.tp_aptran_mst";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "tp_aptran_mst";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][1] = masterParams;
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][1]["masterKeys"].Add("invoice_id");
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_payments_lines_mst"][1]["detailKeys"].Add("payment_id");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "payment_id,  	payment_amount,  	AP_Account_External_Id,  	clientid,  	trans_num,  	site_ref";
protoArray["0"]["m_strFrom"] = "FROM dbo.tp_payments_lines_mst";
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
obj = new SQLField(new XVar("m_strName", "payment_id", "m_strTable", "dbo.tp_payments_lines_mst", "m_srcTableName", "dbo.tp_payments_lines_mst"));

protoArray["6"]["m_sql"] = "payment_id";
protoArray["6"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "payment_amount", "m_strTable", "dbo.tp_payments_lines_mst", "m_srcTableName", "dbo.tp_payments_lines_mst"));

protoArray["8"]["m_sql"] = "payment_amount";
protoArray["8"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "AP_Account_External_Id", "m_strTable", "dbo.tp_payments_lines_mst", "m_srcTableName", "dbo.tp_payments_lines_mst"));

protoArray["10"]["m_sql"] = "AP_Account_External_Id";
protoArray["10"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.tp_payments_lines_mst", "m_srcTableName", "dbo.tp_payments_lines_mst"));

protoArray["12"]["m_sql"] = "clientid";
protoArray["12"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "trans_num", "m_strTable", "dbo.tp_payments_lines_mst", "m_srcTableName", "dbo.tp_payments_lines_mst"));

protoArray["14"]["m_sql"] = "trans_num";
protoArray["14"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "site_ref", "m_strTable", "dbo.tp_payments_lines_mst", "m_srcTableName", "dbo.tp_payments_lines_mst"));

protoArray["16"]["m_sql"] = "site_ref";
protoArray["16"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.tp_payments_lines_mst";
protoArray["19"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("payment_id");
protoArray["19"]["m_columns"].Add("payment_amount");
protoArray["19"]["m_columns"].Add("AP_Account_External_Id");
protoArray["19"]["m_columns"].Add("clientid");
protoArray["19"]["m_columns"].Add("trans_num");
protoArray["19"]["m_columns"].Add("site_ref");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.tp_payments_lines_mst";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
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
protoArray["0"]["m_srcTableName"] = "dbo.tp_payments_lines_mst";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["tp_payments_lines_mst"] = obj;

				
		
			tdataArray["tp_payments_lines_mst"][".sqlquery"] = queryData_Array["tp_payments_lines_mst"];
			tdataArray["tp_payments_lines_mst"][".hasEvents"] = false;
		}
	}

}
