using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryReal
{
    public abstract class Sofa
    {
        public abstract void Fit(Chair chair);
    }

    public class ModernSofa : Sofa
    {
        public override void Fit(Chair chair)
        {
            Console.WriteLine($"{chair.GetType().Name} perfectly fits to the {GetType().Name}");
        }
    }

    public class ProvenceSofa : Sofa
    {
        public override void Fit(Chair chair)
        {
            Console.WriteLine($"{chair.GetType().Name} perfectly fits to the {GetType().Name}");
        }
    }
}
