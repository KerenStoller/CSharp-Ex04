namespace Ex04.Menus.Test;
using Ex04.Menus.Interface;

public static class InterfaceMenu
{
    private static MainMenu sr_MainMenu;
    
    private static void init()
    {
        sr_MainMenu = new MainMenu("Actions Main Menu");
        SubMenu lettersAndVersions = new SubMenu("Letters and Version");
        InterfaceClasses.ShowVersion showVersionFunction = new InterfaceClasses.ShowVersion();
        LeafItem showVersion = new LeafItem("Show Version", showVersionFunction);
        InterfaceClasses.CountLowerCase countLowerCaseFunction = new InterfaceClasses.CountLowerCase();
        LeafItem countLowerCaseLetters = new LeafItem("Count Lowercase Letters", countLowerCaseFunction);

        lettersAndVersions.AddMenuItem(showVersion);
        lettersAndVersions.AddMenuItem(countLowerCaseLetters);
        sr_MainMenu.AddMenuItem(lettersAndVersions);

        SubMenu showDateTimeSubSubMenu = new SubMenu("Show current Date/Time");
        InterfaceClasses.ShowDate showDateFunction = new InterfaceClasses.ShowDate();
        LeafItem showDateItem = new LeafItem("Show current Date", showDateFunction);
        InterfaceClasses.ShowTime showTimeFunction = new InterfaceClasses.ShowTime();
        LeafItem showTimeItem = new LeafItem("Show current Time", showTimeFunction);

        showDateTimeSubSubMenu.AddMenuItem(showDateItem);
        showDateTimeSubSubMenu.AddMenuItem(showTimeItem);
        sr_MainMenu.AddMenuItem(showDateTimeSubSubMenu);
    }
    
    public static void Show()
    {
        init();
        sr_MainMenu.Show();
    }
}