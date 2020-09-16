using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Messages
{
    public class PlaceOrder : ICommand
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
    }
}
