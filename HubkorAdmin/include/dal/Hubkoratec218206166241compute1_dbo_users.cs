using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_users : tDALTable
    {
        public XVar user_name;
        public XVar password;
        public XVar user_group;
        public XVar active;
        public XVar email;
        public XVar email_notification;
        public XVar description;
        public XVar reset_date;
        public XVar two_factor;
        public XVar totp_secret;
        public XVar clientid;
        public XVar userpic;
        public XVar reset_token;
        public XVar title;
        public XVar phone;
        public XVar time_zone;
        public XVar salutation;
        public XVar first_name;
        public XVar last_name;
        public static void Init()
        {
            XVar dalTableusers = XVar.Array();
            dalTableusers["user_name"] = new XVar("type", 202, "varname", "user_name", "name", "user_name", "autoInc", "0");
            dalTableusers["password"] = new XVar("type", 202, "varname", "password", "name", "password", "autoInc", "0");
            dalTableusers["user_group"] = new XVar("type", 202, "varname", "user_group", "name", "user_group", "autoInc", "0");
            dalTableusers["active"] = new XVar("type", 16, "varname", "active", "name", "active", "autoInc", "0");
            dalTableusers["email"] = new XVar("type", 202, "varname", "email", "name", "email", "autoInc", "0");
            dalTableusers["email_notification"] = new XVar("type", 16, "varname", "email_notification", "name", "email_notification", "autoInc", "0");
            dalTableusers["description"] = new XVar("type", 202, "varname", "description", "name", "description", "autoInc", "0");
            dalTableusers["reset_date"] = new XVar("type", 135, "varname", "reset_date", "name", "reset_date", "autoInc", "0");
            dalTableusers["two_factor"] = new XVar("type", 3, "varname", "two_factor", "name", "two_factor", "autoInc", "0");
            dalTableusers["totp_secret"] = new XVar("type", 200, "varname", "totp_secret", "name", "totp_secret", "autoInc", "0");
            dalTableusers["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTableusers["userpic"] = new XVar("type", 205, "varname", "userpic", "name", "userpic", "autoInc", "0");
            dalTableusers["reset_token"] = new XVar("type", 202, "varname", "reset_token", "name", "reset_token", "autoInc", "0");
            dalTableusers["title"] = new XVar("type", 202, "varname", "title", "name", "title", "autoInc", "0");
            dalTableusers["phone"] = new XVar("type", 202, "varname", "phone", "name", "phone", "autoInc", "0");
            dalTableusers["time_zone"] = new XVar("type", 202, "varname", "time_zone", "name", "time_zone", "autoInc", "0");
            dalTableusers["salutation"] = new XVar("type", 202, "varname", "salutation", "name", "salutation", "autoInc", "0");
            dalTableusers["first_name"] = new XVar("type", 202, "varname", "first_name", "name", "first_name", "autoInc", "0");
            dalTableusers["last_name"] = new XVar("type", 202, "varname", "last_name", "name", "last_name", "autoInc", "0");
	        dalTableusers.InitAndSetArrayItem(true, "user_name", "key");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_users"] = dalTableusers;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_users()
        {
            			this.m_TableName = "dbo.users";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_users";
        }
    }
}