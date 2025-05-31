namespace Ex04.Menus.Events;

public class LeafItem : MenuItem
{
    public event Action? Selected;
    public LeafItem(string i_Title) : base(i_Title)
    {
    }

    protected virtual void onSelected()
    {
        Selected?.Invoke();
    }

    public override void Activate()
    {
        Console.Clear();
        onSelected();
    }
}

