public class ListingActivity(string name, string description, int duration, int count, List<string> prompts) 
: Activity(name, description, duration)
{
    private int _count = count;
    private List<string> _prompts = prompts;

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        DisplayPrompt(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.Write($"You've listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new();
        var randomPrompt = _prompts.ElementAt(rnd.Next(0, _prompts.Count));

        return randomPrompt;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"- {prompt} -");
    }

    public void GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
    }
}