using System;

class Program
{
    static void Main(string[] args)
    {
        // Distance in meters
        double distance = 1500;

        // Time in seconds
        double time = 120;

        // Calculate the average speed
        double speed = distance / time;

        Console.WriteLine($"Average speed: {speed} m/s");
    }
}
