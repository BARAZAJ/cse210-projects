public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, -points)
    {
    }

    public override void RecordEvent()
    {
        // This function can have additional logic if needed
    }

    public override bool IsComplete()
    {
        return true; // Always true since negative goals are immediate
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Negative Points: {_points})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}: Negative {_points} points";
    }

    public override string GetCheckboxStatus()
    {
        return "[X]"; // Negative goals are marked complete immediately
    }
}
