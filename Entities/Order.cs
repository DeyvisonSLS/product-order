using System;
using System.Text;
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

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine("ORDER SUMMARY: ");
            text.AppendLine("Order Momment: " + Momment);
            text.AppendLine("Order Status:" + Status);
            text.Append("Client: ");
            text.Append(Client.Name);
            text.Append(" (" + Momment.Date + ") - ");
            text.AppendLine(Client.Email);
            text.AppendLine("Order Items: ");
            
            foreach(OrderItem ordit in Item)
            {
                text.AppendLine(ordit.na);
            }
            
            return text.ToString();
        }
    }
}