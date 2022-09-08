// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int nB = Convert.ToInt32(Console.ReadLine());
if(nA > nB)
{
    Console.WriteLine("max = " + nA);
    Console.WriteLine("min = " + nB);
}
else
{
    Console.WriteLine("max = " + nB);
    Console.WriteLine("min = " + nA);
}
if(nA == nB)
{
    Console.WriteLine("Вы ввели одинаковые числа");
}