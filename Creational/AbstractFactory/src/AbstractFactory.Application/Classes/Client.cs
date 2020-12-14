using System;

namespace AbstractFactory.Application
{
    public class Client
    {
        public IAbstractProductA ProductA { get; private set; }
        public IAbstractProductB ProductB { get; private set; }
        private IAbstractFactory Factory { get; set; }
        public Client (IAbstractFactory factory)
        {
            Factory = factory;
            ProductA = Factory.CreateProductA();
            ProductB = Factory.CreateProductB();
        }
    }
}
