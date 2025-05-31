namespace Ex04.Menus.Events;

public abstract class MenuItem
{
    public string Title { get; set; }

    public MenuItem(string title)
    {
        Title = title;
    }

    public abstract void Activate();
}

