
using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by asking you to list as many things as you can in a certain area.") { }

    public override void Run()
    {
        Start();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Get ready to list as many items as you can...");
        Countdown(5);
        int count = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
        Finish();
    }
}