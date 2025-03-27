using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_invoice_temp : tDALTable
    {
        public XVar invoice_id;
        public static void Init()
        {
            XVar dalTabletp_invoice_temp = XVar.Array();
            dalTabletp_invoice_temp["invoice_id"] = new XVar("type", 202, "varname", "invoice_id", "name", "invoice_id", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_invoice_temp"] = dalTabletp_invoice_temp;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_invoice_temp()
        {
            			this.m_TableName = "dbo.tp_invoice_temp";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_invoice_temp";
        }
    }
}