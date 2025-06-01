namespace Ex04.Menus.Interface;

public static class InputHandler
{
    public static int GetValidInput(int i_MinNumber, int i_MaxNumber)
    {
        string? userInput = Console.ReadLine();
        int chosenInput;
        
        while (string.IsNullOrWhiteSpace(userInput) 
               || !int.TryParse(userInput, out chosenInput) 
               || chosenInput < i_MinNumber || chosenInput > i_MaxNumber)
        {
            Console.WriteLine($"Invalid input. Please enter a number between {i_MinNumber} and {i_MaxNumber}.");
            userInput = Console.ReadLine();
        }
        
        return chosenInput;
    }
}