using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sc_expensereport_line_mst : tDALTable
    {
        public XVar site_ref;
        public XVar report_id;
        public XVar amount;
        public XVar curr_code;
        public XVar clientid;
        public XVar account;
        public XVar unitcd1;
        public XVar unitcd2;
        public XVar unitcd3;
        public XVar unitcd4;
        public XVar expenseid;
        public XVar ispersonalexpense;
        public XVar expenseurl;
        public XVar rel;
        public XVar seq;
        public XVar project;
        public XVar task;
        public static void Init()
        {
            XVar dalTablesc_expensereport_line_mst = XVar.Array();
            dalTablesc_expensereport_line_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablesc_expensereport_line_mst["report_id"] = new XVar("type", 202, "varname", "report_id", "name", "report_id", "autoInc", "0");
            dalTablesc_expensereport_line_mst["amount"] = new XVar("type", 14, "varname", "amount", "name", "amount", "autoInc", "0");
            dalTablesc_expensereport_line_mst["curr_code"] = new XVar("type", 202, "varname", "curr_code", "name", "curr_code", "autoInc", "0");
            dalTablesc_expensereport_line_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesc_expensereport_line_mst["account"] = new XVar("type", 202, "varname", "account", "name", "account", "autoInc", "0");
            dalTablesc_expensereport_line_mst["unitcd1"] = new XVar("type", 202, "varname", "unitcd1", "name", "unitcd1", "autoInc", "0");
            dalTablesc_expensereport_line_mst["unitcd2"] = new XVar("type", 202, "varname", "unitcd2", "name", "unitcd2", "autoInc", "0");
            dalTablesc_expensereport_line_mst["unitcd3"] = new XVar("type", 202, "varname", "unitcd3", "name", "unitcd3", "autoInc", "0");
            dalTablesc_expensereport_line_mst["unitcd4"] = new XVar("type", 202, "varname", "unitcd4", "name", "unitcd4", "autoInc", "0");
            dalTablesc_expensereport_line_mst["expenseid"] = new XVar("type", 202, "varname", "expenseid", "name", "expenseid", "autoInc", "0");
            dalTablesc_expensereport_line_mst["ispersonalexpense"] = new XVar("type", 11, "varname", "ispersonalexpense", "name", "ispersonalexpense", "autoInc", "0");
            dalTablesc_expensereport_line_mst["expenseurl"] = new XVar("type", 202, "varname", "expenseurl", "name", "expenseurl", "autoInc", "0");
            dalTablesc_expensereport_line_mst["rel"] = new XVar("type", 202, "varname", "rel", "name", "rel", "autoInc", "0");
            dalTablesc_expensereport_line_mst["seq"] = new XVar("type", 3, "varname", "seq", "name", "seq", "autoInc", "0");
            dalTablesc_expensereport_line_mst["project"] = new XVar("type", 202, "varname", "project", "name", "project", "autoInc", "0");
            dalTablesc_expensereport_line_mst["task"] = new XVar("type", 202, "varname", "task", "name", "task", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sc_expensereport_line_mst"] = dalTablesc_expensereport_line_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sc_expensereport_line_mst()
        {
            			this.m_TableName = "dbo.sc_expensereport_line_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sc_expensereport_line_mst";
        }
    }
}