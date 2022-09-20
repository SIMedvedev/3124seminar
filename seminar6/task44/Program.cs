//  Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два 
// числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int Fibonacci

//n = int(input())
n1 = 0
n2 = 1 
k = 0
print (n1, n2, end = ' ')
for i in range(n):
    k = n1 +n2
    n1 = n2
    n2 = k
    print (k, end =' ')
