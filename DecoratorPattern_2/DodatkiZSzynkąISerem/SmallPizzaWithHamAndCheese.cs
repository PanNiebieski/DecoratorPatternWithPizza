namespace DecoratorPattern.DodatkiZSzynkąISerem
{
    public class SmallPizzaWithHamAndCheese : Pizza
    {
        public override double CalculateCost()
        {
            return 15.00;
        }

        public override string GetName()
        {
            return "SmallPizzaWithCheese";
        }
    }
}
