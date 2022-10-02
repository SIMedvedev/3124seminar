// Фибоначчи

decimal fRec =0;
decimal fIte =0;
//рекурсивный подход
decimal FibonacciRecursion(int n)
{
    fRec++;
    return n==0 || n ==1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}

// метод подсчета иттераций
decimal FibonacciIteracion(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1= 2;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        fIte++;
    }
   return result;
}


for (int n = 1; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteracion({n}) = {FibonacciIteracion(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine();

for (int n = 1; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fIte = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
