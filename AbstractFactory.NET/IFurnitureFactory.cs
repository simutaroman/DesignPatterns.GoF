namespace AbstractFactory.NET
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }

    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }

    public class ProvenceFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ProvenceChair();
        }

        public ISofa CreateSofa()
        {
            return new ProvenceSofa();
        }
    }



}