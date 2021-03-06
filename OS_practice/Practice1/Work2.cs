﻿using System;
using System.IO;

namespace OS_practice.Practice1
{
    // 2. Работа с файлами ( класс File, FileInfo, FileStream и другие)
    //     a) Создать файл
    //     b) Записать в файл строку
    //     c) Прочитать файл в консоль
    //     d) Удалить файл
    class Work2
    {
        public static void foo()
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = @"text.txt";

            FileMethods.WriteFile(fileName, path);
            Console.WriteLine($"Текст файла:\n{FileMethods.ReadFile(path, fileName)}");

            Console.WriteLine("Нажмите любую кнопку для удаления файла...");
            Console.ReadKey(true);
            
            FileMethods.DeleteFile(path, fileName);
            
            Console.WriteLine("========================");
        }
    }
}