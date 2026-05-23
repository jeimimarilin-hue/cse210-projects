using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        // Creatitity 2) Filter logic to only select from words that are NOT hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Creativity: 1) Method implemented to find hidden words and reveal one randomly
    public void RevealRandomWord()
    {
        Random random = new Random();
        List<Word> hiddenWords = _words.Where(w => w.IsHidden()).ToList();

        if (hiddenWords.Count > 0)
        {
            int index = random.Next(hiddenWords.Count);
            hiddenWords[index].Show();
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = _words.Select(w => w.GetDisplayText()).ToList();
        string scriptureText = string.Join(" ", displayedWords);

        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}