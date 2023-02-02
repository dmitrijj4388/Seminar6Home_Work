// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CoordinatesX(double k1,double b1,double k2,double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    return x;
}

double CoordinatesY(double k1,double b1,double x)
{
    double y = k1*x + b1;
    return y;
}


Console.Clear();

Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = CoordinatesX(k1, b1, k2, b2);
double y = CoordinatesY(k1, b1, x);

if (k1 - k2 == 0 & b1 - b2 != 0) Console.WriteLine("Прямые не пересекаються.");
else
{
  if (k1 - k2 == 0 & b1 - b2 == 0 ) Console.WriteLine("Прямые совпадают.");
  else Console.WriteLine($"Прямые пересекаються в точке ({x}, {y})");
}
   










