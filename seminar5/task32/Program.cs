// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size, int leftRange, int rightRange) //границы случайного диапазона left right
{
     int[] arr = new int[size];
     Random rand = new Random(); // создаем переменную рандома
     for (int i = 0; i < size; i++)
     {
         arr[i] = rand.Next(leftRange, rightRange + 1);
     }
     return arr;
 }
 int[] newArr(int[] arr)  // возвращаем массив  // *можно вместо возвращаемого элемента int[] поставить void
 {
     
     for (int i = 0; i < arr.Length; i++)
             { 
                arr[i] = arr[i] * -1; // можно написать arr[i] = - arr[i];
            }
             return arr;                        // *тогда return будет не нужен
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(",", array));
int[] newarr = newArr(array);                   // * вызов массива будет просто newArr(array);
Console.WriteLine(string.Join(",", newarr));