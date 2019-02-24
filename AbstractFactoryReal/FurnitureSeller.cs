using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryReal
{
    public class FurnitureSeller
    {
        Chair chair;
        Sofa sofa;
        public FurnitureSeller(FurnitureFactory factory)
        {
            chair = factory.CreateChair();
            sofa = factory.CreateSofa();
        }
        
        public void Run()
        {
            sofa.Fit(chair);
        }
    }
}
