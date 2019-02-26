using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.NET
{
    public interface ISofa
    {
        void Fit(IChair chair);
    }

    public class ModernSofa : ISofa
    {
        public void Fit(IChair chair)
        {
            Console.WriteLine($"{chair.GetType().Name} perfectly fits to the {GetType().Name}");
        }
    }

    public class ProvenceSofa : ISofa
    {
        public void Fit(IChair chair)
        {
            Console.WriteLine($"{chair.GetType().Name} perfectly fits to the {GetType().Name}");
        }
    }
}
