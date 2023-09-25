namespace Cuisines;

// This is the Abstract Factory
interface IMealFactory
{
    IMainCourse CreateMainCourse();
    IDessert CreateDessert();
}
