// Как посмотреть содержимое папки?

// string path = "C:/Users/Сергей/Desktop/ОБУЧЕНИЕ ГБ/дз2";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }
void CatalogInfo(string path, string indent = "")  // string indent = "" делает отспупы, чтобы лучшк видеть структуры папки
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i  < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i  < files.Length; i++)
    {
         Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:\Users\Сергей\Desktop\ОБУЧЕНИЕ ГБ";
CatalogInfo(path);

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalogs = new DirectoryInfo(path);
//     foreach (var currentCatalog in catalogs.GetDirectories())
//     {
//         Console.WriteLine($"{indent}{currentCatalog.Name}");
//         CatalogInfo(currentCatalog.FullName, indent + " ");
//     }
//     foreach (var item in catalogs.GetFiles())
//     {
//         Console.WriteLine($"{indent}{item.Name}");
//     }
// }
// string path = @"C:\Users\Сергей\Desktop\ОБУЧЕНИЕ ГБ\Новая папка";
// CatalogInfo(path);