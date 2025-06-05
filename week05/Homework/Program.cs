using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the Assignment class
        Assignment assignment = new Assignment("Henry Peters", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Angel Miles", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Andrew Jones", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}

