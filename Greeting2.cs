using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Form the greeting here
        string greeting = "Hello, " + name + "!";
        Console.WriteLine(greeting);
    }
}