// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y= k1*x+b1, y= k2*x+b2; значения b1, k1, b2, и k2 задаются пользователем.
Console.Clear();
Console.Write("введите значение b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double a = (-b2 + b1)/(-k1 + k2);
double b = k2 * a + b2;

Console.WriteLine($"Точки пересечения прямых А: {a}, B: {b}");