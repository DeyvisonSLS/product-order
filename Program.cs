using System;
using product_order.Entities;
using product_order.Entities.Enums;

namespace product_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (MM/DD/YYYY): ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the {(i + 1)} item data:", i);

                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int prodAmount = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(prodAmount, prodPrice, product);

                order.AddItem(orderItem);
            }

        }
    }
}
