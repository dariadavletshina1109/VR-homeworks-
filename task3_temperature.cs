using System;

class Program
{
    static void Main(string[] args)
    {
        // Temperature in Celsius
        double celsius = 25;

        // Convert Celsius to Fahrenheit
        double fahrenheit = celsius * 9.0 / 5 + 32;

        Console.WriteLine($"{celsius} C = {fahrenheit} F");
    }
}
