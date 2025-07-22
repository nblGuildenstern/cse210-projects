using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 4);
        Console.WriteLine($"Square: {square.GetColor()}, {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 4, 5);
        Console.WriteLine($"Rectangle: {rectangle.GetColor()}, {rectangle.GetArea()}");

        Circle circle = new Circle("Yellow", 5);
        Console.WriteLine($"Circle: {circle.GetColor()}, {circle.GetArea():0.00}");
    }
}