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
	public static partial class Settings_adminuggroups
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["adminuggroups"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".ShortName"] = "adminuggroups";
			tdataArray["adminuggroups"][".OwnerID"] = "";
			tdataArray["adminuggroups"][".OriginalTable"] = "dbo.Adminuggroups";
			tdataArray["adminuggroups"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["adminuggroups"][".originalPagesByType"] = tdataArray["adminuggroups"][".pagesByType"];
			tdataArray["adminuggroups"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{}")));
			tdataArray["adminuggroups"][".originalPages"] = tdataArray["adminuggroups"][".pages"];
			tdataArray["adminuggroups"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["adminuggroups"][".originalDefaultPages"] = tdataArray["adminuggroups"][".defaultPages"];
			fieldLabelsArray["adminuggroups"] = SettingsMap.GetArray();
			fieldToolTipsArray["adminuggroups"] = SettingsMap.GetArray();
			pageTitlesArray["adminuggroups"] = SettingsMap.GetArray();
			placeHoldersArray["adminuggroups"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["adminuggroups"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["adminuggroups"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["adminuggroups"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["adminuggroups"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["adminuggroups"]["English"]["GroupID"] = "Group ID";
				fieldToolTipsArray["adminuggroups"]["English"]["GroupID"] = "";
				placeHoldersArray["adminuggroups"]["English"]["GroupID"] = "";
				fieldLabelsArray["adminuggroups"]["English"]["Label"] = "Label";
				fieldToolTipsArray["adminuggroups"]["English"]["Label"] = "";
				placeHoldersArray["adminuggroups"]["English"]["Label"] = "";
				fieldLabelsArray["adminuggroups"]["English"]["Provider"] = "Provider";
				fieldToolTipsArray["adminuggroups"]["English"]["Provider"] = "";
				placeHoldersArray["adminuggroups"]["English"]["Provider"] = "";
				fieldLabelsArray["adminuggroups"]["English"]["Comment"] = "Comment";
				fieldToolTipsArray["adminuggroups"]["English"]["Comment"] = "";
				placeHoldersArray["adminuggroups"]["English"]["Comment"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["adminuggroups"]["English"])))
				{
					tdataArray["adminuggroups"][".isUseToolTips"] = true;
				}
			}
			tdataArray["adminuggroups"][".NCSearch"] = true;
			tdataArray["adminuggroups"][".shortTableName"] = "adminuggroups";
			tdataArray["adminuggroups"][".nSecOptions"] = 0;
			tdataArray["adminuggroups"][".mainTableOwnerID"] = "";
			tdataArray["adminuggroups"][".entityType"] = 0;
			tdataArray["adminuggroups"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["adminuggroups"][".strOriginalTableName"] = "dbo.Adminuggroups";
			tdataArray["adminuggroups"][".showAddInPopup"] = false;
			tdataArray["adminuggroups"][".showEditInPopup"] = false;
			tdataArray["adminuggroups"][".showViewInPopup"] = false;
			tdataArray["adminuggroups"][".listAjax"] = false;
			tdataArray["adminuggroups"][".audit"] = false;
			tdataArray["adminuggroups"][".locking"] = false;
			GlobalVars.pages = tdataArray["adminuggroups"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["adminuggroups"][".edit"] = true;
				tdataArray["adminuggroups"][".afterEditAction"] = 1;
				tdataArray["adminuggroups"][".closePopupAfterEdit"] = 1;
				tdataArray["adminuggroups"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["adminuggroups"][".add"] = true;
				tdataArray["adminuggroups"][".afterAddAction"] = 1;
				tdataArray["adminuggroups"][".closePopupAfterAdd"] = 1;
				tdataArray["adminuggroups"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["adminuggroups"][".list"] = true;
			}
			tdataArray["adminuggroups"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["adminuggroups"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["adminuggroups"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["adminuggroups"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["adminuggroups"][".printFriendly"] = true;
			}
			tdataArray["adminuggroups"][".showSimpleSearchOptions"] = true;
			tdataArray["adminuggroups"][".allowShowHideFields"] = true;
			tdataArray["adminuggroups"][".allowFieldsReordering"] = true;
			tdataArray["adminuggroups"][".isUseAjaxSuggest"] = true;


			tdataArray["adminuggroups"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["adminuggroups"][".buttonsAdded"] = false;
			tdataArray["adminuggroups"][".addPageEvents"] = false;
			tdataArray["adminuggroups"][".isUseTimeForSearch"] = false;
			tdataArray["adminuggroups"][".badgeColor"] = "2F4F4F";
			tdataArray["adminuggroups"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".googleLikeFields"].Add("GroupID");
			tdataArray["adminuggroups"][".googleLikeFields"].Add("Label");
			tdataArray["adminuggroups"][".googleLikeFields"].Add("Provider");
			tdataArray["adminuggroups"][".googleLikeFields"].Add("Comment");
			tdataArray["adminuggroups"][".tableType"] = "list";
			tdataArray["adminuggroups"][".printerPageOrientation"] = 0;
			tdataArray["adminuggroups"][".nPrinterPageScale"] = 100;
			tdataArray["adminuggroups"][".nPrinterSplitRecords"] = 40;
			tdataArray["adminuggroups"][".geocodingEnabled"] = false;
			tdataArray["adminuggroups"][".pageSize"] = 20;
			tdataArray["adminuggroups"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["adminuggroups"][".strOrderBy"] = tstrOrderBy;
			tdataArray["adminuggroups"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["adminuggroups"][".sqlHead"] = "SELECT GroupID,  	[Label],  	Provider,  	[Comment]";
			tdataArray["adminuggroups"][".sqlFrom"] = "FROM dbo.Adminuggroups";
			tdataArray["adminuggroups"][".sqlWhereExpr"] = "";
			tdataArray["adminuggroups"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["adminuggroups"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["adminuggroups"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["adminuggroups"][".highlightSearchResults"] = true;
			tableKeysArray["adminuggroups"] = SettingsMap.GetArray();
			tableKeysArray["adminuggroups"].Add("GroupID");
			tdataArray["adminuggroups"][".Keys"] = tableKeysArray["adminuggroups"];
			tdataArray["adminuggroups"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "GroupID";
			fdata["GoodName"] = "GroupID";
			fdata["ownerTable"] = "dbo.Adminuggroups";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Adminuggroups","GroupID");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "GroupID";
			fdata["sourceSingle"] = "GroupID";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "GroupID";
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
			tdataArray["adminuggroups"]["GroupID"] = fdata;
			tdataArray["adminuggroups"][".searchableFields"].Add("GroupID");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "Label";
			fdata["GoodName"] = "Label";
			fdata["ownerTable"] = "dbo.Adminuggroups";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Adminuggroups","Label");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Label";
			fdata["sourceSingle"] = "Label";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[Label]";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=300");
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
			tdataArray["adminuggroups"]["Label"] = fdata;
			tdataArray["adminuggroups"][".searchableFields"].Add("Label");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "Provider";
			fdata["GoodName"] = "Provider";
			fdata["ownerTable"] = "dbo.Adminuggroups";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Adminuggroups","Provider");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Provider";
			fdata["sourceSingle"] = "Provider";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Provider";
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
			tdataArray["adminuggroups"]["Provider"] = fdata;
			tdataArray["adminuggroups"][".searchableFields"].Add("Provider");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "Comment";
			fdata["GoodName"] = "Comment";
			fdata["ownerTable"] = "dbo.Adminuggroups";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Adminuggroups","Comment");
			fdata["FieldType"] = 201;
			fdata["strField"] = "Comment";
			fdata["sourceSingle"] = "Comment";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[Comment]";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text area");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
			edata["nRows"] = 100;
			edata["nCols"] = 200;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["CreateThumbnail"] = true;
			edata["StrThumbnail"] = "th";
			edata["ThumbnailSize"] = 600;
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
			tdataArray["adminuggroups"]["Comment"] = fdata;
			tdataArray["adminuggroups"][".searchableFields"].Add("Comment");
			GlobalVars.tables_data["dbo.Adminuggroups"] = tdataArray["adminuggroups"];
			GlobalVars.field_labels["dbo_Adminuggroups"] = fieldLabelsArray["adminuggroups"];
			GlobalVars.fieldToolTips["dbo_Adminuggroups"] = fieldToolTipsArray["adminuggroups"];
			GlobalVars.placeHolders["dbo_Adminuggroups"] = placeHoldersArray["adminuggroups"];
			GlobalVars.page_titles["dbo_Adminuggroups"] = pageTitlesArray["adminuggroups"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.Adminuggroups"));
			GlobalVars.detailsTablesData["dbo.Adminuggroups"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.Adminuggroups"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "GroupID,  	[Label],  	Provider,  	[Comment]";
protoArray["0"]["m_strFrom"] = "FROM dbo.Adminuggroups";
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
obj = new SQLField(new XVar("m_strName", "GroupID", "m_strTable", "dbo.Adminuggroups", "m_srcTableName", "dbo.Adminuggroups"));

protoArray["6"]["m_sql"] = "GroupID";
protoArray["6"]["m_srcTableName"] = "dbo.Adminuggroups";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Label", "m_strTable", "dbo.Adminuggroups", "m_srcTableName", "dbo.Adminuggroups"));

protoArray["8"]["m_sql"] = "[Label]";
protoArray["8"]["m_srcTableName"] = "dbo.Adminuggroups";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Provider", "m_strTable", "dbo.Adminuggroups", "m_srcTableName", "dbo.Adminuggroups"));

protoArray["10"]["m_sql"] = "Provider";
protoArray["10"]["m_srcTableName"] = "dbo.Adminuggroups";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Comment", "m_strTable", "dbo.Adminuggroups", "m_srcTableName", "dbo.Adminuggroups"));

protoArray["12"]["m_sql"] = "[Comment]";
protoArray["12"]["m_srcTableName"] = "dbo.Adminuggroups";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.Adminuggroups";
protoArray["15"]["m_srcTableName"] = "dbo.Adminuggroups";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("GroupID");
protoArray["15"]["m_columns"].Add("Label");
protoArray["15"]["m_columns"].Add("Provider");
protoArray["15"]["m_columns"].Add("Comment");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.Adminuggroups";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.Adminuggroups";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_sql"] = "";
protoArray["16"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["16"]["m_column"] = obj;
protoArray["16"]["m_contained"] = SettingsMap.GetArray();
protoArray["16"]["m_strCase"] = "";
protoArray["16"]["m_havingmode"] = false;
protoArray["16"]["m_inBrackets"] = false;
protoArray["16"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["16"]);

protoArray["14"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["14"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.Adminuggroups";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["adminuggroups"] = obj;

				
		
			tdataArray["adminuggroups"][".sqlquery"] = queryData_Array["adminuggroups"];
			tdataArray["adminuggroups"][".hasEvents"] = false;
		}
	}

}
