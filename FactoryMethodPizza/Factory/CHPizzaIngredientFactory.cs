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
            Dough thinCrustDough = new ThinCrustDough();
            thinCrustDough.setName("Тесто с тонкой корочкой");
            return thinCrustDough;
        }
        public Sauce createSauce()
        {
            Sauce plumTomatoSauce = new PlumTomatoSauce();
            plumTomatoSauce.setName("Cливовый томатный соус");
            return plumTomatoSauce;
        }
        public Cheese createCheese()
        {
            Cheese mozzarellaCheese = new MozzarellaCheese();
            mozzarellaCheese.setName("Сыр Моцарелла");
            return mozzarellaCheese;
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
            Clams frozenClams = new FrozenClams();
            frozenClams.setName("Замороженные устрицы");
            return frozenClams;
        }
    }
}
