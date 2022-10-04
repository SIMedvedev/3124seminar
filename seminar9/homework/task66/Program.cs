// Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadNumber(string message) // Ввод числа из консоли.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumMToN(int m, int n)
{
    int sum2 = 0;
    int sum = 0;
    if (n == m)
    {
        return m;
    }
    else if (m < n)
    {
        sum = n + SumMToN(m, n - 1);
        return sum;
    }
    else if (m > n)
    {
        sum2 = m + SumMToN(m - 1, n);
        return sum2;
    }
    else return -1;
}
int m = ReadNumber("Введите M: ");
int n = ReadNumber("Введите N: ");
Console.Write(SumMToN(m, n));
