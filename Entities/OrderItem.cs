using System;

namespace product_order.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        //This price is a copy of the current price of the entity "Product"
        public double Price { get; set; }
        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}