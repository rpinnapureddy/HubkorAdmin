using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_Clients_provisioning : tDALTable
    {
        public XVar id;
        public XVar name;
        public XVar shortcode;
        public XVar provision_date;
        public XVar project_manager;
        public XVar primary_contact;
        public XVar primary_email;
        public XVar primary_phone;
        public XVar onprem;
        public XVar apps;
        public static void Init()
        {
            XVar dalTableClients_provisioning = XVar.Array();
            dalTableClients_provisioning["id"] = new XVar("type", 3, "varname", "id", "name", "id", "autoInc", "0");
            dalTableClients_provisioning["name"] = new XVar("type", 202, "varname", "name", "name", "name", "autoInc", "0");
            dalTableClients_provisioning["shortcode"] = new XVar("type", 202, "varname", "shortcode", "name", "shortcode", "autoInc", "0");
            dalTableClients_provisioning["provision_date"] = new XVar("type", 7, "varname", "provision_date", "name", "provision_date", "autoInc", "0");
            dalTableClients_provisioning["project_manager"] = new XVar("type", 202, "varname", "project_manager", "name", "project_manager", "autoInc", "0");
            dalTableClients_provisioning["primary_contact"] = new XVar("type", 202, "varname", "primary_contact", "name", "primary_contact", "autoInc", "0");
            dalTableClients_provisioning["primary_email"] = new XVar("type", 202, "varname", "primary_email", "name", "primary_email", "autoInc", "0");
            dalTableClients_provisioning["primary_phone"] = new XVar("type", 202, "varname", "primary_phone", "name", "primary_phone", "autoInc", "0");
            dalTableClients_provisioning["onprem"] = new XVar("type", 16, "varname", "onprem", "name", "onprem", "autoInc", "0");
            dalTableClients_provisioning["apps"] = new XVar("type", 202, "varname", "apps", "name", "apps", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_Clients_provisioning"] = dalTableClients_provisioning;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_Clients_provisioning()
        {
            			this.m_TableName = "dbo.Clients_provisioning";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_Clients_provisioning";
        }
    }
}