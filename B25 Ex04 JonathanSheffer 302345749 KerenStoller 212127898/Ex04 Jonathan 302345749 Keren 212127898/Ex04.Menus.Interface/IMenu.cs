namespace Ex04.Menus.Interface;

internal interface IMenu
{
    //here there will be a list of second menu and leaf actions
    //this will only hold public and abstract functions.
    int NumberOfMenus { get; set; }
    int NumberOfActions { get; set; }
    
    void MakeSubMenus(int numberOfMenus);
    void MakeAction(int numberOfActions);
    void GetChoiceFromUser();
    void CheckValidChoice(int i_UserChoice);
    void PrintMenu();
}