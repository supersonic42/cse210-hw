public class ChecklistGoal(string name, string description, int points, int completionTimesMax, int completionBonus) :
Goal(name, description, points)
{
    private int _completionTimesMax = completionTimesMax;
    private int _completionTimesCurrent = 0;
    private int _completionBonus = completionBonus;

    public void SetCompletionTimesCurrent(int count)
    {
        _completionTimesCurrent = count;
    }

    public override string GetDetailsString(int number)
    {
        string goalCompleteMark = IsComplete() ? "x" : " ";
            
        return $"{number}. [{goalCompleteMark}] {GetName()} ({GetDescription()})"
            + $" | Completed: {_completionTimesCurrent}/{_completionTimesMax}";
    }

    public override string GetStringRepresentation()
    {
        List<string> data = [
            _name, 
            _description, 
            _points.ToString(), 
            _completionBonus.ToString(), 
            _completionTimesCurrent.ToString(), 
            _completionTimesMax.ToString()
        ];

        return typeof(ChecklistGoal).Name + ":" + String.Join(",", data);
    }

    public override bool IsComplete()
    {
        return _completionTimesCurrent == _completionTimesMax;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}