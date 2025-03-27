using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_hk_job : tDALTable
    {
        public XVar job_name;
        public XVar Executed_at;
        public XVar next_execution;
        public static void Init()
        {
            XVar dalTablehk_job = XVar.Array();
            dalTablehk_job["job_name"] = new XVar("type", 202, "varname", "job_name", "name", "job_name", "autoInc", "0");
            dalTablehk_job["Executed_at"] = new XVar("type", 135, "varname", "Executed_at", "name", "Executed_at", "autoInc", "0");
            dalTablehk_job["next_execution"] = new XVar("type", 135, "varname", "next_execution", "name", "next_execution", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_hk_job"] = dalTablehk_job;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_hk_job()
        {
            			this.m_TableName = "dbo.hk_job";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_hk_job";
        }
    }
}