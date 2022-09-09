// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int number1 = number % 100;
    int number2 = number1 / 10;
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Нужно ввести трехзначное число");
}