using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace OS_practice
{
    public static class FileMethods
    {
        public static void WriteFile(string fileName, string path = "")
        {
            path = path == "" ? Directory.GetCurrentDirectory() : path;
            Console.Write("Введите строку для записи в файл: ");
            string textInput = Console.ReadLine();

            WriteFile(path, fileName, textInput);
        }

        public static void WriteFile(string path, string fileName, string textInput)
        {
            using (FileStream fstream = new FileStream($"{path}\\{fileName}", FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(textInput);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Запись в файл завершена!");
            }   
        }
        

        public static string ReadFile(string path, string fileName)
        {
            using (FileStream fstream = File.OpenRead($"{path}\\{fileName}"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                return Encoding.Default.GetString(array);
            }
        }

        public static void DeleteFile(string path, string fileName)
        {
            FileInfo fileInfo = new FileInfo($"{path}\\{fileName}");
            try
            {
                if (fileInfo.Exists) fileInfo.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при удалении файла!\n{e}");
            }
        }

        public static void Compress(string sourceFile, string compressedFile)
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                        Console.WriteLine(
                            $"Сжатие файла {sourceFile} завершено. " +
                            $"Исходный размер: {sourceStream.Length.ToString()}, " +
                            $"сжатый размер: {targetStream.Length.ToString()}.");
                    }
                }
            }
        }

        public static void Decompress(string compressedFile, string targetFile)
        {
            using (FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(targetFile))
                {
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                        Console.WriteLine($"Восстановлен файл: {targetFile}");
                    }
                }
            }
        }
    }
}