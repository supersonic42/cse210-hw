public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
{
    private bool isComplete = false;

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