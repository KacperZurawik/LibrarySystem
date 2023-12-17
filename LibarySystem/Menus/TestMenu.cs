using System;

namespace LibarySystem
{
    class TestMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("TESTOWE MENU");
        }

        public void DisplayOptions()
        {
            throw new NotImplementedException();
        }

        public void DisplaySelectedWrongOption()
        {
            throw new NotImplementedException();
        }
    }
}
