using System;

namespace AbstractFactory
{
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA productA);
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {productA.GetType().Name}");
        }
    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {productA.GetType().Name}");
        }
    }
}
