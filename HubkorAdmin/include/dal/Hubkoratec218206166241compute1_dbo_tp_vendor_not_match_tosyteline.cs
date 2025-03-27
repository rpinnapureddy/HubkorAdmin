using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_vendor_not_match_tosyteline : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar vend_num;
        public XVar sl_name;
        public XVar tp_name;
        public XVar tp_street;
        public XVar sl_street;
        public XVar tp_city;
        public XVar sl_city;
        public XVar tp_state;
        public XVar sl_state;
        public XVar tp_zip;
        public XVar sl_zip;
        public XVar tp_country;
        public XVar sl_country;
        public XVar vendor_remit;
        public static void Init()
        {
            XVar dalTabletp_vendor_not_match_tosyteline = XVar.Array();
            dalTabletp_vendor_not_match_tosyteline["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["vend_num"] = new XVar("type", 200, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["sl_name"] = new XVar("type", 202, "varname", "sl_name", "name", "sl_name", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["tp_name"] = new XVar("type", 202, "varname", "tp_name", "name", "tp_name", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["tp_street"] = new XVar("type", 202, "varname", "tp_street", "name", "tp_street", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["sl_street"] = new XVar("type", 202, "varname", "sl_street", "name", "sl_street", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["tp_city"] = new XVar("type", 202, "varname", "tp_city", "name", "tp_city", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["sl_city"] = new XVar("type", 202, "varname", "sl_city", "name", "sl_city", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["tp_state"] = new XVar("type", 202, "varname", "tp_state", "name", "tp_state", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["sl_state"] = new XVar("type", 202, "varname", "sl_state", "name", "sl_state", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["tp_zip"] = new XVar("type", 202, "varname", "tp_zip", "name", "tp_zip", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["sl_zip"] = new XVar("type", 202, "varname", "sl_zip", "name", "sl_zip", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["tp_country"] = new XVar("type", 202, "varname", "tp_country", "name", "tp_country", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["sl_country"] = new XVar("type", 202, "varname", "sl_country", "name", "sl_country", "autoInc", "0");
            dalTabletp_vendor_not_match_tosyteline["vendor_remit"] = new XVar("type", 202, "varname", "vendor_remit", "name", "vendor_remit", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_vendor_not_match_tosyteline"] = dalTabletp_vendor_not_match_tosyteline;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_vendor_not_match_tosyteline()
        {
            			this.m_TableName = "dbo.tp_vendor_not_match_tosyteline";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_vendor_not_match_tosyteline";
        }
    }
}