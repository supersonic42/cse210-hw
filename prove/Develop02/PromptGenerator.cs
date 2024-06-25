public class PromptGenerator
{
    public Dictionary<int, string> _prompts = [];
    public List<int> _usedPromptIndexes = [];

    public string GetRandomPrompt()
    {
        _usedPromptIndexes.Reverse();

        foreach (int index in _usedPromptIndexes)
        {
            _prompts.Remove(index);
        }

        string prompt = "";

        if (_prompts.Count > 0)
        {
            Random rnd = new();
            var randomPrompt = _prompts.ElementAt(rnd.Next(0, _prompts.Count));
            _usedPromptIndexes.Add(randomPrompt.Key);
            prompt = randomPrompt.Value;
        }
        else
        {
            prompt = null; 
        }
        
        return prompt;
    }
}