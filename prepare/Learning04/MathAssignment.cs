public class MathAssignment(string studentName, string topic, string textbookSection, string problems) : Assignment(studentName, topic)
{
    private string _textbookSection = textbookSection;
    private string _problems = problems;

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}