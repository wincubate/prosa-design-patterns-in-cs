namespace Cuisines;

class Pizza : IMainCourse
{
    public IEnumerable<string> Toppings { get; }

    public Pizza( params string[] toppings )
    {
        Toppings = toppings;
    }

    public void Consume()
    {
        Console.WriteLine( "Delicately consuming " + string.Join( ", ", Toppings) );
    }
}
