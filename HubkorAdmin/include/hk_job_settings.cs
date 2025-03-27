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
	public static partial class Settings_hk_job
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_job"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".ShortName"] = "hk_job";
			tdataArray["hk_job"][".OwnerID"] = "";
			tdataArray["hk_job"][".OriginalTable"] = "dbo.hk_job";
			tdataArray["hk_job"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["hk_job"][".originalPagesByType"] = tdataArray["hk_job"][".pagesByType"];
			tdataArray["hk_job"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["hk_job"][".originalPages"] = tdataArray["hk_job"][".pages"];
			tdataArray["hk_job"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["hk_job"][".originalDefaultPages"] = tdataArray["hk_job"][".defaultPages"];
			fieldLabelsArray["hk_job"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_job"] = SettingsMap.GetArray();
			pageTitlesArray["hk_job"] = SettingsMap.GetArray();
			placeHoldersArray["hk_job"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_job"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_job"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_job"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_job"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_job"]["English"]["job_name"] = "Job Name";
				fieldToolTipsArray["hk_job"]["English"]["job_name"] = "";
				placeHoldersArray["hk_job"]["English"]["job_name"] = "";
				fieldLabelsArray["hk_job"]["English"]["Executed_at"] = "Executed At";
				fieldToolTipsArray["hk_job"]["English"]["Executed_at"] = "";
				placeHoldersArray["hk_job"]["English"]["Executed_at"] = "";
				fieldLabelsArray["hk_job"]["English"]["next_execution"] = "Next Execution";
				fieldToolTipsArray["hk_job"]["English"]["next_execution"] = "";
				placeHoldersArray["hk_job"]["English"]["next_execution"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_job"]["English"])))
				{
					tdataArray["hk_job"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_job"][".NCSearch"] = true;
			tdataArray["hk_job"][".shortTableName"] = "hk_job";
			tdataArray["hk_job"][".nSecOptions"] = 0;
			tdataArray["hk_job"][".mainTableOwnerID"] = "";
			tdataArray["hk_job"][".entityType"] = 0;
			tdataArray["hk_job"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_job"][".strOriginalTableName"] = "dbo.hk_job";
			tdataArray["hk_job"][".showAddInPopup"] = false;
			tdataArray["hk_job"][".showEditInPopup"] = false;
			tdataArray["hk_job"][".showViewInPopup"] = false;
			tdataArray["hk_job"][".listAjax"] = false;
			tdataArray["hk_job"][".audit"] = false;
			tdataArray["hk_job"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_job"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_job"][".edit"] = true;
				tdataArray["hk_job"][".afterEditAction"] = 1;
				tdataArray["hk_job"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_job"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_job"][".add"] = true;
				tdataArray["hk_job"][".afterAddAction"] = 1;
				tdataArray["hk_job"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_job"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_job"][".list"] = true;
			}
			tdataArray["hk_job"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_job"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_job"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_job"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_job"][".printFriendly"] = true;
			}
			tdataArray["hk_job"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_job"][".allowShowHideFields"] = true;
			tdataArray["hk_job"][".allowFieldsReordering"] = true;
			tdataArray["hk_job"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_job"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_job"][".buttonsAdded"] = false;
			tdataArray["hk_job"][".addPageEvents"] = false;
			tdataArray["hk_job"][".isUseTimeForSearch"] = false;
			tdataArray["hk_job"][".badgeColor"] = "EDCA00";
			tdataArray["hk_job"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".googleLikeFields"].Add("job_name");
			tdataArray["hk_job"][".googleLikeFields"].Add("Executed_at");
			tdataArray["hk_job"][".googleLikeFields"].Add("next_execution");
			tdataArray["hk_job"][".tableType"] = "list";
			tdataArray["hk_job"][".printerPageOrientation"] = 0;
			tdataArray["hk_job"][".nPrinterPageScale"] = 100;
			tdataArray["hk_job"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_job"][".geocodingEnabled"] = false;
			tdataArray["hk_job"][".pageSize"] = 20;
			tdataArray["hk_job"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["hk_job"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_job"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_job"][".sqlHead"] = "SELECT job_name,  	Executed_at,  	next_execution";
			tdataArray["hk_job"][".sqlFrom"] = "FROM dbo.hk_job";
			tdataArray["hk_job"][".sqlWhereExpr"] = "";
			tdataArray["hk_job"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_job"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_job"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_job"][".highlightSearchResults"] = true;
			tableKeysArray["hk_job"] = SettingsMap.GetArray();
			tableKeysArray["hk_job"].Add("job_name");
			tdataArray["hk_job"][".Keys"] = tableKeysArray["hk_job"];
			tdataArray["hk_job"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "job_name";
			fdata["GoodName"] = "job_name";
			fdata["ownerTable"] = "dbo.hk_job";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_job","job_name");
			fdata["FieldType"] = 202;
			fdata["strField"] = "job_name";
			fdata["sourceSingle"] = "job_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "job_name";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=128");
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
			tdataArray["hk_job"]["job_name"] = fdata;
			tdataArray["hk_job"][".searchableFields"].Add("job_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "Executed_at";
			fdata["GoodName"] = "Executed_at";
			fdata["ownerTable"] = "dbo.hk_job";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_job","Executed_at");
			fdata["FieldType"] = 135;
			fdata["strField"] = "Executed_at";
			fdata["sourceSingle"] = "Executed_at";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Executed_at";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Datetime");
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
			tdataArray["hk_job"]["Executed_at"] = fdata;
			tdataArray["hk_job"][".searchableFields"].Add("Executed_at");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "next_execution";
			fdata["GoodName"] = "next_execution";
			fdata["ownerTable"] = "dbo.hk_job";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_job","next_execution");
			fdata["FieldType"] = 135;
			fdata["strField"] = "next_execution";
			fdata["sourceSingle"] = "next_execution";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "next_execution";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Datetime");
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
			tdataArray["hk_job"]["next_execution"] = fdata;
			tdataArray["hk_job"][".searchableFields"].Add("next_execution");
			GlobalVars.tables_data["dbo.hk_job"] = tdataArray["hk_job"];
			GlobalVars.field_labels["dbo_hk_job"] = fieldLabelsArray["hk_job"];
			GlobalVars.fieldToolTips["dbo_hk_job"] = fieldToolTipsArray["hk_job"];
			GlobalVars.placeHolders["dbo_hk_job"] = placeHoldersArray["hk_job"];
			GlobalVars.page_titles["dbo_hk_job"] = pageTitlesArray["hk_job"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_job"));
			GlobalVars.detailsTablesData["dbo.hk_job"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_job"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "job_name,  	Executed_at,  	next_execution";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_job";
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
obj = new SQLField(new XVar("m_strName", "job_name", "m_strTable", "dbo.hk_job", "m_srcTableName", "dbo.hk_job"));

protoArray["6"]["m_sql"] = "job_name";
protoArray["6"]["m_srcTableName"] = "dbo.hk_job";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Executed_at", "m_strTable", "dbo.hk_job", "m_srcTableName", "dbo.hk_job"));

protoArray["8"]["m_sql"] = "Executed_at";
protoArray["8"]["m_srcTableName"] = "dbo.hk_job";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "next_execution", "m_strTable", "dbo.hk_job", "m_srcTableName", "dbo.hk_job"));

protoArray["10"]["m_sql"] = "next_execution";
protoArray["10"]["m_srcTableName"] = "dbo.hk_job";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.hk_job";
protoArray["13"]["m_srcTableName"] = "dbo.hk_job";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("job_name");
protoArray["13"]["m_columns"].Add("Executed_at");
protoArray["13"]["m_columns"].Add("next_execution");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.hk_job";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.hk_job";
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
protoArray["0"]["m_srcTableName"] = "dbo.hk_job";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_job"] = obj;

				
		
			tdataArray["hk_job"][".sqlquery"] = queryData_Array["hk_job"];
			tdataArray["hk_job"][".hasEvents"] = false;
		}
	}

}
