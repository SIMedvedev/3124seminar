// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату первой точки по X ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по Y ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по X ");
double xB= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по Y ");
double yB = Convert.ToInt32(Console.ReadLine());
// double x = Math.Pow(xB - xA, 2); // возвести в степень
// double y = Math.Pow(yB - yA , 2);
// double distance = Math.Sqrt(x + y);  // найти квадратный корень
double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
Console.WriteLine($"{distance:f4}"); // осатвим 4 числа после запятой
                                     // f - указывает, что число вещественное