namespace Ex04.Menus.Interface;

public class SubMenu : IMenuItem
{
    public string Title { get; }
    private readonly List<IMenuItem> r_Items =  new List<IMenuItem>();
    private bool m_IsMainMenu;
    private const int k_quit = 0;
    private const int k_InitUserChoice = -1;
    public const string k_Dividor = "--------------------";
    
    public SubMenu(string i_Title, bool i_IsMainMenu = false)
    {   
        Title = i_Title;
        m_IsMainMenu = i_IsMainMenu;
    }
    
    private void PrintMenu()
    {
        int userChoice = k_InitUserChoice;
        
        while (userChoice != k_quit)
        {
            Console.Clear();
            Console.WriteLine($"--- {Title} ---");
            Console.WriteLine(k_Dividor);
            int index = 1;
            
            foreach (IMenuItem menuItem in r_Items)
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
    
    void IMenuItem.OnSelect()
    {
        PrintMenu();
    }

    public void AddMenuItem(IMenuItem i_MenuItem)
    {
        r_Items.Add(i_MenuItem);
    }
}