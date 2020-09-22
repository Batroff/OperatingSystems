using System;
using System.Text;
using System.IO;

namespace OS_practice
{
    class Work2
    {
        public static void foo()
        {
            string path = @"D:\Documents\Files";
            string fileName = @"text.txt";
            
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists) directoryInfo.Create();
            
            FileMethods.WriteFile(path, fileName);
            Console.WriteLine($"Текст файла:\n{FileMethods.ReadFile(path, fileName)}");

            Console.WriteLine("Нажмите любую кнопку для удаления файла...");
            Console.ReadKey(true);
            
            FileMethods.DeleteFile(path, fileName);
            
            Console.WriteLine("========================");
        }
    }
}