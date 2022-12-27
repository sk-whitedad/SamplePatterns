namespace DecorationPattern.ConcreteDecorators
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
         : base(beverage.description + ", milk", beverage)
        { }

        public override double cost()
        {
            return beverage.cost() + 0.15;
        }
    }
}
