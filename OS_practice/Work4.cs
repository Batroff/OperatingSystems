using System;
using System.Linq;
using System.Xml.Linq;

namespace OS_practice
{
    class Work4
    { 
        public static void foo()
        {
            string path = @"D:\Documents\Files";
            string fileName = "base.xml";

            /*Генерация XML-файла*/
            XDocument doc = new XDocument(
                new XElement("users",
                    new XElement("user",
                        new XElement("name", "Mark Zuckerberg"),
                        new XElement("age", "45"),
                        new XElement("salary", "125000.00")),
                    new XElement("user",
                        new XElement("name", "Bill Gates"),
                        new XElement("age", "48"),
                        new XElement("salary", "205000.00")),
                    new XElement("user",
                        new XElement("name", "Larry Page"),
                        new XElement("age", "50"),
                        new XElement("salary", "127500.00"))
                )
            );
            doc.Save($"{path}\\{fileName}");

            /*Чтение файла*/
            foreach (var user in doc.Root.Elements())
            {
                Console.WriteLine($"{user.Name}");
                foreach(var userElem in user.Elements())
                {
                    Console.WriteLine($" {userElem.Name}: {userElem.Value}");
                }
            }

            Console.WriteLine("========================");
        }
    }
}