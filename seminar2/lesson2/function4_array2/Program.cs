// запишем код с использованием генетарора псевдослучайных чисел и методов

void FillArray(int[] collection) // метод заполнения массива числами. void - не возвращает никаких значений
{
    int lenght = collection.Length;
    int index =0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10); // создаем массив из 10 элементов
        index++;
    }

}

void PrintArray(int[] col)  //  метод , который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)   // метод для нахождения нужного элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если искать не существующий элемент, то выдаст -1, т.е. элемент не найден
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //чтобы выводил первый искомый элемент массива, если есть одинаковые
        }    
        index++;
    }
    return position;
}

int[] array = new int[10]; // создвем массив из 10 элементов

FillArray(array);
array[4] = 4; 
array[6] = 6; //принудительно записываем элемент массива
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
        