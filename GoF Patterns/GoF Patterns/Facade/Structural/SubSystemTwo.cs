using System;

namespace GoF_Patterns.Facade.Structural
{
    public class SubSystemTwo
    {
        public void Two()
        {
            Console.WriteLine("Executes " + this.GetType().Name);
        }
    }
}