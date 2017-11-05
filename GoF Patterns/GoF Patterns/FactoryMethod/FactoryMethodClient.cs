using System;
using GoF_Patterns.FactoryMethod.Structural;

namespace GoF_Patterns.FactoryMethod
{
    public static class FactoryMethodClient
    {
        public static void RunStructural()
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
