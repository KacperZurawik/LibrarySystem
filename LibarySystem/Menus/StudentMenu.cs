using System;
using System.Threading;

namespace LibarySystem
{
    class StudentMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.Clear();
            DisplayOptions();

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Selected 1");
            }
            else if (userChoice == "2")
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Selected 2");
            }
            else //invalid menu option
            {
                DisplaySelectedWrongOption();
            }
        }

        public void DisplayOptions()
        {
            // TODO: student menu
            Console.WriteLine(" ");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine("1. Administrator menu option 1");
            Console.WriteLine("2. Student menu option 2");
        }

        public void DisplaySelectedWrongOption()
        {
            Console.WriteLine("Selected option does not exist. Please chose from 1 to 4.");
            Thread.Sleep(2000);
            Console.Clear();
            DisplayMenu();
        }
    }
}
