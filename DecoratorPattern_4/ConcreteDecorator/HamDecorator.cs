using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza) :
            base(pizza)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 4.15;
        }

        public override string GetName()
        {
            return base.GetName() + ", Ham";
        }
    }
}
