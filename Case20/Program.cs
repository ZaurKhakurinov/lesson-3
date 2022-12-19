//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
Console.Clear();
Console.WriteLine ("введите число: ");
int x = int.Parse (Console.ReadLine());
for (int i = 1; i <= x; i++)
{
    Console.WriteLine ($"{Math.Pow(i, 2)}");
}

