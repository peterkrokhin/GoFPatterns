using System;

namespace FactoryMethod.Application
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductB();
    }
}
