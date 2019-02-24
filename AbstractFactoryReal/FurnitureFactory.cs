using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryReal
{
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract Sofa CreateSofa();
    }

    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }

        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
    public class ProvenceFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ProvenceChair();
        }

        public override Sofa CreateSofa()
        {
            return new ProvenceSofa();
        }
    }

}
