
using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected ActivityLog _log = new ActivityLog();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long would you like to do this activity? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowAnimation(5);
    }

    public void Finish()
    {
        Console.WriteLine("You have done a good job!");
        ShowAnimation(3);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowAnimation(5);
        _log.LogActivity(_name);
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b \b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void LogActivity()
    {
        ActivityLog log = new ActivityLog();
        log.LogActivity(_name);
    }

    public abstract void Run();
}
