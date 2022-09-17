//  Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
//  и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] arr = {1, 2, 3, 4, 5, 6, 7};
int[] arr2 = new int [(arr.Length + 1) / 2];
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = arr[i] * arr[arr.Length - i - 1]; 
}
if (arr.Length % 2 != 0)
{
    arr2[arr2.Length - 1] = arr[arr.Length / 2];
}
Console.Write(string.Join(",",arr2));
