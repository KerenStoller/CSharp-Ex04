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

        showVersion.Selected += showVersion_Selected;
        lettersAndVersions.AddMenuItem(showVersion);

        LeafItem countLowerCaseLetters = new LeafItem("Count Lowercase Letters");

        countLowerCaseLetters.Selected += countLowerCase_Selected;
        lettersAndVersions.AddMenuItem(countLowerCaseLetters);

        SubMenu showDateTimeSubMenu = new SubMenu("Show current Date/Time");
        LeafItem showDateItem = new LeafItem("Show current Date");
        LeafItem showTimeItem = new LeafItem("Show current Time");

        showDateItem.Selected += showDate_Selected;
        showTimeItem.Selected += showTime_Selected;

        showDateTimeSubMenu.AddMenuItem(showDateItem);
        showDateTimeSubMenu.AddMenuItem(showTimeItem);
        sr_MainMenu.AddMenuItem(showDateTimeSubMenu);

    }


  
    public static void Show()
    {
        init();
        sr_MainMenu.Show();
    }

    private static void showVersion_Selected(LeafItem i_LeafItem)
    {
        Console.WriteLine("App Version: 25.2.4.4480\n");
    }

    private static void showTime_Selected(LeafItem i_LeafItem)
    {
        DateTime now = DateTime.Now;
        DateTime dateOnly = now.ToLocalTime();
        Console.WriteLine($"The time is: {now:HH:mm:ss}\n");
    }

    private static void showDate_Selected(LeafItem i_LeafItem)
    {
        DateTime now = DateTime.Now;
        DateTime dateOnly = now.Date;
        Console.WriteLine($"Today is the: {now.ToShortDateString()}\n");
    }

    private static void countLowerCase_Selected(LeafItem i_LeafItem)
    {
        Console.WriteLine("Please write something: ");
        string? userInput = Console.ReadLine();
        if (userInput != null)
        {
            int lowerCaseCount = 0;
            foreach (char c in userInput)
            {
                if (char.IsLower(c))
                {
                    lowerCaseCount++;
                }
            }
            Console.WriteLine($"The number of lowercase letters is: {lowerCaseCount}\n");
        }
        else
        {
            Console.WriteLine("No input provided.");
        }
    }
}