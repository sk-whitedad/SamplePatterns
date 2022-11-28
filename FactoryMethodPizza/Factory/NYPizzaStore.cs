﻿using FactoryMethodPizza.Product;

namespace FactoryMethodPizza.Factory
{
    public class NYPizzaStore: PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            if (item == "C")
            {
                pizza = new NYСheesePizza();
            }
            else if (item == "P")
            {
                pizza = new NYPapricaPizza();
            }
            else if (item == "H")
            {
                pizza = new NYHawaiianPizza();
            }
            else if (item == "B")
            {
                pizza = new NYBekonPizza();
            }
            return pizza;
        }
    }
}
