using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.\n");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}~~{entry._mood}");
            }
        }
        Console.WriteLine("Journal successfully saved!\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File not found.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            if (parts.Length == 4)
            {
                Entry loadedEntry = new Entry(parts[1], parts[2], parts[3]);
                loadedEntry._date = parts[0];
                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal successfully loaded!\n");
    }
}
