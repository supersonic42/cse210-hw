public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse =endverse;
    }

    public string GetDisplayText()
    {
        string verses = _startVerse.ToString();

        if (_endVerse != 0)
        {
            verses += $"-{_endVerse}";
        }

        return $"{_book} {_chapter}:{verses}";
    }
}