using System;

namespace MenuSystem
{

    public class MenuItem
    {
        public string Title { get; set; } = default!;
        public string Shortcut { get; set; } = default!;
        public Action? MethodToRun { get; set; }
        //переменные (проперти)

        public MenuItem(string shortcut, string title, Action? methodRun )
            // Action? = функция или метод который надо запускать
        {
            Shortcut = shortcut;
            Title = title;
            MethodToRun = methodRun;
            //когда создается класс, параметры сохраняются в классе.
        }


        public override string ToString() => Shortcut + ") " + Title;

        
    }
}