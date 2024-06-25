public class PromptGenerator
{
    public Dictionary<int, string> _prompts = [];
    public List<int> _usedPromptIds = [];

    public KeyValuePair<int, string> GetRandomPrompt()
    {
        _usedPromptIds.Reverse();

        foreach (int index in _usedPromptIds)
        {
            _prompts.Remove(index);
        }

        KeyValuePair<int, string> prompt = new();

        if (_prompts.Count > 0)
        {
            Random rnd = new();
            var randomPrompt = _prompts.ElementAt(rnd.Next(0, _prompts.Count));
            _usedPromptIds.Add(randomPrompt.Key);
            prompt = randomPrompt;
        }
        
        return prompt;
    }
}