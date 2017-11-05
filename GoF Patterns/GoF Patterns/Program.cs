using System;
using GoF_Patterns.AbstractFactory.Structural;
using GoF_Patterns.FactoryMethod.Structural;

namespace GoF_Patterns
{
    public static class Program
    {
        private const Patterns Pattern = Patterns.CreationalFactoryMethod;
        private const ExampleType Type = ExampleType.Structural;

        static void Main(string[] args)
        {
            Console.WriteLine(new string('=', 42 + Pattern.ToString().Length));
            Console.WriteLine(new string('=', 20) + " " + Pattern + " " + new string('=', 20));
            Console.WriteLine(new string('=', 42 + Pattern.ToString().Length));
            Console.WriteLine();
            switch (Pattern)
            {
                case Patterns.CreationalAbstractFactory:
                    if (Type == ExampleType.Structural)
                    {
                        AbstractFactory.Client.RunStructural(new ConcreteFactory1());
                        AbstractFactory.Client.RunStructural(new ConcreteFactory2());
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
                case Patterns.CreationalFactoryMethod:
                    if (Type == ExampleType.Structural)
                    {
                        Client.Run();
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
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
