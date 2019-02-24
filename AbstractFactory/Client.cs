namespace AbstractFactory
{
    public class Client
    {
        AbstractProductA productA;
        AbstractProductB productB;

        public Client(AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void Run()
        {
            productB.Interact(productA);
        }
    }
}
