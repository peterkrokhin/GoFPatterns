using System;

namespace Strategy.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetStrategy(new Strategy1());
            context.ExecuteAlgorithm();

            context.SetStrategy(new Strategy2());
            context.ExecuteAlgorithm();

            context.SetStrategy(new Strategy2());
            context.ExecuteAlgorithm();

        }
    }
}
