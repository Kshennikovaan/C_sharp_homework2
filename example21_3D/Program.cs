// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними в 3D пространстве.

double lengthBetween(int x1, int y1, int z1, int x2, int y2, int z2)
{
double xres = Math.Pow(x2 - x1, 2);
double yres = Math.Pow(y2 - y1, 2);
double zres = Math.Pow(z2 - z1, 2);
double res = Math.Sqrt(xres + yres + zres);
return res;
}

Console.Write("Введите координату x первой точки ");
int x1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату y первой точки ");
int y1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату z первой точки ");
int z1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату x второй точки ");
int x2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату y второй точки ");
int y2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату z второй точки ");
int z2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($"Расстояние между точками равно {lengthBetween( x1, y1, z1, x2, y2, z2)}");
