namespace Ex04.Menus.Events;

public class MainMenu
{
    private readonly SubMenu r_RootMenu;
    private readonly bool r_IsMainMenu = true;

    public MainMenu(string i_Title)
    {
        r_RootMenu = new SubMenu(i_Title, r_IsMainMenu);
    }

    public void AddMenuItem(MenuItem i_MenuItem)
    {
        r_RootMenu.AddMenuItem(i_MenuItem);
    }

    public void Show()
    {
        r_RootMenu.OnSelect();
    }
}

