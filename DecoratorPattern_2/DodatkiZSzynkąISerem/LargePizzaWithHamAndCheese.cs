namespace DecoratorPattern.DodatkiZSzynkąISerem
{
    public class LargePizzaWithHamAndCheese : Pizza
    {
        public override double CalculateCost()
        {
            return 52.00;
        }

        public override string GetName()
        {
            return "LargePizzaWithHamAndCheese";
        }
    }
}
