// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2

Console.Write("Введите трехзначное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 909)
{
    int N = number % 10;
    Console.WriteLine(N);
}            
 else
 {
       Console.WriteLine("подумай еще");
}   


    