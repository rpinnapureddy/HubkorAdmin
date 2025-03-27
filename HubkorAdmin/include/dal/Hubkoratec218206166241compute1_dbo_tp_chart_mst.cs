using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_chart_mst : tDALTable
    {
        public XVar clientid;
        public XVar acct;
        public XVar type;
        public XVar tp_posted;
        public XVar Category;
        public XVar action;
        public XVar MiscBox1099;
        public XVar description;
        public XVar currency;
        public XVar payer_entity_name;
        public XVar RowPointer;
        public static void Init()
        {
            XVar dalTabletp_chart_mst = XVar.Array();
            dalTabletp_chart_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_chart_mst["acct"] = new XVar("type", 202, "varname", "acct", "name", "acct", "autoInc", "0");
            dalTabletp_chart_mst["type"] = new XVar("type", 202, "varname", "type", "name", "type", "autoInc", "0");
            dalTabletp_chart_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTabletp_chart_mst["Category"] = new XVar("type", 202, "varname", "Category", "name", "Category", "autoInc", "0");
            dalTabletp_chart_mst["action"] = new XVar("type", 202, "varname", "action", "name", "action", "autoInc", "0");
            dalTabletp_chart_mst["MiscBox1099"] = new XVar("type", 202, "varname", "MiscBox1099", "name", "MiscBox1099", "autoInc", "0");
            dalTabletp_chart_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTabletp_chart_mst["currency"] = new XVar("type", 202, "varname", "currency", "name", "currency", "autoInc", "0");
            dalTabletp_chart_mst["payer_entity_name"] = new XVar("type", 202, "varname", "payer_entity_name", "name", "payer_entity_name", "autoInc", "0");
            dalTabletp_chart_mst["RowPointer"] = new XVar("type", 72, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_chart_mst"] = dalTabletp_chart_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_chart_mst()
        {
            			this.m_TableName = "dbo.tp_chart_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_chart_mst";
        }
    }
}