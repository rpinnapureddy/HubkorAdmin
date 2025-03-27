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
	public static partial class Settings_sourcemanagement
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["sourcemanagement"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".ShortName"] = "sourcemanagement";
			tdataArray["sourcemanagement"][".OwnerID"] = "";
			tdataArray["sourcemanagement"][".OriginalTable"] = "dbo.SourceManagement";
			tdataArray["sourcemanagement"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["sourcemanagement"][".originalPagesByType"] = tdataArray["sourcemanagement"][".pagesByType"];
			tdataArray["sourcemanagement"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["sourcemanagement"][".originalPages"] = tdataArray["sourcemanagement"][".pages"];
			tdataArray["sourcemanagement"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["sourcemanagement"][".originalDefaultPages"] = tdataArray["sourcemanagement"][".defaultPages"];
			fieldLabelsArray["sourcemanagement"] = SettingsMap.GetArray();
			fieldToolTipsArray["sourcemanagement"] = SettingsMap.GetArray();
			pageTitlesArray["sourcemanagement"] = SettingsMap.GetArray();
			placeHoldersArray["sourcemanagement"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["sourcemanagement"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["sourcemanagement"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["sourcemanagement"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["sourcemanagement"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["sourcemanagement"]["English"]["Application"] = "Application";
				fieldToolTipsArray["sourcemanagement"]["English"]["Application"] = "";
				placeHoldersArray["sourcemanagement"]["English"]["Application"] = "";
				fieldLabelsArray["sourcemanagement"]["English"]["CreatedDate"] = "Created Date";
				fieldToolTipsArray["sourcemanagement"]["English"]["CreatedDate"] = "";
				placeHoldersArray["sourcemanagement"]["English"]["CreatedDate"] = "";
				fieldLabelsArray["sourcemanagement"]["English"]["User"] = "User";
				fieldToolTipsArray["sourcemanagement"]["English"]["User"] = "";
				placeHoldersArray["sourcemanagement"]["English"]["User"] = "";
				fieldLabelsArray["sourcemanagement"]["English"]["Description"] = "Description";
				fieldToolTipsArray["sourcemanagement"]["English"]["Description"] = "";
				placeHoldersArray["sourcemanagement"]["English"]["Description"] = "";
				fieldLabelsArray["sourcemanagement"]["English"]["ChangeSet"] = "Change Set";
				fieldToolTipsArray["sourcemanagement"]["English"]["ChangeSet"] = "";
				placeHoldersArray["sourcemanagement"]["English"]["ChangeSet"] = "";
				fieldLabelsArray["sourcemanagement"]["English"]["Id"] = "Id";
				fieldToolTipsArray["sourcemanagement"]["English"]["Id"] = "";
				placeHoldersArray["sourcemanagement"]["English"]["Id"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["sourcemanagement"]["English"])))
				{
					tdataArray["sourcemanagement"][".isUseToolTips"] = true;
				}
			}
			tdataArray["sourcemanagement"][".NCSearch"] = true;
			tdataArray["sourcemanagement"][".shortTableName"] = "sourcemanagement";
			tdataArray["sourcemanagement"][".nSecOptions"] = 0;
			tdataArray["sourcemanagement"][".mainTableOwnerID"] = "";
			tdataArray["sourcemanagement"][".entityType"] = 0;
			tdataArray["sourcemanagement"][".connId"] = "Hubkoratec218206166241compute1";
			tdataArray["sourcemanagement"][".strOriginalTableName"] = "dbo.SourceManagement";
			tdataArray["sourcemanagement"][".showAddInPopup"] = false;
			tdataArray["sourcemanagement"][".showEditInPopup"] = false;
			tdataArray["sourcemanagement"][".showViewInPopup"] = false;
			tdataArray["sourcemanagement"][".listAjax"] = false;
			tdataArray["sourcemanagement"][".audit"] = false;
			tdataArray["sourcemanagement"][".locking"] = false;
			GlobalVars.pages = tdataArray["sourcemanagement"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["sourcemanagement"][".edit"] = true;
				tdataArray["sourcemanagement"][".afterEditAction"] = 1;
				tdataArray["sourcemanagement"][".closePopupAfterEdit"] = 1;
				tdataArray["sourcemanagement"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["sourcemanagement"][".add"] = true;
				tdataArray["sourcemanagement"][".afterAddAction"] = 1;
				tdataArray["sourcemanagement"][".closePopupAfterAdd"] = 1;
				tdataArray["sourcemanagement"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["sourcemanagement"][".list"] = true;
			}
			tdataArray["sourcemanagement"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["sourcemanagement"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["sourcemanagement"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["sourcemanagement"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["sourcemanagement"][".printFriendly"] = true;
			}
			tdataArray["sourcemanagement"][".showSimpleSearchOptions"] = true;
			tdataArray["sourcemanagement"][".allowShowHideFields"] = true;
			tdataArray["sourcemanagement"][".allowFieldsReordering"] = true;
			tdataArray["sourcemanagement"][".isUseAjaxSuggest"] = true;


			tdataArray["sourcemanagement"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["sourcemanagement"][".buttonsAdded"] = false;
			tdataArray["sourcemanagement"][".addPageEvents"] = false;
			tdataArray["sourcemanagement"][".isUseTimeForSearch"] = false;
			tdataArray["sourcemanagement"][".badgeColor"] = "E8926F";
			tdataArray["sourcemanagement"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".googleLikeFields"].Add("Application");
			tdataArray["sourcemanagement"][".googleLikeFields"].Add("CreatedDate");
			tdataArray["sourcemanagement"][".googleLikeFields"].Add("User");
			tdataArray["sourcemanagement"][".googleLikeFields"].Add("Description");
			tdataArray["sourcemanagement"][".googleLikeFields"].Add("ChangeSet");
			tdataArray["sourcemanagement"][".googleLikeFields"].Add("Id");
			tdataArray["sourcemanagement"][".tableType"] = "list";
			tdataArray["sourcemanagement"][".printerPageOrientation"] = 0;
			tdataArray["sourcemanagement"][".nPrinterPageScale"] = 100;
			tdataArray["sourcemanagement"][".nPrinterSplitRecords"] = 40;
			tdataArray["sourcemanagement"][".geocodingEnabled"] = false;
			tdataArray["sourcemanagement"][".pageSize"] = 20;
			tdataArray["sourcemanagement"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["sourcemanagement"][".strOrderBy"] = tstrOrderBy;
			tdataArray["sourcemanagement"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["sourcemanagement"][".sqlHead"] = "SELECT Application,  	CreatedDate,  	[User],  	Description,  	ChangeSet,  	Id";
			tdataArray["sourcemanagement"][".sqlFrom"] = "FROM dbo.SourceManagement";
			tdataArray["sourcemanagement"][".sqlWhereExpr"] = "";
			tdataArray["sourcemanagement"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["sourcemanagement"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["sourcemanagement"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["sourcemanagement"][".highlightSearchResults"] = true;
			tableKeysArray["sourcemanagement"] = SettingsMap.GetArray();
			tableKeysArray["sourcemanagement"].Add("Id");
			tdataArray["sourcemanagement"][".Keys"] = tableKeysArray["sourcemanagement"];
			tdataArray["sourcemanagement"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Application";
			fdata["GoodName"] = "Application";
			fdata["ownerTable"] = "dbo.SourceManagement";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SourceManagement","Application");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Application";
			fdata["sourceSingle"] = "Application";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Application";
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
			edata["LinkField"] = "name";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "name";
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
			tdataArray["sourcemanagement"]["Application"] = fdata;
			tdataArray["sourcemanagement"][".searchableFields"].Add("Application");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "CreatedDate";
			fdata["GoodName"] = "CreatedDate";
			fdata["ownerTable"] = "dbo.SourceManagement";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SourceManagement","CreatedDate");
			fdata["FieldType"] = 135;
			fdata["strField"] = "CreatedDate";
			fdata["sourceSingle"] = "CreatedDate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "CreatedDate";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["weekdayMessage"] = new XVar("message", "Invalid week day", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 5;
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
			tdataArray["sourcemanagement"]["CreatedDate"] = fdata;
			tdataArray["sourcemanagement"][".searchableFields"].Add("CreatedDate");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "User";
			fdata["GoodName"] = "User";
			fdata["ownerTable"] = "dbo.SourceManagement";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SourceManagement","User");
			fdata["FieldType"] = 200;
			fdata["strField"] = "User";
			fdata["sourceSingle"] = "User";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[User]";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=200");
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
			tdataArray["sourcemanagement"]["User"] = fdata;
			tdataArray["sourcemanagement"][".searchableFields"].Add("User");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "Description";
			fdata["GoodName"] = "Description";
			fdata["ownerTable"] = "dbo.SourceManagement";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SourceManagement","Description");
			fdata["FieldType"] = 202;
			fdata["strField"] = "Description";
			fdata["sourceSingle"] = "Description";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Description";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 500;
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
			fdata["filterTotalFields"] = "Id";
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["sourcemanagement"]["Description"] = fdata;
			tdataArray["sourcemanagement"][".searchableFields"].Add("Description");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "ChangeSet";
			fdata["GoodName"] = "ChangeSet";
			fdata["ownerTable"] = "dbo.SourceManagement";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SourceManagement","ChangeSet");
			fdata["FieldType"] = 202;
			fdata["strField"] = "ChangeSet";
			fdata["sourceSingle"] = "ChangeSet";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ChangeSet";
			fdata["UploadCodeExpression"] = true;
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
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
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
			fdata["filterTotalFields"] = "Id";
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["sourcemanagement"]["ChangeSet"] = fdata;
			tdataArray["sourcemanagement"][".searchableFields"].Add("ChangeSet");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.SourceManagement";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SourceManagement","Id");
			fdata["FieldType"] = 3;
			fdata["strField"] = "Id";
			fdata["sourceSingle"] = "Id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Id";
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
			tdataArray["sourcemanagement"]["Id"] = fdata;
			tdataArray["sourcemanagement"][".searchableFields"].Add("Id");
			GlobalVars.tables_data["dbo.SourceManagement"] = tdataArray["sourcemanagement"];
			GlobalVars.field_labels["dbo_SourceManagement"] = fieldLabelsArray["sourcemanagement"];
			GlobalVars.fieldToolTips["dbo_SourceManagement"] = fieldToolTipsArray["sourcemanagement"];
			GlobalVars.placeHolders["dbo_SourceManagement"] = placeHoldersArray["sourcemanagement"];
			GlobalVars.page_titles["dbo_SourceManagement"] = pageTitlesArray["sourcemanagement"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.SourceManagement"));
			GlobalVars.detailsTablesData["dbo.SourceManagement"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.SourceManagement"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Application,  	CreatedDate,  	[User],  	Description,  	ChangeSet,  	Id";
protoArray["0"]["m_strFrom"] = "FROM dbo.SourceManagement";
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
obj = new SQLField(new XVar("m_strName", "Application", "m_strTable", "dbo.SourceManagement", "m_srcTableName", "dbo.SourceManagement"));

protoArray["6"]["m_sql"] = "Application";
protoArray["6"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "CreatedDate", "m_strTable", "dbo.SourceManagement", "m_srcTableName", "dbo.SourceManagement"));

protoArray["8"]["m_sql"] = "CreatedDate";
protoArray["8"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "User", "m_strTable", "dbo.SourceManagement", "m_srcTableName", "dbo.SourceManagement"));

protoArray["10"]["m_sql"] = "[User]";
protoArray["10"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Description", "m_strTable", "dbo.SourceManagement", "m_srcTableName", "dbo.SourceManagement"));

protoArray["12"]["m_sql"] = "Description";
protoArray["12"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ChangeSet", "m_strTable", "dbo.SourceManagement", "m_srcTableName", "dbo.SourceManagement"));

protoArray["14"]["m_sql"] = "ChangeSet";
protoArray["14"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.SourceManagement", "m_srcTableName", "dbo.SourceManagement"));

protoArray["16"]["m_sql"] = "Id";
protoArray["16"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.SourceManagement";
protoArray["19"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("Application");
protoArray["19"]["m_columns"].Add("CreatedDate");
protoArray["19"]["m_columns"].Add("User");
protoArray["19"]["m_columns"].Add("Description");
protoArray["19"]["m_columns"].Add("ChangeSet");
protoArray["19"]["m_columns"].Add("Id");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.SourceManagement";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.SourceManagement";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_sql"] = "";
protoArray["20"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["20"]["m_column"] = obj;
protoArray["20"]["m_contained"] = SettingsMap.GetArray();
protoArray["20"]["m_strCase"] = "";
protoArray["20"]["m_havingmode"] = false;
protoArray["20"]["m_inBrackets"] = false;
protoArray["20"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["20"]);

protoArray["18"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["18"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.SourceManagement";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["sourcemanagement"] = obj;

				
		
			tdataArray["sourcemanagement"][".sqlquery"] = queryData_Array["sourcemanagement"];
			tdataArray["sourcemanagement"][".hasEvents"] = false;
		}
	}

}
