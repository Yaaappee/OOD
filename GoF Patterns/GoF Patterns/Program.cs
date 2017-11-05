using System;
using GoF_Patterns.AbstractFactory;
using GoF_Patterns.AbstractFactory.Structural;
using GoF_Patterns.Facade;
using GoF_Patterns.FactoryMethod;

namespace GoF_Patterns
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = Patterns.StructuralFacade;
            ExampleType type = ExampleType.Structural;

            Console.WriteLine(new string('=', 42 + pattern.ToString().Length));
            Console.WriteLine(new string('=', 20) + " " + pattern + " " + new string('=', 20));
            Console.WriteLine(new string('=', 42 + pattern.ToString().Length));
            Console.WriteLine();
            switch (pattern)
            {


                case Patterns.CreationalAbstractFactory:

                    // ==========================================================================================
                    // Abstract Factory (Creational) - Creates an instance of several families of classes
                    // ==========================================================================================

                    #region Abstract Factory

                    if (type == ExampleType.Structural)
                    {
                        AbstractFactoryClient.RunStructural(new ConcreteFactory1());
                        AbstractFactoryClient.RunStructural(new ConcreteFactory2());
                    }
                    else
                    {
                        // TODO: Abstract Factory Real-world example
                        /*
                        Lion eats Wildebeest
                        Wolf eats Bison    
                        */
                    }
                    break;

                #endregion




                case Patterns.CreationalFactoryMethod:

                    // ==========================================================================================
                    // Factory Method (Creational) - Creates an instance of several derived classes
                    // ==========================================================================================

                    #region Factory Method

                    if (type == ExampleType.Structural)
                    {
                        FactoryMethodClient.RunStructural();
                    }
                    else
                    {
                        // TODO: Factory Method Real-world example
                        /*
                        Resume -------
                            SkillsPage
                            EducationPage
                            ExperiencePage

                        Report -------
                            IntroductionPage
                            ResultsPage
                            ConclusionPage
                            SummaryPage
                            BibliographyPage
                        */
                    }
                    break;

                #endregion




                case Patterns.StructuralFacade:

                    // ==========================================================================================
                    // Facade (Structural) - A single class that represents an entire subsystem
                    // ==========================================================================================

                    #region Facade

                    if (type == ExampleType.Structural)
                    {
                        FacadeClient.RunStructural();
                    }
                    else
                    {
                        // TODO: Facade Real-world example
                        /*
                        Ann McKinsey applies for $125,000.00 loan

                        Check bank for Ann McKinsey
                        Check loans for Ann McKinsey
                        Check credit for Ann McKinsey

                        Ann McKinsey has been Approved
                        */
                    }
                    break;

                #endregion


                    

                case Patterns.BehavioralObserver:

                    // ==========================================================================================
                    // Observer (Behavioral) - A way of notifying change to a number of classes
                    // ==========================================================================================

                    #region Observer

                    if (type == ExampleType.Structural)
                    {
                        // TODO: Observer Structural example
                        /*
                        Observer X's new state is ABC
                        Observer Y's new state is ABC
                        Observer Z's new state is ABC    
                        */
                    }
                    else
                    {
                        // TODO: Observer Real-world example
                        /*
                        Notified Sorros of IBM's change to $120.10
                        Notified Berkshire of IBM's change to $120.10

                        Notified Sorros of IBM's change to $121.00
                        Notified Berkshire of IBM's change to $121.00

                        Notified Sorros of IBM's change to $120.50
                        Notified Berkshire of IBM's change to $120.50

                        Notified Sorros of IBM's change to $120.75
                        Notified Berkshire of IBM's change to $120.75
                        */
                    }
                    break;

                #endregion




                case Patterns.BehavioralIterator:
                    break;
                case Patterns.BehavioralStrategy:
                    break;
                case Patterns.StructuralProxy:
                    break;
                case Patterns.StructuralComposite:
                    break;
                case Patterns.CreationalSingleton:
                    break;
                case Patterns.StructuralAdapter:
                    break;
                case Patterns.BehavioralCommand:
                    break;
                case Patterns.BehavioralState:
                    break;
                case Patterns.BehavioralTemplateMethod:
                    break;
                case Patterns.CreationalPrototype:
                    break;
                case Patterns.StructuralBridge:
                    break;
                case Patterns.StructuralDecorator:
                    break;
                case Patterns.CreationalBuilder:
                    break;
                case Patterns.BehavioralChainOfResponsibility:
                    break;
                case Patterns.BehavioralMediator:
                    break;
                case Patterns.StructuralFlyweight:
                    break;
                case Patterns.BehavioralInterpreter:
                    break;
                case Patterns.BehavioralMemento:
                    break;
                case Patterns.BehavioralVisitor:
                    break;
            }

            Console.ReadKey();
        }
    }
}
