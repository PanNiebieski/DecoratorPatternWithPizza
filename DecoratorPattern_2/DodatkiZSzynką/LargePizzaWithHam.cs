namespace DecoratorPattern.DodatkiZSzynką
{
    public class LargePizzaWithHam : Pizza
    {
        public override double CalculateCost()
        {
            return 52.00;
        }

        public override string GetName()
        {
            return "LargePizzaWithHam";
        }
    }
}
