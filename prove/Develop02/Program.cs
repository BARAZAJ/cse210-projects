using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select from one of the choices below!");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");

        // Reading user input as a string
        string userInput = Console.ReadLine();

        // Attempting to parse the user input to an integer
        if (int.TryParse(userInput, out int userChoice))
        {
            // Switch statement to handle different user choices
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You chose: Write");
                    List<string> questions = new List<string>()
                    {
                        "Who was the most interesting person you spoke to today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I have one thing I could ever do today, what would it be?"
                    };
                       Random random = new Random();

                       int randomindex = random.Next(questions.Count);
                       string randomquestion = questions[randomindex];
                        Console.Write($"{randomquestion}");
                        string UserInput = Console.ReadLine();

                        DateTime currenttime = DateTime.Now;
                        string DateToday = currenttime.ToShortDateString();

                       entry entrydata = new entry();
                       entrydata.prompttext = randomquestion;
                       entrydata.date = DateToday;
                       entrydata.userentry = UserInput;









                    // Add code here to handle "Write" action
                    





                    break;
                case 2:
                    Console.WriteLine("You chose: Display");
                    // Add code here to handle "Display" action
                    break;
                case 3:
                    Console.WriteLine("You chose: Load");
                    // Add code here to handle "Load" action
                    break;
                case 4:
                    Console.WriteLine("You chose: Save");
                    // Add code here to handle "Save" action
                    break;
                case 5:
                    Console.WriteLine("You chose: Quit");
                    // Add code here to handle "Quit" action
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}









