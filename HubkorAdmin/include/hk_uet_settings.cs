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
	public static partial class Settings_hk_uet
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_uet"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".ShortName"] = "hk_uet";
			tdataArray["hk_uet"][".OwnerID"] = "clientid";
			tdataArray["hk_uet"][".OriginalTable"] = "dbo.hk_uet";
			tdataArray["hk_uet"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["hk_uet"][".originalPagesByType"] = tdataArray["hk_uet"][".pagesByType"];
			tdataArray["hk_uet"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["hk_uet"][".originalPages"] = tdataArray["hk_uet"][".pages"];
			tdataArray["hk_uet"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["hk_uet"][".originalDefaultPages"] = tdataArray["hk_uet"][".defaultPages"];
			fieldLabelsArray["hk_uet"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_uet"] = SettingsMap.GetArray();
			pageTitlesArray["hk_uet"] = SettingsMap.GetArray();
			placeHoldersArray["hk_uet"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_uet"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_uet"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_uet"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_uet"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_uet"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["hk_uet"]["English"]["clientid"] = "";
				placeHoldersArray["hk_uet"]["English"]["clientid"] = "";
				fieldLabelsArray["hk_uet"]["English"]["table"] = "Table";
				fieldToolTipsArray["hk_uet"]["English"]["table"] = "";
				placeHoldersArray["hk_uet"]["English"]["table"] = "";
				fieldLabelsArray["hk_uet"]["English"]["field_to"] = "Field To";
				fieldToolTipsArray["hk_uet"]["English"]["field_to"] = "";
				placeHoldersArray["hk_uet"]["English"]["field_to"] = "";
				fieldLabelsArray["hk_uet"]["English"]["field"] = "Field";
				fieldToolTipsArray["hk_uet"]["English"]["field"] = "";
				placeHoldersArray["hk_uet"]["English"]["field"] = "";
				fieldLabelsArray["hk_uet"]["English"]["int"] = "Int";
				fieldToolTipsArray["hk_uet"]["English"]["int"] = "";
				placeHoldersArray["hk_uet"]["English"]["int"] = "";
				fieldLabelsArray["hk_uet"]["English"]["rowpointer"] = "Rowpointer";
				fieldToolTipsArray["hk_uet"]["English"]["rowpointer"] = "";
				placeHoldersArray["hk_uet"]["English"]["rowpointer"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_uet"]["English"])))
				{
					tdataArray["hk_uet"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_uet"][".NCSearch"] = true;
			tdataArray["hk_uet"][".shortTableName"] = "hk_uet";
			tdataArray["hk_uet"][".nSecOptions"] = 1;
			tdataArray["hk_uet"][".mainTableOwnerID"] = "clientid";
			tdataArray["hk_uet"][".entityType"] = 0;
			tdataArray["hk_uet"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_uet"][".strOriginalTableName"] = "dbo.hk_uet";
			tdataArray["hk_uet"][".showAddInPopup"] = false;
			tdataArray["hk_uet"][".showEditInPopup"] = false;
			tdataArray["hk_uet"][".showViewInPopup"] = false;
			tdataArray["hk_uet"][".listAjax"] = false;
			tdataArray["hk_uet"][".audit"] = true;
			tdataArray["hk_uet"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_uet"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_uet"][".edit"] = true;
				tdataArray["hk_uet"][".afterEditAction"] = 1;
				tdataArray["hk_uet"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_uet"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_uet"][".add"] = true;
				tdataArray["hk_uet"][".afterAddAction"] = 1;
				tdataArray["hk_uet"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_uet"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_uet"][".list"] = true;
			}
			tdataArray["hk_uet"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_uet"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_uet"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_uet"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_uet"][".printFriendly"] = true;
			}
			tdataArray["hk_uet"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_uet"][".allowShowHideFields"] = true;
			tdataArray["hk_uet"][".allowFieldsReordering"] = true;
			tdataArray["hk_uet"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_uet"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_uet"][".buttonsAdded"] = false;
			tdataArray["hk_uet"][".addPageEvents"] = false;
			tdataArray["hk_uet"][".isUseTimeForSearch"] = false;
			tdataArray["hk_uet"][".badgeColor"] = "7b68ee";
			tdataArray["hk_uet"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".googleLikeFields"].Add("clientid");
			tdataArray["hk_uet"][".googleLikeFields"].Add("table");
			tdataArray["hk_uet"][".googleLikeFields"].Add("field_to");
			tdataArray["hk_uet"][".googleLikeFields"].Add("field");
			tdataArray["hk_uet"][".googleLikeFields"].Add("int");
			tdataArray["hk_uet"][".googleLikeFields"].Add("rowpointer");
			tdataArray["hk_uet"][".tableType"] = "list";
			tdataArray["hk_uet"][".printerPageOrientation"] = 0;
			tdataArray["hk_uet"][".nPrinterPageScale"] = 100;
			tdataArray["hk_uet"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_uet"][".geocodingEnabled"] = false;
			tdataArray["hk_uet"][".pageSize"] = 20;
			tdataArray["hk_uet"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["hk_uet"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_uet"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_uet"][".sqlHead"] = "SELECT clientid,  	[table],  	field_to,  	field,  	[int],  	rowpointer";
			tdataArray["hk_uet"][".sqlFrom"] = "FROM dbo.hk_uet";
			tdataArray["hk_uet"][".sqlWhereExpr"] = "";
			tdataArray["hk_uet"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_uet"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_uet"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_uet"][".highlightSearchResults"] = true;
			tableKeysArray["hk_uet"] = SettingsMap.GetArray();
			tableKeysArray["hk_uet"].Add("clientid");
			tableKeysArray["hk_uet"].Add("table");
			tableKeysArray["hk_uet"].Add("field_to");
			tdataArray["hk_uet"][".Keys"] = tableKeysArray["hk_uet"];
			tdataArray["hk_uet"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.hk_uet";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_uet","clientid");
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
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.clients";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "shortcode";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "shortcode";
			edata["LookupOrderBy"] = "shortcode";
			edata["SelectSize"] = 1;
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
			tdataArray["hk_uet"]["clientid"] = fdata;
			tdataArray["hk_uet"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "table";
			fdata["GoodName"] = "table";
			fdata["ownerTable"] = "dbo.hk_uet";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_uet","table");
			fdata["FieldType"] = 202;
			fdata["strField"] = "table";
			fdata["sourceSingle"] = "table";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[table]";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.hk_csi_uet_tables";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Expr1";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "Expr1";
			edata["LookupOrderBy"] = "Expr1";
			edata["DependentLookups"] = SettingsMap.GetArray();
			edata["DependentLookups"].Add("field_to");
			edata["SelectSize"] = 1;
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
			tdataArray["hk_uet"]["table"] = fdata;
			tdataArray["hk_uet"][".searchableFields"].Add("table");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "field_to";
			fdata["GoodName"] = "field_to";
			fdata["ownerTable"] = "dbo.hk_uet";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_uet","field_to");
			fdata["FieldType"] = 202;
			fdata["strField"] = "field_to";
			fdata["sourceSingle"] = "field_to";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "field_to";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.hk_csi_uet_fields";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "COLUMN_NAME";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "COLUMN_NAME";
			edata["LookupOrderBy"] = "Expr2";
			edata["UseCategory"] = true;
			edata["categoryFields"] = SettingsMap.GetArray();
			edata["categoryFields"].Add(new XVar("main", "table", "lookup", "Expr1"));
			edata["SelectSize"] = 1;
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
			tdataArray["hk_uet"]["field_to"] = fdata;
			tdataArray["hk_uet"][".searchableFields"].Add("field_to");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "field";
			fdata["GoodName"] = "field";
			fdata["ownerTable"] = "dbo.hk_uet";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_uet","field");
			fdata["FieldType"] = 202;
			fdata["strField"] = "field";
			fdata["sourceSingle"] = "field";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "field";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=20");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["hk_uet"]["field"] = fdata;
			tdataArray["hk_uet"][".searchableFields"].Add("field");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "int";
			fdata["GoodName"] = "int";
			fdata["ownerTable"] = "dbo.hk_uet";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_uet","int");
			fdata["FieldType"] = 3;
			fdata["strField"] = "int";
			fdata["sourceSingle"] = "int";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[int]";
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
			tdataArray["hk_uet"]["int"] = fdata;
			tdataArray["hk_uet"][".searchableFields"].Add("int");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "rowpointer";
			fdata["GoodName"] = "rowpointer";
			fdata["ownerTable"] = "dbo.hk_uet";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_uet","rowpointer");
			fdata["FieldType"] = 72;
			fdata["strField"] = "rowpointer";
			fdata["sourceSingle"] = "rowpointer";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "rowpointer";
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
			tdataArray["hk_uet"]["rowpointer"] = fdata;
			tdataArray["hk_uet"][".searchableFields"].Add("rowpointer");
			GlobalVars.tables_data["dbo.hk_uet"] = tdataArray["hk_uet"];
			GlobalVars.field_labels["dbo_hk_uet"] = fieldLabelsArray["hk_uet"];
			GlobalVars.fieldToolTips["dbo_hk_uet"] = fieldToolTipsArray["hk_uet"];
			GlobalVars.placeHolders["dbo_hk_uet"] = placeHoldersArray["hk_uet"];
			GlobalVars.page_titles["dbo_hk_uet"] = pageTitlesArray["hk_uet"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_uet"));
			GlobalVars.detailsTablesData["dbo.hk_uet"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_uet"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.hk_csi_uet_tables";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.hk_csi_uet_tables";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "hk_csi_uet_tables";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.hk_uet"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.hk_uet"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_uet"][0]["masterKeys"].Add("Expr1");
			GlobalVars.masterTablesData["dbo.hk_uet"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_uet"][0]["detailKeys"].Add("table");


			strOriginalDetailsTable = "dbo.hk_csi_uet_fields";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.hk_csi_uet_fields";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "hk_csi_uet_fields";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.hk_uet"][1] = masterParams;
			GlobalVars.masterTablesData["dbo.hk_uet"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_uet"][1]["masterKeys"].Add("Expr1");
			GlobalVars.masterTablesData["dbo.hk_uet"][1]["masterKeys"].Add("COLUMN_NAME");
			GlobalVars.masterTablesData["dbo.hk_uet"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_uet"][1]["detailKeys"].Add("table");
			GlobalVars.masterTablesData["dbo.hk_uet"][1]["detailKeys"].Add("field_to");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "clientid,  	[table],  	field_to,  	field,  	[int],  	rowpointer";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_uet";
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
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.hk_uet", "m_srcTableName", "dbo.hk_uet"));

protoArray["6"]["m_sql"] = "clientid";
protoArray["6"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "table", "m_strTable", "dbo.hk_uet", "m_srcTableName", "dbo.hk_uet"));

protoArray["8"]["m_sql"] = "[table]";
protoArray["8"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "field_to", "m_strTable", "dbo.hk_uet", "m_srcTableName", "dbo.hk_uet"));

protoArray["10"]["m_sql"] = "field_to";
protoArray["10"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "field", "m_strTable", "dbo.hk_uet", "m_srcTableName", "dbo.hk_uet"));

protoArray["12"]["m_sql"] = "field";
protoArray["12"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "int", "m_strTable", "dbo.hk_uet", "m_srcTableName", "dbo.hk_uet"));

protoArray["14"]["m_sql"] = "[int]";
protoArray["14"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "rowpointer", "m_strTable", "dbo.hk_uet", "m_srcTableName", "dbo.hk_uet"));

protoArray["16"]["m_sql"] = "rowpointer";
protoArray["16"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.hk_uet";
protoArray["19"]["m_srcTableName"] = "dbo.hk_uet";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("clientid");
protoArray["19"]["m_columns"].Add("table");
protoArray["19"]["m_columns"].Add("field_to");
protoArray["19"]["m_columns"].Add("field");
protoArray["19"]["m_columns"].Add("int");
protoArray["19"]["m_columns"].Add("rowpointer");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.hk_uet";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.hk_uet";
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
protoArray["0"]["m_srcTableName"] = "dbo.hk_uet";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_uet"] = obj;

				
		
			tdataArray["hk_uet"][".sqlquery"] = queryData_Array["hk_uet"];
			tdataArray["hk_uet"][".hasEvents"] = false;
		}
	}

}
