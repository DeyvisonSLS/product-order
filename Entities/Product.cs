using System;

namespace product_order.Entities
{
    public class Product
    {
        public string Name { get; set; }
        //This price is a dinamic value, here the price will be changed acordingly to the market.
        public double Price { get; set; }
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}