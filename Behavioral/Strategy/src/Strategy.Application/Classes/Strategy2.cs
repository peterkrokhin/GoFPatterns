using System;

namespace Strategy.Application
{
    public class Strategy2 : IStrategy
    {
        public string AlgorithmCheck { get; set; }
        public void Algorithm()
        {
            AlgorithmCheck = "Strategy2 algorithm";
        }
    }
}
