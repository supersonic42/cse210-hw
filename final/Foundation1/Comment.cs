public class Comment(string authorName, string text)
{
    private string _authorName = authorName;
    private string _text = text;

    public string GetDisplayString()
    {
        return "";
    }

    public string GetAuthorName()
    {
        return _authorName;
    }

    public string GetText()
    {
        return _text;
    }
}