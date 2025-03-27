using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_csi_site_mst : tDALTable
    {
        public XVar clientid;
        public XVar site_ref;
        public XVar tp_payer_entity_name;
        public XVar RowPointer;
        public XVar VariationNumber;
        public XVar uf_uet1;
        public XVar uf_uet2;
        public XVar uf_uet3;
        public XVar uf_uet4;
        public XVar uf_uet5;
        public XVar uf_uet6;
        public XVar uf_uet7;
        public XVar uf_uet8;
        public XVar uf_uet9;
        public XVar uf_uet10;
        public XVar tp_bankcode;
        public XVar sf_entity_name;
        public XVar site_prefix;
        public XVar mg_whse;
        public XVar mg_quest_vend_num;
        public XVar sc_entity_name;
        public XVar exp_entity_name;
        public XVar exp_journal;
        public XVar tp_active;
        public XVar tp_vend_stat_pre;
        public XVar tp_vend_stat_post;
        public XVar tp_vend_post_to_sl;
        public XVar tp_lc_active;
        public static void Init()
        {
            XVar dalTablecsi_site_mst = XVar.Array();
            dalTablecsi_site_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablecsi_site_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablecsi_site_mst["tp_payer_entity_name"] = new XVar("type", 202, "varname", "tp_payer_entity_name", "name", "tp_payer_entity_name", "autoInc", "0");
            dalTablecsi_site_mst["RowPointer"] = new XVar("type", 72, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTablecsi_site_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablecsi_site_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            dalTablecsi_site_mst["tp_bankcode"] = new XVar("type", 202, "varname", "tp_bankcode", "name", "tp_bankcode", "autoInc", "0");
            dalTablecsi_site_mst["sf_entity_name"] = new XVar("type", 202, "varname", "sf_entity_name", "name", "sf_entity_name", "autoInc", "0");
            dalTablecsi_site_mst["site_prefix"] = new XVar("type", 202, "varname", "site_prefix", "name", "site_prefix", "autoInc", "0");
            dalTablecsi_site_mst["mg_whse"] = new XVar("type", 202, "varname", "mg_whse", "name", "mg_whse", "autoInc", "0");
            dalTablecsi_site_mst["mg_quest_vend_num"] = new XVar("type", 202, "varname", "mg_quest_vend_num", "name", "mg_quest_vend_num", "autoInc", "0");
            dalTablecsi_site_mst["sc_entity_name"] = new XVar("type", 202, "varname", "sc_entity_name", "name", "sc_entity_name", "autoInc", "0");
            dalTablecsi_site_mst["exp_entity_name"] = new XVar("type", 202, "varname", "exp_entity_name", "name", "exp_entity_name", "autoInc", "0");
            dalTablecsi_site_mst["exp_journal"] = new XVar("type", 202, "varname", "exp_journal", "name", "exp_journal", "autoInc", "0");
            dalTablecsi_site_mst["tp_active"] = new XVar("type", 16, "varname", "tp_active", "name", "tp_active", "autoInc", "0");
            dalTablecsi_site_mst["tp_vend_stat_pre"] = new XVar("type", 202, "varname", "tp_vend_stat_pre", "name", "tp_vend_stat_pre", "autoInc", "0");
            dalTablecsi_site_mst["tp_vend_stat_post"] = new XVar("type", 202, "varname", "tp_vend_stat_post", "name", "tp_vend_stat_post", "autoInc", "0");
            dalTablecsi_site_mst["tp_vend_post_to_sl"] = new XVar("type", 16, "varname", "tp_vend_post_to_sl", "name", "tp_vend_post_to_sl", "autoInc", "0");
            dalTablecsi_site_mst["tp_lc_active"] = new XVar("type", 16, "varname", "tp_lc_active", "name", "tp_lc_active", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_csi_site_mst"] = dalTablecsi_site_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_csi_site_mst()
        {
            			this.m_TableName = "dbo.csi_site_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_csi_site_mst";
        }
    }
}