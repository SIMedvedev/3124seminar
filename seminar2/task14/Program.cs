// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());


    int mod = N % 7;
    int mod2 = N % 23;
        if (mod ==0 && mod2 ==0)       // (N % 7 == 0 && N % 23 == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine($"не кратно");
    }
