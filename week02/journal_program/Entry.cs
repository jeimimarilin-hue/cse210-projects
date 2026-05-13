using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = text;
    }

    public void Display()
    {
        // word count as creativity
        int wordCount = string.IsNullOrWhiteSpace(_entryText) ? 0 : _entryText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"(Word Count: {wordCount})"); //wordcount function
        Console.WriteLine($"{_entryText}\n");
    }
}