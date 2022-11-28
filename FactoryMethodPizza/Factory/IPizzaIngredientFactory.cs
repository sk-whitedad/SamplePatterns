using FactoryMethodPizza.Ingredients;
using FactoryMethodPizza.Product;

namespace FactoryMethodPizza.Factory
{
    public interface IPizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }
}
