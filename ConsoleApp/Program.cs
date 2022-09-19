using System.Collections.Generic;
using MenuSystem;
using System;

var mainMenu = new Menu(
    ">  Othello  <",
    new List<MenuItem>()
    {
        new MenuItem("N", "New Game", DoNewGame),
        new MenuItem("L", "Load Game", null),
        new MenuItem("O", "Options", null)
    }
);

var choice = mainMenu.RunMenu();

void DoNewGame()
{
    Console.WriteLine("New game method");
}
