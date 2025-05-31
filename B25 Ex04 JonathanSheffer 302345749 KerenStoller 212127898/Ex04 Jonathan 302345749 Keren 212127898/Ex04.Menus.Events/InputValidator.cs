namespace Ex04.Menus.Events
{
    public class InputValidator
    {
        public int NumberOfItems { get; set; } = 0;

        public int IsValidInput(string? i_Input)
        {
            int chosen;
            if (string.IsNullOrWhiteSpace(i_Input) || !int.TryParse(i_Input, out int choice) || choice < 0 || choice > NumberOfItems)
            {
                chosen = -1;
                throw new ArgumentException($"Invalid input. Please enter a number between 0 and {NumberOfItems} .");
            }
            else
            {
                chosen = choice;
            }
            return chosen;
        }
    }
}
