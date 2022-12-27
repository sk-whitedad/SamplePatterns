namespace DecorationPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public CondimentDecorator(string n, Beverage beverage) : base(n)
        {
            this.beverage = beverage;
        }
    }
}
