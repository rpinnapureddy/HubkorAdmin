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
	public static partial class Settings_indcode
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["indcode"] = SettingsMap.GetArray();
			tdataArray["indcode"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["indcode"][".ShortName"] = "indcode";
			tdataArray["indcode"][".OwnerID"] = "";
			tdataArray["indcode"][".OriginalTable"] = "dbo.indcode";
			tdataArray["indcode"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["indcode"][".originalPagesByType"] = tdataArray["indcode"][".pagesByType"];
			tdataArray["indcode"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["indcode"][".originalPages"] = tdataArray["indcode"][".pages"];
			tdataArray["indcode"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["indcode"][".originalDefaultPages"] = tdataArray["indcode"][".defaultPages"];
			fieldLabelsArray["indcode"] = SettingsMap.GetArray();
			fieldToolTipsArray["indcode"] = SettingsMap.GetArray();
			pageTitlesArray["indcode"] = SettingsMap.GetArray();
			placeHoldersArray["indcode"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["indcode"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["indcode"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["indcode"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["indcode"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["indcode"]["English"]["indcode"] = "Indcode";
				fieldToolTipsArray["indcode"]["English"]["indcode"] = "";
				placeHoldersArray["indcode"]["English"]["indcode"] = "";
				fieldLabelsArray["indcode"]["English"]["description"] = "Description";
				fieldToolTipsArray["indcode"]["English"]["description"] = "";
				placeHoldersArray["indcode"]["English"]["description"] = "";
				fieldLabelsArray["indcode"]["English"]["rowpointer"] = "Rowpointer";
				fieldToolTipsArray["indcode"]["English"]["rowpointer"] = "";
				placeHoldersArray["indcode"]["English"]["rowpointer"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["indcode"]["English"])))
				{
					tdataArray["indcode"][".isUseToolTips"] = true;
				}
			}
			tdataArray["indcode"][".NCSearch"] = true;
			tdataArray["indcode"][".shortTableName"] = "indcode";
			tdataArray["indcode"][".nSecOptions"] = 0;
			tdataArray["indcode"][".mainTableOwnerID"] = "";
			tdataArray["indcode"][".entityType"] = 0;
			tdataArray["indcode"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["indcode"][".strOriginalTableName"] = "dbo.indcode";
			tdataArray["indcode"][".showAddInPopup"] = false;
			tdataArray["indcode"][".showEditInPopup"] = false;
			tdataArray["indcode"][".showViewInPopup"] = false;
			tdataArray["indcode"][".listAjax"] = false;
			tdataArray["indcode"][".audit"] = false;
			tdataArray["indcode"][".locking"] = false;
			GlobalVars.pages = tdataArray["indcode"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["indcode"][".edit"] = true;
				tdataArray["indcode"][".afterEditAction"] = 1;
				tdataArray["indcode"][".closePopupAfterEdit"] = 1;
				tdataArray["indcode"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["indcode"][".add"] = true;
				tdataArray["indcode"][".afterAddAction"] = 1;
				tdataArray["indcode"][".closePopupAfterAdd"] = 1;
				tdataArray["indcode"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["indcode"][".list"] = true;
			}
			tdataArray["indcode"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["indcode"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["indcode"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["indcode"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["indcode"][".printFriendly"] = true;
			}
			tdataArray["indcode"][".showSimpleSearchOptions"] = true;
			tdataArray["indcode"][".allowShowHideFields"] = true;
			tdataArray["indcode"][".allowFieldsReordering"] = true;
			tdataArray["indcode"][".isUseAjaxSuggest"] = true;


			tdataArray["indcode"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["indcode"][".buttonsAdded"] = false;
			tdataArray["indcode"][".addPageEvents"] = false;
			tdataArray["indcode"][".isUseTimeForSearch"] = false;
			tdataArray["indcode"][".badgeColor"] = "008B8B";
			tdataArray["indcode"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["indcode"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["indcode"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["indcode"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["indcode"][".googleLikeFields"].Add("indcode");
			tdataArray["indcode"][".googleLikeFields"].Add("description");
			tdataArray["indcode"][".googleLikeFields"].Add("rowpointer");
			tdataArray["indcode"][".tableType"] = "list";
			tdataArray["indcode"][".printerPageOrientation"] = 0;
			tdataArray["indcode"][".nPrinterPageScale"] = 100;
			tdataArray["indcode"][".nPrinterSplitRecords"] = 40;
			tdataArray["indcode"][".geocodingEnabled"] = false;
			tdataArray["indcode"][".pageSize"] = 20;
			tdataArray["indcode"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["indcode"][".strOrderBy"] = tstrOrderBy;
			tdataArray["indcode"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["indcode"][".sqlHead"] = "SELECT indcode,  	description,  	rowpointer";
			tdataArray["indcode"][".sqlFrom"] = "FROM dbo.indcode";
			tdataArray["indcode"][".sqlWhereExpr"] = "";
			tdataArray["indcode"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["indcode"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["indcode"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["indcode"][".highlightSearchResults"] = true;
			tableKeysArray["indcode"] = SettingsMap.GetArray();
			tableKeysArray["indcode"].Add("indcode");
			tdataArray["indcode"][".Keys"] = tableKeysArray["indcode"];
			tdataArray["indcode"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "indcode";
			fdata["GoodName"] = "indcode";
			fdata["ownerTable"] = "dbo.indcode";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_indcode","indcode");
			fdata["FieldType"] = 202;
			fdata["strField"] = "indcode";
			fdata["sourceSingle"] = "indcode";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "indcode";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["indcode"]["indcode"] = fdata;
			tdataArray["indcode"][".searchableFields"].Add("indcode");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "description";
			fdata["GoodName"] = "description";
			fdata["ownerTable"] = "dbo.indcode";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_indcode","description");
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["indcode"]["description"] = fdata;
			tdataArray["indcode"][".searchableFields"].Add("description");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "rowpointer";
			fdata["GoodName"] = "rowpointer";
			fdata["ownerTable"] = "dbo.indcode";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_indcode","rowpointer");
			fdata["FieldType"] = 200;
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=36");
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
			tdataArray["indcode"]["rowpointer"] = fdata;
			tdataArray["indcode"][".searchableFields"].Add("rowpointer");
			GlobalVars.tables_data["dbo.indcode"] = tdataArray["indcode"];
			GlobalVars.field_labels["dbo_indcode"] = fieldLabelsArray["indcode"];
			GlobalVars.fieldToolTips["dbo_indcode"] = fieldToolTipsArray["indcode"];
			GlobalVars.placeHolders["dbo_indcode"] = placeHoldersArray["indcode"];
			GlobalVars.page_titles["dbo_indcode"] = pageTitlesArray["indcode"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.indcode"));
			GlobalVars.detailsTablesData["dbo.indcode"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.indcode"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "indcode,  	description,  	rowpointer";
protoArray["0"]["m_strFrom"] = "FROM dbo.indcode";
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
obj = new SQLField(new XVar("m_strName", "indcode", "m_strTable", "dbo.indcode", "m_srcTableName", "dbo.indcode"));

protoArray["6"]["m_sql"] = "indcode";
protoArray["6"]["m_srcTableName"] = "dbo.indcode";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "description", "m_strTable", "dbo.indcode", "m_srcTableName", "dbo.indcode"));

protoArray["8"]["m_sql"] = "description";
protoArray["8"]["m_srcTableName"] = "dbo.indcode";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "rowpointer", "m_strTable", "dbo.indcode", "m_srcTableName", "dbo.indcode"));

protoArray["10"]["m_sql"] = "rowpointer";
protoArray["10"]["m_srcTableName"] = "dbo.indcode";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.indcode";
protoArray["13"]["m_srcTableName"] = "dbo.indcode";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("indcode");
protoArray["13"]["m_columns"].Add("description");
protoArray["13"]["m_columns"].Add("rowpointer");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.indcode";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.indcode";
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_sql"] = "";
protoArray["14"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["14"]["m_column"] = obj;
protoArray["14"]["m_contained"] = SettingsMap.GetArray();
protoArray["14"]["m_strCase"] = "";
protoArray["14"]["m_havingmode"] = false;
protoArray["14"]["m_inBrackets"] = false;
protoArray["14"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["14"]);

protoArray["12"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["12"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.indcode";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["indcode"] = obj;

				
		
			tdataArray["indcode"][".sqlquery"] = queryData_Array["indcode"];
			tdataArray["indcode"][".hasEvents"] = false;
		}
	}

}
