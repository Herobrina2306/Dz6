//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Введите четыре координаты через энтер:");

double a1 = double.Parse(Console.ReadLine());
double c1 = double.Parse(Console.ReadLine());
double a2 = double.Parse(Console.ReadLine());
double c2 = double.Parse(Console.ReadLine());

Console.Write($"b1 = {a1}, k1 = {c1}, b2 = {a2}, k2 = {c2} ");

void Intersection(double b1, double k1, double b2, double k2)
{
    double y;
    double x;
    x = (b2 - b1)/(k1 -k2);
    y = k1 * x + b1;
    Console.Write($" -> ({x}; {y})");
}
Intersection(a1, c1, a2, c2);