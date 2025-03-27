using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sc_indcode : tDALTable
    {
        public XVar indcode;
        public XVar description;
        public XVar site_ref;
        public static void Init()
        {
            XVar dalTablesc_indcode = XVar.Array();
            dalTablesc_indcode["indcode"] = new XVar("type", 202, "varname", "indcode", "name", "indcode", "autoInc", "0");
            dalTablesc_indcode["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablesc_indcode["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sc_indcode"] = dalTablesc_indcode;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sc_indcode()
        {
            			this.m_TableName = "dbo.sc_indcode";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sc_indcode";
        }
    }
}