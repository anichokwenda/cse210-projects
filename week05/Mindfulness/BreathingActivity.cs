
using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Please can you clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        Start();
        int timeElapsed = 0;
        while (timeElapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            timeElapsed += 4;
            if (timeElapsed >= _duration) break;
            Console.WriteLine("Breathe out...");
            Countdown(4);
            timeElapsed += 4;
        }
        Finish();
    }
}

