using System;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Address address1 = new Address("22 jump St", "Jinja", "JN", "USA");
            Customer customer1 = new Customer("Baraza John", address1);
            Product product1 = new Product("Smartphones", "W123", 40.4, 3);
            Product product2 = new Product("Hard disks", "G456", 60.3, 5);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

           
            Address address2 = new Address("22 Jump St", "Jinja", "JN", "Uganda");
            Customer customer2 = new Customer("Otema Isaac", address2);
            Product product3 = new Product("Soccer ball", "SC33", 20.5, 5);
            Product product4 = new Product("Gloves", "T32", 43.99, 9);

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
