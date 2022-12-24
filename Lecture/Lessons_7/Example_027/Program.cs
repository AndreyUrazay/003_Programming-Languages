// как посмотреть директорию папок. Обход директории
string path = "H:\GeekBrains\003_Знакомство с языками програмиирования\003_git_PL\Lecture\Lessons_1"
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}


// Рекурсия
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent} {catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent} {files[i].Name}");
    }
}
string path = @"H:\GeekBrains\003_Знакомство с языками програмиирования\003_git_PL\Lecture\Lessons_1";
CatalogInfo(path);