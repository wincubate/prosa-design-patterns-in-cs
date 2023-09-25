using Cuisines;

//IMealFactory factory = new ItalianFactory();
IMealFactory factory = new IndianFactory();

IMainCourse main = factory.CreateMainCourse();
main.Consume();

IDessert dessert = factory.CreateDessert();
dessert.Enjoy();
