using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;
using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            BootStraper.Boot();

            Console.ReadKey();
        }
    }
}
