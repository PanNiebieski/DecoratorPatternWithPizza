namespace DecoratorPattern.DodatkiZSzynką
{
    class MediumPizzaWithHam : Pizza
    {
        public override double CalculateCost()
        {
            return 54.00;
        }

        public override string GetName()
        {
            return "Medium Pizza With Ham";
        }
    }
}
