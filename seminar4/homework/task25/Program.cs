//  Напишите цикл, который принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B > 0)
{   
    int count = 1;
    int result = A;
    while (count < B)
    {
       result = result * A;
       count++;
    }
Console.Write($"Число {A} в степени {B} равно: ");
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Степень должна быть натуральным числом");
}


// int ReadNumber(string message) 
// {
//   Console.WriteLine(message);
//   return Convert.ToInt32(Console.ReadLine());
// }

// int ExpNumbers(int a, int b) 
// {
//   if (b > 0)
//   {
//     int result = a;
//     for (int i = 1; i < b; i++)
//     {
//       result = result * a;
//     }
//     return result;
//   }
//   else
//   {
//     return -1;
//   }
// }

// int numberA = ReadNumber("Введите число (А): ");
// int numberB = ReadNumber("Введите степень (В): ");
// int result = ExpNumbers(numberA, numberB);

// if (result == -1)
// {
//   Console.WriteLine("Степень должна быть натуральным числом!");
// }
// else
// {
//    Console.WriteLine($"Число {numberA} в степени {numberB} равно: ");
//    Console.WriteLine(result);
// }