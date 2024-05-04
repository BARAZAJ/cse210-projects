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
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{QuoteField(entry.Prompt)}, {QuoteField(entry.Response)}, {entry.Date:yyyy-MM-dd HH:mm:ss}");
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

            using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = SplitCsvLine(line);
                    if (parts.Length >= 3)
                    {
                        string prompt = UnquoteField(parts[0].Trim());
                        string response = UnquoteField(parts[1].Trim());
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

    private string QuoteField(string value)
    {
        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }

    private string UnquoteField(string value)
    {
        if (value.StartsWith("\"") && value.EndsWith("\""))
        {
           
            return value.Substring(1, value.Length - 2).Replace("\"\"", "\"");
        }
        return value;
    }

    private string[] SplitCsvLine(string line)
    {
        List<string> fields = new List<string>();
        StringBuilder currentField = new StringBuilder();
        bool inQuotes = false;

        foreach (char c in line)
        {
            if (c == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                fields.Add(currentField.ToString());
                currentField.Clear();
            }
            else
            {
                currentField.Append(c);
            }
        }

        fields.Add(currentField.ToString()); 
        return fields.ToArray();
    }
}
