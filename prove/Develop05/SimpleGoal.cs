public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
{
    private bool _isComplete = false;

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}