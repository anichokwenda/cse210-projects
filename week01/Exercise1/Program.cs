using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their names
        Console.Write("What is you first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}