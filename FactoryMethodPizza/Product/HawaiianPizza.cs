using FactoryMethodPizza.Factory;

namespace FactoryMethodPizza.Product
{
    public class HawaiianPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public HawaiianPizza(IPizzaIngredientFactory ingredientFactory)
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
