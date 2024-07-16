public abstract class Goal(string name, string description, int points)
{
    protected string _name = name;
    protected string _description = description;
    protected int points = points;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}