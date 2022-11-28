using FactoryMethodPizza.Factory;

namespace FactoryMethodPizza.Product
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Готовим {name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
