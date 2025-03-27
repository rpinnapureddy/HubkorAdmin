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
	public static partial class Settings_hk_client_app_connector
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".ShortName"] = "hk_client_app_connector";
			tdataArray["hk_client_app_connector"][".OwnerID"] = "";
			tdataArray["hk_client_app_connector"][".OriginalTable"] = "dbo.hk_client_app_connector";
			tdataArray["hk_client_app_connector"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["hk_client_app_connector"][".originalPagesByType"] = tdataArray["hk_client_app_connector"][".pagesByType"];
			tdataArray["hk_client_app_connector"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{}")));
			tdataArray["hk_client_app_connector"][".originalPages"] = tdataArray["hk_client_app_connector"][".pages"];
			tdataArray["hk_client_app_connector"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["hk_client_app_connector"][".originalDefaultPages"] = tdataArray["hk_client_app_connector"][".defaultPages"];
			fieldLabelsArray["hk_client_app_connector"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_client_app_connector"] = SettingsMap.GetArray();
			pageTitlesArray["hk_client_app_connector"] = SettingsMap.GetArray();
			placeHoldersArray["hk_client_app_connector"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_client_app_connector"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_client_app_connector"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_client_app_connector"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_client_app_connector"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_client_app_connector"]["English"]["client"] = "Client";
				fieldToolTipsArray["hk_client_app_connector"]["English"]["client"] = "";
				placeHoldersArray["hk_client_app_connector"]["English"]["client"] = "";
				fieldLabelsArray["hk_client_app_connector"]["English"]["app"] = "App";
				fieldToolTipsArray["hk_client_app_connector"]["English"]["app"] = "";
				placeHoldersArray["hk_client_app_connector"]["English"]["app"] = "";
				fieldLabelsArray["hk_client_app_connector"]["English"]["connector"] = "Connector";
				fieldToolTipsArray["hk_client_app_connector"]["English"]["connector"] = "";
				placeHoldersArray["hk_client_app_connector"]["English"]["connector"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_client_app_connector"]["English"])))
				{
					tdataArray["hk_client_app_connector"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_client_app_connector"][".NCSearch"] = true;
			tdataArray["hk_client_app_connector"][".shortTableName"] = "hk_client_app_connector";
			tdataArray["hk_client_app_connector"][".nSecOptions"] = 0;
			tdataArray["hk_client_app_connector"][".mainTableOwnerID"] = "";
			tdataArray["hk_client_app_connector"][".entityType"] = 0;
			tdataArray["hk_client_app_connector"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_client_app_connector"][".strOriginalTableName"] = "dbo.hk_client_app_connector";
			tdataArray["hk_client_app_connector"][".showAddInPopup"] = false;
			tdataArray["hk_client_app_connector"][".showEditInPopup"] = false;
			tdataArray["hk_client_app_connector"][".showViewInPopup"] = false;
			tdataArray["hk_client_app_connector"][".listAjax"] = false;
			tdataArray["hk_client_app_connector"][".audit"] = false;
			tdataArray["hk_client_app_connector"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_client_app_connector"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_client_app_connector"][".edit"] = true;
				tdataArray["hk_client_app_connector"][".afterEditAction"] = 1;
				tdataArray["hk_client_app_connector"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_client_app_connector"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_client_app_connector"][".add"] = true;
				tdataArray["hk_client_app_connector"][".afterAddAction"] = 1;
				tdataArray["hk_client_app_connector"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_client_app_connector"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_client_app_connector"][".list"] = true;
			}
			tdataArray["hk_client_app_connector"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_client_app_connector"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_client_app_connector"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_client_app_connector"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_client_app_connector"][".printFriendly"] = true;
			}
			tdataArray["hk_client_app_connector"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_client_app_connector"][".allowShowHideFields"] = true;
			tdataArray["hk_client_app_connector"][".allowFieldsReordering"] = true;
			tdataArray["hk_client_app_connector"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_client_app_connector"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_client_app_connector"][".buttonsAdded"] = false;
			tdataArray["hk_client_app_connector"][".addPageEvents"] = false;
			tdataArray["hk_client_app_connector"][".isUseTimeForSearch"] = false;
			tdataArray["hk_client_app_connector"][".badgeColor"] = "4682B4";
			tdataArray["hk_client_app_connector"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".googleLikeFields"].Add("client");
			tdataArray["hk_client_app_connector"][".googleLikeFields"].Add("app");
			tdataArray["hk_client_app_connector"][".googleLikeFields"].Add("connector");
			tdataArray["hk_client_app_connector"][".tableType"] = "list";
			tdataArray["hk_client_app_connector"][".printerPageOrientation"] = 0;
			tdataArray["hk_client_app_connector"][".nPrinterPageScale"] = 100;
			tdataArray["hk_client_app_connector"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_client_app_connector"][".geocodingEnabled"] = false;
			tdataArray["hk_client_app_connector"][".pageSize"] = 20;
			tdataArray["hk_client_app_connector"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["hk_client_app_connector"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_client_app_connector"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".sqlHead"] = "SELECT client,  	app,  	connector";
			tdataArray["hk_client_app_connector"][".sqlFrom"] = "FROM dbo.hk_client_app_connector";
			tdataArray["hk_client_app_connector"][".sqlWhereExpr"] = "";
			tdataArray["hk_client_app_connector"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_client_app_connector"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_client_app_connector"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_client_app_connector"][".highlightSearchResults"] = true;
			tableKeysArray["hk_client_app_connector"] = SettingsMap.GetArray();
			tdataArray["hk_client_app_connector"][".Keys"] = tableKeysArray["hk_client_app_connector"];
			tdataArray["hk_client_app_connector"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "client";
			fdata["GoodName"] = "client";
			fdata["ownerTable"] = "dbo.hk_client_app_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_client_app_connector","client");
			fdata["FieldType"] = 202;
			fdata["strField"] = "client";
			fdata["sourceSingle"] = "client";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "client";
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
			tdataArray["hk_client_app_connector"]["client"] = fdata;
			tdataArray["hk_client_app_connector"][".searchableFields"].Add("client");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "app";
			fdata["GoodName"] = "app";
			fdata["ownerTable"] = "dbo.hk_client_app_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_client_app_connector","app");
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
			tdataArray["hk_client_app_connector"]["app"] = fdata;
			tdataArray["hk_client_app_connector"][".searchableFields"].Add("app");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "connector";
			fdata["GoodName"] = "connector";
			fdata["ownerTable"] = "dbo.hk_client_app_connector";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_client_app_connector","connector");
			fdata["FieldType"] = 202;
			fdata["strField"] = "connector";
			fdata["sourceSingle"] = "connector";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "connector";
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
			tdataArray["hk_client_app_connector"]["connector"] = fdata;
			tdataArray["hk_client_app_connector"][".searchableFields"].Add("connector");
			GlobalVars.tables_data["dbo.hk_client_app_connector"] = tdataArray["hk_client_app_connector"];
			GlobalVars.field_labels["dbo_hk_client_app_connector"] = fieldLabelsArray["hk_client_app_connector"];
			GlobalVars.fieldToolTips["dbo_hk_client_app_connector"] = fieldToolTipsArray["hk_client_app_connector"];
			GlobalVars.placeHolders["dbo_hk_client_app_connector"] = placeHoldersArray["hk_client_app_connector"];
			GlobalVars.page_titles["dbo_hk_client_app_connector"] = pageTitlesArray["hk_client_app_connector"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_client_app_connector"));
			GlobalVars.detailsTablesData["dbo.hk_client_app_connector"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_client_app_connector"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "client,  	app,  	connector";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_client_app_connector";
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
obj = new SQLField(new XVar("m_strName", "client", "m_strTable", "dbo.hk_client_app_connector", "m_srcTableName", "dbo.hk_client_app_connector"));

protoArray["6"]["m_sql"] = "client";
protoArray["6"]["m_srcTableName"] = "dbo.hk_client_app_connector";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "app", "m_strTable", "dbo.hk_client_app_connector", "m_srcTableName", "dbo.hk_client_app_connector"));

protoArray["8"]["m_sql"] = "app";
protoArray["8"]["m_srcTableName"] = "dbo.hk_client_app_connector";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "connector", "m_strTable", "dbo.hk_client_app_connector", "m_srcTableName", "dbo.hk_client_app_connector"));

protoArray["10"]["m_sql"] = "connector";
protoArray["10"]["m_srcTableName"] = "dbo.hk_client_app_connector";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.hk_client_app_connector";
protoArray["13"]["m_srcTableName"] = "dbo.hk_client_app_connector";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("client");
protoArray["13"]["m_columns"].Add("app");
protoArray["13"]["m_columns"].Add("connector");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.hk_client_app_connector";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.hk_client_app_connector";
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
protoArray["0"]["m_srcTableName"] = "dbo.hk_client_app_connector";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_client_app_connector"] = obj;

				
		
			tdataArray["hk_client_app_connector"][".sqlquery"] = queryData_Array["hk_client_app_connector"];
			tdataArray["hk_client_app_connector"][".hasEvents"] = false;
		}
	}

}
