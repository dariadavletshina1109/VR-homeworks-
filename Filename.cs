/*
Выведите на экран имя файла
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "scene_01.unity";

        // Find dot position
        int dotIndex = fileName.IndexOf('.');

        string name = fileName.Substring(0, dotIndex);

        Console.WriteLine(name);
    }
}
