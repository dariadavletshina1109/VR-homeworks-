/*
Задание 2: средняя скорость и время
Формула: `v = s / t`
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int distance = 1500;
        int time = 120;

        // Calculate speed (use double)
        double speed = (double)distance / time;
        Console.WriteLine($"Average speed: {speed} m/s");

        // Calculate time for 2500 meters
        double newTime = 2500 / speed;
        Console.WriteLine($"Time for 2500 m: {newTime} s");
    }
}
