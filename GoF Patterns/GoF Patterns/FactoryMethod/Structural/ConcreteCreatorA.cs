namespace GoF_Patterns.FactoryMethod.Structural
{
    public class ConcreteCreatorA : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}