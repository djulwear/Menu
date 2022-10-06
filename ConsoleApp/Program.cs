using System;
using System.Collections.Generic;
using ConsoleUI;
using GameBrain;
using MenuSystem;
using Domain;
using DAL;
using DAL.FileSystem;

var gameOptions = new CheckersOptions();
var game = new CheckersBrain(gameOptions);

IGameOptionsRepository repo = new GameOptionsRepositoryFileSystem();


var thirdMenu = new Menu(
    EMenuLevel.Other,
    "> Third level  <",
    new List<MenuItem>()
    {
        new MenuItem("N", "Nothing", null),
    }
);


var secondMenu = new Menu(
    EMenuLevel.Second,
    "> Second level  <",
    new List<MenuItem>()
    {
        new MenuItem("T", "Third level", thirdMenu.RunMenu),
    }
);

var sizeMenu = new Menu(
    EMenuLevel.Second,
    "> Second Level, Borad size <",
    new List<MenuItem>()
    {
        new MenuItem("N", "New Game", DoNewGame),
        new MenuItem("S","Board Bigger", null),
        new MenuItem("D","Board Smaller", null),
    }
);


var mainMenu = new Menu(
    EMenuLevel.Main,
    ">  Firsl level, Main Menu  <",
    new List<MenuItem>()
    {
        new MenuItem("N", "New Game", sizeMenu.RunMenu),
        new MenuItem("L", "Load Game", null),
        new MenuItem("O", "Options", secondMenu.RunMenu)
    }
);



var choice = mainMenu.RunMenu();

string DoNewGame()
{

    var game = new CheckersBrain(8, 8);

    UI.DrawGameBoard(game.GetBoard());
    Console.WriteLine("New game method+-");
    return "---";
}
