using System;

namespace Strategy.Application
{
    public class Context
    {
        private IStrategy Strategy { get; set; }
        public void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
            Console.WriteLine($"set strategy {strategy.GetType()}");
        }
        public void ExecuteAlgorithm()
        {
            Strategy?.Algorithm();
        }
    }  
}
