using System;
using System.IO;

namespace OS_practice.Practice1
{
    // 5. Создание zip архива, добавление туда файла, определение размера архива
    class Work5
    {
        public static void foo()
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = "test-gzip";
            string fileExt = "txt";

            if (!File.Exists($"{path}\\{fileName}.{fileExt}"))
                FileMethods.WriteFile($"{fileName}.{fileExt}", path);
            FileMethods.Compress($"{fileName}.{fileExt}", fileName + ".gz");

            Console.WriteLine("\n========================\n");

            FileMethods.Decompress($"{path}\\{fileName}.gz", $"{path}\\uncompressed-{fileName}.{fileExt}");
            Console.WriteLine("Нажмите любую кнопку для удаления файла...");
            Console.ReadKey(true);
            FileMethods.DeleteFile(path, $"uncompressed-{fileName}.{fileExt}");
            FileMethods.DeleteFile(path, $"{fileName}.gz");

            Console.WriteLine("========================");
        }
    }
}