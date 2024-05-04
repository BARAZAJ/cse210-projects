using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        var newEntry = new Entry(prompt, response, DateTime.Now);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveEntriesToCsv(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    string line = $"{QuoteIfNeeded(entry.Prompt)}, {QuoteIfNeeded(entry.Response)}, {entry.Date:yyyy-MM-dd HH:mm:ss}";
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Entries saved to CSV successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving entries to CSV: {ex.Message}");
        }
    }

    public void LoadEntriesFromCsv(string fileName)
    {
        try
        {
            List<Entry> loadedEntries = new List<Entry>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string prompt = UnquoteIfNeeded(parts[0].Trim());
                        string response = UnquoteIfNeeded(parts[1].Trim());
                        DateTime date = DateTime.ParseExact(parts[2].Trim(), "yyyy-MM-dd HH:mm:ss", null);
                        loadedEntries.Add(new Entry(prompt, response, date));
                    }
                }
            }

            entries = loadedEntries;
            Console.WriteLine("Entries loaded from CSV successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading entries from CSV: {ex.Message}");
        }
    }

    private string QuoteIfNeeded(string value)
    {
        if (value.Contains(",") || value.Contains("\""))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }

    private string UnquoteIfNeeded(string value)
    {
        if (value.StartsWith("\"") && value.EndsWith("\""))
        {
            
            return value.Substring(1, value.Length - 2).Replace("\"\"", "\"");
        }
        return value;
    }
}
