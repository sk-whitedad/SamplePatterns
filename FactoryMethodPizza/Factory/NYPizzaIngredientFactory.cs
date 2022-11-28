using FactoryMethodPizza.Ingredients;

namespace FactoryMethodPizza.Factory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough createDough()
        {
            Dough thinCrustDough = new ThinCrustDough();
            thinCrustDough.setName("Тесто с тонкой корочкой");
            return thinCrustDough;
        }
        public Sauce createSauce()
        {
            Sauce marinaraSauce = new MarinaraSauce();
            marinaraSauce.setName("Соус Маринара");
            return marinaraSauce;
        }
        public Cheese createCheese()
        {
            Cheese reggianoCheese = new ReggianoCheese();
            reggianoCheese.setName("Сыр Реджано");
            return reggianoCheese;
        }
        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams createClam()
        {
            Clams freshClams = new FreshClams();
            freshClams.setName("Свежие устрицы");
            return freshClams;
        }
    }
}
