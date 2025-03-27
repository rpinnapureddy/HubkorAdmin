using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_vendor : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar tp_posted;
        public XVar vend_num;
        public XVar RowPointer;
        public XVar contact;
        public XVar phone;
        public XVar vend_type;
        public XVar terms_code;
        public XVar ship_code;
        public XVar stat;
        public XVar curr_code;
        public XVar bank_code;
        public XVar pay_type;
        public XVar delterm;
        public XVar tax_code1;
        public XVar tax_code2;
        public XVar cust_num;
        public XVar vend_bank;
        public XVar name;
        public XVar city;
        public XVar state;
        public XVar zip;
        public XVar county;
        public XVar country;
        public XVar fax_num;
        public XVar telex_num;
        public XVar addr1;
        public XVar addr2;
        public XVar addr3;
        public XVar addr4;
        public XVar pay_hold;
        public XVar internet_url;
        public XVar internal_email_addr;
        public XVar external_email_addr;
        public XVar long_name;
        public XVar vend_remit;
        public XVar PendInv;
        public static void Init()
        {
            XVar dalTabletp_vendor = XVar.Array();
            dalTabletp_vendor["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_vendor["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_vendor["tp_posted"] = new XVar("type", 3, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTabletp_vendor["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTabletp_vendor["RowPointer"] = new XVar("type", 72, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTabletp_vendor["contact"] = new XVar("type", 202, "varname", "contact", "name", "contact", "autoInc", "0");
            dalTabletp_vendor["phone"] = new XVar("type", 202, "varname", "phone", "name", "phone", "autoInc", "0");
            dalTabletp_vendor["vend_type"] = new XVar("type", 202, "varname", "vend_type", "name", "vend_type", "autoInc", "0");
            dalTabletp_vendor["terms_code"] = new XVar("type", 202, "varname", "terms_code", "name", "terms_code", "autoInc", "0");
            dalTabletp_vendor["ship_code"] = new XVar("type", 202, "varname", "ship_code", "name", "ship_code", "autoInc", "0");
            dalTabletp_vendor["stat"] = new XVar("type", 130, "varname", "stat", "name", "stat", "autoInc", "0");
            dalTabletp_vendor["curr_code"] = new XVar("type", 202, "varname", "curr_code", "name", "curr_code", "autoInc", "0");
            dalTabletp_vendor["bank_code"] = new XVar("type", 202, "varname", "bank_code", "name", "bank_code", "autoInc", "0");
            dalTabletp_vendor["pay_type"] = new XVar("type", 130, "varname", "pay_type", "name", "pay_type", "autoInc", "0");
            dalTabletp_vendor["delterm"] = new XVar("type", 202, "varname", "delterm", "name", "delterm", "autoInc", "0");
            dalTabletp_vendor["tax_code1"] = new XVar("type", 202, "varname", "tax_code1", "name", "tax_code1", "autoInc", "0");
            dalTabletp_vendor["tax_code2"] = new XVar("type", 202, "varname", "tax_code2", "name", "tax_code2", "autoInc", "0");
            dalTabletp_vendor["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTabletp_vendor["vend_bank"] = new XVar("type", 202, "varname", "vend_bank", "name", "vend_bank", "autoInc", "0");
            dalTabletp_vendor["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTabletp_vendor["city"] = new XVar("type", 202, "varname", "city", "name", "city", "autoInc", "0");
            dalTabletp_vendor["state"] = new XVar("type", 202, "varname", "state", "name", "state", "autoInc", "0");
            dalTabletp_vendor["zip"] = new XVar("type", 202, "varname", "zip", "name", "zip", "autoInc", "0");
            dalTabletp_vendor["county"] = new XVar("type", 202, "varname", "county", "name", "county", "autoInc", "0");
            dalTabletp_vendor["country"] = new XVar("type", 202, "varname", "country", "name", "country", "autoInc", "0");
            dalTabletp_vendor["fax_num"] = new XVar("type", 202, "varname", "fax_num", "name", "fax_num", "autoInc", "0");
            dalTabletp_vendor["telex_num"] = new XVar("type", 202, "varname", "telex_num", "name", "telex_num", "autoInc", "0");
            dalTabletp_vendor["addr1"] = new XVar("type", 202, "varname", "addr1", "name", "addr1", "autoInc", "0");
            dalTabletp_vendor["addr2"] = new XVar("type", 202, "varname", "addr2", "name", "addr2", "autoInc", "0");
            dalTabletp_vendor["addr3"] = new XVar("type", 202, "varname", "addr3", "name", "addr3", "autoInc", "0");
            dalTabletp_vendor["addr4"] = new XVar("type", 202, "varname", "addr4", "name", "addr4", "autoInc", "0");
            dalTabletp_vendor["pay_hold"] = new XVar("type", 17, "varname", "pay_hold", "name", "pay_hold", "autoInc", "0");
            dalTabletp_vendor["internet_url"] = new XVar("type", 203, "varname", "internet_url", "name", "internet_url", "autoInc", "0");
            dalTabletp_vendor["internal_email_addr"] = new XVar("type", 202, "varname", "internal_email_addr", "name", "internal_email_addr", "autoInc", "0");
            dalTabletp_vendor["external_email_addr"] = new XVar("type", 202, "varname", "external_email_addr", "name", "external_email_addr", "autoInc", "0");
            dalTabletp_vendor["long_name"] = new XVar("type", 202, "varname", "long_name", "name", "long_name", "autoInc", "0");
            dalTabletp_vendor["vend_remit"] = new XVar("type", 202, "varname", "vend_remit", "name", "vend_remit", "autoInc", "0");
            dalTabletp_vendor["PendInv"] = new XVar("type", 3, "varname", "PendInv", "name", "PendInv", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_vendor"] = dalTabletp_vendor;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_vendor()
        {
            			this.m_TableName = "dbo.tp_vendor";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_vendor";
        }
    }
}