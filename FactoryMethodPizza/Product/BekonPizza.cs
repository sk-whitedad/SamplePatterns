using FactoryMethodPizza.Factory;

namespace FactoryMethodPizza.Product
{
    public class BekonPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public BekonPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Готовим {name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClam();
        }
    }
}
