using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Messages
{
    public class MakePayment : ICommand
    {
        public int Id { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal AmountPaid { get; set; }

    }

    public enum PaymentType
    {
        Cash,
        Credit,
        Debit
    }
}
