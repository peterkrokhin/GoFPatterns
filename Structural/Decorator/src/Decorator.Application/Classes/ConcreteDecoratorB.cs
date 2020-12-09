using System;

namespace Decorator.Application
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) => Component = component;
        public override void Operation()
        {
            try
            {
                base.Operation();
            }
            catch
            {
                AddedBehavior();
            }
        }
        private void AddedBehavior() => throw new Exception("Operation from object of ConcreteDecoratorB type");

    }
}
