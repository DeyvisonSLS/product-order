using System;
using System.Collections.Generic;
using product_order.Entities.Enums;

namespace product_order.Entities
{
    public class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; private set; } = new List<OrderItem>();
        public Order()
        {
        }
        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double TotalAmount()
        {
            double sum = 0.0;
            foreach(OrderItem item in Item)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}