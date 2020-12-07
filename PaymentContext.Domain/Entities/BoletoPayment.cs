using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }

        public BoletoPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, double total, double totalPaid, string payer, Document document, Address address, Email email)
            : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            this.BarCode = barCode;
            this.BoletoNumber = boletoNumber;
        }
    }
}