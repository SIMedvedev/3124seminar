//  Напишите программу, которая будет принимать на вход 
//  число и возвращать сумму его цифр.
//  453 -> 12
//  45 -> 9
int ReadNumber(string message) //Метод для ввода числа из консоли
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SumDigits(int number) //Метод для подсчета суммы цифр в числе с помощью рекурсии
{
    if (number == 0) return 0;
    else
    {
        return number % 10 + SumDigits(number / 10);
    }
}

Console.WriteLine(SumDigits(ReadNumber("Введите M")));
