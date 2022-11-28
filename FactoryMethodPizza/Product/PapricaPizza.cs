using FactoryMethodPizza.Factory;

namespace FactoryMethodPizza.Product
{
    public class PapricaPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public PapricaPizza(IPizzaIngredientFactory ingredientFactory)
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
