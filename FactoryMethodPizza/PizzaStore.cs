using FactoryMethodPizza.Factory;
using FactoryMethodPizza.Product;

namespace FactoryMethodPizza
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(String type)
        {
            Pizza pizza;
            pizza = createPizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza createPizza(String type);
    }
}