using FactoryMethodPizza.Product;

namespace FactoryMethodPizza.Factory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (item == "C")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Нью-Йоркская сырная пицца");
            }
            else if (item == "P")
            {
                pizza = new PapricaPizza(ingredientFactory);
                pizza.setName("Нью-Йоркская пицца с паприкой");
            }
            else if (item == "H")
            {
                pizza = new HawaiianPizza(ingredientFactory);
                pizza.setName("Нью-Йоркская гавайская пицца");
            }
            else if (item == "B")
            {
                pizza = new BekonPizza(ingredientFactory);
                pizza.setName("Нью-Йоркская пицца с беконом");
            }
            return pizza;
        }
    }
}
