public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;
        List<int> availableIndices = new List<int>();

        foreach (var word in _words)
        {
            if (word.IsHidden())
            {
                availableIndices.Add(_words.IndexOf(word));
            }
        }

        while (hiddenCount < numberToHide)
        {
            if (availableIndices.Count < _words.Count)
            {
                int index = rand.Next(0, _words.Count);
                if (!availableIndices.Contains(index))
                {
                    if (!_words[index].IsHidden())
                    {
                        _words[index].Hide();
                        availableIndices.Add(index);
                        hiddenCount++;
                    }
                }   
            }
            else
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        Console.WriteLine(_reference.GetDisplayText());
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.DisplayText() + " ";
        }
        return displayText;
    }

    public bool isCompletelyHidden()
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