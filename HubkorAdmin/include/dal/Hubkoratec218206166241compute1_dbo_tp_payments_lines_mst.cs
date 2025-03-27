using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_payments_lines_mst : tDALTable
    {
        public XVar payment_id;
        public XVar payment_amount;
        public XVar AP_Account_External_Id;
        public XVar clientid;
        public XVar trans_num;
        public XVar site_ref;
        public static void Init()
        {
            XVar dalTabletp_payments_lines_mst = XVar.Array();
            dalTabletp_payments_lines_mst["payment_id"] = new XVar("type", 202, "varname", "payment_id", "name", "payment_id", "autoInc", "0");
            dalTabletp_payments_lines_mst["payment_amount"] = new XVar("type", 202, "varname", "payment_amount", "name", "payment_amount", "autoInc", "0");
            dalTabletp_payments_lines_mst["AP_Account_External_Id"] = new XVar("type", 202, "varname", "AP_Account_External_Id", "name", "AP_Account_External_Id", "autoInc", "0");
            dalTabletp_payments_lines_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_payments_lines_mst["trans_num"] = new XVar("type", 20, "varname", "trans_num", "name", "trans_num", "autoInc", "0");
            dalTabletp_payments_lines_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_payments_lines_mst"] = dalTabletp_payments_lines_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_payments_lines_mst()
        {
            			this.m_TableName = "dbo.tp_payments_lines_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_payments_lines_mst";
        }
    }
}