namespace Ex04.Menus.Events;

public class SubMenu : MenuItem
{
    private bool m_IsMainMenu;

    public const string k_Dividor = "--------------------";

    private readonly List<MenuItem> r_MenuItems = new();

    private readonly InputValidator r_Validator = new();

    public SubMenu(string i_Title, bool i_IsMainMenu = false)
        : base(i_Title)
    {
        this.m_IsMainMenu = i_IsMainMenu;
    }

    public void AddMenuItem(MenuItem i_MenuItem)
    {
        r_MenuItems.Add(i_MenuItem);
        r_Validator.NumberOfItems++;
    }

    public override void Activate()
    {
        Console.Clear();
        bool exit = false;

        string exitMessage = m_IsMainMenu ? "exit" : "go back";

        string backMessage = m_IsMainMenu ? "Exit" : "Back";

        while (!exit)
        {
            Console.WriteLine($"** {this.Title} **");
            Console.WriteLine(k_Dividor);

            int choiceNumber = 1;

            foreach(MenuItem menuItem in r_MenuItems)
            {
                Console.WriteLine($"{choiceNumber++}. {menuItem.Title}");
            }

            Console.WriteLine($"0. {backMessage}");

            Console.WriteLine(
                r_MenuItems.Count == 1
                    ? $"Please enter you choice or 0 to {exitMessage}:"
                    : $"Please enter your choice (1 - {r_MenuItems.Count} or 0 to {exitMessage}):");

            string? userInput = Console.ReadLine();
            int choice;

            try
            {
                choice = r_Validator.IsValidInput(userInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to return to the menu");
                Console.ReadLine();
                continue;
            }

            if (choice == 0)
            {
                Console.Clear();
                exit = true;
            }
            else
            {
                MenuItem selectedItem = r_MenuItems[choice - 1];
                selectedItem.Activate();
            }
        }
    }

}

