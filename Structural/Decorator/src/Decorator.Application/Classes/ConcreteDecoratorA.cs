using System;

namespace Decorator.Application
{
    public class ConcreteDecoratorA : Decorator
    {
        public string AddedState { get; private set; } = "added state";
        public ConcreteDecoratorA(Component component) => Component = component;
        public override void Operation() => base.Operation();
    }
}
