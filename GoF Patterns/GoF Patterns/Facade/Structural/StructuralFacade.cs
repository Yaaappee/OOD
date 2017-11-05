using System;

namespace GoF_Patterns.Facade.Structural
{
    public class StructuralFacade
    {
        private SubSystemOne _subSystemOne;
        private SubSystemTwo _subSystemTwo;
        private SubSystemThree _subSystemThree;
        private SubSystemFour _subSystemFour;

        public StructuralFacade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
            _subSystemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("== Method A ==");
            _subSystemOne.One();
            _subSystemThree.Three();
            _subSystemFour.Four();
        }

        public void MethodB()
        {
            Console.WriteLine("== Method B ==");
            _subSystemOne.One();
            _subSystemTwo.Two();
            _subSystemFour.Four();
        }
    }
}