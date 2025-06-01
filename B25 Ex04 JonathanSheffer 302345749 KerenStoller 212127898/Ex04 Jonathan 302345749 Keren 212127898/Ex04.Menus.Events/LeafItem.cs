namespace Ex04.Menus.Events;

public class LeafItem : MenuItem
{
    public event Action Selected;
    
    public LeafItem(string i_Title) : base(i_Title) {}

    public override void OnSelect()
    {
        Selected?.Invoke();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}