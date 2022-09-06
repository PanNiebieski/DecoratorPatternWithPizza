using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LargePizza largePizza = new LargePizza();

            Console.WriteLine(largePizza.GetName());

            Console.WriteLine("{0:C2}",largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
