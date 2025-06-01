namespace Ex04.Menus.Interface;

public interface ISpecificFunction
{
    void FunctionToExecute();
}

public class LeafItem : IMenuItem
{
    public string Title { get; }
    public ISpecificFunction Function { get; }
    
    public LeafItem(string i_Title, ISpecificFunction function)
    {
        Title = i_Title;
        Function = function;
    }
    void IMenuItem.OnSelect()
    {
        Function.FunctionToExecute();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}