using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exposing modern furniture set");
            var modern = new FurnitureSeller<ModernFurnitureFactory>();
            modern.Run();
            Console.WriteLine();

            Console.WriteLine("Exposing provence furniture set");
            var provence = new FurnitureSeller<ProvenceFurnitureFactory>();
            provence.Run();

            Console.ReadKey();
        }
    }

    class FurnitureSeller<T> where T: IFurnitureFactory, new()
    {
        ISofa sofa;
        IChair chair;

        T factory;

        public FurnitureSeller()
        {
            factory = new T();
            sofa = factory.CreateSofa();
            chair = factory.CreateChair();
        }

        public void Run()
        {
            sofa.Fit(chair);
        }
    }
}
