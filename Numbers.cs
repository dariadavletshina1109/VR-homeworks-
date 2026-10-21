/*
Вывести построчно 
10
20
30
Подсказка: используйте split
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string coords = "x=10;y=20;z=30";

        // Divide the string and output each part
        string[] parts = coords.Split(';');

        foreach (string part in parts)
        {
            string value = part.Split('=')[1];
            Console.WriteLine(value);
        }
    }
}