namespace DecorationPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() : base("DarkRoast ")
        { }
        public override double cost()
        {
            return 2.5;
        }
    }
}
