using System;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first order
            Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Product product1 = new Product("Widget", "W123", 10.99, 3);
            Product product2 = new Product("Gadget", "G456", 25.50, 2);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

            // Create second order
            Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);
            Product product3 = new Product("Thingamajig", "T789", 15.75, 4);
            Product product4 = new Product("Doohickey", "D012", 9.99, 5);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            Console.WriteLine("\nOrder 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        }
    }
}
