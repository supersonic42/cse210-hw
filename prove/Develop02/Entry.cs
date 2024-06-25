public class Entry
{
    public DateTime _date;
    public int _promptId;
    public string _entryText;

    public void Display(Dictionary<int, string> prompts)
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"Prompt: {prompts[_promptId]}");
        Console.WriteLine($"Answer: {_entryText}");
    }
}