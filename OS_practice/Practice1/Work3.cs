using System;
using System.IO;
using System.Text.Json;

namespace OS_practice.Practice1
{
    // 3. Работа с форматом JSON
    class Work3
    {
        public static void foo()
        {
            Person person = new Person { Age = 25, Name = "Larry", Salary = 12500.50 };
            string path = Directory.GetCurrentDirectory();
            string fileName = @"person.json";

            string json = JsonSerializer.Serialize(person);
            Console.WriteLine($"Person в JSON: {json}");

            FileMethods.WriteFile(path, fileName, json);
            
            string jsonFromFile = FileMethods.ReadFile(path, fileName);
            Person personFromJson = JsonSerializer.Deserialize<Person>(jsonFromFile);
            Console.WriteLine(personFromJson);
            
            
            Console.WriteLine("Нажмите любую кнопку для удаления файла...");
            Console.ReadKey(true);
            FileMethods.DeleteFile(path, fileName);

            Console.WriteLine("========================");
        }
    }
}