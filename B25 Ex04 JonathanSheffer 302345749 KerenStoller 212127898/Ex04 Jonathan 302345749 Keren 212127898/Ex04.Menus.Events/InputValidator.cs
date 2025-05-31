namespace Ex04.Menus.Events
{
    public class InputValidator
    {
        public int numberOfItems { get; set; } = 0;

        public int IsValidInput(string? input)
        {
            int chosen;
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int choice) || choice < 0 || choice > numberOfItems)
            {
                chosen = -1;
                throw new ArgumentException($"Invalid input. Please enter a number between 0 and {numberOfItems} .");
            }
            else
            {
                chosen = choice;
            }
            return chosen;
        }
    }
}
