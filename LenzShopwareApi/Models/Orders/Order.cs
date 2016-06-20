using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi.Models.Orders
{
    public class Order
    {
        public int? id;
        public int number;
        public int customerId;
        public int paymentId;
        public int? partnerId;
        public int shopId;
        public double invoiceAmount;
        public double invoiceAmountNet;
        public double invoiceShipping;
        public double invoiceShippingNet;
        public string orderTime;
        public string transactionId;
        public string comment;
        public string customerComment;
        public string inernalComment;
        public int net;
        public int taxFree;
        public string temporaryId;
        public string referer;
        public string clearedDate;
        public string trackingCode;
        public int languageIso;
        public string currency;
        public double currencyFactor;
        public string remoteAddress;
        public string deviceType;
        public int paymentStatusId;
        public int orderStatusId;
    }
}
