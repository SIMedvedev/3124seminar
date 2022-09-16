// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNumber(string message) // напишем метод, который будет возвращать целое число
{   
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNymbersFrom1ToA(int a) //метод для нахождения суммы чисел от 1 до А
{
    if (a >= 1)  
    {   
        int product = 1;
        for (int i = 1; i <=a; i++)
        {
            product = product * i; 
        }
        return product; //вернем накопившуюся сумму
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1");
        return -1; //неправильная сумма(код ошибки) попадет в переменную summa
    }
}
int number = ReadNumber("Введите число A:");
int product1 = SumNymbersFrom1ToA(number);
Console.Write($"Произведение элементов от 1 до А = {product1}");