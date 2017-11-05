using System;
using GoF_Patterns.AbstractFactory;
using GoF_Patterns.AbstractFactory.Structural;
using GoF_Patterns.FactoryMethod;

namespace GoF_Patterns
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = Patterns.CreationalFactoryMethod;
            ExampleType type = ExampleType.Structural;

            Console.WriteLine(new string('=', 42 + pattern.ToString().Length));
            Console.WriteLine(new string('=', 20) + " " + pattern + " " + new string('=', 20));
            Console.WriteLine(new string('=', 42 + pattern.ToString().Length));
            Console.WriteLine();
            switch (pattern)
            {
                // Creates an instance of several families of classes
                case Patterns.CreationalAbstractFactory:
                    if (type == ExampleType.Structural)
                    {
                        AbstractFactoryClient.RunStructural(new ConcreteFactory1());
                        AbstractFactoryClient.RunStructural(new ConcreteFactory2());
                    }
                    else
                    {
                        // TODO: CreationalAbstractFactory Real-world example
                        /*
                        Lion eats Wildebeest
                        Wolf eats Bison    
                        */
                    }
                    break;
                // Creates an instance of several derived classes
                case Patterns.CreationalFactoryMethod:
                    if (type == ExampleType.Structural)
                    {
                        FactoryMethodClient.RunStructural();
                    }
                    else
                    {
                        // TODO: CreationalFactoryMethod Real-world example
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
                case Patterns.StructuralFacade:
                    break;
                case Patterns.BehavioralObserver:
                    break;
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
