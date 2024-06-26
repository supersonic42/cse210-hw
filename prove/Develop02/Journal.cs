using System.Text.Json;

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
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the journal.");
        }
        else
        {
            foreach(KeyValuePair<string, Entry> entry in _entries)
            {
                entry.Value.Display(prompts);
            }
        } 
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new(filename);
        foreach (KeyValuePair<string, Entry> entry in _entries)
        {
            writer.WriteLine(
                "{0};{1};{2};{3};",
                entry.Key, entry.Value._date, entry.Value._promptId, entry.Value._entryText
            );
        }
    }

    public void LoadFromFile(string filename, ref PromptGenerator promptGenerator, bool emptyEntries = true)
    {
        if (emptyEntries)
        {
            _entries = [];
        }

        List<int> usedPromptIds = [];

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            int promptId = int.Parse(parts[2]);
            DateTime date = DateTime.Parse(parts[1]);

            if (!_entries.ContainsKey(parts[0]))
            {
                Entry entry = new()
                {
                    _date = date,
                    _promptId = promptId,
                    _entryText = parts[3],
                };

                _entries.Add(parts[0], entry);
            }

            if (date.Date == DateTime.Today)
            {
                usedPromptIds.Add(promptId);
            }
        }

        promptGenerator.FillUsedPromptIds(usedPromptIds);
    }
}