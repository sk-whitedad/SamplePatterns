using FactoryMethodPizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPizza.Factory
{
    public class CHPizzaIngredientFactory: IPizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThinCrustDough();
        }
        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }
        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Spinach(), new BlackOlives(), new EggPlant() };
            return veggies;
        }
        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams createClam()
        {
            return new FrozenClams();
        }
    }
}
