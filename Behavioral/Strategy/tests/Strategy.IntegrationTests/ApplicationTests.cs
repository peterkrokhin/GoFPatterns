using NUnit.Framework;
using Strategy.Application;

namespace Strategy.IntegrationTests
{
    public class ApplicationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Strategy1ExecuteAlgorithmTest()
        {
            Context context = new Context();
            
            IStrategy strategy = new Strategy1();
            context.SetStrategy(strategy);
            context.ExecuteAlgorithm();

            Assert.That((strategy as Strategy1).AlgorithmCheck == "Strategy1 algorithm");
        }

        [Test]
        public void Strategy2ExecuteAlgorithmTest()
        {
            Context context = new Context();
            
            IStrategy strategy = new Strategy2();
            context.SetStrategy(strategy);
            context.ExecuteAlgorithm();

            Assert.That((strategy as Strategy2).AlgorithmCheck == "Strategy2 algorithm");
        }

        [Test]
        public void Strategy3ExecuteAlgorithmTest()
        {
            Context context = new Context();
            
            IStrategy strategy = new Strategy3();
            context.SetStrategy(strategy);
            context.ExecuteAlgorithm();

            Assert.That((strategy as Strategy3).AlgorithmCheck == "Strategy3 algorithm");
        }
    }
}