public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');

        foreach(string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int count = 0;

        while (count < numberToHide)
        {
            int index = rand.Next(_words.Count);
            Word word = _words[index];

            bool hidden = word.IsHidden();
            if (hidden == false)
            {
                word.Hide();
                count++;
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
        
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach(Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();

    }

    public bool IsCompletelyHidden()
{
    foreach (Word word in _words)
    {
        if (word.IsHidden() == false) 
        {
            return false;
        }
    }
    return true; 
}
}