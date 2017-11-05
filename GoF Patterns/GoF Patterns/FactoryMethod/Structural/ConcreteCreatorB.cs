namespace GoF_Patterns.FactoryMethod.Structural
{
    public class ConcreteCreatorB : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}