using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running client with Factory1");
            var client = new Client(new Factory1());
            client.Run();

            Console.WriteLine();

            Console.WriteLine("Running client with Factory2");
            client = new Client(new Factory2());
            client.Run();
        }
    }

   

   



   
}
