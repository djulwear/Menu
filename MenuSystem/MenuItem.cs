using System;

namespace MenuSystem
{

    public class MenuItem
    {
        public string Title { get; set; } = default!;
        public string Shortcut { get; set; } = default!;
        public Action? MethodToRun { get; set; }

        public MenuItem(string shortcut, string title, Action? methodRun )
        {
            Shortcut = shortcut;
            Title = title;
            MethodToRun = methodRun;
        }


        public override string ToString() => Shortcut + ") " + Title;
        
    }
}