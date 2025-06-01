namespace Ex04.Menus.Events;

public class SubMenu : MenuItem
{
    private bool m_IsMainMenu;

    public const string k_Dividor = "--------------------";

    List<MenuItem> m_MenuItems = new List<MenuItem>();

    private InputValidator m_Validator = new InputValidator();

    public SubMenu(string i_Title, bool i_IsMainMenu = false)
        : base(i_Title)
    {
        this.m_IsMainMenu = i_IsMainMenu;
    }

    public void AddMenuItem(MenuItem i_MenuItem)
    {
        m_MenuItems.Add(i_MenuItem);
        m_Validator.NumberOfItems++;
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

            foreach(MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine($"{choiceNumber++}. {menuItem.Title}");
            }

            Console.WriteLine($"0. {backMessage}");

            Console.WriteLine(
                m_MenuItems.Count == 1
                    ? $"Please enter you choice or 0 to {exitMessage}:"
                    : $"Please enter your choice (1 - {m_MenuItems.Count} or 0 to {exitMessage}):");

            string? userInput = Console.ReadLine();
            int choice;

            try
            {
                choice = m_Validator.IsValidInput(userInput);
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
                MenuItem selectedItem = m_MenuItems[choice - 1];
                selectedItem.Activate();
            }
        }
    }

}

