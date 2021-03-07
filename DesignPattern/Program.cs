using DesignPattern.BehavioralPatterns.Strategy;
using DesignPattern.CreationalPatterns.FactoryMethod;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new FactoryMethodRunner().Run();

            new StrategyRunner().Run();
        }
    }
}
