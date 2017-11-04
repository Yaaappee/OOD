using System;
using GoF_Patterns.AbstractFactory.Structural;

namespace GoF_Patterns
{
    public static class Program
    {
        private const Patterns Pattern = Patterns.AbstractFactory;
        private const ExampleType Type = ExampleType.Structural;

        static void Main(string[] args)
        {
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
                    }
                    break;
                case Patterns.FactoryMethod:
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
