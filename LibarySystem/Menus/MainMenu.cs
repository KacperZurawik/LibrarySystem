using System;
using System.Threading;

namespace LibarySystem
{
    class MainMenu : IMenu
    {
        IMenu studentMenu = new StudentMenu();
        public void DisplayMenu()
        {
            DisplayOptions();

            string userChoice;
            userChoice = Console.ReadLine();

            if (userChoice == "1") //administrator menu
            {

            }
            else if (userChoice == "2") //student menu
            {
                studentMenu.DisplayMenu();
            }
            else if (userChoice == "3") //browsing library
            {

            }
            else if (userChoice == "4") //closing app
            {
                Environment.Exit(0);
            }
            else //invalid menu option
            {
                DisplaySelectedWrongOption();
            }
        }

        public void DisplayOptions()
        {
            Console.WriteLine(" ");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Administrator");
            Console.WriteLine("2. Student");
            Console.WriteLine("3. Browse library");
            Console.WriteLine("4. Close");
            Console.WriteLine("Choose your option from Menu :");
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
