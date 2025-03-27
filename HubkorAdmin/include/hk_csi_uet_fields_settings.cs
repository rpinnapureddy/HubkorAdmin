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
	public static partial class Settings_hk_csi_uet_fields
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".ShortName"] = "hk_csi_uet_fields";
			tdataArray["hk_csi_uet_fields"][".OwnerID"] = "";
			tdataArray["hk_csi_uet_fields"][".OriginalTable"] = "dbo.hk_csi_uet_fields";
			tdataArray["hk_csi_uet_fields"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}"));
			tdataArray["hk_csi_uet_fields"][".originalPagesByType"] = tdataArray["hk_csi_uet_fields"][".pagesByType"];
			tdataArray["hk_csi_uet_fields"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["hk_csi_uet_fields"][".originalPages"] = tdataArray["hk_csi_uet_fields"][".pages"];
			tdataArray["hk_csi_uet_fields"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["hk_csi_uet_fields"][".originalDefaultPages"] = tdataArray["hk_csi_uet_fields"][".defaultPages"];
			fieldLabelsArray["hk_csi_uet_fields"] = SettingsMap.GetArray();
			fieldToolTipsArray["hk_csi_uet_fields"] = SettingsMap.GetArray();
			pageTitlesArray["hk_csi_uet_fields"] = SettingsMap.GetArray();
			placeHoldersArray["hk_csi_uet_fields"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["hk_csi_uet_fields"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["hk_csi_uet_fields"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["hk_csi_uet_fields"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["hk_csi_uet_fields"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["hk_csi_uet_fields"]["English"]["Expr1"] = "Expr1";
				fieldToolTipsArray["hk_csi_uet_fields"]["English"]["Expr1"] = "";
				placeHoldersArray["hk_csi_uet_fields"]["English"]["Expr1"] = "";
				fieldLabelsArray["hk_csi_uet_fields"]["English"]["COLUMN_NAME"] = "COLUMN NAME";
				fieldToolTipsArray["hk_csi_uet_fields"]["English"]["COLUMN_NAME"] = "";
				placeHoldersArray["hk_csi_uet_fields"]["English"]["COLUMN_NAME"] = "";
				fieldLabelsArray["hk_csi_uet_fields"]["English"]["Expr2"] = "Expr2";
				fieldToolTipsArray["hk_csi_uet_fields"]["English"]["Expr2"] = "";
				placeHoldersArray["hk_csi_uet_fields"]["English"]["Expr2"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["hk_csi_uet_fields"]["English"])))
				{
					tdataArray["hk_csi_uet_fields"][".isUseToolTips"] = true;
				}
			}
			tdataArray["hk_csi_uet_fields"][".NCSearch"] = true;
			tdataArray["hk_csi_uet_fields"][".shortTableName"] = "hk_csi_uet_fields";
			tdataArray["hk_csi_uet_fields"][".nSecOptions"] = 0;
			tdataArray["hk_csi_uet_fields"][".mainTableOwnerID"] = "";
			tdataArray["hk_csi_uet_fields"][".entityType"] = 0;
			tdataArray["hk_csi_uet_fields"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["hk_csi_uet_fields"][".strOriginalTableName"] = "dbo.hk_csi_uet_fields";
			tdataArray["hk_csi_uet_fields"][".showAddInPopup"] = false;
			tdataArray["hk_csi_uet_fields"][".showEditInPopup"] = false;
			tdataArray["hk_csi_uet_fields"][".showViewInPopup"] = false;
			tdataArray["hk_csi_uet_fields"][".listAjax"] = false;
			tdataArray["hk_csi_uet_fields"][".audit"] = true;
			tdataArray["hk_csi_uet_fields"][".locking"] = false;
			GlobalVars.pages = tdataArray["hk_csi_uet_fields"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["hk_csi_uet_fields"][".edit"] = true;
				tdataArray["hk_csi_uet_fields"][".afterEditAction"] = 1;
				tdataArray["hk_csi_uet_fields"][".closePopupAfterEdit"] = 1;
				tdataArray["hk_csi_uet_fields"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["hk_csi_uet_fields"][".add"] = true;
				tdataArray["hk_csi_uet_fields"][".afterAddAction"] = 1;
				tdataArray["hk_csi_uet_fields"][".closePopupAfterAdd"] = 1;
				tdataArray["hk_csi_uet_fields"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["hk_csi_uet_fields"][".list"] = true;
			}
			tdataArray["hk_csi_uet_fields"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["hk_csi_uet_fields"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["hk_csi_uet_fields"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["hk_csi_uet_fields"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["hk_csi_uet_fields"][".printFriendly"] = true;
			}
			tdataArray["hk_csi_uet_fields"][".showSimpleSearchOptions"] = true;
			tdataArray["hk_csi_uet_fields"][".allowShowHideFields"] = true;
			tdataArray["hk_csi_uet_fields"][".allowFieldsReordering"] = true;
			tdataArray["hk_csi_uet_fields"][".isUseAjaxSuggest"] = true;


			tdataArray["hk_csi_uet_fields"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["hk_csi_uet_fields"][".buttonsAdded"] = false;
			tdataArray["hk_csi_uet_fields"][".addPageEvents"] = false;
			tdataArray["hk_csi_uet_fields"][".isUseTimeForSearch"] = false;
			tdataArray["hk_csi_uet_fields"][".badgeColor"] = "cfae83";
			tdataArray["hk_csi_uet_fields"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".googleLikeFields"].Add("Expr1");
			tdataArray["hk_csi_uet_fields"][".googleLikeFields"].Add("COLUMN_NAME");
			tdataArray["hk_csi_uet_fields"][".googleLikeFields"].Add("Expr2");
			tdataArray["hk_csi_uet_fields"][".tableType"] = "list";
			tdataArray["hk_csi_uet_fields"][".printerPageOrientation"] = 0;
			tdataArray["hk_csi_uet_fields"][".nPrinterPageScale"] = 100;
			tdataArray["hk_csi_uet_fields"][".nPrinterSplitRecords"] = 40;
			tdataArray["hk_csi_uet_fields"][".geocodingEnabled"] = false;
			tdataArray["hk_csi_uet_fields"][".pageSize"] = 20;
			tdataArray["hk_csi_uet_fields"][".warnLeavingPages"] = true;
			tstrOrderBy = "order by 	Expr1,	Expr2";
			tdataArray["hk_csi_uet_fields"][".strOrderBy"] = tstrOrderBy;
			tdataArray["hk_csi_uet_fields"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["hk_csi_uet_fields"][".orderindexes"].Add(new XVar(0, 1, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "Expr1"));
			tdataArray["hk_csi_uet_fields"][".orderindexes"].Add(new XVar(0, 3, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "Expr2"));
			tdataArray["hk_csi_uet_fields"][".sqlHead"] = "SELECT Expr1,  	COLUMN_NAME,  	Expr2";
			tdataArray["hk_csi_uet_fields"][".sqlFrom"] = "FROM dbo.hk_csi_uet_fields";
			tdataArray["hk_csi_uet_fields"][".sqlWhereExpr"] = "";
			tdataArray["hk_csi_uet_fields"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["hk_csi_uet_fields"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["hk_csi_uet_fields"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["hk_csi_uet_fields"][".highlightSearchResults"] = true;
			tableKeysArray["hk_csi_uet_fields"] = SettingsMap.GetArray();
			tableKeysArray["hk_csi_uet_fields"].Add("Expr1");
			tableKeysArray["hk_csi_uet_fields"].Add("COLUMN_NAME");
			tdataArray["hk_csi_uet_fields"][".Keys"] = tableKeysArray["hk_csi_uet_fields"];
			tdataArray["hk_csi_uet_fields"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Expr1";
			fdata["GoodName"] = "Expr1";
			fdata["ownerTable"] = "dbo.hk_csi_uet_fields";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_csi_uet_fields","Expr1");
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
			tdataArray["hk_csi_uet_fields"]["Expr1"] = fdata;
			tdataArray["hk_csi_uet_fields"][".searchableFields"].Add("Expr1");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "COLUMN_NAME";
			fdata["GoodName"] = "COLUMN_NAME";
			fdata["ownerTable"] = "dbo.hk_csi_uet_fields";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_csi_uet_fields","COLUMN_NAME");
			fdata["FieldType"] = 202;
			fdata["strField"] = "COLUMN_NAME";
			fdata["sourceSingle"] = "COLUMN_NAME";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "COLUMN_NAME";
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
			tdataArray["hk_csi_uet_fields"]["COLUMN_NAME"] = fdata;
			tdataArray["hk_csi_uet_fields"][".searchableFields"].Add("COLUMN_NAME");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "Expr2";
			fdata["GoodName"] = "Expr2";
			fdata["ownerTable"] = "dbo.hk_csi_uet_fields";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_hk_csi_uet_fields","Expr2");
			fdata["FieldType"] = 3;
			fdata["strField"] = "Expr2";
			fdata["sourceSingle"] = "Expr2";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Expr2";
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
			tdataArray["hk_csi_uet_fields"]["Expr2"] = fdata;
			tdataArray["hk_csi_uet_fields"][".searchableFields"].Add("Expr2");
			GlobalVars.tables_data["dbo.hk_csi_uet_fields"] = tdataArray["hk_csi_uet_fields"];
			GlobalVars.field_labels["dbo_hk_csi_uet_fields"] = fieldLabelsArray["hk_csi_uet_fields"];
			GlobalVars.fieldToolTips["dbo_hk_csi_uet_fields"] = fieldToolTipsArray["hk_csi_uet_fields"];
			GlobalVars.placeHolders["dbo_hk_csi_uet_fields"] = placeHoldersArray["hk_csi_uet_fields"];
			GlobalVars.page_titles["dbo_hk_csi_uet_fields"] = pageTitlesArray["hk_csi_uet_fields"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.hk_csi_uet_fields"));
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.hk_uet";
			detailsParam["dOriginalTable"] = "dbo.hk_uet";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "hk_uet";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_hk_uet"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex]["masterKeys"].Add("Expr1");
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex]["masterKeys"].Add("COLUMN_NAME");
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex]["detailKeys"].Add("table");
			GlobalVars.detailsTablesData["dbo.hk_csi_uet_fields"][dIndex]["detailKeys"].Add("field_to");
			GlobalVars.masterTablesData["dbo.hk_csi_uet_fields"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.hk_csi_uet_tables";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.hk_csi_uet_tables";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "hk_csi_uet_tables";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.hk_csi_uet_fields"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.hk_csi_uet_fields"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_csi_uet_fields"][0]["masterKeys"].Add("Expr1");
			GlobalVars.masterTablesData["dbo.hk_csi_uet_fields"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.hk_csi_uet_fields"][0]["detailKeys"].Add("Expr1");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Expr1,  	COLUMN_NAME,  	Expr2";
protoArray["0"]["m_strFrom"] = "FROM dbo.hk_csi_uet_fields";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "order by 	Expr1,	Expr2";
	
		
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
obj = new SQLField(new XVar("m_strName", "Expr1", "m_strTable", "dbo.hk_csi_uet_fields", "m_srcTableName", "dbo.hk_csi_uet_fields"));

protoArray["6"]["m_sql"] = "Expr1";
protoArray["6"]["m_srcTableName"] = "dbo.hk_csi_uet_fields";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "COLUMN_NAME", "m_strTable", "dbo.hk_csi_uet_fields", "m_srcTableName", "dbo.hk_csi_uet_fields"));

protoArray["8"]["m_sql"] = "COLUMN_NAME";
protoArray["8"]["m_srcTableName"] = "dbo.hk_csi_uet_fields";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Expr2", "m_strTable", "dbo.hk_csi_uet_fields", "m_srcTableName", "dbo.hk_csi_uet_fields"));

protoArray["10"]["m_sql"] = "Expr2";
protoArray["10"]["m_srcTableName"] = "dbo.hk_csi_uet_fields";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.hk_csi_uet_fields";
protoArray["13"]["m_srcTableName"] = "dbo.hk_csi_uet_fields";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("Expr1");
protoArray["13"]["m_columns"].Add("COLUMN_NAME");
protoArray["13"]["m_columns"].Add("Expr2");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.hk_csi_uet_fields";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.hk_csi_uet_fields";
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
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Expr1", "m_strTable", "dbo.hk_csi_uet_fields", "m_srcTableName", "dbo.hk_csi_uet_fields"));

protoArray["16"]["m_column"] = obj;
protoArray["16"]["m_bAsc"] = 1;
protoArray["16"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["16"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Expr2", "m_strTable", "dbo.hk_csi_uet_fields", "m_srcTableName", "dbo.hk_csi_uet_fields"));

protoArray["18"]["m_column"] = obj;
protoArray["18"]["m_bAsc"] = 1;
protoArray["18"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["18"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "dbo.hk_csi_uet_fields";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["hk_csi_uet_fields"] = obj;

				
		
			tdataArray["hk_csi_uet_fields"][".sqlquery"] = queryData_Array["hk_csi_uet_fields"];
			tdataArray["hk_csi_uet_fields"][".hasEvents"] = false;
		}
	}

}
