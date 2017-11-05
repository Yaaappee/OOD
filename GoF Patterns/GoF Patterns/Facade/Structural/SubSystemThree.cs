using System;

namespace GoF_Patterns.Facade.Structural
{
    public class SubSystemThree
    {
        public void Three()
        {
            Console.WriteLine("Executes " + this.GetType().Name);
        }
    }
}