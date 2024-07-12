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

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {
        
    }
}