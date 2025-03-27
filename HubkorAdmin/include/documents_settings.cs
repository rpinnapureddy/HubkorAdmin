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
	public static partial class Settings_documents
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["documents"] = SettingsMap.GetArray();
			tdataArray["documents"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["documents"][".ShortName"] = "documents";
			tdataArray["documents"][".OwnerID"] = "";
			tdataArray["documents"][".OriginalTable"] = "dbo.documents";
			tdataArray["documents"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["documents"][".originalPagesByType"] = tdataArray["documents"][".pagesByType"];
			tdataArray["documents"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["documents"][".originalPages"] = tdataArray["documents"][".pages"];
			tdataArray["documents"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["documents"][".originalDefaultPages"] = tdataArray["documents"][".defaultPages"];
			fieldLabelsArray["documents"] = SettingsMap.GetArray();
			fieldToolTipsArray["documents"] = SettingsMap.GetArray();
			pageTitlesArray["documents"] = SettingsMap.GetArray();
			placeHoldersArray["documents"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["documents"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["documents"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["documents"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["documents"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["documents"]["English"]["id"] = "Id";
				fieldToolTipsArray["documents"]["English"]["id"] = "";
				placeHoldersArray["documents"]["English"]["id"] = "";
				fieldLabelsArray["documents"]["English"]["clientid"] = "Clientid";
				fieldToolTipsArray["documents"]["English"]["clientid"] = "";
				placeHoldersArray["documents"]["English"]["clientid"] = "";
				fieldLabelsArray["documents"]["English"]["apps"] = "Apps";
				fieldToolTipsArray["documents"]["English"]["apps"] = "";
				placeHoldersArray["documents"]["English"]["apps"] = "";
				fieldLabelsArray["documents"]["English"]["description"] = "Description";
				fieldToolTipsArray["documents"]["English"]["description"] = "";
				placeHoldersArray["documents"]["English"]["description"] = "";
				fieldLabelsArray["documents"]["English"]["file_name"] = "File Name";
				fieldToolTipsArray["documents"]["English"]["file_name"] = "";
				placeHoldersArray["documents"]["English"]["file_name"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["documents"]["English"])))
				{
					tdataArray["documents"][".isUseToolTips"] = true;
				}
			}
			tdataArray["documents"][".NCSearch"] = true;
			tdataArray["documents"][".shortTableName"] = "documents";
			tdataArray["documents"][".nSecOptions"] = 0;
			tdataArray["documents"][".mainTableOwnerID"] = "";
			tdataArray["documents"][".entityType"] = 0;
			tdataArray["documents"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["documents"][".strOriginalTableName"] = "dbo.documents";
			tdataArray["documents"][".showAddInPopup"] = false;
			tdataArray["documents"][".showEditInPopup"] = false;
			tdataArray["documents"][".showViewInPopup"] = false;
			tdataArray["documents"][".listAjax"] = false;
			tdataArray["documents"][".audit"] = false;
			tdataArray["documents"][".locking"] = false;
			GlobalVars.pages = tdataArray["documents"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["documents"][".edit"] = true;
				tdataArray["documents"][".afterEditAction"] = 1;
				tdataArray["documents"][".closePopupAfterEdit"] = 1;
				tdataArray["documents"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["documents"][".add"] = true;
				tdataArray["documents"][".afterAddAction"] = 1;
				tdataArray["documents"][".closePopupAfterAdd"] = 1;
				tdataArray["documents"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["documents"][".list"] = true;
			}
			tdataArray["documents"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["documents"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["documents"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["documents"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["documents"][".printFriendly"] = true;
			}
			tdataArray["documents"][".showSimpleSearchOptions"] = true;
			tdataArray["documents"][".allowShowHideFields"] = true;
			tdataArray["documents"][".allowFieldsReordering"] = true;
			tdataArray["documents"][".isUseAjaxSuggest"] = true;


			tdataArray["documents"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["documents"][".buttonsAdded"] = false;
			tdataArray["documents"][".addPageEvents"] = false;
			tdataArray["documents"][".isUseTimeForSearch"] = false;
			tdataArray["documents"][".badgeColor"] = "4682B4";
			tdataArray["documents"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["documents"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["documents"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["documents"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["documents"][".googleLikeFields"].Add("id");
			tdataArray["documents"][".googleLikeFields"].Add("clientid");
			tdataArray["documents"][".googleLikeFields"].Add("apps");
			tdataArray["documents"][".googleLikeFields"].Add("description");
			tdataArray["documents"][".googleLikeFields"].Add("file_name");
			tdataArray["documents"][".tableType"] = "list";
			tdataArray["documents"][".printerPageOrientation"] = 0;
			tdataArray["documents"][".nPrinterPageScale"] = 100;
			tdataArray["documents"][".nPrinterSplitRecords"] = 40;
			tdataArray["documents"][".geocodingEnabled"] = false;
			tdataArray["documents"][".pageSize"] = 20;
			tdataArray["documents"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["documents"][".strOrderBy"] = tstrOrderBy;
			tdataArray["documents"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["documents"][".sqlHead"] = "SELECT id,  	clientid,  	apps,  	description,  	file_name";
			tdataArray["documents"][".sqlFrom"] = "FROM dbo.documents";
			tdataArray["documents"][".sqlWhereExpr"] = "";
			tdataArray["documents"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["documents"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["documents"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["documents"][".highlightSearchResults"] = true;
			tableKeysArray["documents"] = SettingsMap.GetArray();
			tableKeysArray["documents"].Add("id");
			tdataArray["documents"][".Keys"] = tableKeysArray["documents"];
			tdataArray["documents"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "dbo.documents";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_documents","id");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id";
			fdata["sourceSingle"] = "id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id";
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
			tdataArray["documents"]["id"] = fdata;
			tdataArray["documents"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "clientid";
			fdata["GoodName"] = "clientid";
			fdata["ownerTable"] = "dbo.documents";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_documents","clientid");
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
			tdataArray["documents"]["clientid"] = fdata;
			tdataArray["documents"][".searchableFields"].Add("clientid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "apps";
			fdata["GoodName"] = "apps";
			fdata["ownerTable"] = "dbo.documents";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_documents","apps");
			fdata["FieldType"] = 202;
			fdata["strField"] = "apps";
			fdata["sourceSingle"] = "apps";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "apps";
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
			tdataArray["documents"]["apps"] = fdata;
			tdataArray["documents"][".searchableFields"].Add("apps");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "description";
			fdata["GoodName"] = "description";
			fdata["ownerTable"] = "dbo.documents";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_documents","description");
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
			tdataArray["documents"]["description"] = fdata;
			tdataArray["documents"][".searchableFields"].Add("description");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "file_name";
			fdata["GoodName"] = "file_name";
			fdata["ownerTable"] = "dbo.documents";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_documents","file_name");
			fdata["FieldType"] = 202;
			fdata["strField"] = "file_name";
			fdata["sourceSingle"] = "file_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "file_name";
			fdata["DeleteAssociatedFile"] = true;
			fdata["UploadFolder"] = "C:\\Hubkor\\files\\documents";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Document Download");
			vdata["ShowThumbnail"] = true;
			vdata["ShowFileSize"] = true;
			vdata["ShowIcon"] = true;
			vdata["DisplayPDF"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Document upload");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			edata["CreateThumbnail"] = true;
			edata["StrThumbnail"] = "th";
			edata["ThumbnailSize"] = 600;
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["Absolute"] = true;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["documents"]["file_name"] = fdata;
			tdataArray["documents"][".searchableFields"].Add("file_name");
			GlobalVars.tables_data["dbo.documents"] = tdataArray["documents"];
			GlobalVars.field_labels["dbo_documents"] = fieldLabelsArray["documents"];
			GlobalVars.fieldToolTips["dbo_documents"] = fieldToolTipsArray["documents"];
			GlobalVars.placeHolders["dbo_documents"] = placeHoldersArray["documents"];
			GlobalVars.page_titles["dbo_documents"] = pageTitlesArray["documents"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.documents"));
			GlobalVars.detailsTablesData["dbo.documents"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.documents"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	clientid,  	apps,  	description,  	file_name";
protoArray["0"]["m_strFrom"] = "FROM dbo.documents";
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "dbo.documents", "m_srcTableName", "dbo.documents"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "dbo.documents";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "clientid", "m_strTable", "dbo.documents", "m_srcTableName", "dbo.documents"));

protoArray["8"]["m_sql"] = "clientid";
protoArray["8"]["m_srcTableName"] = "dbo.documents";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "apps", "m_strTable", "dbo.documents", "m_srcTableName", "dbo.documents"));

protoArray["10"]["m_sql"] = "apps";
protoArray["10"]["m_srcTableName"] = "dbo.documents";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "description", "m_strTable", "dbo.documents", "m_srcTableName", "dbo.documents"));

protoArray["12"]["m_sql"] = "description";
protoArray["12"]["m_srcTableName"] = "dbo.documents";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "file_name", "m_strTable", "dbo.documents", "m_srcTableName", "dbo.documents"));

protoArray["14"]["m_sql"] = "file_name";
protoArray["14"]["m_srcTableName"] = "dbo.documents";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.documents";
protoArray["17"]["m_srcTableName"] = "dbo.documents";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("id");
protoArray["17"]["m_columns"].Add("clientid");
protoArray["17"]["m_columns"].Add("apps");
protoArray["17"]["m_columns"].Add("description");
protoArray["17"]["m_columns"].Add("file_name");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.documents";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.documents";
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
protoArray["0"]["m_srcTableName"] = "dbo.documents";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["documents"] = obj;

				
		
			tdataArray["documents"][".sqlquery"] = queryData_Array["documents"];
			tdataArray["documents"][".hasEvents"] = false;
		}
	}

}
