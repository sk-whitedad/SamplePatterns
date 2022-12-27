namespace DecorationPattern.ConcreteDecorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
 : base(beverage.description + ", soy", beverage)
        { }

        public override double cost()
        {
            return beverage.cost() + 0.25;
        }
    }
}
