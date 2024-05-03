using System;
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 
using System.Text.Json;
using System.Text.Json.Serialization;


public class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string _userFileName;

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n******************** End ********************");
    }

    public void CreateJournalFile()
    {
        Console.Write("What do you want to name your file? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            // Properly closing the StreamWriter with 'using'
            using (StreamWriter sw = File.CreateText(_userFileName))
            {
                // Initialize the file with a blank line to ensure it is created
                sw.WriteLine("");
            }

            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("*** Your journal entry has been saved. ***\n");

            // Now that the file is properly created and closed, it's safe to use
            SaveJournalFile(_userFileName);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exists. ***\n");
            Console.Write("*** Your journal entry has been added. ***\n");

            AppendJournalFile(_userFileName);
        }
    }

    public void SaveJournalFile(string userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(userFileName, false))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(userFileName, true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadJournalFile()
    {
        Console.Write("What's the name of your file? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            using (StreamReader reader = new StreamReader(_userFileName))
            {
                List<string> readText = new List<string>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        readText.Add(line);
                    }
                }

                foreach (string entryLine in readText)
                {
                    string[] entries = entryLine.Split("; ");

                    JournalEntry entry = new JournalEntry
                    {
                        _entryNumber = entries[0],
                        _dateTime = entries[1],
                        _journalPrompt = entries[2],
                        _journalEntry = entries[3]
                    };

                    _journal.Add(entry);
                }
            }
        }
    }

    public void CreateJSON(string userInput)
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (JournalEntry journalEntry in _journal)
        {
            _data.Add(new JsonItem()
            {
                ID = journalEntry._entryNumber,
                Date = journalEntry._dateTime,
                Prompt = journalEntry._journalPrompt,
                Entry = journalEntry._journalEntry
            });
        }

        string json = JsonSerializer.Serialize(_data);

        // Properly using StreamWriter to write JSON data
        using (StreamWriter jsonWriter = new StreamWriter(fileName, false))
        {
            jsonWriter.Write(json);
        }
    }
}
