public class PromptGenerator
{
    public List<string> _prompts = [];
    public List<int> _usedPromptIndexes = [];

    public string GetRandomPrompt()
    {
        _usedPromptIndexes.Reverse();

        List<string> prompts = _prompts;

        foreach (int index in _usedPromptIndexes)
        {
            prompts.RemoveAt(index);
        }

        string prompt = "";

        if (prompts.Count > 0)
        {
            Random rnd = new();
            int promptIndex = rnd.Next(_prompts.Count);
            _usedPromptIndexes.Add(promptIndex);
            prompt = prompts[promptIndex];
        }
        else
        {
            prompt = "No prompts..."; 
        }
        
        return prompt;
    }
}