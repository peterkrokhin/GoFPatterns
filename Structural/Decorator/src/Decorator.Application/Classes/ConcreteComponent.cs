using System;

namespace Decorator.Application
{
    public class ConcreteComponent : Component
    {
        public override void Operation() => throw new Exception("Operation from object of ConcreteComponent type");
    }
}
