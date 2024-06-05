public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // This function can have additional logic if needed
    }

    public override bool IsComplete()
    {
        return false; // Never complete
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points} per event)";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}: {_points} points per event";
    }

    public override string GetCheckboxStatus()
    {
        return "[ ]"; // Eternal goals are never complete
    }
}
