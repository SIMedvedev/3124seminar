// Найти максимум из 9 чисел
// Стихийный подход

int a1 = 151;
int b1 = 21;
int c1 = 34;
int a2 = 90;
int b2 = 17;
int c2 = 47;
int a3 = 81;
int b3 = 8;
int c3 = 11;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

 Console.WriteLine(max);


