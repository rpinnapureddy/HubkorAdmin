using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_Hubkoratec218206166241compute1_dbo_tp_payments_hdr_mst : tDALTable
    {
        public XVar id;
        public XVar SequenceRefCode;
        public XVar submissionDate;
        public XVar AmountSubmitted;
        public XVar AmountSubmittedCur;
        public XVar PaymentMethod;
        public XVar Status;
        public XVar PayerFees;
        public XVar PayeeFxfees;
        public XVar PayerFxfees;
        public XVar withdrawCurr;
        public XVar withdrawAmt;
        public XVar NetAmountCurr;
        public XVar NetAmount;
        public XVar Message;
        public XVar BankingMessage;
        public XVar EmailSubject;
        public XVar TxnReference;
        public XVar paymentcurr;
        public XVar PayerEntityName;
        public XVar PayerEntityCountryISO;
        public XVar Provider;
        public XVar AccountIdentifier;
        public XVar PayerExchangeRate;
        public XVar PaymentAmountInWithdrawCurrency;
        public XVar vendor;
        public XVar TxnDate;
        public XVar posted;
        public XVar clientid;
        public XVar trans_num;
        public XVar site_ref;
        public XVar rowpointer;
        public XVar RelatedBills;
        public XVar err_msg;
        public XVar json_data;
        public XVar jresult;
        public XVar postdate;
        public XVar bank_code;
        public XVar manually_paid;
        public XVar ext_bank_type;
        public XVar ext_acct;
        public static void Init()
        {
            XVar dalTabletp_payments_hdr_mst = XVar.Array();
            dalTabletp_payments_hdr_mst["id"] = new XVar("type", 202, "varname", "id", "name", "id", "autoInc", "0");
            dalTabletp_payments_hdr_mst["SequenceRefCode"] = new XVar("type", 202, "varname", "SequenceRefCode", "name", "SequenceRefCode", "autoInc", "0");
            dalTabletp_payments_hdr_mst["submissionDate"] = new XVar("type", 202, "varname", "submissionDate", "name", "submissionDate", "autoInc", "0");
            dalTabletp_payments_hdr_mst["AmountSubmitted"] = new XVar("type", 202, "varname", "AmountSubmitted", "name", "AmountSubmitted", "autoInc", "0");
            dalTabletp_payments_hdr_mst["AmountSubmittedCur"] = new XVar("type", 202, "varname", "AmountSubmittedCur", "name", "AmountSubmittedCur", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PaymentMethod"] = new XVar("type", 202, "varname", "PaymentMethod", "name", "PaymentMethod", "autoInc", "0");
            dalTabletp_payments_hdr_mst["Status"] = new XVar("type", 202, "varname", "Status", "name", "Status", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PayerFees"] = new XVar("type", 202, "varname", "PayerFees", "name", "PayerFees", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PayeeFxfees"] = new XVar("type", 202, "varname", "PayeeFxfees", "name", "PayeeFxfees", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PayerFxfees"] = new XVar("type", 202, "varname", "PayerFxfees", "name", "PayerFxfees", "autoInc", "0");
            dalTabletp_payments_hdr_mst["withdrawCurr"] = new XVar("type", 202, "varname", "withdrawCurr", "name", "withdrawCurr", "autoInc", "0");
            dalTabletp_payments_hdr_mst["withdrawAmt"] = new XVar("type", 202, "varname", "withdrawAmt", "name", "withdrawAmt", "autoInc", "0");
            dalTabletp_payments_hdr_mst["NetAmountCurr"] = new XVar("type", 202, "varname", "NetAmountCurr", "name", "NetAmountCurr", "autoInc", "0");
            dalTabletp_payments_hdr_mst["NetAmount"] = new XVar("type", 202, "varname", "NetAmount", "name", "NetAmount", "autoInc", "0");
            dalTabletp_payments_hdr_mst["Message"] = new XVar("type", 202, "varname", "Message", "name", "Message", "autoInc", "0");
            dalTabletp_payments_hdr_mst["BankingMessage"] = new XVar("type", 202, "varname", "BankingMessage", "name", "BankingMessage", "autoInc", "0");
            dalTabletp_payments_hdr_mst["EmailSubject"] = new XVar("type", 202, "varname", "EmailSubject", "name", "EmailSubject", "autoInc", "0");
            dalTabletp_payments_hdr_mst["TxnReference"] = new XVar("type", 202, "varname", "TxnReference", "name", "TxnReference", "autoInc", "0");
            dalTabletp_payments_hdr_mst["paymentcurr"] = new XVar("type", 202, "varname", "paymentcurr", "name", "paymentcurr", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PayerEntityName"] = new XVar("type", 202, "varname", "PayerEntityName", "name", "PayerEntityName", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PayerEntityCountryISO"] = new XVar("type", 202, "varname", "PayerEntityCountryISO", "name", "PayerEntityCountryISO", "autoInc", "0");
            dalTabletp_payments_hdr_mst["Provider"] = new XVar("type", 202, "varname", "Provider", "name", "Provider", "autoInc", "0");
            dalTabletp_payments_hdr_mst["AccountIdentifier"] = new XVar("type", 202, "varname", "AccountIdentifier", "name", "AccountIdentifier", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PayerExchangeRate"] = new XVar("type", 202, "varname", "PayerExchangeRate", "name", "PayerExchangeRate", "autoInc", "0");
            dalTabletp_payments_hdr_mst["PaymentAmountInWithdrawCurrency"] = new XVar("type", 202, "varname", "PaymentAmountInWithdrawCurrency", "name", "PaymentAmountInWithdrawCurrency", "autoInc", "0");
            dalTabletp_payments_hdr_mst["vendor"] = new XVar("type", 202, "varname", "vendor", "name", "vendor", "autoInc", "0");
            dalTabletp_payments_hdr_mst["TxnDate"] = new XVar("type", 202, "varname", "TxnDate", "name", "TxnDate", "autoInc", "0");
            dalTabletp_payments_hdr_mst["posted"] = new XVar("type", 16, "varname", "posted", "name", "posted", "autoInc", "0");
            dalTabletp_payments_hdr_mst["clientid"] = new XVar("type", 202, "varname", "clientid", "name", "clientid", "autoInc", "0");
            dalTabletp_payments_hdr_mst["trans_num"] = new XVar("type", 20, "varname", "trans_num", "name", "trans_num", "autoInc", "1");
            dalTabletp_payments_hdr_mst["site_ref"] = new XVar("type", 202, "varname", "site_ref", "name", "site_ref", "autoInc", "0");
            dalTabletp_payments_hdr_mst["rowpointer"] = new XVar("type", 72, "varname", "rowpointer", "name", "rowpointer", "autoInc", "0");
            dalTabletp_payments_hdr_mst["RelatedBills"] = new XVar("type", 202, "varname", "RelatedBills", "name", "RelatedBills", "autoInc", "0");
            dalTabletp_payments_hdr_mst["err_msg"] = new XVar("type", 202, "varname", "err_msg", "name", "err_msg", "autoInc", "0");
            dalTabletp_payments_hdr_mst["json_data"] = new XVar("type", 202, "varname", "json_data", "name", "json_data", "autoInc", "0");
            dalTabletp_payments_hdr_mst["jresult"] = new XVar("type", 202, "varname", "jresult", "name", "jresult", "autoInc", "0");
            dalTabletp_payments_hdr_mst["postdate"] = new XVar("type", 135, "varname", "postdate", "name", "postdate", "autoInc", "0");
            dalTabletp_payments_hdr_mst["bank_code"] = new XVar("type", 202, "varname", "bank_code", "name", "bank_code", "autoInc", "0");
            dalTabletp_payments_hdr_mst["manually_paid"] = new XVar("type", 202, "varname", "manually_paid", "name", "manually_paid", "autoInc", "0");
            dalTabletp_payments_hdr_mst["ext_bank_type"] = new XVar("type", 202, "varname", "ext_bank_type", "name", "ext_bank_type", "autoInc", "0");
            dalTabletp_payments_hdr_mst["ext_acct"] = new XVar("type", 202, "varname", "ext_acct", "name", "ext_acct", "autoInc", "0");
            GlobalVars.dal_info["Hubkoratec218206166241compute1_dbo_tp_payments_hdr_mst"] = dalTabletp_payments_hdr_mst;
        }

        public  dalTable_Hubkoratec218206166241compute1_dbo_tp_payments_hdr_mst()
        {
            			this.m_TableName = "dbo.tp_payments_hdr_mst";
            this.m_infoKey = "Hubkoratec218206166241compute1_dbo_tp_payments_hdr_mst";
        }
    }
}