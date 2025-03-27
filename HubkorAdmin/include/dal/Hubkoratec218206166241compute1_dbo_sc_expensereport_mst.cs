using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sc_expensereport_mst : tDALTable
    {
        public XVar site_ref;
        public XVar report_id;
        public XVar uri;
        public XVar name;
        public XVar total;
        public XVar curr_code;
        public XVar clientid;
        public XVar createdate;
        public XVar submitdate;
        public XVar ownerloginid;
        public XVar ownername;
        public XVar country;
        public XVar reportdate;
        public XVar concuruserid;
        public XVar vend_num;
        public XVar trans_num;
        public XVar posted;
        public XVar lastmodifieddate;
        public static void Init()
        {
            XVar dalTablesc_expensereport_mst = XVar.Array();
            dalTablesc_expensereport_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesc_expensereport_mst["report_id"] = new XVar("type", 202, "varname", "report_id", "name", "report_id", "autoInc", "0");
            dalTablesc_expensereport_mst["uri"] = new XVar("type", 202, "varname", "uri", "name", "uri", "autoInc", "0");
            dalTablesc_expensereport_mst["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTablesc_expensereport_mst["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTablesc_expensereport_mst["curr_code"] = new XVar("type", 202, "varname", "curr_code", "name", "curr_code", "autoInc", "0");
            dalTablesc_expensereport_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesc_expensereport_mst["createdate"] = new XVar("type", 135, "varname", "createdate", "name", "createdate", "autoInc", "0");
            dalTablesc_expensereport_mst["submitdate"] = new XVar("type", 135, "varname", "submitdate", "name", "submitdate", "autoInc", "0");
            dalTablesc_expensereport_mst["ownerloginid"] = new XVar("type", 202, "varname", "ownerloginid", "name", "ownerloginid", "autoInc", "0");
            dalTablesc_expensereport_mst["ownername"] = new XVar("type", 202, "varname", "ownername", "name", "ownername", "autoInc", "0");
            dalTablesc_expensereport_mst["country"] = new XVar("type", 202, "varname", "country", "name", "country", "autoInc", "0");
            dalTablesc_expensereport_mst["reportdate"] = new XVar("type", 135, "varname", "reportdate", "name", "reportdate", "autoInc", "0");
            dalTablesc_expensereport_mst["concuruserid"] = new XVar("type", 202, "varname", "concuruserid", "name", "concuruserid", "autoInc", "0");
            dalTablesc_expensereport_mst["vend_num"] = new XVar("type", 202, "varname", "vend_num", "name", "vend_num", "autoInc", "0");
            dalTablesc_expensereport_mst["trans_num"] = new XVar("type", 20, "varname", "trans_num", "name", "trans_num", "autoInc", "1");
            dalTablesc_expensereport_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablesc_expensereport_mst["lastmodifieddate"] = new XVar("type", 135, "varname", "lastmodifieddate", "name", "lastmodifieddate", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sc_expensereport_mst"] = dalTablesc_expensereport_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sc_expensereport_mst()
        {
            			this.m_TableName = "dbo.sc_expensereport_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sc_expensereport_mst";
        }
    }
}