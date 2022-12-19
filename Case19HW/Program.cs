// Написать программу которая проверяет является ли пятизначное число палиндромом

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if(num >= 10000)
{
    int division1 = num / 10000;
    int remainder1 = num % 10;
 
        if(division1 == remainder1)
            {
                num = num / 10;
                int division2 = (num / 100)%10;
                int remainder2 = num % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Да");
            }
            else 
                Console.WriteLine("Нет");
            
}
    else
        Console.WriteLine("Некорректное число!"); 
