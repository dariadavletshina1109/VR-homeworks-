using System;

class Program
{
    static void Main(string[] args)
    {
        // Initial point coordinates
        double x = 2.5;
        double y = 3.0;

        // Translation vector coordinates
        double dx = 1.5;
        double dy = -2.0;

        // Calculate the new point coordinates
        double newX = x + dx;
        double newY = y + dy;

        Console.WriteLine($"New point: ({newX}, {newY})");
    }
}