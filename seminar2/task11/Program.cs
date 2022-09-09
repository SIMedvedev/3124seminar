// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.Write("Сгенерировалось число " + number  +" -> абра кадабра -> ");
int digit1 = number / 100;
int digit2 = number % 10;
// int res = digit1 * 10 + digit2 умножаем на 10, так как первая цифра это десятки в 
//двухзнвчном чсисле, т.е. 5*10 + 5 == 55
// Соответственно вывод Console.WriteLine(res);
Console.Write(digit1); 
Console.WriteLine(digit2); 
