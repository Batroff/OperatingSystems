using System;
using System.IO;
using System.IO.Compression;

namespace OS_practice
{
    class Work5
    {
        public static void foo()
        {
            string path = @"D:\Documents\Files";
            string fileName = "text.txt";
            FileInfo fileInfo = new FileInfo($"{path}\\{fileName}");
            fileInfo.Create();
            Console.WriteLine(fileInfo.Name);


            Console.WriteLine("Нажмите любую кнопку для удаления файла...");
            Console.ReadKey(true);
            try
            {
                if (fileInfo.Exists) fileInfo.Delete();
        
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при удалении файла!\n{e}");
            }

            Console.WriteLine("========================");
        }
    }
}