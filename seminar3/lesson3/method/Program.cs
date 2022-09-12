// void Method1()  // самый простой метод, выводит любой текст, ничего не возвращает
// {
//     Console.WriteLine("Пампарам2312");
// }
// Method1();
// void Method2(string msg)        // ничего не возвращает, но может 
// {                               // принимать какие-нибудь аргументы
//     Console.WriteLine(msg);     // выводит указанный текст
// }


// Method2("Первый второй");
// void Method21(string msg, int count)         
// {                               
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg); 
//         i++;
//     }


// Method21("текст" , 4);
//Method21(msg: "Какой-то текст", count: 4); можно вывести текст на экрна несколько раз
//Method21(count: 4, msg: "новый текст");


// int Method3()       // что-то возвращает, но ничего не принимает
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// string Method4(int count, string text) // что-то принимает и что-то возвращает
// {
//     int i = 0;
//     string result = String.Empty;   // String.Empty пустая строка, инициализация ацстой строки
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "as df");
// Console.WriteLine(res);

string Method4(int count, string text) // с помощью цикла for
 {
    string result = String.Empty;
    for (int i = 0; i < count; i++) 
    {
         result = result + text;
    }
    return result;
 }
 string res = Method4(10, "z");
 Console.WriteLine(res);
