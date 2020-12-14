using NUnit.Framework;
using AbstractFactory.Application;

namespace AbstractFactory.IntegrationTests
{
    public class Tests
    {
        [Test]
        public void CreateProductsFromConcreteFactory1Tests()
        {
            Client client = new Client(new ConcreteFactory1());
        
            Assert.That((client.ProductA is ConcreteProductA1));
            Assert.That((client.ProductB is ConcreteProductB1));
        }

        [Test]
        public void CreateProductsFromConcreteFactory2Tests()
        {
            Client client = new Client(new ConcreteFactory2());

            Assert.That((client.ProductA is ConcreteProductA2));
            Assert.That((client.ProductB is ConcreteProductB2));
        }
    }
}