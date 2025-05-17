using System;
using System.Collections.Generic;

namespace JournalProgram
{
    class Program
    {
        //I added 2 questions and the information is saved in the journal entry. I saved and loaded as a .csv file. I also saved and loaded my document to a database JSON for storage
        static void Main(string[] args)
        {
            var journal = new Journal();

            while (true)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Save to JSON");
                Console.WriteLine("3. Load from JSON");
                Console.WriteLine("4. Save to CSV");
                Console.WriteLine("5. Load from CSV");
                Console.WriteLine("6. Display Entries");
                Console.WriteLine("7. Exit");

                Console.Write("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.SaveToJson("journal.json");
                        Console.WriteLine("Journal saved to journal.json");
                        break;
                    case "3":
                        journal.LoadFromJson("journal.json");
                        Console.WriteLine("Journal loaded from journal.json");
                        break;
                    case "4":
                        journal.SaveToCsv("journal.csv");
                        Console.WriteLine("Journal saved to journal.csv");
                        break;
                    case "5":
                        journal.LoadFromCsv("journal.csv");
                        Console.WriteLine("Journal loaded from journal.csv");
                        break;
                    case "6":
                        journal.DisplayEntries();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}