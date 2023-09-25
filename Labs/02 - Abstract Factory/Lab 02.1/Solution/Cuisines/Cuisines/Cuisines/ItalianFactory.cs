namespace Cuisines;

class ItalianFactory : IMealFactory
{
    // Could have made use of Builder or similar
    public IMainCourse CreateMainCourse()
        => new Pizza( "Tomato Sauce", "Pepperoni", "Pineapple", "Cheese" );
    public IDessert CreateDessert() => new Tiramisu(); 
}
