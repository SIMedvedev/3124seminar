// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    int Number = number;
    while (Number > 999)
    {
        Number = Number / 10;
    }
    int N = Number % 10; 
    Console.WriteLine(N);
}
else
{
    Console.WriteLine("третьей цифры нет");
}