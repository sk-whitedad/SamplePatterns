namespace DecorationPattern
{
    public abstract class Beverage
    {
        public Beverage(string d)
        {
            this.description = d;
        }
        public String description {get; protected set;}
        public abstract double cost();
    }
}
