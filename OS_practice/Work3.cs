using System;
using System.Text.Json;

namespace OS_practice
{
    class Work3
    {
        public static void foo()
        {
            Person person = new Person { Age = 25, Name = "Larry", Salary = 12500.50 };
            string path = @"D:\Documents\Files";
            string fileName = @"person.json";

            string json = JsonSerializer.Serialize(person);
            Console.WriteLine($"Person в JSON: {json}");

            FileMethods.WriteFile(path, fileName, json);
            
            string jsonFromFile = FileMethods.ReadFile(path, fileName);
            Person personFromJson = JsonSerializer.Deserialize<Person>(jsonFromFile);
            Console.WriteLine(personFromJson);

            FileMethods.DeleteFile(path, fileName);

            Console.WriteLine("========================");
        }
    }
}