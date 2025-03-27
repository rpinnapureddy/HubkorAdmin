using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using System.Web;
using runnerDotNet;


namespace runnerDotNet
{
	[Export(typeof(IGlobalEventProviderCS))]
	public class CommonEventsCS : IGlobalEventProviderCS
	{

		// handlers

// After successful login
		public XVar AfterSuccessfulLogin(dynamic username, dynamic password, dynamic data, dynamic pageObject)
		{
XSession.Session["user_name"] = data["user_name"];

// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // AfterSuccessfulLogin


		// onscreen events

		// table maps, buttons
		public XVar event_New_Button(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
// Put your code here.
result["txt"] = parameters["txt"].ToString() + " world";


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button1(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
// Put your code here.
result["txt"] = parameters["txt"].ToString() + " world";


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button2(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic sql = DB.PrepareSQL("EXEC hk_send_provisonal_email '" + keys["shortcode"].ToString() + "'");
DB.Exec( sql );

			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button3(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic sql = DB.PrepareSQL("EXEC tp_Post_repost_po1 '" + keys["clientid"].ToString() + "','" +  keys["po_num"].ToString() + "'");

XVar rs = tDAL.CustomQuery(sql);

XVar data = CommonFunctions.db_fetch_array(rs);


result["txt"] = "Vendor posted";
 


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button4(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic sql = DB.PrepareSQL("EXEC tp_Post_repost_po1 '" + keys["clientid"].ToString() + "','" +  keys["po_num"].ToString() + "'");

XVar rs = tDAL.CustomQuery(sql);

XVar data = CommonFunctions.db_fetch_array(rs);


result["txt"] = "PO posted";
 
 


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button5(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic sql = DB.PrepareSQL("EXEC tp_PostCSI_PO_AP '" + keys["clientid"].ToString() + "','" +  keys["trans_num"].ToString() + "',1");

XVar rs = tDAL.CustomQuery(sql);

XVar data = CommonFunctions.db_fetch_array(rs);


result["txt"] = "Bill posted";
 

			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button6(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic sql = DB.PrepareSQL("EXEC tp_PostCSI_Payments '" + keys["clientid"].ToString() + "','" +  keys["id"].ToString() + "',1");

XVar rs = tDAL.CustomQuery(sql);

XVar data = CommonFunctions.db_fetch_array(rs);


result["txt"] = "Payment posted";
 

			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button7(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic sql = DB.PrepareSQL("EXEC tp_Post_repost_po2 '" + keys["clientid"].ToString() + "','" +  keys["po_num"].ToString() + "'");

XVar rs = tDAL.CustomQuery(sql);

XVar data = CommonFunctions.db_fetch_array(rs);


result["txt"] = "posted";
 
 

			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button_For_Post(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic record = button.getCurrentRecord();

// Execute the stored procedure and get the response
string query = "exec tp_postCSI_Vendor '" 
    + record["clientid"].ToString() + "', '" 
    + record["vend_num"].ToString() + "', '" 
    + record["site_ref"].ToString() + "'";

// Retrieve only the necessary result from the database
result["txt"] = DB.DBLookup(query);

// Optionally set a custom success message
if (!string.IsNullOrEmpty(result["txt"]))
{
    result["txt"] = "Vendor posted successfully";
}
else
{
    result["txt"] = "Error: Vendor post failed.";
}


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button9(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code

dynamic record = button.getCurrentRecord();

// Build the query for the stored procedure
string query = "exec tp_Update_Chart '" 
    + record["clientid"].ToString() + "', '" 
    + record["site_ref"].ToString() + "', '" 
    + record["tp_status"].ToString() + "', '" 
    + record["acct"].ToString() + "'";

// Execute the query and retrieve the result
string dbResult = DB.DBLookup(query);

// Handle the response based on the stored procedure result
if (!string.IsNullOrEmpty(dbResult) && dbResult == "Success")
{
    // Success case
    result["txt"] = "Chart of account updated.";
}
else
{
    // Failure case
    result["txt"] = "Error: Chart of account updated failed.";
}

			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_Post(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
dynamic record = button.getCurrentRecord();

// Build the query for the stored procedure
string query = "exec Sent_Client_Provision_Email '" 
           + record["shortcode"].ToString() + "'";

// Execute the query and retrieve the result
string dbResult = DB.DBLookup(query);

// Handle the response based on the stored procedure result
if (!string.IsNullOrEmpty(dbResult) && dbResult == "Success")
{
    // Success case
    result["txt"] = "Provision Email successfully sent.";
}
else
{
    // Failure case
    result["txt"] = "Provision Email failed.";
}


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_post1(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code

dynamic record = button.getCurrentRecord();

// Build the query for the stored procedure
string query = "exec tp_Repost_Invoice_byId '" 
           + record["invoice_id"].ToString() + "'";

// Execute the query and retrieve the result
string dbResult = DB.DBLookup(query);

// Handle the response based on the stored procedure result
if (!string.IsNullOrEmpty(dbResult) && dbResult == "Success")
{
    // Success case
    result["txt"] = "invoice Reposted successfully.";
}
else
{
    // Failure case
    result["txt"] = "invoice Reposted failed.";
}


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}




		public XVar AfterTableInit(dynamic context)
		{
			var table = context["table"];
			var query = context["query"];
			context["query"] = query;
			return null;
		}

		public XVar GetTablePermissions(dynamic permissions, dynamic table = null)
		{
			return permissions;
		}

		public XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null)
		{
			return isEditable;
		}
	}
}