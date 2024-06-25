public class Journal
{
    public Dictionary<string, Entry> _entries = [];

    public void AddEntry(Entry entry)
    {
        string key = entry._date.ToString("yyyy-MM-dd") + '-' + entry._promptId;
        
        if (_entries.ContainsKey(key))
        {
            _entries[key] = entry;
        }
        else
        {
            _entries.Add(key, entry);
        }
    }

    public void DisplayAll(Dictionary<int, string> prompts)
    {
        foreach(KeyValuePair<string, Entry> entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry.Value._date.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Prompt: {prompts[entry.Value._promptId]}");
            Console.WriteLine($"Answer: {entry.Value._entryText}");
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (KeyValuePair<string, Entry> entry in _entries)
        {
            writer.WriteLine("{0};{1};", entry.Key, entry.Value);
        }
    }

    public void LoadFromFile(string file)
    {
        
    }
}