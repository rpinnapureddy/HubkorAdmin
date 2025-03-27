using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_vendor_mst : tDALTable
    {
        public XVar site_ref;
        public XVar clientid;
        public XVar posted;
        public XVar posteddate;
        public XVar Alias;
        public XVar CompanyName;
        public XVar Email;
        public XVar FirstName;
        public XVar MiddleName;
        public XVar LastName;
        public XVar PaymentMethod;
        public XVar Street1;
        public XVar Street2;
        public XVar City;
        public XVar State;
        public XVar Zip;
        public XVar Country;
        public XVar Phone;
        public XVar PaymentCurrency;
        public XVar Payable;
        public XVar Status;
        public XVar StatusReason;
        public XVar StatusUpdateDate;
        public XVar PreferredPayerEntity;
        public XVar ActualPayerEntity;
        public XVar Idap;
        public XVar CountryName;
        public XVar ErpCurrency;
        public XVar EntityType;
        public XVar TaxFormStatus;
        public XVar PortalUser;
        public XVar WithholdingRate;
        public XVar TaxFormEntityType;
        public XVar TaxFormEntityName;
        public XVar TaxFormType;
        public XVar TaxFormSubmittedBy;
        public XVar TaxFormSubmittedDate;
        public XVar PaymentTermId;
        public XVar ApAccountExternalId;
        public XVar ExternalID;
        public XVar vendor_seq;
        public XVar is_1099;
        public XVar vend_num;
        public static void Init()
        {
            XVar dalTabletp_vendor_mst = XVar.Array();
            dalTabletp_vendor_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_vendor_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_vendor_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTabletp_vendor_mst["posteddate"] = new XVar("type", 135, "varname", "posteddate", "name", "posteddate", "autoInc", "0");
            dalTabletp_vendor_mst["Alias"] = new XVar("type", 202, "varname", "Alias", "name", "Alias", "autoInc", "0");
            dalTabletp_vendor_mst["CompanyName"] = new XVar("type", 202, "varname", "CompanyName", "name", "CompanyName", "autoInc", "0");
            dalTabletp_vendor_mst["Email"] = new XVar("type", 202, "varname", "Email", "name", "Email", "autoInc", "0");
            dalTabletp_vendor_mst["FirstName"] = new XVar("type", 202, "varname", "FirstName", "name", "FirstName", "autoInc", "0");
            dalTabletp_vendor_mst["MiddleName"] = new XVar("type", 202, "varname", "MiddleName", "name", "MiddleName", "autoInc", "0");
            dalTabletp_vendor_mst["LastName"] = new XVar("type", 202, "varname", "LastName", "name", "LastName", "autoInc", "0");
            dalTabletp_vendor_mst["PaymentMethod"] = new XVar("type", 202, "varname", "PaymentMethod", "name", "PaymentMethod", "autoInc", "0");
            dalTabletp_vendor_mst["Street1"] = new XVar("type", 202, "varname", "Street1", "name", "Street1", "autoInc", "0");
            dalTabletp_vendor_mst["Street2"] = new XVar("type", 202, "varname", "Street2", "name", "Street2", "autoInc", "0");
            dalTabletp_vendor_mst["City"] = new XVar("type", 202, "varname", "City", "name", "City", "autoInc", "0");
            dalTabletp_vendor_mst["State"] = new XVar("type", 202, "varname", "State", "name", "State", "autoInc", "0");
            dalTabletp_vendor_mst["Zip"] = new XVar("type", 202, "varname", "Zip", "name", "Zip", "autoInc", "0");
            dalTabletp_vendor_mst["Country"] = new XVar("type", 202, "varname", "Country", "name", "Country", "autoInc", "0");
            dalTabletp_vendor_mst["Phone"] = new XVar("type", 202, "varname", "Phone", "name", "Phone", "autoInc", "0");
            dalTabletp_vendor_mst["PaymentCurrency"] = new XVar("type", 202, "varname", "PaymentCurrency", "name", "PaymentCurrency", "autoInc", "0");
            dalTabletp_vendor_mst["Payable"] = new XVar("type", 202, "varname", "Payable", "name", "Payable", "autoInc", "0");
            dalTabletp_vendor_mst["Status"] = new XVar("type", 202, "varname", "Status", "name", "Status", "autoInc", "0");
            dalTabletp_vendor_mst["StatusReason"] = new XVar("type", 202, "varname", "StatusReason", "name", "StatusReason", "autoInc", "0");
            dalTabletp_vendor_mst["StatusUpdateDate"] = new XVar("type", 135, "varname", "StatusUpdateDate", "name", "StatusUpdateDate", "autoInc", "0");
            dalTabletp_vendor_mst["PreferredPayerEntity"] = new XVar("type", 202, "varname", "PreferredPayerEntity", "name", "PreferredPayerEntity", "autoInc", "0");
            dalTabletp_vendor_mst["ActualPayerEntity"] = new XVar("type", 202, "varname", "ActualPayerEntity", "name", "ActualPayerEntity", "autoInc", "0");
            dalTabletp_vendor_mst["Idap"] = new XVar("type", 200, "varname", "Idap", "name", "Idap", "autoInc", "0");
            dalTabletp_vendor_mst["CountryName"] = new XVar("type", 202, "varname", "CountryName", "name", "CountryName", "autoInc", "0");
            dalTabletp_vendor_mst["ErpCurrency"] = new XVar("type", 202, "varname", "ErpCurrency", "name", "ErpCurrency", "autoInc", "0");
            dalTabletp_vendor_mst["EntityType"] = new XVar("type", 202, "varname", "EntityType", "name", "EntityType", "autoInc", "0");
            dalTabletp_vendor_mst["TaxFormStatus"] = new XVar("type", 202, "varname", "TaxFormStatus", "name", "TaxFormStatus", "autoInc", "0");
            dalTabletp_vendor_mst["PortalUser"] = new XVar("type", 202, "varname", "PortalUser", "name", "PortalUser", "autoInc", "0");
            dalTabletp_vendor_mst["WithholdingRate"] = new XVar("type", 202, "varname", "WithholdingRate", "name", "WithholdingRate", "autoInc", "0");
            dalTabletp_vendor_mst["TaxFormEntityType"] = new XVar("type", 202, "varname", "TaxFormEntityType", "name", "TaxFormEntityType", "autoInc", "0");
            dalTabletp_vendor_mst["TaxFormEntityName"] = new XVar("type", 202, "varname", "TaxFormEntityName", "name", "TaxFormEntityName", "autoInc", "0");
            dalTabletp_vendor_mst["TaxFormType"] = new XVar("type", 202, "varname", "TaxFormType", "name", "TaxFormType", "autoInc", "0");
            dalTabletp_vendor_mst["TaxFormSubmittedBy"] = new XVar("type", 202, "varname", "TaxFormSubmittedBy", "name", "TaxFormSubmittedBy", "autoInc", "0");
            dalTabletp_vendor_mst["TaxFormSubmittedDate"] = new XVar("type", 135, "varname", "TaxFormSubmittedDate", "name", "TaxFormSubmittedDate", "autoInc", "0");
            dalTabletp_vendor_mst["PaymentTermId"] = new XVar("type", 202, "varname", "PaymentTermId", "name", "PaymentTermId", "autoInc", "0");
            dalTabletp_vendor_mst["ApAccountExternalId"] = new XVar("type", 202, "varname", "ApAccountExternalId", "name", "ApAccountExternalId", "autoInc", "0");
            dalTabletp_vendor_mst["ExternalID"] = new XVar("type", 200, "varname", "ExternalID", "name", "ExternalID", "autoInc", "0");
            dalTabletp_vendor_mst["vendor_seq"] = new XVar("type", 202, "varname", "vendor_seq", "name", "vendor_seq", "autoInc", "0");
            dalTabletp_vendor_mst["is_1099"] = new XVar("type", 16, "varname", "is_1099", "name", "is_1099", "autoInc", "0");
            dalTabletp_vendor_mst["vend_num"] = new XVar("type", 200, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_vendor_mst"] = dalTabletp_vendor_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_vendor_mst()
        {
            			this.m_TableName = "dbo.tp_vendor_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_vendor_mst";
        }
    }
}