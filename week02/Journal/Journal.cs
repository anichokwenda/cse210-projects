
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using Microsoft.VisualBasic;

public class JournalEntry
{
    public string Date { get; set; }
    public string InterestingPerson { get; set; }
    public string BestPartOfDay { get; set; }
    public string LordsHand { get; set; }
    public string StrongestEmotion { get; set; }
    public string RedoToday { get; set; }
    public string WeatherToday { get; set; }
    public string ManageTime { get; set; }
}
public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    public void AddEntry()
    {
        Console.Write("Who was the most interesting person I interacted with?  ");
        var interestingPerson = Console.ReadLine();

        Console.Write("What was the best part of my day?  ");
        var bestPartOfDay = Console.ReadLine();

        Console.Write("How did I see the hand of the Lord in my life today?  ");
        var lordsHand = Console.ReadLine();

        Console.Write("What was the strongest emotion I felt today?  ");
        var strongestEmotion = Console.ReadLine();

        Console.Write("If I had one thing I could do over today, what would it be?  ");
        var redoToday = Console.ReadLine();

        Console.Write("How was the weather today?  ");
        var weatherToday = Console.ReadLine();

        Console.Write("How did you manage your time today?  ");
        var manageTime = Console.ReadLine();

        var entry = new JournalEntry
        {
            Date = DateTime.Now.ToString(),
            InterestingPerson = interestingPerson,
            BestPartOfDay = bestPartOfDay,
            LordsHand = lordsHand,
            StrongestEmotion = strongestEmotion,
            RedoToday = redoToday,
            WeatherToday = weatherToday,
            ManageTime = manageTime,

        };
        entries.Add(entry);
    }

    public void SaveToJson(string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(entries, options);
        File.WriteAllText(filePath, json);
    }
    public void LoadFromJson(string filePath)
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            entries = JsonSerializer.Deserialize<List<JournalEntry>>(json);
        }
    }
    public void SaveToCsv(String filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Date, Content");
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}, {entry.InterestingPerson.Replace(",", ";").Replace("\"", "'")}, {entry.BestPartOfDay.Replace(",", ";").Replace("\"", "'")}, {entry.LordsHand.Replace(",", ";").Replace("\"", "'")}, {entry.StrongestEmotion.Replace(",", ";").Replace("\"", "'")}, {entry.RedoToday.Replace(",", ";").Replace("\"", "'")}, {entry.WeatherToday.Replace(",", ";").Replace("\"", "'")}, {entry.ManageTime.Replace(",", ";").Replace("\"", "'")}");
            }
        }
    }

    public void LoadFromCsv(string filePath)
    {
        if (File.Exists(filePath))
        {
            entries.Clear();
            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length == 8)
                {
                    var entry = new JournalEntry
                    {
                        Date = parts[0],
                        InterestingPerson = parts[1],
                        BestPartOfDay = parts[2],
                        LordsHand = parts[3],
                        StrongestEmotion = parts[4],
                        RedoToday = parts[5],
                        WeatherToday = parts[6],
                        ManageTime = parts[7]
                    };
                    entries.Add(entry);
                }
            }
        }
    }


    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Most Interesting Person:: {entry.InterestingPerson}");
            Console.WriteLine($"Best Part of Day: {entry.BestPartOfDay}");
            Console.WriteLine($"Lord's Hand: {entry.LordsHand}");
            Console.WriteLine($"Strongest Emotion: {entry.StrongestEmotion}");
            Console.WriteLine($"Redo Today: {entry.RedoToday}");
            Console.WriteLine($"Weather Today: {entry.WeatherToday}");
            Console.WriteLine($"Manage Time: {entry.ManageTime}");
            Console.WriteLine();

        }
    }
}