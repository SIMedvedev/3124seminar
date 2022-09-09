// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру.
// 78 -> 8
// 12 -> 2

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 10;
// Console.WriteLIne(digit1);
// Console.WriteLIne(digit2);
 
if (digit1 > digit2)
{
    Console.WriteLine($"Цифра {digit1} больше цифры {digit2}");
}
else if (digit1 < digit2)
{
    Console.WriteLine($"Цифра {digit2} больше цифры {digit1}");
}
else 
{
    Console.WriteLine("Цифры равны");
}
