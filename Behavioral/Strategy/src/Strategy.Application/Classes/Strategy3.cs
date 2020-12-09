using System;

namespace Strategy.Application
{
    public class Strategy3 : IStrategy
    {
        public string AlgorithmCheck { get; set; }
        public void Algorithm()
        {
            AlgorithmCheck = "Strategy3 algorithm";
        }
    }
}
