// напишите программу,
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве

// А (3,6); В(2, 1)->5,09
// А (7,-5); В(1, -1)->7,21
// А (х, у) В (х1, у1)
//S= корень: (х-х1)"2"+(у+у1)"2"

Console.Write("введите данные точки Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Y1: ");
int y1 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x-x1,2)+Math.Pow(y-y1,2));

Console.WriteLine($"d = {d:f3}");