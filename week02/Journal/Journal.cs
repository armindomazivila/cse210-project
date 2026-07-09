using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()

    {

        Console.WriteLine($"\nTotal Entries: {_entries.Count}\n");

        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)

        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)

    {

        using (StreamWriter output = new StreamWriter(fileName))

        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{Escape(entry.Date)},{Escape(entry.Prompt)},{Escape(entry.Response)}");

            }

        }

    }

    public void LoadFromFile(string fileName)

    {

        _entries.Clear();

        if (!File.Exists(fileName))

        {

            Console.WriteLine("File not found.");

            return;

        }

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)

        {

            string[] parts = ParseCsv(line);

            if (parts.Length >= 3)

            {

                Entry entry = new Entry

                {

                    Date = parts[0],

                    Prompt = parts[1],

                    Response = parts[2]

                };

                _entries.Add(entry);

            }

        }

    }

    private string Escape(string text)

    {

        if (text.Contains("\""))

            text = text.Replace("\"", "\"\"");

        return $"\"{text}\"";

    }

    private string[] ParseCsv(string line)

    {

        List<string> values = new List<string>();

        bool insideQuotes = false;

        string current = "";

        foreach (char c in line)

        {

            if (c == '"')

            {

                insideQuotes = !insideQuotes;

            }

            else if (c == ',' && !insideQuotes)

            {

                values.Add(current);

                current = "";

            }

            else

            {

                current += c;

            }

        }

        values.Add(current);

        return values.ToArray();

    }

}