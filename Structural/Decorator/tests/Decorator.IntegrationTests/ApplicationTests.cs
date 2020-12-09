using NUnit.Framework;
using Decorator.Application;

namespace Decorator.IntegrationTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddStateTest()
        {
            Component component = new ConcreteComponent();
            component = new ConcreteDecoratorA(component);

            Assert.That((component as ConcreteDecoratorA)?.AddedState == "added state");
            Assert.That(() => component.Operation(), 
                Throws.Exception.With.Message.EqualTo("Operation from object of ConcreteComponent type"));
        }

        [Test]
        public void AddBehaviorTest()
        {
            Component component = new ConcreteComponent();
            component = new ConcreteDecoratorB(component);

            Assert.That(() => component.Operation(), 
                Throws.Exception.With.Message.EqualTo("Operation from object of ConcreteDecoratorB type"));
            
        }
    }
}