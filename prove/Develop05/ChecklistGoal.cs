public class ChecklistGoal(string name, string description, int points, int target, int bonus) :
Goal(name, description, points)
{
    private int _target = target;
    private int _bonus = bonus;
    private int _amountCompleted;

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}