using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PFEMAPIORACLE.Models
{
    public class V_TRNS_PAYMENT_HDR
    {
        [Key, Column(Order = 1),]
        public string HOS_CODE { get; set; }
        [Key, Column(Order = 2),]
        public string YYYY { get; set; }
        [Key, Column(Order = 3),]
        public string MM { get; set; }
        [Key, Column(Order = 4),]
        public string PAYMENT_DOCNO { get; set; }
        public string VENDER_CODE { get; set; }
        public string VENDER_NAME { get; set; }
        public string VENDER_TAX_TYPE { get; set; }
        public string VENDER_TAX_ID { get; set; }
        public string VENDER_ADDR { get; set; }
        public string VENDER_BANK_CODE { get; set; }
        public string VENDER_BANK_BRANCH { get; set; }
        public string VENDER_BANK_ACCNT { get; set; }
        public string DELIVERY_MODE { get; set; }
        public string BATCH_ID { get; set; }
        public int NUMBER_OF_INVOICES { get; set; }
        public decimal TOTAL_AMT { get; set; }
        public decimal VAT_AMT { get; set; }
        public decimal WHT_AMT { get; set; }
        public decimal NET_PAID_AMT { get; set; }
    }
}