using NUnit.Framework;
using FactoryMethod.Application;

namespace FactoryMethod.IntegrationTests
{
    public class Tests
    {
        [Test]
        public void CreateConcreteProductATest()
        {
            Creator creator = new ConcreteCreatorA();
            creator.FactoryMethod();

            Assert.That(() => creator.AnOperation(), 
                Throws.Exception.With.Message.EqualTo("AnOperation with object FactoryMethod.Application.ConcreteProductA type"));
        }

        [Test]
        public void CreateConcreteProductBTest()
        {
            Creator creator = new ConcreteCreatorB();
            creator.FactoryMethod();

            Assert.That(() => creator.AnOperation(), 
                Throws.Exception.With.Message.EqualTo("AnOperation with object FactoryMethod.Application.ConcreteProductB type"));
        }
    }
}