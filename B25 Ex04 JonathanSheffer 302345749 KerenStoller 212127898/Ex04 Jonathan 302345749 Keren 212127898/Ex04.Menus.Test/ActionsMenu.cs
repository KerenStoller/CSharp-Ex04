namespace Ex04.Menus.Test;
using Ex04.Menus.Events;

public class ActionsMenu
{
    private static readonly MainMenu sr_MainMenu = new MainMenu("Actions Main Menu");
    
    private static void init()
    {
        SubMenu lettersAndVersions = new SubMenu("Letters and Version");

        sr_MainMenu.AddMenuItem(lettersAndVersions);
        LeafItem showVersion = new LeafItem("Show Version");

        showVersion.Selected += ActionFunctions.ShowVersion_Selected;
        lettersAndVersions.AddMenuItem(showVersion);
        LeafItem countLowerCaseLetters = new LeafItem("Count Lowercase Letters");

        countLowerCaseLetters.Selected += ActionFunctions.CountLowerCase_Selected;
        lettersAndVersions.AddMenuItem(countLowerCaseLetters);
        SubMenu showDateTimeSubMenu = new SubMenu("Show current Date/Time");
        LeafItem showDateItem = new LeafItem("Show current Date");
        LeafItem showTimeItem = new LeafItem("Show current Time");

        showDateItem.Selected += ActionFunctions.ShowDate_Selected;
        showTimeItem.Selected += ActionFunctions.ShowTime_Selected;

        showDateTimeSubMenu.AddMenuItem(showDateItem);
        showDateTimeSubMenu.AddMenuItem(showTimeItem);
        sr_MainMenu.AddMenuItem(showDateTimeSubMenu);
    }
  
    public static void Show()
    {
        init();
        sr_MainMenu.Show();
    }
}