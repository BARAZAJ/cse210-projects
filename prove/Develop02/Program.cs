internal class Program
{
    private static Journal entryManager = new Journal();
    private static string[] randomPrompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me smile today?",
        "How did I challenge myself today?",
        "What am I grateful for right now?",
        "What is one thing I learned today?",
        "How did I show kindness to someone today?"
       
    };
    private static Random random = new Random();
    private static int promptIndex;

    static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("What would you like to do? ");
            if (int.TryParse(Console.ReadLine(), out int userChoice))
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Writing a new entry...");
                        DisplayRandomPrompt();
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        entryManager.AddEntry(randomPrompts[promptIndex], response);
                        break;

                    case 2:
                        Console.WriteLine("Displaying all entries...");
                        entryManager.DisplayEntries();
                        break;

                    case 3:
                        Console.WriteLine("Saving entries to a CSV file...");
                        Console.Write("Enter a filename to save: ");
                        string saveFileName = Console.ReadLine();
                        entryManager.SaveEntriesToCsv(saveFileName);
                        break;

                    case 4:
                        Console.WriteLine("Loading entries from a CSV file...");
                        Console.Write("Enter a filename to load: ");
                        string loadFileName = Console.ReadLine();
                        entryManager.LoadEntriesFromCsv(loadFileName);
                        Console.WriteLine("Entries loaded:");
                        entryManager.DisplayEntries(); 
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        continueRunning = false;
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

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Please select from one of the choices below:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save entries to a CSV file");
        Console.WriteLine("4. Load entries from a CSV file");
        Console.WriteLine("5. Quit");
    }

    private static void DisplayRandomPrompt()
    {
        promptIndex = random.Next(randomPrompts.Length);
        Console.WriteLine($"Prompt: {randomPrompts[promptIndex]}");
    }
}
