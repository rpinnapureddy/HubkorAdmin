using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_indcode : tDALTable
    {
        public XVar indcode;
        public XVar description;
        public XVar rowpointer;
        public static void Init()
        {
            XVar dalTableindcode = XVar.Array();
            dalTableindcode["indcode"] = new XVar("type", 202, "varname", "indcode", "name", "indcode", "autoInc", "0");
            dalTableindcode["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTableindcode["rowpointer"] = new XVar("type", 200, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_indcode"] = dalTableindcode;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_indcode()
        {
            			this.m_TableName = "dbo.indcode";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_indcode";
        }
    }
}