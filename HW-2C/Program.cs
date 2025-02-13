string? selection = "";
do
{
    Console.Clear();
    PrintMenu();
    Console.WriteLine("\nSelect an option from the menu above");
    selection = Console.ReadLine();
    if (selection == null)
        continue;
    
    DisplaySelectionChoice();
} while (selection != "4");

void DisplaySelectionChoice()
{
    Console.Write("\nYou chose to ");
    switch (selection)
    {
        case "1":
            Console.WriteLine("start a new game");
            break;
        case "2":
            Console.WriteLine("load an existing game");
            break;
        case "3":
            Console.WriteLine("view the options");
            break;
        case "4":
            Console.WriteLine("quit. Bye!");
            break;
        default:
            return;
    }
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
}

void PrintMenu()
{
    Console.WriteLine("**************");
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - New Game");
    Console.WriteLine("2 - Load Game");
    Console.WriteLine("3 - Options");
    Console.WriteLine("4 - Quit");
    Console.WriteLine("**************");
}