// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X для первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X для второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для второй точки: ");
int z2 = int.Parse(Console.ReadLine());
double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"A {x1},{y1},{z1}; B {x2},{y2},{z2} -> {segmentLength}");