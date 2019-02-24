using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exposing modern furniture set");
            FurnitureSeller seller = new FurnitureSeller(new ModernFurnitureFactory());
            seller.Run();

            Console.WriteLine();

            Console.WriteLine("Exposing provence furniture set");
            seller = new FurnitureSeller(new ProvenceFurnitureFactory());
            seller.Run();

        }
    }
}
