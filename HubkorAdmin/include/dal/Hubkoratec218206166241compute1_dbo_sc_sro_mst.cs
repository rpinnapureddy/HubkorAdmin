using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sc_sro_mst : tDALTable
    {
        public XVar trans_num;
        public XVar emp_num;
        public XVar trans_date;
        public XVar sro_num;
        public XVar line;
        public XVar oper_num;
        public XVar misc_code;
        public XVar qty;
        public XVar pay_type;
        public XVar cost;
        public XVar price;
        public XVar curr_code;
        public XVar report_id;
        public XVar posted;
        public XVar batchid;
        public XVar clientid;
        public XVar site_ref;
        public XVar rowpointer;
        public static void Init()
        {
            XVar dalTablesc_sro_mst = XVar.Array();
            dalTablesc_sro_mst["trans_num"] = new XVar("type", 3, "varname", "trans_num", "name", "trans_num", "autoInc", "1");
            dalTablesc_sro_mst["emp_num"] = new XVar("type", 202, "varname", "emp_num", "name", "emp_num", "autoInc", "0");
            dalTablesc_sro_mst["trans_date"] = new XVar("type", 7, "varname", "trans_date", "name", "trans_date", "autoInc", "0");
            dalTablesc_sro_mst["sro_num"] = new XVar("type", 202, "varname", "sro_num", "name", "sro_num", "autoInc", "0");
            dalTablesc_sro_mst["line"] = new XVar("type", 202, "varname", "line", "name", "line", "autoInc", "0");
            dalTablesc_sro_mst["oper_num"] = new XVar("type", 3, "varname", "oper_num", "name", "oper_num", "autoInc", "0");
            dalTablesc_sro_mst["misc_code"] = new XVar("type", 202, "varname", "misc_code", "name", "misc_code", "autoInc", "0");
            dalTablesc_sro_mst["qty"] = new XVar("type", 3, "varname", "qty", "name", "qty", "autoInc", "0");
            dalTablesc_sro_mst["pay_type"] = new XVar("type", 202, "varname", "pay_type", "name", "pay_type", "autoInc", "0");
            dalTablesc_sro_mst["cost"] = new XVar("type", 14, "varname", "cost", "name", "cost", "autoInc", "0");
            dalTablesc_sro_mst["price"] = new XVar("type", 14, "varname", "price", "name", "price", "autoInc", "0");
            dalTablesc_sro_mst["curr_code"] = new XVar("type", 130, "varname", "curr_code", "name", "curr_code", "autoInc", "0");
            dalTablesc_sro_mst["report_id"] = new XVar("type", 202, "varname", "report_id", "name", "report_id", "autoInc", "0");
            dalTablesc_sro_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablesc_sro_mst["batchid"] = new XVar("type", 3, "varname", "batchid", "name", "batchid", "autoInc", "0");
            dalTablesc_sro_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesc_sro_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesc_sro_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sc_sro_mst"] = dalTablesc_sro_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sc_sro_mst()
        {
            			this.m_TableName = "dbo.sc_sro_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sc_sro_mst";
        }
    }
}