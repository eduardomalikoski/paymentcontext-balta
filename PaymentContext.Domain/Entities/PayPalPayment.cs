using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; private set; }

        public PayPalPayment(string transactionCode, DateTime paidDate, DateTime expireDate, double total, double totalPaid, string payer, Document document, Address address, Email email)
            : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            this.TransactionCode = transactionCode;
        }
    }
}