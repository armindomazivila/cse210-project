public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetDisplayText()
    {
        if (_hidden)
        {
            string underline = "";

            foreach (char letter in _text)
            {
                if (char.IsLetter(letter))
                {
                    underline += "_";
                }
                else
                {
                    underline += letter;
                }
            }

            return underline;
        }

        return _text;
    }
}