namespace Ex04.Menus.Events;

public class SubMenu : MenuItem
{

    public const string k_dividor = "--------------------";

    List<MenuItem> m_MenuItems = new List<MenuItem>();

    private InputValidator validator = new InputValidator();

    public SubMenu(string i_Title)
        : base(i_Title)
    {
    }

    public void AddMenuItem(MenuItem i_MenuItem)
    {
        m_MenuItems.Add(i_MenuItem);
        validator.numberOfItems++;
    }

    public override void Activate()
    {
        bool exit = false;
        while(!exit)
        {
            Console.Clear();
            Console.WriteLine($"** {this.Title} **");
            Console.WriteLine(k_dividor);

            int choiceNumber = 1;

            foreach(MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine($"{choiceNumber}. {menuItem.Title}");
            }

            Console.WriteLine(
                m_MenuItems.Count == 1
                    ? "Please enter you choice or 0 to exit:"
                    : $"Please enter your choice (1 - {m_MenuItems.Count} or 0 to exit):");

            string? userInput = Console.ReadLine();
            int choice;

            try
            {
                choice = validator.IsValidInput(userInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            if (choice == 0)
            {
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

