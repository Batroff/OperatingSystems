using System;
using System.IO;
using System.IO.Compression;

namespace OS_practice
{
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

            FileMethods.Decompress($"{path}.gz", $"{path}\\uncompressed-{fileName}.{fileExt}");
            Console.WriteLine("Нажмите любую кнопку для удаления файла...");
            Console.ReadKey(true);
            FileMethods.DeleteFile(path, $"{fileName}.{fileExt}");

            Console.WriteLine("========================");
        }
    }
}