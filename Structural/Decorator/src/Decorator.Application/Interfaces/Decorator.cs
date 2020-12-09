using System;

namespace Decorator.Application
{
    public abstract class Decorator : Component
    {
        protected Component Component { get; set; }
        public override void Operation() => Component?.Operation();
    }
}
