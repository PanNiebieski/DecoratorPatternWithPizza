namespace DecoratorPattern.DodatkiZSzynkąISerem
{
    class MediumPizzaWithHamAndCheese : Pizza
    {
        public override double CalculateCost()
        {
            return 54.00;
        }

        public override string GetName()
        {
            return "MediumPizzaWithHamAndCheese";
        }
    }
}
