namespace Cuisines;

class IndianFactory : IMealFactory
{
    public IMainCourse CreateMainCourse() => new ChickenCurry(5);
    public IDessert CreateDessert() => new Kheer();
}
