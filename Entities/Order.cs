using System;
using System.Text;
using System.Globalization;
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
        private CultureInfo invCult = CultureInfo.InvariantCulture;
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
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine("ORDER SUMMARY: ");
            text.AppendLine("Order Momment: " + Momment.ToString("MM/dd/yyyy"));
            text.AppendLine("Order Status:" + Status);
            text.Append("Client: " + Client);
            text.Append("Order Items: ");
            
            foreach(OrderItem ordit in Item)
            {
                text.Append(ordit.Product.Name + ", ");
                text.Append("Quantity: " + ordit.Quantity + ", ");
                text.AppendLine("Subtotal: $" + ordit.SubTotal().ToString("F2", invCult));
            }
            
            return text.ToString();
        }
    }
}