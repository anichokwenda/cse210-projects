// Another class of LogActivity.cs has been added which helps in creating activities log and the number of times activities were perfomed.

using System;

class Program
{
    public static void ViewActivityLog()
    {
        ActivityLog log = new ActivityLog();
        log.ViewLog();
        Console.WriteLine("Press any key to return to the menu..");
        Console.ReadKey();
    }

    public static void ViewActivityCounts()
    {
        ActivityLog log = new ActivityLog();
        Dictionary<string, int> activityCounts = log.GetActivityCounts();

        foreach (var activity in activityCounts)
        {
            Console.WriteLine($"{activity.Key} activity performed {activity.Value} times.");
        }

        Console.WriteLine("Press any key to return to the menu..");
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. View Activity Counts");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    ViewActivityLog();
                    break;
                case "5":
                    ViewActivityCounts();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

