// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number > 0)
{
    while (i <= number)                 // for (int i = 0; i <= number; i++)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
}
else 
{
    Console.Write("N должно быть больше 0");
}