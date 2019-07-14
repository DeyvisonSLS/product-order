using System;
using product_order.Entities;

namespace product_order.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        //This price is a copy of the current price of the entity "Product"
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}