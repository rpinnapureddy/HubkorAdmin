using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_invitem_mst : tDALTable
    {
        public XVar inv_num;
        public XVar app;
        public XVar item;
        public XVar description;
        public XVar rate;
        public XVar qty;
        public XVar u_m;
        public XVar discount;
        public XVar clientid;
        public XVar rowpointer;
        public static void Init()
        {
            XVar dalTablehk_invitem_mst = XVar.Array();
            dalTablehk_invitem_mst["inv_num"] = new XVar("type", 20, "varname", "inv_num", "name", "inv_num", "autoInc", "0");
            dalTablehk_invitem_mst["app"] = new XVar("type", 202, "varname", "app", "name", "app", "autoInc", "0");
            dalTablehk_invitem_mst["item"] = new XVar("type", 202, "varname", "item", "name", "item", "autoInc", "0");
            dalTablehk_invitem_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablehk_invitem_mst["rate"] = new XVar("type", 14, "varname", "rate", "name", "rate", "autoInc", "0");
            dalTablehk_invitem_mst["qty"] = new XVar("type", 14, "varname", "qty", "name", "qty", "autoInc", "0");
            dalTablehk_invitem_mst["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTablehk_invitem_mst["discount"] = new XVar("type", 3, "varname", "discount", "name", "discount", "autoInc", "0");
            dalTablehk_invitem_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablehk_invitem_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_invitem_mst"] = dalTablehk_invitem_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_invitem_mst()
        {
            			this.m_TableName = "dbo.hk_invitem_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_invitem_mst";
        }
    }
}