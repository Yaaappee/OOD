namespace GoF_Patterns.AbstractFactory.Structural
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateAbstractProductA()
        {
            return new ConcreteProductA1();
        }

        public override AbstractProductB CreateAbstractProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
