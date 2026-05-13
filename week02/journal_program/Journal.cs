using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("-----------------------");
    }

    public void SaveToFile(string file)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(file, jsonString);
        Console.WriteLine($"Journal saved to {file}.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string jsonString = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine($"Journal loaded from {file}.");
        }
        else
        {
            Console.WriteLine($"Error: File {file} not found.");
        }
    }
}