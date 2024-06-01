using System;
using System.Collections.Generic;

namespace EventPlanning
{
    class Program
    {
        static void Main()
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
            Address address2 = new Address("456 Elm St", "Chicago", "IL", "60601");
            Address address3 = new Address("789 Oak St", "Peoria", "IL", "61601");

            // Create customers
            Customer customer1 = new Customer("John Smith", address1);
            Customer customer2 = new Customer("Jane Doe", address2);

            // Create products
            Product product1 = new Product("Laptop", 999.99, 1);
            Product product2 = new Product("Mouse", 19.99, 2);
            Product product3 = new Product("Keyboard", 49.99, 1);
            Product product4 = new Product("Monitor", 199.99, 1);

            // Create orders and add products
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            // Display order details
            List<Order> orders = new List<Order> { order1, order2 };
            foreach (var order in orders)
            {
                Console.WriteLine("Order Details:");
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine($"Total Cost: {order.GetTotalCost():C}");
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine();
            }

            // Create events
            Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", DateTime.Now.AddDays(7), "10:00 AM", address1, "John Doe", 100);
            Event reception = new Reception("Wedding Reception", "Celebrate the wedding of Jane and John", DateTime.Now.AddDays(14), "6:00 PM", address2, "rsvp@wedding.com");
            Event outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun picnic in the park", DateTime.Now.AddDays(21), "1:00 PM", address3, "Sunny and warm");

            Event[] events = { lecture, reception, outdoorGathering };

            foreach (var ev in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine();
            }
        }
    }
}
