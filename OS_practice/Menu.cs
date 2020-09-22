using System;
using OS_practice.Practice1;

namespace OS_practice
{
    class Menu
    {
        ConsoleKeyInfo keyInfo;
        bool inMenu = true;
        public void start()
        {
            while (inMenu)
            {
                Console.WriteLine("Для выбора задания нажмите 1-5, для выхода - Escape");
                Console.Write("Ввод: ");
                keyInfo = Console.ReadKey(true);
                Console.Clear();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Escape:
                        inMenu = false;
                        break;

                    case ConsoleKey.D1:
                        Work1.foo();
                        break;

                    case ConsoleKey.D2:
                        Work2.foo();
                        break;

                    case ConsoleKey.D3:
                        Work3.foo();
                        break;

                    case ConsoleKey.D4:
                        Work4.foo();
                        break;

                    case ConsoleKey.D5:
                        Work5.foo();
                        break;
                }
            }
        }
    }
}