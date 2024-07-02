public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        var number = 0;

        foreach(string word in words)
        {
            number++;
            _words.Add(new Word(number, word));
        }
    }

    public void HideRandomWords(int count)
    {
        if (count > 0)
        {
            List<int> visibleWordNumbers = [];
            Word[] visibleWords = _words.Where(w => !w.IsHidden()).ToArray();

            foreach (Word word in visibleWords)
            {
                visibleWordNumbers.Add(word.GetNumber());
            }

            var rnd = new Random();
            var randomWordNumbers = visibleWordNumbers.OrderBy(x => rnd.Next()).Take(count).ToList();

            foreach(Word word in _words)
            {
                if (randomWordNumbers.Contains(word.GetNumber()))
                {
                    word.Hide();
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach(Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}