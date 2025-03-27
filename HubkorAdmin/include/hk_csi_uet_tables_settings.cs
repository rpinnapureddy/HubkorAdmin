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
	public static partial class Settings_hk_csi_uet_tables
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".ShortName"] = "hk_csi_uet_tables";
			tdataArray["hk_csi_uet_tables"][".OwnerID"] = "";
			tdataArray["hk_csi_uet_tables"][".OriginalTable"] = "dbo.hk_csi_uet_tables";
			tdataArray["hk_csi_uet_tables"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"]}"));
			tdataArray["hk_csi_uet_tables"][".originalPagesByType"] = tdataArray["hk_csi_uet_tables"][".pagesByType"];
			tdataArray["hk_csi_uet_tables"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"]}")));
			tdataArray["hk_csi_uet_tables"][".originalPages"] = tdataArray["hk_csi_uet_tables"][".pages"];
			tdataArray["hk_csi_uet_tables"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\"}"));
			tdataArray["hk_csi_uet_tables"][".originalDefaultPages"] = tdataArray["hk_csi_uet_tables"][".defaultPages"];
			fieldLabelsArray["hk_csi_uet_tables"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_csi_uet_tables"] = SettingsMap.GetArray();
			pageTitlesArray["hk_csi_uet_tables"] = SettingsMap.GetArray();
			placeHoldersArray["hk_csi_uet_tables"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_csi_uet_tables"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_csi_uet_tables"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_csi_uet_tables"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_csi_uet_tables"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_csi_uet_tables"]["English"]["Expr1"] = "Expr1";
				fieldToolTipsArray["hk_csi_uet_tables"]["English"]["Expr1"] = "";
				placeHoldersArray["hk_csi_uet_tables"]["English"]["Expr1"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_csi_uet_tables"]["English"])))
				{
					tdataArray["hk_csi_uet_tables"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_csi_uet_tables"][".NCSearch"] = true;
			tdataArray["hk_csi_uet_tables"][".shortTableName"] = "hk_csi_uet_tables";
			tdataArray["hk_csi_uet_tables"][".nSecOptions"] = 0;
			tdataArray["hk_csi_uet_tables"][".mainTableOwnerID"] = "";
			tdataArray["hk_csi_uet_tables"][".entityType"] = 0;
			tdataArray["hk_csi_uet_tables"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_csi_uet_tables"][".strOriginalTableName"] = "dbo.hk_csi_uet_tables";
			tdataArray["hk_csi_uet_tables"][".showAddInPopup"] = false;
			tdataArray["hk_csi_uet_tables"][".showEditInPopup"] = false;
			tdataArray["hk_csi_uet_tables"][".showViewInPopup"] = false;
			tdataArray["hk_csi_uet_tables"][".listAjax"] = false;
			tdataArray["hk_csi_uet_tables"][".audit"] = true;
			tdataArray["hk_csi_uet_tables"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_csi_uet_tables"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_csi_uet_tables"][".edit"] = true;
				tdataArray["hk_csi_uet_tables"][".afterEditAction"] = 1;
				tdataArray["hk_csi_uet_tables"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_csi_uet_tables"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_csi_uet_tables"][".add"] = true;
				tdataArray["hk_csi_uet_tables"][".afterAddAction"] = 1;
				tdataArray["hk_csi_uet_tables"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_csi_uet_tables"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_csi_uet_tables"][".list"] = true;
			}
			tdataArray["hk_csi_uet_tables"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_csi_uet_tables"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_csi_uet_tables"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_csi_uet_tables"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_csi_uet_tables"][".printFriendly"] = true;
			}
			tdataArray["hk_csi_uet_tables"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_csi_uet_tables"][".allowShowHideFields"] = true;
			tdataArray["hk_csi_uet_tables"][".allowFieldsReordering"] = true;
			tdataArray["hk_csi_uet_tables"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_csi_uet_tables"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_csi_uet_tables"][".buttonsAdded"] = false;
			tdataArray["hk_csi_uet_tables"][".addPageEvents"] = false;
			tdataArray["hk_csi_uet_tables"][".isUseTimeForSearch"] = false;
			tdataArray["hk_csi_uet_tables"][".badgeColor"] = "5F9EA0";
			tdataArray["hk_csi_uet_tables"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".googleLikeFields"].Add("Expr1");
			tdataArray["hk_csi_uet_tables"][".tableType"] = "list";
			tdataArray["hk_csi_uet_tables"][".printerPageOrientation"] = 0;
			tdataArray["hk_csi_uet_tables"][".nPrinterPageScale"] = 100;
			tdataArray["hk_csi_uet_tables"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_csi_uet_tables"][".geocodingEnabled"] = false;
			tdataArray["hk_csi_uet_tables"][".pageSize"] = 20;
			tdataArray["hk_csi_uet_tables"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["hk_csi_uet_tables"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_csi_uet_tables"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_tables"][".sqlHead"] = "SELECT Expr1";
			tdataArray["hk_csi_uet_tables"][".sqlFrom"] = "FROM dbo.hk_csi_uet_tables";
			tdataArray["hk_csi_uet_tables"][".sqlWhereExpr"] = "";
			tdataArray["hk_csi_uet_tables"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_csi_uet_tables"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_csi_uet_tables"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_csi_uet_tables"][".highlightSearchResults"] = true;
			tableKeysArray["hk_csi_uet_tables"] = SettingsMap.GetArray();
			tableKeysArray["hk_csi_uet_tables"].Add("Expr1");
			tdataArray["hk_csi_uet_tables"][".Keys"] = tableKeysArray["hk_csi_uet_tables"];
			tdataArray["hk_csi_uet_tables"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Expr1";
			fdata["GoodName"] = "Expr1";
			fdata["ownerTable"] = "dbo.hk_csi_uet_tables";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_csi_uet_tables","Expr1");
			fdata["FieldType"] = 202;
			fdata["strField"] = "Expr1";
			fdata["sourceSingle"] = "Expr1";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Expr1";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=4000");
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
			tdataArray["hk_csi_uet_tables"]["Expr1"] = fdata;
			tdataArray["hk_csi_uet_tables"][".searchableFields"].Add("Expr1");
			GlobalVars.tables_data["dbo.hk_csi_uet_tables"] = tdataArray["hk_csi_uet_tables"];
			GlobalVars.field_labels["dbo_hk_csi_uet_tables"] = fieldLabelsArray["hk_csi_uet_tables"];
			GlobalVars.fieldToolTips["dbo_hk_csi_uet_tables"] = fieldToolTipsArray["hk_csi_uet_tables"];
			GlobalVars.placeHolders["dbo_hk_csi_uet_tables"] = placeHoldersArray["hk_csi_uet_tables"];
			GlobalVars.page_titles["dbo_hk_csi_uet_tables"] = pageTitlesArray["hk_csi_uet_tables"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_csi_uet_tables"));
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.hk_csi_uet_fields";
			detailsParam["dOriginalTable"] = "dbo.hk_csi_uet_fields";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "hk_csi_uet_fields";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_hk_csi_uet_fields"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["masterKeys"].Add("Expr1");
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["detailKeys"].Add("Expr1");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.hk_uet";
			detailsParam["dOriginalTable"] = "dbo.hk_uet";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "hk_uet";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_hk_uet"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["masterKeys"].Add("Expr1");
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_tables"][dIndex]["detailKeys"].Add("table");
			GlobalVars.masterTablesData["dbo.hk_csi_uet_tables"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Expr1";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_csi_uet_tables";
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
obj = new SQLField(new XVar("m_strName", "Expr1", "m_strTable", "dbo.hk_csi_uet_tables", "m_srcTableName", "dbo.hk_csi_uet_tables"));

protoArray["6"]["m_sql"] = "Expr1";
protoArray["6"]["m_srcTableName"] = "dbo.hk_csi_uet_tables";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["8"] = SettingsMap.GetArray();
protoArray["8"]["m_link"] = "SQLL_MAIN";
protoArray["9"] = SettingsMap.GetArray();
protoArray["9"]["m_strName"] = "dbo.hk_csi_uet_tables";
protoArray["9"]["m_srcTableName"] = "dbo.hk_csi_uet_tables";
protoArray["9"]["m_columns"] = SettingsMap.GetArray();
protoArray["9"]["m_columns"].Add("Expr1");
obj = new SQLTable(protoArray["9"]);

protoArray["8"]["m_table"] = obj;
protoArray["8"]["m_sql"] = "dbo.hk_csi_uet_tables";
protoArray["8"]["m_alias"] = "";
protoArray["8"]["m_srcTableName"] = "dbo.hk_csi_uet_tables";
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_sql"] = "";
protoArray["10"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["10"]["m_column"] = obj;
protoArray["10"]["m_contained"] = SettingsMap.GetArray();
protoArray["10"]["m_strCase"] = "";
protoArray["10"]["m_havingmode"] = false;
protoArray["10"]["m_inBrackets"] = false;
protoArray["10"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["10"]);

protoArray["8"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["8"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.hk_csi_uet_tables";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_csi_uet_tables"] = obj;

				
		
			tdataArray["hk_csi_uet_tables"][".sqlquery"] = queryData_Array["hk_csi_uet_tables"];
			tdataArray["hk_csi_uet_tables"][".hasEvents"] = false;
		}
	}

}
