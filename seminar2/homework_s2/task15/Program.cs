//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
//  проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 1 && N <= 5)
{
   Console.WriteLine("нет");
}

else if (N == 6 || N ==7) 
{
    Console.WriteLine("да");
}  

else
{
    Console.WriteLine("в неделе всего семь дней");
}



