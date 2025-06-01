namespace Ex04.Menus.Interface;

public interface IMenuItem
{
    string Title { get; }
    void OnSelect();
}