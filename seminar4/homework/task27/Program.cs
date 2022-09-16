//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumDigit = 0;
while (number != 0)
{
    SumDigit = SumDigit + number % 10;
        number = number / 10;
}
Console.WriteLine(Math.Abs(SumDigit));

int ReadNumber(string message) //Метод для ввода числа из консоли
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


// int SumDigits(int number) //Метод для подсчета суммы цифр в числе
// {
//     int sum = 0;
//     while (number != 0)
//         {
//           sum = sum + number % 10;
//           number = number / 10;
//         }
//     return sum;
// }

// int number = ReadNumber("Введите число: ");
// int summa = SumDigits(number);
// Console.WriteLine($"Сумма цифр в числе {number}: {Math.Abs(summa)}");