namespace Ex04.Menus.Interface;

public class MenuItem : IMenuItem
{
    public string Title { get; }
    private readonly List<IMenuItem> r_Items =  new List<IMenuItem>();
    bool i_IsMainMenu;
    
    public MenuItem(string i_Title, bool i_IsMainMenu = false)
    {   
        Title = i_Title;
        i_IsMainMenu = i_IsMainMenu;
    }
    
    private void PrintMenu()
    {
        int quit = -1;
        
        while (quit != 0)
        {
            Console.Clear();
            Console.WriteLine($"--- {Title} ---");
            int index = 1;
            
            foreach (IMenuItem menuItem in r_Items)
            {
                Console.WriteLine($"{index++}. {menuItem.Title}");
            }

            if (i_IsMainMenu)
            {
                Console.WriteLine("0. Exit");
            }
            else
            {
                Console.WriteLine("0. Back");
            }
            
            Console.Write("Choose an option: ");
            InputValidator.GetValidChoice(r_Items.Count, out quit);
            if (quit > 0)
            {
                r_Items[quit-1].OnSelect();
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