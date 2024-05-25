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
            Console.WriteLine("\n--- Goal Manager ---");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type:");
        Console.WriteLine("1 - Simple Goal");
        Console.WriteLine("2 - Eternal Goal");
        Console.WriteLine("3 - Checklist Goal");
        Console.WriteLine("4 - Negative Goal");
        Console.Write("Choose a goal type: ");
        var type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();

        Console.Write("Enter points: ");
        var points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target amount: ");
                var target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                var bonus = int.Parse(Console.ReadLine());

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
        Console.Write("Enter the filename to save goals: ");
        var filename = Console.ReadLine();

        using (var writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        var filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            using (var reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine()); // Load the score

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(new[] { '-' }, 2);
                    var name = parts[0].Trim();
                    var descriptionPoints = parts[1].Split(':')[0].Trim();
                    var points = int.Parse(descriptionPoints.Split()[0]);

                    // Simplified for demo purposes
                    var description = descriptionPoints.Substring(descriptionPoints.IndexOf(' ') + 1);
                    _goals.Add(new SimpleGoal(name, description, points));
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}



























