﻿// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное чсисло: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >9999 && number < 100000)
{
    int n1 = number / 10000;
    int n5 = number % 10;
    int n2 = number / 1000 % 10;
    int n4 = number / 10 %10;
    if (n1 == n5 && n2 == n4)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
  Console.WriteLine("Введите  положительное пятизначное число");  
}
