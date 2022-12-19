// напишите программу,
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве

// А (3,6,8); В(2,1,-7)->15,84
// А (7,-5,0); В(1,-1,9)->11,53
// А (х, у) В (х1, у1)
//S= корень: (х-х1)"2"+(у-у1)"2"+(z-z1)"2"

Console.Write("введите данные точки Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Z: ");
int z = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("введите данные точки Z1: ");
int z1 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x-x1,2)+Math.Pow(y-y1,2)+Math.Pow(z-z1,2));

Console.WriteLine($"d = {d:f3}");
