// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 
Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
// int i = 1;
// while (i <= num)
// {
//     int cube = i * i * i; 
//     Console.Write($"{num} -> {cube} ");
//     i++;
//}   
void PrintCube(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine($"{i} -> {i*i*i} ");
    }
}
PrintCube(num);
