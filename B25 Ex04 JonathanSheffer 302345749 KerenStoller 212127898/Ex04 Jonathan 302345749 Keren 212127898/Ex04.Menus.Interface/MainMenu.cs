namespace Ex04.Menus.Interface;

public class SubMenu
{
    private MenuItem m_RootMenuItem;
    private readonly bool r_IsMainMenu = true;

    public SubMenu(string i_Title)
    {
        m_RootMenuItem = new MenuItem(i_Title, r_IsMainMenu);
    }

    public void Show()
    {
        (m_RootMenuItem as IMenuItem).OnSelect();
    }

    public void AddMenuItem(MenuItem iMenuItemItem)
    {
        m_RootMenuItem.AddMenuItem(iMenuItemItem);
    }
    
    public void AddActionItem(ActionItem i_Action)
    {
        m_RootMenuItem.AddMenuItem(i_Action);
    }
}