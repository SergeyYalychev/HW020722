﻿// задача 21
Console.WriteLine("Введите координаты первой точки:");
// int x1, y1 = Convert.ToInt32(Console.ReadLine());
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double newPoint()
{
double newPoint = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));
return newPoint;
}

Console.WriteLine(newPoint());

