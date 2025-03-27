using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_csi_uet_tables : tDALTable
    {
        public XVar Expr1;
        public static void Init()
        {
            XVar dalTablehk_csi_uet_tables = XVar.Array();
            dalTablehk_csi_uet_tables["Expr1"] = new XVar("type", 202, "varname", "Expr1", "name", "Expr1", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_csi_uet_tables"] = dalTablehk_csi_uet_tables;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_csi_uet_tables()
        {
            			this.m_TableName = "dbo.hk_csi_uet_tables";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_csi_uet_tables";
        }
    }
}