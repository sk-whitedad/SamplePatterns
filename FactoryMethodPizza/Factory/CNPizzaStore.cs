using FactoryMethodPizza.Product;

namespace FactoryMethodPizza.Factory
{
    public class CHPizzaStore: PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            if (item == "C")
            {
                pizza = new CHСheesePizza();
            }
            else if (item == "P")
            {
                pizza = new CHPapricaPizza();
            }
            else if (item == "H")
            {
                pizza = new CHHawaiianPizza();
            }
            else if (item == "B")
            {
                pizza = new CHBekonPizza();
            }
            return pizza;
        }
    }
}
