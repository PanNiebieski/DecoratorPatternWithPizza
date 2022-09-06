namespace DecoratorPattern.DodatkiZSerem
{
    public class LargePizzaWithCheese : Pizza
    {
        public override double CalculateCost()
        {
            return 52.00;
        }

        public override string GetName()
        {
            return "LargePizzaWithCheese";
        }
    }
}
