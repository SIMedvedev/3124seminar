// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number %2;
if (count == 0)
{
    Console.WriteLine("да");
} 
else
{
    Console.WriteLine("нет");
}
