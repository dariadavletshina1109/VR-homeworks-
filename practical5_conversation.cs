/*
Задание 5: преобразование типов
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 7.85;

        // Explicit conversion to int
        int intValue = (int)value;
        Console.WriteLine($"Explicit (double -> int): {intValue}");

        // Implicit conversion back to double
        double backToDouble = intValue;
        Console.WriteLine($"Implicit (int -> double): {backToDouble}");

        // Compare values
        bool areEqual = value == backToDouble;
        Console.WriteLine($"Original: {value}, after conversions: {backToDouble}");
        Console.WriteLine($"Equal: {areEqual}");
    }
}
