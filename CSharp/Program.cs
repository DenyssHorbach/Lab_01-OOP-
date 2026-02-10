using System;
using CSharp;

Rectangle test = new Rectangle(5.0, 3.0);
double area = test.Area();
double perimeter = test.Perimeter();

Console.WriteLine($"Length: {test.GetLength()}");
Console.WriteLine($"Width: {test.GetWidth()}");
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine("Vertices:");
foreach (var vertex in test.GetVertices())
{
    Console.WriteLine($"({vertex.Item1}, {vertex.Item2})");
}