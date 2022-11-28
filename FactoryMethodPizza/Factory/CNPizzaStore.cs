using FactoryMethodPizza.Product;

namespace FactoryMethodPizza.Factory
{
    public class CHPizzaStore: PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (item == "C")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Чикагская сырная пицца");
            }
            else if (item == "P")
            {
                pizza = new PapricaPizza(ingredientFactory);
                pizza.setName("Чикагская пицца с паприкой");
            }
            else if (item == "H")
            {
                pizza = new HawaiianPizza(ingredientFactory);
                pizza.setName("Чикагская гавайская пицца");
            }
            else if (item == "B")
            {
                pizza = new BekonPizza(ingredientFactory);
                pizza.setName("Чикагская пицца с беконом");
            }
            return pizza;
        }
    }
}
