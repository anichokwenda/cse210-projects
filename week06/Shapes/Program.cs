using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create shapes
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        Circle circle = new Circle("Green", 2);

        // Test individual shapes
        Console.WriteLine($"Square Color: {square.Color}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle Color: {rectangle.Color}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Color: {circle.Color}, Area: {circle.GetArea()}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle,
            new Square("Yellow", 2),
            new Rectangle("Purple", 4, 6),
            new Circle("Orange", 3)
        };

        // Iterate through the list and display areas
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}


