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
	public static partial class Settings_hk_inv_items
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_inv_items"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".ShortName"] = "hk_inv_items";
			tdataArray["hk_inv_items"][".OwnerID"] = "app";
			tdataArray["hk_inv_items"][".OriginalTable"] = "dbo.hk_inv_items";
			tdataArray["hk_inv_items"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["hk_inv_items"][".originalPagesByType"] = tdataArray["hk_inv_items"][".pagesByType"];
			tdataArray["hk_inv_items"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["hk_inv_items"][".originalPages"] = tdataArray["hk_inv_items"][".pages"];
			tdataArray["hk_inv_items"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["hk_inv_items"][".originalDefaultPages"] = tdataArray["hk_inv_items"][".defaultPages"];
			fieldLabelsArray["hk_inv_items"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_inv_items"] = SettingsMap.GetArray();
			pageTitlesArray["hk_inv_items"] = SettingsMap.GetArray();
			placeHoldersArray["hk_inv_items"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_inv_items"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_inv_items"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_inv_items"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_inv_items"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_inv_items"]["English"]["app"] = "App";
				fieldToolTipsArray["hk_inv_items"]["English"]["app"] = "";
				placeHoldersArray["hk_inv_items"]["English"]["app"] = "";
				fieldLabelsArray["hk_inv_items"]["English"]["item"] = "Item";
				fieldToolTipsArray["hk_inv_items"]["English"]["item"] = "";
				placeHoldersArray["hk_inv_items"]["English"]["item"] = "";
				fieldLabelsArray["hk_inv_items"]["English"]["description"] = "Description";
				fieldToolTipsArray["hk_inv_items"]["English"]["description"] = "";
				placeHoldersArray["hk_inv_items"]["English"]["description"] = "";
				fieldLabelsArray["hk_inv_items"]["English"]["qty"] = "Qty";
				fieldToolTipsArray["hk_inv_items"]["English"]["qty"] = "";
				placeHoldersArray["hk_inv_items"]["English"]["qty"] = "";
				fieldLabelsArray["hk_inv_items"]["English"]["rate"] = "Rate";
				fieldToolTipsArray["hk_inv_items"]["English"]["rate"] = "";
				placeHoldersArray["hk_inv_items"]["English"]["rate"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_inv_items"]["English"])))
				{
					tdataArray["hk_inv_items"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_inv_items"][".NCSearch"] = true;
			tdataArray["hk_inv_items"][".shortTableName"] = "hk_inv_items";
			tdataArray["hk_inv_items"][".nSecOptions"] = 1;
			tdataArray["hk_inv_items"][".mainTableOwnerID"] = "app";
			tdataArray["hk_inv_items"][".entityType"] = 0;
			tdataArray["hk_inv_items"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_inv_items"][".strOriginalTableName"] = "dbo.hk_inv_items";
			tdataArray["hk_inv_items"][".showAddInPopup"] = false;
			tdataArray["hk_inv_items"][".showEditInPopup"] = false;
			tdataArray["hk_inv_items"][".showViewInPopup"] = false;
			tdataArray["hk_inv_items"][".listAjax"] = false;
			tdataArray["hk_inv_items"][".audit"] = false;
			tdataArray["hk_inv_items"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_inv_items"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_inv_items"][".edit"] = true;
				tdataArray["hk_inv_items"][".afterEditAction"] = 1;
				tdataArray["hk_inv_items"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_inv_items"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_inv_items"][".add"] = true;
				tdataArray["hk_inv_items"][".afterAddAction"] = 1;
				tdataArray["hk_inv_items"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_inv_items"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_inv_items"][".list"] = true;
			}
			tdataArray["hk_inv_items"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_inv_items"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_inv_items"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_inv_items"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_inv_items"][".printFriendly"] = true;
			}
			tdataArray["hk_inv_items"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_inv_items"][".allowShowHideFields"] = true;
			tdataArray["hk_inv_items"][".allowFieldsReordering"] = true;
			tdataArray["hk_inv_items"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_inv_items"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_inv_items"][".buttonsAdded"] = false;
			tdataArray["hk_inv_items"][".addPageEvents"] = false;
			tdataArray["hk_inv_items"][".isUseTimeForSearch"] = false;
			tdataArray["hk_inv_items"][".badgeColor"] = "008B8B";
			tdataArray["hk_inv_items"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".googleLikeFields"].Add("app");
			tdataArray["hk_inv_items"][".googleLikeFields"].Add("item");
			tdataArray["hk_inv_items"][".googleLikeFields"].Add("description");
			tdataArray["hk_inv_items"][".googleLikeFields"].Add("qty");
			tdataArray["hk_inv_items"][".googleLikeFields"].Add("rate");
			tdataArray["hk_inv_items"][".tableType"] = "list";
			tdataArray["hk_inv_items"][".printerPageOrientation"] = 0;
			tdataArray["hk_inv_items"][".nPrinterPageScale"] = 100;
			tdataArray["hk_inv_items"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_inv_items"][".geocodingEnabled"] = false;
			tdataArray["hk_inv_items"][".pageSize"] = 20;
			tdataArray["hk_inv_items"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["hk_inv_items"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_inv_items"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_inv_items"][".sqlHead"] = "SELECT app,  item,  description,  qty,  rate";
			tdataArray["hk_inv_items"][".sqlFrom"] = "FROM dbo.hk_inv_items";
			tdataArray["hk_inv_items"][".sqlWhereExpr"] = "";
			tdataArray["hk_inv_items"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_inv_items"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_inv_items"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_inv_items"][".highlightSearchResults"] = true;
			tableKeysArray["hk_inv_items"] = SettingsMap.GetArray();
			tableKeysArray["hk_inv_items"].Add("app");
			tableKeysArray["hk_inv_items"].Add("item");
			tdataArray["hk_inv_items"][".Keys"] = tableKeysArray["hk_inv_items"];
			tdataArray["hk_inv_items"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "app";
			fdata["GoodName"] = "app";
			fdata["ownerTable"] = "dbo.hk_inv_items";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_inv_items","app");
			fdata["FieldType"] = 202;
			fdata["strField"] = "app";
			fdata["sourceSingle"] = "app";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "app";
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
			edata["LookupTable"] = "dbo.apps";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "code";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "code";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["hk_inv_items"]["app"] = fdata;
			tdataArray["hk_inv_items"][".searchableFields"].Add("app");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "item";
			fdata["GoodName"] = "item";
			fdata["ownerTable"] = "dbo.hk_inv_items";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_inv_items","item");
			fdata["FieldType"] = 130;
			fdata["strField"] = "item";
			fdata["sourceSingle"] = "item";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "item";
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
			tdataArray["hk_inv_items"]["item"] = fdata;
			tdataArray["hk_inv_items"][".searchableFields"].Add("item");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "description";
			fdata["GoodName"] = "description";
			fdata["ownerTable"] = "dbo.hk_inv_items";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_inv_items","description");
			fdata["FieldType"] = 202;
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
			tdataArray["hk_inv_items"]["description"] = fdata;
			tdataArray["hk_inv_items"][".searchableFields"].Add("description");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "qty";
			fdata["GoodName"] = "qty";
			fdata["ownerTable"] = "dbo.hk_inv_items";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_inv_items","qty");
			fdata["FieldType"] = 14;
			fdata["strField"] = "qty";
			fdata["sourceSingle"] = "qty";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "qty";
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
			tdataArray["hk_inv_items"]["qty"] = fdata;
			tdataArray["hk_inv_items"][".searchableFields"].Add("qty");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "rate";
			fdata["GoodName"] = "rate";
			fdata["ownerTable"] = "dbo.hk_inv_items";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_inv_items","rate");
			fdata["FieldType"] = 14;
			fdata["strField"] = "rate";
			fdata["sourceSingle"] = "rate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "rate";
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
			tdataArray["hk_inv_items"]["rate"] = fdata;
			tdataArray["hk_inv_items"][".searchableFields"].Add("rate");
			GlobalVars.tables_data["dbo.hk_inv_items"] = tdataArray["hk_inv_items"];
			GlobalVars.field_labels["dbo_hk_inv_items"] = fieldLabelsArray["hk_inv_items"];
			GlobalVars.fieldToolTips["dbo_hk_inv_items"] = fieldToolTipsArray["hk_inv_items"];
			GlobalVars.placeHolders["dbo_hk_inv_items"] = placeHoldersArray["hk_inv_items"];
			GlobalVars.page_titles["dbo_hk_inv_items"] = pageTitlesArray["hk_inv_items"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_inv_items"));
			GlobalVars.detailsTablesData["dbo.hk_inv_items"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_inv_items"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "app,  item,  description,  qty,  rate";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_inv_items";
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
obj = new SQLField(new XVar("m_strName", "app", "m_strTable", "dbo.hk_inv_items", "m_srcTableName", "dbo.hk_inv_items"));

protoArray["6"]["m_sql"] = "app";
protoArray["6"]["m_srcTableName"] = "dbo.hk_inv_items";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "item", "m_strTable", "dbo.hk_inv_items", "m_srcTableName", "dbo.hk_inv_items"));

protoArray["8"]["m_sql"] = "item";
protoArray["8"]["m_srcTableName"] = "dbo.hk_inv_items";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "description", "m_strTable", "dbo.hk_inv_items", "m_srcTableName", "dbo.hk_inv_items"));

protoArray["10"]["m_sql"] = "description";
protoArray["10"]["m_srcTableName"] = "dbo.hk_inv_items";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "qty", "m_strTable", "dbo.hk_inv_items", "m_srcTableName", "dbo.hk_inv_items"));

protoArray["12"]["m_sql"] = "qty";
protoArray["12"]["m_srcTableName"] = "dbo.hk_inv_items";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "rate", "m_strTable", "dbo.hk_inv_items", "m_srcTableName", "dbo.hk_inv_items"));

protoArray["14"]["m_sql"] = "rate";
protoArray["14"]["m_srcTableName"] = "dbo.hk_inv_items";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.hk_inv_items";
protoArray["17"]["m_srcTableName"] = "dbo.hk_inv_items";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("app");
protoArray["17"]["m_columns"].Add("item");
protoArray["17"]["m_columns"].Add("description");
protoArray["17"]["m_columns"].Add("qty");
protoArray["17"]["m_columns"].Add("rate");
protoArray["17"]["m_columns"].Add("u_m");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.hk_inv_items";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.hk_inv_items";
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
protoArray["0"]["m_srcTableName"] = "dbo.hk_inv_items";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_inv_items"] = obj;

				
		
			tdataArray["hk_inv_items"][".sqlquery"] = queryData_Array["hk_inv_items"];
			tdataArray["hk_inv_items"][".hasEvents"] = false;
		}
	}

}
