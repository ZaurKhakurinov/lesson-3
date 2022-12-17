// Напишите программу, которая принимает на вход координаты точки (X и Y), причем Х и Y не равно 0 и выдает номер четверти плоскости в которой находится эта точка.

Console.Clear();
Console.Write("Введите значение X ");
int x = int.Parse(Console.ReadLine ());
Console.Write("Введите значение Y ");
int y = int.Parse(Console.ReadLine ());

if (x > 0 && y > 0)
{
        Console.WriteLine($"число находится в 1 четверти");
}
if (x < 0&& y > 0);
{
    Console.WriteLine($"число находится в 2 четверти");
}
if (x < 0&&y < 0);
{
    Console.WriteLine($"число находится в 3 четверти");
}
if (x > 0&&y< 0);
{
    Console.WriteLine($"число находится в 4 четверти");
}
if (x==0||y==0)
{
    Console.WriteLine($"в точке 0");
}
