// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное чсисло: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >9999 && number < 100000)
// {
//     int n1 = number / 10000;
//     int n5 = number % 10;
//     int n2 = number / 1000 % 10;
//     int n4 = number / 10 %10;
//     if (n1 == n5 && n2 == n4)
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }
// else
// {
//   Console.WriteLine("Введите  положительное пятизначное число");  
// }


// более правильное решение
Console.WriteLine("Введите пятизначное число:");
string userNumber = Console.ReadLine();
int number = Convert.ToInt32(userNumber);

if (Math.Abs(number) <= 99999 && Math.Abs(number) > 9999)
{
    if (userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
    {
        Console.WriteLine("Да. Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Нет. Число не палиндром");
    }
}
else
{
    Console.WriteLine("Число введено некорректно!");
}


// разворот числа

// int number = 12345;  - исходное число
// int tempNumber = number;  - число, которое будем делить на 10
// int reversedNumber = 0;  - развернутое число
// while (tempNumber > 0)
// {
//     int digit = tempNumber % 10;
//     reversedNumber = reversedNumber * 10 + digit;
//     tempNumber = tempNumber / 10;
// }
// Console.WriteLine($"развернутое число = {reversedNumber}");

