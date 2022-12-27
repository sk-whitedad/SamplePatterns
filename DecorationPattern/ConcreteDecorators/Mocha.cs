namespace DecorationPattern.ConcreteDecorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
            : base(beverage.description + ", mocha", beverage)
        { }

        public override double cost()
        {
            return beverage.cost() + 0.10;
        }

    }
}
