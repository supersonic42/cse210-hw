public abstract class Goal(string name, string description, int points)
{
    protected string _name = name;
    protected string _description = description;
    protected int _points = points;
    protected int _completionTimesCurrent = 0;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract int GetRecordPoints();

    public abstract int CalculatePoints();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString(int number)
    {
        string goalCompleteMark = IsComplete() ? "x" : " ";
            
        return $"{number}. [{goalCompleteMark}] {GetName()} ({GetDescription()})";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetCompletionTimesCurrent()
    {
        return _completionTimesCurrent;
    }

    public void SetCompletionTimesCurrent(int count)
    {
        _completionTimesCurrent = count;
    }

    public int GetPoints()
    {
        return _points;
    }
}