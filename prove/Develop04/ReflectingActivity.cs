public class ReflectingActivity(
    string name, 
    string description, 
    int duration, 
    List<string> prompts, 
    List<string> questions
) : Activity(name, description, duration)
{
    private List<string> _prompts = prompts;
    private List<string> _questions = questions;
    private List<string> _displayedQuestions = [];

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);
        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions if they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new();
        var randomPrompt = _prompts.ElementAt(rnd.Next(0, _prompts.Count));

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random rnd = new();

        foreach (string displayedQuestion in _displayedQuestions)
        {
            _questions.Remove(displayedQuestion);
        }

        var randomQuestion = _questions.ElementAt(rnd.Next(0, _questions.Count));

        _displayedQuestions.Add(randomQuestion);
        
        return randomQuestion;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"- {prompt} -\n");
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {GetRandomQuestion()} ");
            ShowSpinner(10);
        }
    }
}