namespace DecorationPattern.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso() : base("Espresso")
        { }
        public override double cost()
        {
            return 1.5;
        }
    }
}
