using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sh_get_orders_mst : tDALTable
    {
        public XVar clientid;
        public XVar VariationNumber;
        public XVar order_id;
        public XVar Name;
        public XVar CustomerDisplayName;
        public XVar CreatedAt;
        public XVar ConfirmationNumber;
        public XVar tp_id;
        public XVar tp_posted;
        public XVar sc_id;
        public XVar sc_posted;
        public XVar sf_id;
        public XVar sf_posted;
        public XVar mg_id;
        public XVar mg_posted;
        public XVar uf_uet1;
        public XVar uf_uet2;
        public XVar uf_uet3;
        public XVar uf_uet4;
        public XVar uf_uet5;
        public XVar uf_uet6;
        public XVar uf_uet7;
        public XVar uf_uet8;
        public XVar uf_uet9;
        public XVar uf_uet10;
        public XVar CustomerEmail;
        public XVar CustomerFirstName;
        public XVar CustomerLastName;
        public XVar CustomerState;
        public XVar CustomerID;
        public XVar UpdatedAt;
        public XVar TotalDiscounts;
        public XVar TotalTax;
        public XVar TotalPrice;
        public XVar BillingAddress1;
        public XVar BillingCity;
        public XVar BillingCountry;
        public XVar BillingProvince;
        public XVar BillingZip;
        public XVar BillingFirstName;
        public XVar BillingLastName;
        public XVar poNumber;
        public XVar BillingCountryCode;
        public XVar BillingName;
        public XVar billing_address_id;
        public XVar status;
        public XVar site_ref;
        public XVar co_num;
        public XVar posted;
        public XVar csi_posted;
        public XVar BillingAddress2;
        public XVar ShippingAddress1;
        public XVar post_date;
        public XVar cust_num;
        public XVar cust_seq;
        public XVar bill_phoneno;
        public XVar ship_phoneno;
        public XVar method;
        public XVar end_type;
        public XVar prepaid;
        public XVar total_weight;
        public XVar current_Subtotal_Price;
        public XVar subtotal_Price;
        public XVar whse;
        public XVar terms_code;
        public XVar ship_code;
        public XVar bank_code;
        public XVar invcategory;
        public XVar shop_currency_code;
        public XVar Total_line_item_price;
        public XVar tax_code1;
        public XVar frt_tax_code1;
        public XVar msc_tax_code1;
        public XVar disc_amount;
        public XVar cust_po;
        public XVar store_id;
        public XVar locale;
        public XVar customer_is_guest;
        public XVar Bill_Ship_address;
        public XVar ShippingAddress2;
        public XVar ShippingCity;
        public XVar ShippingCountry;
        public XVar ShippingProvince;
        public XVar ShippingZip;
        public XVar Tags;
        public XVar ShippingName;
        public XVar shop_name;
        public XVar store_name;
        public XVar jresult;
        public XVar rowpointer;
        public XVar Shipment_amount;
        public XVar state_code;
        public XVar Billing_Province_code;
        public XVar Shipping_Province_code;
        public static void Init()
        {
            XVar dalTablesh_get_orders_mst = XVar.Array();
            dalTablesh_get_orders_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesh_get_orders_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablesh_get_orders_mst["order_id"] = new XVar("type", 202, "varname", "order_id", "name", "order_id", "autoInc", "0");
            dalTablesh_get_orders_mst["Name"] = new XVar("type", 202, "varname", "Name", "name", "Name", "autoInc", "0");
            dalTablesh_get_orders_mst["CustomerDisplayName"] = new XVar("type", 202, "varname", "CustomerDisplayName", "name", "CustomerDisplayName", "autoInc", "0");
            dalTablesh_get_orders_mst["CreatedAt"] = new XVar("type", 135, "varname", "CreatedAt", "name", "CreatedAt", "autoInc", "0");
            dalTablesh_get_orders_mst["ConfirmationNumber"] = new XVar("type", 202, "varname", "ConfirmationNumber", "name", "ConfirmationNumber", "autoInc", "0");
            dalTablesh_get_orders_mst["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTablesh_get_orders_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTablesh_get_orders_mst["sc_id"] = new XVar("type", 202, "varname", "sc_id", "name", "sc_id", "autoInc", "0");
            dalTablesh_get_orders_mst["sc_posted"] = new XVar("type", 16, "varname", "sc_posted", "name", "sc_posted", "autoInc", "0");
            dalTablesh_get_orders_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablesh_get_orders_mst["sf_posted"] = new XVar("type", 16, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablesh_get_orders_mst["mg_id"] = new XVar("type", 202, "varname", "mg_id", "name", "mg_id", "autoInc", "0");
            dalTablesh_get_orders_mst["mg_posted"] = new XVar("type", 16, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablesh_get_orders_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            dalTablesh_get_orders_mst["CustomerEmail"] = new XVar("type", 202, "varname", "CustomerEmail", "name", "CustomerEmail", "autoInc", "0");
            dalTablesh_get_orders_mst["CustomerFirstName"] = new XVar("type", 202, "varname", "CustomerFirstName", "name", "CustomerFirstName", "autoInc", "0");
            dalTablesh_get_orders_mst["CustomerLastName"] = new XVar("type", 202, "varname", "CustomerLastName", "name", "CustomerLastName", "autoInc", "0");
            dalTablesh_get_orders_mst["CustomerState"] = new XVar("type", 202, "varname", "CustomerState", "name", "CustomerState", "autoInc", "0");
            dalTablesh_get_orders_mst["CustomerID"] = new XVar("type", 202, "varname", "CustomerID", "name", "CustomerID", "autoInc", "0");
            dalTablesh_get_orders_mst["UpdatedAt"] = new XVar("type", 135, "varname", "UpdatedAt", "name", "UpdatedAt", "autoInc", "0");
            dalTablesh_get_orders_mst["TotalDiscounts"] = new XVar("type", 14, "varname", "TotalDiscounts", "name", "TotalDiscounts", "autoInc", "0");
            dalTablesh_get_orders_mst["TotalTax"] = new XVar("type", 14, "varname", "TotalTax", "name", "TotalTax", "autoInc", "0");
            dalTablesh_get_orders_mst["TotalPrice"] = new XVar("type", 14, "varname", "TotalPrice", "name", "TotalPrice", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingAddress1"] = new XVar("type", 202, "varname", "BillingAddress1", "name", "BillingAddress1", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingCity"] = new XVar("type", 202, "varname", "BillingCity", "name", "BillingCity", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingCountry"] = new XVar("type", 202, "varname", "BillingCountry", "name", "BillingCountry", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingProvince"] = new XVar("type", 202, "varname", "BillingProvince", "name", "BillingProvince", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingZip"] = new XVar("type", 202, "varname", "BillingZip", "name", "BillingZip", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingFirstName"] = new XVar("type", 202, "varname", "BillingFirstName", "name", "BillingFirstName", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingLastName"] = new XVar("type", 202, "varname", "BillingLastName", "name", "BillingLastName", "autoInc", "0");
            dalTablesh_get_orders_mst["poNumber"] = new XVar("type", 202, "varname", "poNumber", "name", "poNumber", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingCountryCode"] = new XVar("type", 202, "varname", "BillingCountryCode", "name", "BillingCountryCode", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingName"] = new XVar("type", 202, "varname", "BillingName", "name", "BillingName", "autoInc", "0");
            dalTablesh_get_orders_mst["billing_address_id"] = new XVar("type", 202, "varname", "billing_address_id", "name", "billing_address_id", "autoInc", "0");
            dalTablesh_get_orders_mst["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            dalTablesh_get_orders_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesh_get_orders_mst["co_num"] = new XVar("type", 202, "varname", "co_num", "name", "co_num", "autoInc", "0");
            dalTablesh_get_orders_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablesh_get_orders_mst["csi_posted"] = new XVar("type", 16, "varname", "csi_posted", "name", "csi_posted", "autoInc", "0");
            dalTablesh_get_orders_mst["BillingAddress2"] = new XVar("type", 202, "varname", "BillingAddress2", "name", "BillingAddress2", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingAddress1"] = new XVar("type", 202, "varname", "ShippingAddress1", "name", "ShippingAddress1", "autoInc", "0");
            dalTablesh_get_orders_mst["post_date"] = new XVar("type", 135, "varname", "post_date", "name", "post_date", "autoInc", "0");
            dalTablesh_get_orders_mst["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTablesh_get_orders_mst["cust_seq"] = new XVar("type", 3, "varname", "cust_seq", "name", "cust_seq", "autoInc", "0");
            dalTablesh_get_orders_mst["bill_phoneno"] = new XVar("type", 202, "varname", "bill_phoneno", "name", "bill_phoneno", "autoInc", "0");
            dalTablesh_get_orders_mst["ship_phoneno"] = new XVar("type", 202, "varname", "ship_phoneno", "name", "ship_phoneno", "autoInc", "0");
            dalTablesh_get_orders_mst["method"] = new XVar("type", 202, "varname", "method", "name", "method", "autoInc", "0");
            dalTablesh_get_orders_mst["end_type"] = new XVar("type", 202, "varname", "end_type", "name", "end_type", "autoInc", "0");
            dalTablesh_get_orders_mst["prepaid"] = new XVar("type", 16, "varname", "prepaid", "name", "prepaid", "autoInc", "0");
            dalTablesh_get_orders_mst["total_weight"] = new XVar("type", 14, "varname", "total_weight", "name", "total_weight", "autoInc", "0");
            dalTablesh_get_orders_mst["current_Subtotal_Price"] = new XVar("type", 14, "varname", "current_Subtotal_Price", "name", "current_Subtotal_Price", "autoInc", "0");
            dalTablesh_get_orders_mst["subtotal_Price"] = new XVar("type", 14, "varname", "subtotal_Price", "name", "subtotal_Price", "autoInc", "0");
            dalTablesh_get_orders_mst["whse"] = new XVar("type", 202, "varname", "whse", "name", "whse", "autoInc", "0");
            dalTablesh_get_orders_mst["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTablesh_get_orders_mst["ship_code"] = new XVar("type", 202, "varname", "ship_code", "name", "ship_code", "autoInc", "0");
            dalTablesh_get_orders_mst["bank_code"] = new XVar("type", 202, "varname", "bank_code", "name", "bank_code", "autoInc", "0");
            dalTablesh_get_orders_mst["invcategory"] = new XVar("type", 202, "varname", "invcategory", "name", "invcategory", "autoInc", "0");
            dalTablesh_get_orders_mst["shop_currency_code"] = new XVar("type", 202, "varname", "shop_currency_code", "name", "shop_currency_code", "autoInc", "0");
            dalTablesh_get_orders_mst["Total_line_item_price"] = new XVar("type", 14, "varname", "Total_line_item_price", "name", "Total_line_item_price", "autoInc", "0");
            dalTablesh_get_orders_mst["tax_code1"] = new XVar("type", 202, "varname", "tax_code1", "name", "tax_code1", "autoInc", "0");
            dalTablesh_get_orders_mst["frt_tax_code1"] = new XVar("type", 202, "varname", "frt_tax_code1", "name", "frt_tax_code1", "autoInc", "0");
            dalTablesh_get_orders_mst["msc_tax_code1"] = new XVar("type", 202, "varname", "msc_tax_code1", "name", "msc_tax_code1", "autoInc", "0");
            dalTablesh_get_orders_mst["disc_amount"] = new XVar("type", 14, "varname", "disc_amount", "name", "disc_amount", "autoInc", "0");
            dalTablesh_get_orders_mst["cust_po"] = new XVar("type", 202, "varname", "cust_po", "name", "cust_po", "autoInc", "0");
            dalTablesh_get_orders_mst["store_id"] = new XVar("type", 202, "varname", "store_id", "name", "store_id", "autoInc", "0");
            dalTablesh_get_orders_mst["locale"] = new XVar("type", 202, "varname", "locale", "name", "locale", "autoInc", "0");
            dalTablesh_get_orders_mst["customer_is_guest"] = new XVar("type", 16, "varname", "customer_is_guest", "name", "customer_is_guest", "autoInc", "0");
            dalTablesh_get_orders_mst["Bill_Ship_address"] = new XVar("type", 202, "varname", "Bill_Ship_address", "name", "Bill_Ship_address", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingAddress2"] = new XVar("type", 202, "varname", "ShippingAddress2", "name", "ShippingAddress2", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingCity"] = new XVar("type", 202, "varname", "ShippingCity", "name", "ShippingCity", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingCountry"] = new XVar("type", 202, "varname", "ShippingCountry", "name", "ShippingCountry", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingProvince"] = new XVar("type", 202, "varname", "ShippingProvince", "name", "ShippingProvince", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingZip"] = new XVar("type", 202, "varname", "ShippingZip", "name", "ShippingZip", "autoInc", "0");
            dalTablesh_get_orders_mst["Tags"] = new XVar("type", 202, "varname", "Tags", "name", "Tags", "autoInc", "0");
            dalTablesh_get_orders_mst["ShippingName"] = new XVar("type", 202, "varname", "ShippingName", "name", "ShippingName", "autoInc", "0");
            dalTablesh_get_orders_mst["shop_name"] = new XVar("type", 202, "varname", "shop_name", "name", "shop_name", "autoInc", "0");
            dalTablesh_get_orders_mst["store_name"] = new XVar("type", 202, "varname", "store_name", "name", "store_name", "autoInc", "0");
            dalTablesh_get_orders_mst["jresult"] = new XVar("type", 202, "varname", "jresult", "name", "jresult", "autoInc", "0");
            dalTablesh_get_orders_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTablesh_get_orders_mst["Shipment_amount"] = new XVar("type", 14, "varname", "Shipment_amount", "name", "Shipment_amount", "autoInc", "0");
            dalTablesh_get_orders_mst["state_code"] = new XVar("type", 202, "varname", "state_code", "name", "state_code", "autoInc", "0");
            dalTablesh_get_orders_mst["Billing_Province_code"] = new XVar("type", 202, "varname", "Billing_Province_code", "name", "Billing_Province_code", "autoInc", "0");
            dalTablesh_get_orders_mst["Shipping_Province_code"] = new XVar("type", 202, "varname", "Shipping_Province_code", "name", "Shipping_Province_code", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sh_get_orders_mst"] = dalTablesh_get_orders_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sh_get_orders_mst()
        {
            			this.m_TableName = "dbo.sh_get_orders_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sh_get_orders_mst";
        }
    }
}