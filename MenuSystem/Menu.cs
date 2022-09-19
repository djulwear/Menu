using System;
using System.Collections.Generic;

namespace MenuSystem
{
    public class Menu

    {
        private static readonly string ShortcutExit = "X";
        public string Title { get; set; } = default!;
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();
        //Dictionary словарик (встроенный класс)
        private readonly MenuItem _menuItemExit = new MenuItem(ShortcutExit, "Exit", null);
        // переменные класса (поля класса) fields
        // _нижнее подчеркивание = приватная переменная для использования внутри этого класса/объекта

        public Menu(string title, List<MenuItem> menuItems)
        {
            Title = title;
            foreach (var menuItem in menuItems)
            {
                _menuItems.Add(menuItem.Shortcut, menuItem);
            }
        }

        public string RunMenu()
        {
            bool menuDone = false;
            var userChoise = "";
            do
            {
                Console.WriteLine(Title);
                Console.WriteLine("===============");
                foreach (var menuItem in _menuItems.Values)
                {
                    Console.WriteLine(menuItem);
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
