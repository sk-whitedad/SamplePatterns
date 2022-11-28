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
            Console.WriteLine($"{dough.getName()}");
            sauce = ingredientFactory.createSauce();
            Console.WriteLine($"{sauce.getName()}");
            cheese = ingredientFactory.createCheese();
            Console.WriteLine($"{cheese.getName()}");
            clam = ingredientFactory.createClam();
            Console.WriteLine($"{clam.getName()}");

        }
    }
}
