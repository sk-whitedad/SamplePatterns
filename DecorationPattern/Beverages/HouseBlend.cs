namespace DecorationPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() : base("HouseBlend")
        { }
        public override double cost()
        {
            return 3.0;
        }
    }
}
