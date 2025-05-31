namespace Ex04.Menus.Events;

public class MainMenu
{
    private readonly SubMenu r_RootMenu;

    public MainMenu(string i_Title)
    {
        r_RootMenu = new SubMenu(i_Title, true);
    }

    public void AddMenuItem(MenuItem i_MenuItem)
    {
        r_RootMenu.AddMenuItem(i_MenuItem);
    }

    public void Show()
    {
        r_RootMenu.Activate();
    }
}

