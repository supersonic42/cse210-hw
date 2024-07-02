public class Word(int number, string text)
{
    private int _number = number;
    private string _text = text;
    private bool _isHidden = false;

    public int GetNumber()
    {
        return _number;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (this.IsHidden())
        {
            return new string('_', _text.Length);
        }

        return _text;
    }
}