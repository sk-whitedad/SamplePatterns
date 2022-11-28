namespace FactoryMethodPizza.Ingredients
{
    public abstract class Dough
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