using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_csi_u_m_mst : tDALTable
    {
        public XVar clientid;
        public XVar u_m;
        public XVar site_ref;
        public XVar CreateDate;
        public XVar CreatedBy;
        public XVar description;
        public XVar InWorkflow;
        public XVar iso_u_m;
        public XVar NoteExistsFlag;
        public XVar precision_;
        public XVar RecordDate;
        public XVar RowPointer;
        public XVar u_m_family;
        public XVar UpdatedBy;
        public XVar DLDeleteIndicator;
        public XVar VariationNumber;
        public XVar tp_id;
        public XVar tp_posted;
        public XVar sc_id;
        public XVar sc_posted;
        public XVar sf_id;
        public XVar sf_posted;
        public XVar mg_id;
        public XVar mg_posted;
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
        public static void Init()
        {
            XVar dalTablecsi_u_m_mst = XVar.Array();
            dalTablecsi_u_m_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTablecsi_u_m_mst["u_m"] = new XVar("type", 202, "varname", "u_m", "name", "u_m", "autoInc", "0");
            dalTablecsi_u_m_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTablecsi_u_m_mst["CreateDate"] = new XVar("type", 135, "varname", "CreateDate", "name", "CreateDate", "autoInc", "0");
            dalTablecsi_u_m_mst["CreatedBy"] = new XVar("type", 202, "varname", "CreatedBy", "name", "CreatedBy", "autoInc", "0");
            dalTablecsi_u_m_mst["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTablecsi_u_m_mst["InWorkflow"] = new XVar("type", 20, "varname", "InWorkflow", "name", "InWorkflow", "autoInc", "0");
            dalTablecsi_u_m_mst["iso_u_m"] = new XVar("type", 202, "varname", "iso_u_m", "name", "iso_u_m", "autoInc", "0");
            dalTablecsi_u_m_mst["NoteExistsFlag"] = new XVar("type", 20, "varname", "NoteExistsFlag", "name", "NoteExistsFlag", "autoInc", "0");
            dalTablecsi_u_m_mst["precision_"] = new XVar("type", 20, "varname", "precision_", "name", "precision_", "autoInc", "0");
            dalTablecsi_u_m_mst["RecordDate"] = new XVar("type", 135, "varname", "RecordDate", "name", "RecordDate", "autoInc", "0");
            dalTablecsi_u_m_mst["RowPointer"] = new XVar("type", 202, "varname", "RowPointer", "name", "RowPointer", "autoInc", "0");
            dalTablecsi_u_m_mst["u_m_family"] = new XVar("type", 20, "varname", "u_m_family", "name", "u_m_family", "autoInc", "0");
            dalTablecsi_u_m_mst["UpdatedBy"] = new XVar("type", 202, "varname", "UpdatedBy", "name", "UpdatedBy", "autoInc", "0");
            dalTablecsi_u_m_mst["DLDeleteIndicator"] = new XVar("type", 20, "varname", "DLDeleteIndicator", "name", "DLDeleteIndicator", "autoInc", "0");
            dalTablecsi_u_m_mst["VariationNumber"] = new XVar("type", 20, "varname", "VariationNumber", "name", "VariationNumber", "autoInc", "0");
            dalTablecsi_u_m_mst["tp_id"] = new XVar("type", 202, "varname", "tp_id", "name", "tp_id", "autoInc", "0");
            dalTablecsi_u_m_mst["tp_posted"] = new XVar("type", 16, "varname", "tp_posted", "name", "tp_posted", "autoInc", "0");
            dalTablecsi_u_m_mst["sc_id"] = new XVar("type", 202, "varname", "sc_id", "name", "sc_id", "autoInc", "0");
            dalTablecsi_u_m_mst["sc_posted"] = new XVar("type", 16, "varname", "sc_posted", "name", "sc_posted", "autoInc", "0");
            dalTablecsi_u_m_mst["sf_id"] = new XVar("type", 202, "varname", "sf_id", "name", "sf_id", "autoInc", "0");
            dalTablecsi_u_m_mst["sf_posted"] = new XVar("type", 16, "varname", "sf_posted", "name", "sf_posted", "autoInc", "0");
            dalTablecsi_u_m_mst["mg_id"] = new XVar("type", 202, "varname", "mg_id", "name", "mg_id", "autoInc", "0");
            dalTablecsi_u_m_mst["mg_posted"] = new XVar("type", 16, "varname", "mg_posted", "name", "mg_posted", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet1"] = new XVar("type", 202, "varname", "uf_uet1", "name", "uf_uet1", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet2"] = new XVar("type", 202, "varname", "uf_uet2", "name", "uf_uet2", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet3"] = new XVar("type", 202, "varname", "uf_uet3", "name", "uf_uet3", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet4"] = new XVar("type", 202, "varname", "uf_uet4", "name", "uf_uet4", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet5"] = new XVar("type", 202, "varname", "uf_uet5", "name", "uf_uet5", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet6"] = new XVar("type", 202, "varname", "uf_uet6", "name", "uf_uet6", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet7"] = new XVar("type", 202, "varname", "uf_uet7", "name", "uf_uet7", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet8"] = new XVar("type", 202, "varname", "uf_uet8", "name", "uf_uet8", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet9"] = new XVar("type", 202, "varname", "uf_uet9", "name", "uf_uet9", "autoInc", "0");
            dalTablecsi_u_m_mst["uf_uet10"] = new XVar("type", 202, "varname", "uf_uet10", "name", "uf_uet10", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_csi_u_m_mst"] = dalTablecsi_u_m_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_csi_u_m_mst()
        {
            			this.m_TableName = "dbo.csi_u_m_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_csi_u_m_mst";
        }
    }
}