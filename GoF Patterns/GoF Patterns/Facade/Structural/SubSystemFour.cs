using System;

namespace GoF_Patterns.Facade.Structural
{
    public class SubSystemFour
    {
        public void Four()
        {
            Console.WriteLine("Executes " + this.GetType().Name);
        }
    }
}