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
	public static partial class Settings_tp_invoice_temp
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".ShortName"] = "tp_invoice_temp";
			tdataArray["tp_invoice_temp"][".OwnerID"] = "";
			tdataArray["tp_invoice_temp"][".OriginalTable"] = "dbo.tp_invoice_temp";
			tdataArray["tp_invoice_temp"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}"));
			tdataArray["tp_invoice_temp"][".originalPagesByType"] = tdataArray["tp_invoice_temp"][".pagesByType"];
			tdataArray["tp_invoice_temp"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["tp_invoice_temp"][".originalPages"] = tdataArray["tp_invoice_temp"][".pages"];
			tdataArray["tp_invoice_temp"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["tp_invoice_temp"][".originalDefaultPages"] = tdataArray["tp_invoice_temp"][".defaultPages"];
			fieldLabelsArray["tp_invoice_temp"] = SettingsMap.GetArray();
			fieldToolTipsArray["tp_invoice_temp"] = SettingsMap.GetArray();
			pageTitlesArray["tp_invoice_temp"] = SettingsMap.GetArray();
			placeHoldersArray["tp_invoice_temp"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["tp_invoice_temp"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["tp_invoice_temp"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["tp_invoice_temp"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["tp_invoice_temp"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["tp_invoice_temp"]["English"]["invoice_id"] = "Invoice Id";
				fieldToolTipsArray["tp_invoice_temp"]["English"]["invoice_id"] = "";
				placeHoldersArray["tp_invoice_temp"]["English"]["invoice_id"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["tp_invoice_temp"]["English"])))
				{
					tdataArray["tp_invoice_temp"][".isUseToolTips"] = true;
				}
			}
			tdataArray["tp_invoice_temp"][".NCSearch"] = true;
			tdataArray["tp_invoice_temp"][".shortTableName"] = "tp_invoice_temp";
			tdataArray["tp_invoice_temp"][".nSecOptions"] = 0;
			tdataArray["tp_invoice_temp"][".mainTableOwnerID"] = "";
			tdataArray["tp_invoice_temp"][".entityType"] = 0;
			tdataArray["tp_invoice_temp"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["tp_invoice_temp"][".strOriginalTableName"] = "dbo.tp_invoice_temp";
			tdataArray["tp_invoice_temp"][".showAddInPopup"] = false;
			tdataArray["tp_invoice_temp"][".showEditInPopup"] = false;
			tdataArray["tp_invoice_temp"][".showViewInPopup"] = false;
			tdataArray["tp_invoice_temp"][".listAjax"] = false;
			tdataArray["tp_invoice_temp"][".audit"] = false;
			tdataArray["tp_invoice_temp"][".locking"] = false;
			GlobalVars.pages = tdataArray["tp_invoice_temp"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["tp_invoice_temp"][".edit"] = true;
				tdataArray["tp_invoice_temp"][".afterEditAction"] = 1;
				tdataArray["tp_invoice_temp"][".closePopupAfterEdit"] = 1;
				tdataArray["tp_invoice_temp"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["tp_invoice_temp"][".add"] = true;
				tdataArray["tp_invoice_temp"][".afterAddAction"] = 1;
				tdataArray["tp_invoice_temp"][".closePopupAfterAdd"] = 1;
				tdataArray["tp_invoice_temp"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["tp_invoice_temp"][".list"] = true;
			}
			tdataArray["tp_invoice_temp"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["tp_invoice_temp"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["tp_invoice_temp"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["tp_invoice_temp"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["tp_invoice_temp"][".printFriendly"] = true;
			}
			tdataArray["tp_invoice_temp"][".showSimpleSearchOptions"] = true;
			tdataArray["tp_invoice_temp"][".allowShowHideFields"] = true;
			tdataArray["tp_invoice_temp"][".allowFieldsReordering"] = true;
			tdataArray["tp_invoice_temp"][".isUseAjaxSuggest"] = true;


			tdataArray["tp_invoice_temp"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["tp_invoice_temp"][".buttonsAdded"] = false;
			tdataArray["tp_invoice_temp"][".addPageEvents"] = false;
			tdataArray["tp_invoice_temp"][".isUseTimeForSearch"] = false;
			tdataArray["tp_invoice_temp"][".badgeColor"] = "1E90FF";
			tdataArray["tp_invoice_temp"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".googleLikeFields"].Add("invoice_id");
			tdataArray["tp_invoice_temp"][".tableType"] = "list";
			tdataArray["tp_invoice_temp"][".printerPageOrientation"] = 0;
			tdataArray["tp_invoice_temp"][".nPrinterPageScale"] = 100;
			tdataArray["tp_invoice_temp"][".nPrinterSplitRecords"] = 40;
			tdataArray["tp_invoice_temp"][".geocodingEnabled"] = false;
			tdataArray["tp_invoice_temp"][".pageSize"] = 20;
			tdataArray["tp_invoice_temp"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["tp_invoice_temp"][".strOrderBy"] = tstrOrderBy;
			tdataArray["tp_invoice_temp"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["tp_invoice_temp"][".sqlHead"] = "SELECT invoice_id";
			tdataArray["tp_invoice_temp"][".sqlFrom"] = "FROM dbo.tp_invoice_temp";
			tdataArray["tp_invoice_temp"][".sqlWhereExpr"] = "";
			tdataArray["tp_invoice_temp"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["tp_invoice_temp"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["tp_invoice_temp"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["tp_invoice_temp"][".highlightSearchResults"] = true;
			tableKeysArray["tp_invoice_temp"] = SettingsMap.GetArray();
			tableKeysArray["tp_invoice_temp"].Add("invoice_id");
			tdataArray["tp_invoice_temp"][".Keys"] = tableKeysArray["tp_invoice_temp"];
			tdataArray["tp_invoice_temp"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "invoice_id";
			fdata["GoodName"] = "invoice_id";
			fdata["ownerTable"] = "dbo.tp_invoice_temp";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_tp_invoice_temp","invoice_id");
			fdata["FieldType"] = 202;
			fdata["strField"] = "invoice_id";
			fdata["sourceSingle"] = "invoice_id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "invoice_id";
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
			tdataArray["tp_invoice_temp"]["invoice_id"] = fdata;
			tdataArray["tp_invoice_temp"][".searchableFields"].Add("invoice_id");
			GlobalVars.tables_data["dbo.tp_invoice_temp"] = tdataArray["tp_invoice_temp"];
			GlobalVars.field_labels["dbo_tp_invoice_temp"] = fieldLabelsArray["tp_invoice_temp"];
			GlobalVars.fieldToolTips["dbo_tp_invoice_temp"] = fieldToolTipsArray["tp_invoice_temp"];
			GlobalVars.placeHolders["dbo_tp_invoice_temp"] = placeHoldersArray["tp_invoice_temp"];
			GlobalVars.page_titles["dbo_tp_invoice_temp"] = pageTitlesArray["tp_invoice_temp"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.tp_invoice_temp"));
			GlobalVars.detailsTablesData["dbo.tp_invoice_temp"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.tp_invoice_temp"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "invoice_id";
protoArray["0"]["m_strFrom"] = "FROM dbo.tp_invoice_temp";
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
obj = new SQLField(new XVar("m_strName", "invoice_id", "m_strTable", "dbo.tp_invoice_temp", "m_srcTableName", "dbo.tp_invoice_temp"));

protoArray["6"]["m_sql"] = "invoice_id";
protoArray["6"]["m_srcTableName"] = "dbo.tp_invoice_temp";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["8"] = SettingsMap.GetArray();
protoArray["8"]["m_link"] = "SQLL_MAIN";
protoArray["9"] = SettingsMap.GetArray();
protoArray["9"]["m_strName"] = "dbo.tp_invoice_temp";
protoArray["9"]["m_srcTableName"] = "dbo.tp_invoice_temp";
protoArray["9"]["m_columns"] = SettingsMap.GetArray();
protoArray["9"]["m_columns"].Add("invoice_id");
obj = new SQLTable(protoArray["9"]);

protoArray["8"]["m_table"] = obj;
protoArray["8"]["m_sql"] = "dbo.tp_invoice_temp";
protoArray["8"]["m_alias"] = "";
protoArray["8"]["m_srcTableName"] = "dbo.tp_invoice_temp";
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
protoArray["0"]["m_srcTableName"] = "dbo.tp_invoice_temp";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["tp_invoice_temp"] = obj;

				
		
			tdataArray["tp_invoice_temp"][".sqlquery"] = queryData_Array["tp_invoice_temp"];
			tdataArray["tp_invoice_temp"][".hasEvents"] = false;
		}
	}

}
