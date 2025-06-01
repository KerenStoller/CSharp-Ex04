namespace Ex04.Menus.Events;

public class SubMenu : MenuItem
{
    private bool m_IsMainMenu;
    public const string k_Dividor = "--------------------";
    private readonly List<MenuItem> r_Items = new List<MenuItem>();
    private const int k_quit = 0;
    private const int k_InitUserChoice = -1;

    public SubMenu(string i_Title, bool i_IsMainMenu = false) : base(i_Title)
    {
        m_IsMainMenu = i_IsMainMenu;
    }

    public void AddMenuItem(MenuItem i_MenuItem)
    {
        r_Items.Add(i_MenuItem);
    }

    public override void OnSelect()
    {
        int userChoice = k_InitUserChoice;
        
        while (userChoice != k_quit)
        {
            Console.Clear();
            Console.WriteLine($"--- {Title} ---");
            Console.WriteLine(k_Dividor);
            int index = 1;
            
            foreach (MenuItem menuItem in r_Items)
            {
                Console.WriteLine($"{index++}. {menuItem.Title}");
            }

            if (m_IsMainMenu)
            {
                Console.WriteLine("0. Exit");
            }
            else
            {
                Console.WriteLine("0. Back");
            }
            
            Console.Write("Choose an option: ");
            userChoice = InputHandler.GetValidInput(0, r_Items.Count);
            
            if (userChoice > 0)
            {
                r_Items[userChoice-1].OnSelect();
            }
        }
        Console.Clear();
    }
}