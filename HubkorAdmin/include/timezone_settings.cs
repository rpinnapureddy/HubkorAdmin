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
	public static partial class Settings_timezone
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["timezone"] = SettingsMap.GetArray();
			tdataArray["timezone"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["timezone"][".ShortName"] = "timezone";
			tdataArray["timezone"][".OwnerID"] = "";
			tdataArray["timezone"][".OriginalTable"] = "dbo.timezone";
			tdataArray["timezone"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["timezone"][".originalPagesByType"] = tdataArray["timezone"][".pagesByType"];
			tdataArray["timezone"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{}")));
			tdataArray["timezone"][".originalPages"] = tdataArray["timezone"][".pages"];
			tdataArray["timezone"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["timezone"][".originalDefaultPages"] = tdataArray["timezone"][".defaultPages"];
			fieldLabelsArray["timezone"] = SettingsMap.GetArray();
			fieldToolTipsArray["timezone"] = SettingsMap.GetArray();
			pageTitlesArray["timezone"] = SettingsMap.GetArray();
			placeHoldersArray["timezone"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["timezone"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["timezone"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["timezone"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["timezone"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["timezone"]["English"]["timezone"] = "Timezone";
				fieldToolTipsArray["timezone"]["English"]["timezone"] = "";
				placeHoldersArray["timezone"]["English"]["timezone"] = "";
				fieldLabelsArray["timezone"]["English"]["offset"] = "Offset";
				fieldToolTipsArray["timezone"]["English"]["offset"] = "";
				placeHoldersArray["timezone"]["English"]["offset"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["timezone"]["English"])))
				{
					tdataArray["timezone"][".isUseToolTips"] = true;
				}
			}
			tdataArray["timezone"][".NCSearch"] = true;
			tdataArray["timezone"][".shortTableName"] = "timezone";
			tdataArray["timezone"][".nSecOptions"] = 0;
			tdataArray["timezone"][".mainTableOwnerID"] = "";
			tdataArray["timezone"][".entityType"] = 0;
			tdataArray["timezone"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["timezone"][".strOriginalTableName"] = "dbo.timezone";
			tdataArray["timezone"][".showAddInPopup"] = false;
			tdataArray["timezone"][".showEditInPopup"] = false;
			tdataArray["timezone"][".showViewInPopup"] = false;
			tdataArray["timezone"][".listAjax"] = false;
			tdataArray["timezone"][".audit"] = false;
			tdataArray["timezone"][".locking"] = false;
			GlobalVars.pages = tdataArray["timezone"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["timezone"][".edit"] = true;
				tdataArray["timezone"][".afterEditAction"] = 1;
				tdataArray["timezone"][".closePopupAfterEdit"] = 1;
				tdataArray["timezone"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["timezone"][".add"] = true;
				tdataArray["timezone"][".afterAddAction"] = 1;
				tdataArray["timezone"][".closePopupAfterAdd"] = 1;
				tdataArray["timezone"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["timezone"][".list"] = true;
			}
			tdataArray["timezone"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["timezone"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["timezone"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["timezone"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["timezone"][".printFriendly"] = true;
			}
			tdataArray["timezone"][".showSimpleSearchOptions"] = true;
			tdataArray["timezone"][".allowShowHideFields"] = true;
			tdataArray["timezone"][".allowFieldsReordering"] = true;
			tdataArray["timezone"][".isUseAjaxSuggest"] = true;


			tdataArray["timezone"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["timezone"][".buttonsAdded"] = false;
			tdataArray["timezone"][".addPageEvents"] = false;
			tdataArray["timezone"][".isUseTimeForSearch"] = false;
			tdataArray["timezone"][".badgeColor"] = "8FBC8B";
			tdataArray["timezone"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["timezone"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["timezone"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["timezone"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["timezone"][".googleLikeFields"].Add("timezone");
			tdataArray["timezone"][".googleLikeFields"].Add("offset");
			tdataArray["timezone"][".tableType"] = "list";
			tdataArray["timezone"][".printerPageOrientation"] = 0;
			tdataArray["timezone"][".nPrinterPageScale"] = 100;
			tdataArray["timezone"][".nPrinterSplitRecords"] = 40;
			tdataArray["timezone"][".geocodingEnabled"] = false;
			tdataArray["timezone"][".pageSize"] = 20;
			tdataArray["timezone"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["timezone"][".strOrderBy"] = tstrOrderBy;
			tdataArray["timezone"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["timezone"][".sqlHead"] = "SELECT timezone,  	[offset]";
			tdataArray["timezone"][".sqlFrom"] = "FROM dbo.timezone";
			tdataArray["timezone"][".sqlWhereExpr"] = "";
			tdataArray["timezone"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["timezone"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["timezone"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["timezone"][".highlightSearchResults"] = true;
			tableKeysArray["timezone"] = SettingsMap.GetArray();
			tdataArray["timezone"][".Keys"] = tableKeysArray["timezone"];
			tdataArray["timezone"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "timezone";
			fdata["GoodName"] = "timezone";
			fdata["ownerTable"] = "dbo.timezone";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_timezone","timezone");
			fdata["FieldType"] = 202;
			fdata["strField"] = "timezone";
			fdata["sourceSingle"] = "timezone";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "timezone";
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
			tdataArray["timezone"]["timezone"] = fdata;
			tdataArray["timezone"][".searchableFields"].Add("timezone");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "offset";
			fdata["GoodName"] = "offset";
			fdata["ownerTable"] = "dbo.timezone";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_timezone","offset");
			fdata["FieldType"] = 3;
			fdata["strField"] = "offset";
			fdata["sourceSingle"] = "offset";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[offset]";
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
			tdataArray["timezone"]["offset"] = fdata;
			tdataArray["timezone"][".searchableFields"].Add("offset");
			GlobalVars.tables_data["dbo.timezone"] = tdataArray["timezone"];
			GlobalVars.field_labels["dbo_timezone"] = fieldLabelsArray["timezone"];
			GlobalVars.fieldToolTips["dbo_timezone"] = fieldToolTipsArray["timezone"];
			GlobalVars.placeHolders["dbo_timezone"] = placeHoldersArray["timezone"];
			GlobalVars.page_titles["dbo_timezone"] = pageTitlesArray["timezone"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.timezone"));
			GlobalVars.detailsTablesData["dbo.timezone"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.timezone"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "timezone,  	[offset]";
protoArray["0"]["m_strFrom"] = "FROM dbo.timezone";
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
obj = new SQLField(new XVar("m_strName", "timezone", "m_strTable", "dbo.timezone", "m_srcTableName", "dbo.timezone"));

protoArray["6"]["m_sql"] = "timezone";
protoArray["6"]["m_srcTableName"] = "dbo.timezone";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "offset", "m_strTable", "dbo.timezone", "m_srcTableName", "dbo.timezone"));

protoArray["8"]["m_sql"] = "[offset]";
protoArray["8"]["m_srcTableName"] = "dbo.timezone";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.timezone";
protoArray["11"]["m_srcTableName"] = "dbo.timezone";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("timezone");
protoArray["11"]["m_columns"].Add("offset");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.timezone";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.timezone";
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_sql"] = "";
protoArray["12"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["12"]["m_column"] = obj;
protoArray["12"]["m_contained"] = SettingsMap.GetArray();
protoArray["12"]["m_strCase"] = "";
protoArray["12"]["m_havingmode"] = false;
protoArray["12"]["m_inBrackets"] = false;
protoArray["12"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["12"]);

protoArray["10"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["10"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.timezone";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["timezone"] = obj;

				
		
			tdataArray["timezone"][".sqlquery"] = queryData_Array["timezone"];
			tdataArray["timezone"][".hasEvents"] = false;
		}
	}

}
