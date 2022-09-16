// Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// напишем метод, который будет возвращать целое число
// Console.WriteLine("Введите число1:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write(number1);
// Console.WriteLine("Введите число2:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write(number2);

int ReadNumber(string message) // напишем метод, который будет возвращать целое число
{   
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNymbersFrom1ToA(int a) //метод для нахождения суммы чисел от 1 до А
{
    if (a >= 1)  
    {   
        int sum = 0;
        for (int i = 1; i <=a; i++)
        {
            sum = sum + i; // sum +=i;
        }
        return sum; //вернем накопившуюся сумму
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1");
        return -1; //неправильная сумма(код ошибки) попадет в переменную summa
    }
}
int number = ReadNumber("Введите число A:");
int summa = SumNymbersFrom1ToA(number);
Console.Write($"Сумма элементов от 1 до А = {summa}");







