
using Library_App.Models;
using Service.Helpers;
using System.Collections.Concurrent;

LibraryController libraryController = new LibraryController();

while (true)
{
    ConsoleColor.Cyan.CW("Select one option: ");
    ConsoleColor.Cyan.CW("Library options --> 1.Create, 2.Get by id, 3.Delete");

    Option: string option = Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);

    if (isParseOption)
    {
        switch (selectedOption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                libraryController.GetById();
                break;
            default:
                break;
        }
    }
    else 
    {
        ConsoleColor.Red.CW("Please write correct option: ");
        goto Option;
    }
}