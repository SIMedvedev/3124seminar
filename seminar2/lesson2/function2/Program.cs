// Найти максимум из 9 чисел
// Введем функцию(метод)

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 151;
int b1 = 21;
int c1 = 34;
int a2 = 90;
int b2 = 1237;
int c2 = 47;
int a3 = 81;
int b3 = 8;
int c3 = 11;

// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max(max1, max2, max3);
// или можно записать так:

int max = Max(
    Max (a1, b1, c1),
    Max (a2, b2, c2),
    Max (a3, b3, c3));


Console.WriteLine(max);