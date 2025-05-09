using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please  enter a valid number.");
            }
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }
        double sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        double max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        double smallestPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is:{smallestPositive}");

        // stretch challenge: Sort the numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is : ");
        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}