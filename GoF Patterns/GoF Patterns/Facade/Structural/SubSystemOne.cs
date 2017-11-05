using System;

namespace GoF_Patterns.Facade.Structural
{
    public class SubSystemOne
    {
        public void One()
        {
            Console.WriteLine("Executes " + this.GetType().Name);
        }
    }
}