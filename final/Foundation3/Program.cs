using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "TX", "67890");
        Address address3 = new Address("789 Oak St", "Sometown", "FL", "10112");

        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in technology", "2024-07-10", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Company Gala", "Annual company celebration", "2024-07-15", "7:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Festival", "A fun day in the sun", "2024-08-05", "12:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event eventItem in events)
        {
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }
    }
}
