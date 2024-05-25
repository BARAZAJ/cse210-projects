using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        Console.Write("Select a choice from the menu (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Welcome to the breathing Activity! ");
                Console.WriteLine(" ");
                Console.WriteLine("This activity will help you relax by walking through through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.Write("How long, in seconds, would you like your session to be?");
                int durationBreathing = Convert.ToInt32(Console.ReadLine());
                BreathingActivity breathingActivity = new BreathingActivity(durationBreathing);
                breathingActivity.Run();
                break;
                
            case 2:
                Console.WriteLine("Welcome to the Reflection activity");
                Console.WriteLine("This activity will help you reflect on time in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.Write("How long in seconds would you like your session to be: ");
                int durationReflection = Convert.ToInt32(Console.ReadLine());
                ReflectingActivity reflectingActivity = new ReflectingActivity(durationReflection);
                reflectingActivity.Run();
                break;
                
            case 3:
                Console.WriteLine("Welcome to the listing activity!");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.Write("How long in seconds would you like the activity to be:  ");
                int durationListing = Convert.ToInt32(Console.ReadLine());
                ListingActivity listingActivity = new ListingActivity(durationListing);
                listingActivity.Run();
                break;
                
            case 4:
                
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.WriteLine("Thank you!!");
    }
}
