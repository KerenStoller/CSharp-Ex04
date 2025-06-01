namespace Ex04.Menus.Test;
using Ex04.Menus.Interface;

public static class InterfaceClasses
{
    public class ShowVersion : ISpecificFunction
    {
        public void FunctionToExecute()
        {
            Console.WriteLine("App Version: 25.2.4.4480\n");
        }
    }

    public class ShowTime : ISpecificFunction
    {
        public void FunctionToExecute()
        {
            DateTime now = DateTime.Now;
            DateTime dateOnly = now.ToLocalTime();
            Console.WriteLine($"The time is: {now:HH:mm:ss}\n");
        }
    }

    public class ShowDate : ISpecificFunction
    {
        public void FunctionToExecute()
        {
            DateTime now = DateTime.Now;
            DateTime dateOnly = now.Date;
            Console.WriteLine($"Today is the: {now.ToShortDateString()}\n");
        }
    }

    public class CountLowerCase : ISpecificFunction
    {
        public void FunctionToExecute()
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
}

public static class ActionFunctions
{
    public static void ShowVersion_Selected()
    {
        Console.WriteLine("App Version: 25.2.4.4480\n");
    }

    public static void ShowTime_Selected()
    {
        DateTime now = DateTime.Now;
        DateTime dateOnly = now.ToLocalTime();
        Console.WriteLine($"The time is: {now:HH:mm:ss}\n");
    }

    public static void ShowDate_Selected()
    {
        DateTime now = DateTime.Now;
        DateTime dateOnly = now.Date;
        Console.WriteLine($"Today is the: {now.ToShortDateString()}\n");
    }

    public static void CountLowerCase_Selected()
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