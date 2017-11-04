namespace GoF_Patterns.AbstractFactory.Structural
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateAbstractProductA()
        {
            return new ConcreteProductA2();
        }

        public override AbstractProductB CreateAbstractProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
