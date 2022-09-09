// Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// первое число кратно второму. Если число 1 не кратно чсислу 2, то программа выводит 
// остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число 1: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N2 !=0)
{
    int mod = N1 % N2;
    if (mod ==0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine($"не кратно, остаток {mod}");
    }
}
else
{
    Console.WriteLine("нельзя делить на ноль");
}

// if (N1 % N2 == 0)
// {
//     Console.WriteLine("кратно");
// }
// else 
// {
//     Console.WriteLine($"не кратно, остаток {N1 % N2}");
// }
