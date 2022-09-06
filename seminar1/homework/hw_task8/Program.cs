// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 2;
while (count <= N)
{
    Console.Write(count + " " );
    count += 2;
}
 if (N <=0)
 {
    Console.WriteLine("Введите целое положительное число");
 }