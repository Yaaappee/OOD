namespace GoF_Patterns.AbstractFactory
{
    public static class AbstractFactoryClient
    {
        public static void RunStructural(Structural.AbstractFactory factory)
        {
            var productA = factory.CreateAbstractProductA();
            var productB = factory.CreateAbstractProductB();
            productB.Interact(productA);
        }
    }
}