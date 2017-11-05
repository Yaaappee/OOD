using System;

namespace GoF_Patterns.FactoryMethod.Structural
{
    public static class Client
    {
        public static void Run()
        {
            var creators = new Creator[]
            {
                new ConcreteCreatorA(),
                new ConcreteCreatorB()
            };

            foreach (Creator creator in creators)
            {
                Product product = creator.CreateProduct();
                Console.WriteLine(creator.GetType().Name + " creates product " + product.GetType().Name);
            }

        }
    }
}
