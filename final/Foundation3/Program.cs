using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Jinja St", "Jinja", "Ug", "12345");
        Address address2 = new Address("234 Main St", "Kampala", "Kn", "67890");
        Address address3 = new Address("342 Iganga St", "Mbarara", "RW", "10112");

        Lecture lecture = new Lecture("Biology Talk", "A talk on the latest in the field of Biology", "2024-04-02", "10:00 AM", address1, "BARAZA JOHN", 230);
        Reception reception = new Reception("Company Party", "Serious dancing party", "2023-02-02", "7:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Beach party", "Just chilling in the sand", "2022-09-01", "02:00 PM", address3, "Buddy");

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
