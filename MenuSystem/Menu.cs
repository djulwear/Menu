using System;
using System.Collections.Generic;

namespace MenuSystem
{
    public class Menu
    {
        private static readonly string ShortcutExit = "X";
        public string Title { get; set; } = default!;
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();
        private readonly MenuItem _menuItemExit = new MenuItem(ShortcutExit, "Exit", null);
       
        public string RunMenu()
        {
            var menuDone = false;
            var userChoise = "";
            do
            {
                Console.WriteLine(Title);
                Console.WriteLine("===============");
                foreach (var menuItem in menuItems.Values)
                {
                    _menuItems.Add(menuItem.Shortcut, menuItem);
                }
                Console.WriteLine(_menuItemExit);
                Console.WriteLine("---------------");
                Console.Write("Ÿour choise: ");
                userChoise = Console.ReadLine()?.ToUpper().Trim() ?? "";

                if(userChoise == ShortcutExit)
                {
                    menuDone = true;
                }

            } while (menuDone == false);
            return userChoise;
        }
    }
}
