using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_csi_uet_fields : tDALTable
    {
        public XVar Expr1;
        public XVar COLUMN_NAME;
        public XVar Expr2;
        public static void Init()
        {
            XVar dalTablehk_csi_uet_fields = XVar.Array();
            dalTablehk_csi_uet_fields["Expr1"] = new XVar("type", 202, "varname", "Expr1", "name", "Expr1", "autoInc", "0");
            dalTablehk_csi_uet_fields["COLUMN_NAME"] = new XVar("type", 202, "varname", "COLUMN_NAME", "name", "COLUMN_NAME", "autoInc", "0");
            dalTablehk_csi_uet_fields["Expr2"] = new XVar("type", 3, "varname", "Expr2", "name", "Expr2", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_csi_uet_fields"] = dalTablehk_csi_uet_fields;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_csi_uet_fields()
        {
            			this.m_TableName = "dbo.hk_csi_uet_fields";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_csi_uet_fields";
        }
    }
}