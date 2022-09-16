// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int[8]; // создали массив на 8 элементов
Random rand = new Random();
for (int n = 0; n < array.Length; n++)
    array[n] = rand.Next(0, 2);

Console.WriteLine(string.Join(" ", array)); //выведит все элементы массива через запятую, вместо цикла приведенного ниже   
//foreach (int arr in array)            // for (int n = 0; n < array.Length; n++)
//{                            или      //{
//    Console.Write(arr + " ");         //Console.Write(array[n] + " ");
//}                                     //}
