public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1: Display Player Info");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Create Goal");
            Console.WriteLine("4: Record Event");
            Console.WriteLine("5: Save Goals");
            Console.WriteLine("6: Load Goals");
            Console.WriteLine("7: Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.GetCheckboxStatus()} {goal.GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter your goal type (1: Simple, 2: Eternal, 3: Checklist, 4: Negative): ");
        string type = Console.ReadLine();

        Console.WriteLine("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Describe your goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the goal's number of points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter the target: ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter goal bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "4":
                _goals.Add(new NegativeGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        var name = Console.ReadLine(); 

        var goal = _goals.Find(g => g.GetStringRepresentation().StartsWith(name));
        if (goal != null)
        {
            goal.RecordEvent();
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
            }
            _score += goal.Points;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            _goals.Clear();
            while ((line = reader.ReadLine()) != null)
            {
                // Parsing logic for different goal types
                // This part depends on how the goals are represented in the file
            }
        }
    }
}
