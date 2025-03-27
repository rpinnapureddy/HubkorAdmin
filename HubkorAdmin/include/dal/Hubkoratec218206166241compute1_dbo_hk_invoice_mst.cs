using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_invoice_mst : tDALTable
    {
        public XVar inv_num;
        public XVar rowpointer;
        public XVar clientid;
        public XVar total;
        public XVar inv_date;
        public XVar due_date;
        public XVar posted;
        public XVar status;
        public static void Init()
        {
            XVar dalTablehk_invoice_mst = XVar.Array();
            dalTablehk_invoice_mst["inv_num"] = new XVar("type", 20, "varname", "inv_num", "name", "inv_num", "autoInc", "1");
            dalTablehk_invoice_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTablehk_invoice_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablehk_invoice_mst["total"] = new XVar("type", 14, "varname", "total", "name", "total", "autoInc", "0");
            dalTablehk_invoice_mst["inv_date"] = new XVar("type", 7, "varname", "inv_date", "name", "inv_date", "autoInc", "0");
            dalTablehk_invoice_mst["due_date"] = new XVar("type", 7, "varname", "due_date", "name", "due_date", "autoInc", "0");
            dalTablehk_invoice_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablehk_invoice_mst["status"] = new XVar("type", 202, "varname", "status", "name", "status", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_invoice_mst"] = dalTablehk_invoice_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_invoice_mst()
        {
            			this.m_TableName = "dbo.hk_invoice_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_invoice_mst";
        }
    }
}