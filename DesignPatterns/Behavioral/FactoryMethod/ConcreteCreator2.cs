namespace DesignPatterns.Behavioral.Factory;

class ConcreteCreator2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}
