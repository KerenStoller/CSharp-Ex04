namespace Ex04.Menus.Events;

public class LeafItem : MenuItem
{
    public event Action<LeafItem>? Selected;
    public LeafItem(string i_Title) : base(i_Title)
    {
    }

    protected virtual void OnSelected()
    {
        Selected?.Invoke(this);
    }

    public override void Activate()
    {
        OnSelected();
    }
}

