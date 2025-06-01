namespace Ex04.Menus.Interface;

public class MainMenu
{
    private SubMenu _mRootSubMenu;
    private readonly bool r_IsMainMenu = true;

    public MainMenu(string i_Title)
    {
        _mRootSubMenu = new SubMenu(i_Title, r_IsMainMenu);
    }

    public void Show()
    {
        (_mRootSubMenu as IMenuItem).OnSelect();
    }

    public void AddMenuItem(SubMenu iSubMenu)
    {
        _mRootSubMenu.AddMenuItem(iSubMenu);
    }
}