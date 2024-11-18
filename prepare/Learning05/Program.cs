using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(">>>>>>>>>>>>>>>>");
        Console.WriteLine("----Shapes in a List----\n<<<<<<<<<<<<<<<<\n");
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();
        // Add different shapes to the list

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iterate over the list and display the color and area of each shape
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            string shapeType = s.GetType().Name;  // Get the name in the class
            Console.WriteLine($"The shape is a {shapeType.ToLower()} and is {color} and it has an area of {area:F0}.\n");
        }

    }
}