using System;

namespace FactoryMethod.Application
{
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductA();
    }
}
