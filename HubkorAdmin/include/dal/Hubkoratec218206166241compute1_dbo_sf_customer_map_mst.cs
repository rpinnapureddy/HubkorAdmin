using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_sf_customer_map_mst : tDALTable
    {
        public XVar clientid;
        public XVar cust_num;
        public XVar cust_seq;
        public XVar to_cust_num;
        public XVar to_cust_seq;
        public XVar sf_id;
        public XVar active;
        public XVar master;
        public XVar accountnumber;
        public XVar parentaccount;
        public XVar RowPointer;
        public static void Init()
        {
            XVar dalTablesf_customer_map_mst = XVar.Array();
            dalTablesf_customer_map_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablesf_customer_map_mst["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTablesf_customer_map_mst["cust_seq"] = new XVar("type", 20, "varname", "cust_seq", "name", "cust_seq", "autoInc", "0");
            dalTablesf_customer_map_mst["to_cust_num"] = new XVar("type", 202, "varname", "to_cust_num", "name", "to_cust_num", "autoInc", "0");
            dalTablesf_customer_map_mst["to_cust_seq"] = new XVar("type", 20, "varname", "to_cust_seq", "name", "to_cust_seq", "autoInc", "0");
            dalTablesf_customer_map_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablesf_customer_map_mst["active"] = new XVar("type", 16, "varname", "active", "name", "active", "autoInc", "0");
            dalTablesf_customer_map_mst["master"] = new XVar("type", 16, "varname", "master", "name", "master", "autoInc", "0");
            dalTablesf_customer_map_mst["accountnumber"] = new XVar("type", 202, "varname", "accountnumber", "name", "accountnumber", "autoInc", "0");
            dalTablesf_customer_map_mst["parentaccount"] = new XVar("type", 202, "varname", "parentaccount", "name", "parentaccount", "autoInc", "0");
            dalTablesf_customer_map_mst["RowPointer"] = new XVar("type", 72, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
	        dalTablesf_customer_map_mst.InitAndSetArrayItem(true, "clientid", "key");
	        dalTablesf_customer_map_mst.InitAndSetArrayItem(true, "cust_num", "key");
	        dalTablesf_customer_map_mst.InitAndSetArrayItem(true, "cust_seq", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_sf_customer_map_mst"] = dalTablesf_customer_map_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_sf_customer_map_mst()
        {
            			this.m_TableName = "dbo.sf_customer_map_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_sf_customer_map_mst";
        }
    }
}