/*
Пользователь вводит своё имя и год рождения.
Программа:
1. принимает имя через Console.ReadLine()
2. вычисляет текущий возраст (текущий год - 2026)
3. выводит приветствие и возраст
4. выводит имя в верхнем регистре и его длину в символах
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter your birth year: ");
    int birthYear = int.Parse(Console.ReadLine());
    // ваш код здесь

    int currentYear = 2026;
    int age = currentYear - birthYear;

    Console.WriteLine($"Hello, {name}! You are {age} years old.");
    Console.WriteLine($"Your name in upper case: {name.ToUpper()}");
    Console.WriteLine($"Name length: {name.Length}");
  }
}
