using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);


        if (percentage >= 90)
        {
            Console.WriteLine("A");

        }
        else if (percentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("You passed");
        }

    }
}