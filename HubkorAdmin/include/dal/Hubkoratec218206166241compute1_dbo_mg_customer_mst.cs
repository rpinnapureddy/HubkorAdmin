using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_mg_customer_mst : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar customer_id;
        public XVar cust_num;
        public XVar cust_seq;
        public XVar name;
        public XVar city;
        public XVar state;
        public XVar zip;
        public XVar country;
        public XVar addr1;
        public XVar addr2;
        public XVar addr3;
        public XVar addr4;
        public XVar email;
        public XVar posted;
        public XVar address_id;
        public XVar telephone;
        public static void Init()
        {
            XVar dalTablemg_customer_mst = XVar.Array();
            dalTablemg_customer_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablemg_customer_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablemg_customer_mst["customer_id"] = new XVar("type", 3, "varname", "customer_id", "name", "customer_id", "autoInc", "0");
            dalTablemg_customer_mst["cust_num"] = new XVar("type", 202, "varname", "cust_num", "name", "cust_num", "autoInc", "0");
            dalTablemg_customer_mst["cust_seq"] = new XVar("type", 3, "varname", "cust_seq", "name", "cust_seq", "autoInc", "0");
            dalTablemg_customer_mst["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTablemg_customer_mst["city"] = new XVar("type", 202, "varname", "city", "name", "city", "autoInc", "0");
            dalTablemg_customer_mst["state"] = new XVar("type", 202, "varname", "state", "name", "state", "autoInc", "0");
            dalTablemg_customer_mst["zip"] = new XVar("type", 202, "varname", "zip", "name", "zip", "autoInc", "0");
            dalTablemg_customer_mst["country"] = new XVar("type", 202, "varname", "country", "name", "country", "autoInc", "0");
            dalTablemg_customer_mst["addr1"] = new XVar("type", 202, "varname", "addr1", "name", "addr1", "autoInc", "0");
            dalTablemg_customer_mst["addr2"] = new XVar("type", 202, "varname", "addr2", "name", "addr2", "autoInc", "0");
            dalTablemg_customer_mst["addr3"] = new XVar("type", 202, "varname", "addr3", "name", "addr3", "autoInc", "0");
            dalTablemg_customer_mst["addr4"] = new XVar("type", 202, "varname", "addr4", "name", "addr4", "autoInc", "0");
            dalTablemg_customer_mst["email"] = new XVar("type", 202, "varname", "email", "name", "email", "autoInc", "0");
            dalTablemg_customer_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTablemg_customer_mst["address_id"] = new XVar("type", 3, "varname", "address_id", "name", "address_id", "autoInc", "0");
            dalTablemg_customer_mst["telephone"] = new XVar("type", 202, "varname", "telephone", "name", "telephone", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_mg_customer_mst"] = dalTablemg_customer_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_mg_customer_mst()
        {
            			this.m_TableName = "dbo.mg_customer_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_mg_customer_mst";
        }
    }
}