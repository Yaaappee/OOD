using System;
using GoF_Patterns.AbstractFactory.Structural;
using GoF_Patterns.FactoryMethod.Structural;

namespace GoF_Patterns
{
    public static class Program
    {
        private const Patterns Pattern = Patterns.FactoryMethod;
        private const ExampleType Type = ExampleType.Structural;

        static void Main(string[] args)
        {
            Console.WriteLine(new string('=', 42 + Pattern.ToString().Length));
            Console.WriteLine(new string('=', 20) + " " + Pattern + " " + new string('=', 20));
            Console.WriteLine(new string('=', 42 + Pattern.ToString().Length));
            Console.WriteLine();
            switch (Pattern)
            {
                case Patterns.AbstractFactory:
                    if (Type == ExampleType.Structural)
                    {
                        AbstractFactory.Client.RunStructural(new ConcreteFactory1());
                        AbstractFactory.Client.RunStructural(new ConcreteFactory2());
                    }
                    else
                    {
                        // TODO: AbstractFactory Real-world example
                        /*
                        Lion eats Wildebeest
                        Wolf eats Bison    
                        */
                    }
                    break;
                case Patterns.FactoryMethod:
                    if (Type == ExampleType.Structural)
                    {
                        Client.Run();
                    }
                    else
                    {
                        // TODO: FactoryMethod Real-world example
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
                case Patterns.Facade:
                    break;
                case Patterns.Observer:
                    break;
                case Patterns.Iterator:
                    break;
                case Patterns.Strategy:
                    break;
                case Patterns.Proxy:
                    break;
                case Patterns.Composite:
                    break;
                case Patterns.Singleton:
                    break;
                case Patterns.Adapter:
                    break;
                case Patterns.Command:
                    break;
                case Patterns.State:
                    break;
                case Patterns.TemplateMethod:
                    break;
                case Patterns.Prototype:
                    break;
                case Patterns.Bridge:
                    break;
                case Patterns.Decorator:
                    break;
                case Patterns.Builder:
                    break;
                case Patterns.ChainOfResponsibility:
                    break;
                case Patterns.Mediator:
                    break;
                case Patterns.Flyweight:
                    break;
                case Patterns.Interpreter:
                    break;
                case Patterns.Memento:
                    break;
                case Patterns.Visitor:
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
