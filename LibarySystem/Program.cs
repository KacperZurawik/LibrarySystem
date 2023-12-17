using System;

namespace LibarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu(new TestMenu());
            ShowMenu(new MainMenu());
            ShowMenu(new StudentMenu());
            Console.Read();
        }
        
        static void ShowMenu(IMenu menu)
        {
            menu.DisplayMenu();
        }
    }
}

