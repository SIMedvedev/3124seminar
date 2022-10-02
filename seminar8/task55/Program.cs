// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// решим задачу созданием новой матрицы

int ReadNumber(string message) // Ввод числа из консоли.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10) // Наполнение массива случайными числами.
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в терминал.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GetTMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

int m = ReadNumber("Введите количество строк матрицы: ");
int n = ReadNumber("Введите количество столбцов матрицы: ");

int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
int[,] result = GetTMatrix(matr);
Console.WriteLine("\n");


PrintMatrix(result);