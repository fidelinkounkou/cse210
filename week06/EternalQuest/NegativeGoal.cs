using System;

public class NegativeGoal : Goal
{
    private int _countOccurred;

    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        _countOccurred = 0;
    }

    public NegativeGoal(string name, string description, int points, int countOccurred) : base(name, description, points)
    {
        _countOccurred = countOccurred;
    }

    public override int RecordEvent()
    {
        _countOccurred++;
        return -GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "[ ] " + GetName() + " (" + GetDescription() + ") -- Occurred: " + _countOccurred + " times (Penalty: -" + GetPoints() + " pts)";
    }

    public override string GetStringRepresentation()
    {
        return "NegativeGoal:" + GetName() + "," + GetDescription() + "," + GetPoints() + "," + _countOccurred;
    }
}
