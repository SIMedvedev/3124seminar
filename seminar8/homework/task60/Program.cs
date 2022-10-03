﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// генерируем случайные неповторяющиеся числа через одномерный массив
int[,,] arr = new int[2, 2, 2];
Random rand = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    int number = rand.Next(10, 100);
    if (array.Contains(number)) i--; //проверка на повторение числа
    else array[i] = number;
}
int count = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            arr[i, j, k] = array[count];
            count++;
            Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})\t");
        }
        Console.WriteLine();
    }
}

// int[] NewRandom(int[] randNew)
// {
//   int n = 0;
//   Random rand = new Random();
//   for (int d = 0; d < randNew.Length; d++)
//   {
//     n = rand.Next(10, 100);
//     if (!randNew.Contains<int>(n))
//     {
//       randNew[d] = n;
//     }
//     else d--;
//   }
//   return randNew;
// }
// void GetCubeMatrix(int[] array, int[,,] cubeMatrix)
// {
//   int count = 0;
//   for (int i = 0; i < cubeMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < cubeMatrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < cubeMatrix.GetLength(2); k++)
//       {
//         cubeMatrix[i, j, k] = array[count++];
//         Console.Write($"{cubeMatrix[i, j, k]}({i},{j},{k})\t");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }
// Console.Write("Введите кол-во строк: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во строк: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int size = i * j * k;
// int[] randNew = new int[size];
// int[,,] cubeMatrix = new int[i, j, k];
// Console.WriteLine("Cлучайный трехмерный массив:");
// GetCubeMatrix(NewRandom(randNew), cubeMatrix);