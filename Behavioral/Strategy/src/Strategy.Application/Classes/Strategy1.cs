using System;

namespace Strategy.Application
{
    public class Strategy1 : IStrategy
    {
        public string AlgorithmCheck { get; set; }
        public void Algorithm()
        {
            AlgorithmCheck = "Strategy1 algorithm";
        }
    }
}
