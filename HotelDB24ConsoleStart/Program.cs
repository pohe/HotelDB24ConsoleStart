// See https://aka.ms/new-console-template for more information

using HotelDB24ConsoleStart;

Console.WriteLine("Hello, World!");
bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu.Menu();
}