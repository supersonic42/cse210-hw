public class Assignment(string studentName, string topic)
{
    protected string _studentName = studentName;
    private string _topic = topic;

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}