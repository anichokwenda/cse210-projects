public class Word
{
    private string _originalText;
    private bool _isHidden;

    public Word(string text)
    {
        _originalText = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetText()
    {
        if (_isHidden)
        {
            return new string('_', _originalText.Length);
        }

        else
        {
            return _originalText;
        }
    }
}
