namespace Ex04.Menus.Interface;

public interface ISpecificFunction
{
    void FunctionToExecute();
}

public class ActionItem : IMenuItem
{
    public string Title { get; }
    public ISpecificFunction Function { get; }
    
    public ActionItem(string i_Title, ISpecificFunction function)
    {
        Title = i_Title;
        Function = function;
    }
    void IMenuItem.OnSelect()
    {
        Console.Clear();
        Function.FunctionToExecute();
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}