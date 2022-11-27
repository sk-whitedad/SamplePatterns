using FactoryMethodPizza.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPizza.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;
            if (type.Equals("C"))
            {
                pizza = new СheesePizza();
            }
            else if (type.Equals("P"))
            {
                pizza = new PapricaPizza();
            }
            else if (type.Equals("H"))
            {
                pizza = new HawaiianPizza();
            }
            else if (type.Equals("B"))
            {
                pizza = new BekonPizza();
            }
            return pizza;
        }
    }
}
