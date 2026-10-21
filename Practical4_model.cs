/*
Задание 4: информация о 3D-модели
Переменные: имя (`string`), полигоны (`int`), длительность анимации (`float`), видимость (`bool`), угол поворота (`float`).
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create variables here
        string modelName = "Robot";
        int polygons = 12500;
        float animationDuration = 2.5f;
        bool isVisible = true;
        float rotationAngle = 90f;

        Console.WriteLine($"Model: {modelName}");
        Console.WriteLine($"Polygons: {polygons}");
        Console.WriteLine($"Animation duration: {animationDuration} s");
        Console.WriteLine($"Visible: {isVisible}");
        Console.WriteLine($"Rotation angle: {rotationAngle}");
    }
}