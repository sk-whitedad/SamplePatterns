namespace FactoryMethodPizza.Ingredients
{
    public abstract class Cheese
    {
        string name;
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }

}