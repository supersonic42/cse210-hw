public class WritingAssignment(string studentName, string topic, string title) : Assignment(studentName, topic)
{
    private string _title = title;

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}