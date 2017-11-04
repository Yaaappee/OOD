using System;

namespace GoF_Patterns.AbstractFactory.Structural
{
    public class ConcreteProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA abstractProductB)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + abstractProductB.GetType().Name);
        }
    }
}
