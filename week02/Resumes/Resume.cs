using System.Collections.Generic;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    //Constructor
    public Resume(string name)
    {
        Name = name;
    }

    //Display method
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (var job in Jobs)
        {
            job.Display();
        }
    }
}