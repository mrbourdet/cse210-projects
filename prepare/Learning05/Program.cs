using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 3, 3);
        shapes.Add(r1);

        Circle c1 = new Circle("Green", 3);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());
        }
    }
}