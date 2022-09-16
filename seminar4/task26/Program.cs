// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int readNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numberOfDigits(int n)
{                                     // int i = o; число цифр(количество итераций цикла)
    int i = 0;                        // if (n == 0) i = 1;
    for (i = 0; n > 0; i++)           // while (n != 0)
    {                                 // {n = n / 10;         
        n = n / 10;                   // i++;}
    }                                 // return i;                         
    return i;
}
int number = readNumber ("Введите число");
int digits = numberOfDigits(number);
Console.WriteLine($"Количетсво цифр = {digits}");
