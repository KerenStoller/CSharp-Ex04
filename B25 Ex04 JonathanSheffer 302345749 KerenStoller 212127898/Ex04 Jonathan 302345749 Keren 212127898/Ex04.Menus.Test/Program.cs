using Ex04.Menus;
using Ex04.Menus.Events;

public class Program
{
   private static void printHello()
    {
        Console.WriteLine("Hello from printHello method!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {
        Ex04.Menus.Events.MainMenu mainMenu = new Ex04.Menus.Events.MainMenu("Main Menu");
        Ex04.Menus.Events.SubMenu subMenu1 = new Ex04.Menus.Events.SubMenu("Sub Menu 1");
        mainMenu.AddMenuItem(subMenu1);
        Ex04.Menus.Events.LeafItem test1 = new LeafItem("test 1");
        test1.Selected += new Action(printHello);
        subMenu1.AddMenuItem(test1);
        mainMenu.Show();
    }
}
