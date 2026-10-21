/*
Задание 2: переменные для 3D-объекта

Нужно создать переменные: имя, координаты, масштаб, вращение, видимость. Присвоить значения и вывести в консоль.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create variables here
        string objectName = "Cube";
        float posX = 0f, posY = 1.5f, posZ = -3f;
        float scale = 2f;
        float rotationY = 45f;
        bool isVisible = true;

        Console.WriteLine($"Name: {objectName}");
        Console.WriteLine($"Position: ({posX}, {posY}, {posZ})");
        Console.WriteLine($"Scale: {scale}");
        Console.WriteLine($"Rotation Y: {rotationY}");
        Console.WriteLine($"Visible: {isVisible}");
    }
}
