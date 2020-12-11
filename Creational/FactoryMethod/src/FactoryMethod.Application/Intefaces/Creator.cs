using System;

namespace FactoryMethod.Application
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
        public void AnOperation()
        {
            Product product = FactoryMethod();
            throw new Exception($"AnOperation with object {product.GetType()} type");
        }
    }
}
