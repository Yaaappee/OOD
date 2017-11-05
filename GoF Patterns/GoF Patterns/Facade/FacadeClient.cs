using GoF_Patterns.Facade.Structural;

namespace GoF_Patterns.Facade
{
    public static class FacadeClient
    {
        public static void RunStructural()
        {
            var facade = new StructuralFacade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}