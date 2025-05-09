using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = 6;

        int guess = -1;
        do
        {
            Console.Write("What is the magic number? ");
            while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 100)
            {
                Console.Write("Invalid input. Please enter anumber between 1 and 100: ");
            }
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);
    }
}