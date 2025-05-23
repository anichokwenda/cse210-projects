public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }


    public int HideRandomWords(int count)
    {
        var random = new Random();
        int wordsHidden = 0;
        for (int i = 0; i < count; i++)
        {
            var index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;

            }

            else
            {
                i--;
            }
        }
        return wordsHidden;

    }
    public bool AreAllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}- {string.Join(" ", _words.Select(w => w.GetText()))}";
    }

    public string GetOriginalText()
    {
        return _text;
    }

}


