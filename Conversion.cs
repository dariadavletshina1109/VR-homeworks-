/*
Задание 3: преобразование типов

Дана переменная:

double value = 3.99;

Нужно:
1. Преобразовать `value` в `int` и вывести результат
2. Преобразовать `int` обратно в `double` и вывести результат
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 3.99;

        int intValue = (int)value;
        Console.WriteLine($"double -> int: {intValue}");

        double backToDouble = intValue;
        Console.WriteLine($"int -> double: {backToDouble}");
    }
}
