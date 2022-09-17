// : Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int[] array = GetArray(10, 0, 5);
Console.WriteLine(string.Join(",", array));
int count = 0;
for (int i = 1; i < array.Length; i +=2)
{
    count = count + array[i]; 
}
Console.WriteLine("Сумма элементов чисел равна " + count);