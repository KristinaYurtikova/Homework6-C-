// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите к1: ");
double k1 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите к2: ");
double k2 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите b1: ");
double b1 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите b2: ");
double b2 = Double.Parse(Console.ReadLine()!);

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Ваши прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Ваши прямые параллельные");
}
else 
{
    double x =(b2-b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение в точке: ({Math.Round (x,3)};{Math.Round (y, 3)})");
}