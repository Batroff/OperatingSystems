using System;
using System.IO;

namespace OS_practice
{
    class Work1
    {
        public static void foo()
        {
            Console.WriteLine("Задание 1.");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Название диска: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");

                if (!drive.IsReady) continue;
                Console.WriteLine($"Формат диска: {drive.DriveFormat}");
                Console.WriteLine($"Размер диска: {drive.TotalSize}");
                Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                Console.WriteLine("========================");
            }
        }
    }
}